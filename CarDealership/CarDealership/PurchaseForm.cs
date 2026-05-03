using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class PurchaseForm : Form
    {
        private Car _selectedCar;
        private string _username;
        private string _connectionString;
        private static int _customerIdCounter = 1000;

        public PurchaseForm(Car selectedCar, string username, string connectionString)
        {
            InitializeComponent();
            _selectedCar = selectedCar;
            _username = username;
            _connectionString = connectionString;

            lblCarModel.Text = selectedCar.ModelName;
            lblCarPrice.Text = selectedCar.Price.ToString("C");
            lblCustomerInfo.Text = $"Customer: {username}";

            // Generate and display customer ID
            string customerId = GenerateCustomerId();
            lblCustomerId.Text = $"Customer ID: {customerId}";

            try
            {
                if (!string.IsNullOrEmpty(selectedCar.ImageUrl))
                {
                    string fullPath = System.IO.Path.Combine(Application.StartupPath, selectedCar.ImageUrl);
                    if (System.IO.File.Exists(fullPath))
                        pbCarImage.Image = Image.FromFile(fullPath);
                }
            }
            catch { }

            ApplyRedTheme();
        }

        private string GenerateCustomerId()
        {
            _customerIdCounter++;
            return $"CUST-{_customerIdCounter:D6}";
        }

        private void ApplyRedTheme()
        {
            btnConfirm.MouseEnter += (s, e) => btnConfirm.BackColor = Color.FromArgb(217, 55, 55);
            btnConfirm.MouseLeave += (s, e) => btnConfirm.BackColor = Color.FromArgb(240, 71, 71);

            btnCancel.MouseEnter += (s, e) => btnCancel.BackColor = Color.FromArgb(94, 99, 107);
            btnCancel.MouseLeave += (s, e) => btnCancel.BackColor = Color.FromArgb(64, 68, 75);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string customerId = lblCustomerId.Text.Replace("Customer ID: ", "");

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    // Check if stock exists for this car
                    string stockQuery = "SELECT StockID, Quantity FROM Stocks WHERE CarID = @CarID";
                    int stockId = 0;
                    int availableQty = 0;
                    bool hasStock = false;

                    using (SqlCommand cmd = new SqlCommand(stockQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CarID", _selectedCar.CarID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                stockId = (int)reader["StockID"];
                                availableQty = (int)reader["Quantity"];
                                hasStock = true;
                            }
                        }
                    }

                    // Insert into OrderLogs
                    string insertQuery = @"INSERT INTO OrderLogs 
                        (CustomerID, Username, CarID, StockID, Quantity, TotalAmount, OrderDate, Status) 
                        VALUES (@CustomerID, @Username, @CarID, @StockID, @Quantity, @TotalAmount, @OrderDate, @Status)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        cmd.Parameters.AddWithValue("@Username", _username);
                        cmd.Parameters.AddWithValue("@CarID", _selectedCar.CarID);
                        cmd.Parameters.AddWithValue("@StockID", hasStock ? (object)stockId : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Quantity", 1);
                        cmd.Parameters.AddWithValue("@TotalAmount", _selectedCar.Price);
                        cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Status", "Completed");
                        cmd.ExecuteNonQuery();
                    }

                    // Update stock quantity if stock exists
                    if (hasStock && availableQty > 0)
                    {
                        string updateQuery = "UPDATE Stocks SET Quantity = Quantity - 1 WHERE StockID = @StockID AND Quantity > 0";
                        using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@StockID", stockId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show($"Purchase request for {_selectedCar.ModelName} has been submitted!\n\n" +
                               $"Customer ID: {customerId}\n" +
                               $"You will be contacted by our sales team shortly.",
                               "Purchase Initiated",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

                // Clear form and close
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing purchase: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}