using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CarDealership
{
    public partial class AdminForm : Form
    {
        private string _connectionString;
        private string _username;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public AdminForm(string connectionString, string username)
        {
            InitializeComponent();
            _connectionString = connectionString;
            _username = username;
            this.Text = "Admin Panel - " + username;
            this.DoubleBuffered = true;

            ApplyDiscordTheme();
            LoadCarComboBox();
            LoadUsersGrid();
            LoadStocksGrid();
            LoadOrderLogsGrid();
        }

        private void ApplyDiscordTheme()
        {
            StyleDataGridView(dgvUsers);
            StyleDataGridView(dgvStocks);
            StyleDataGridView(dgvOrderLogs);
            StyleDataGridView(dgvReceipt);

            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.DrawItem += TabControl_DrawItem;
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabCtrl = sender as TabControl;
            if (e.Index >= tabCtrl.TabPages.Count) return;

            TabPage tabPage = tabCtrl.TabPages[e.Index];
            Rectangle tabRect = tabCtrl.GetTabRect(e.Index);

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(47, 49, 54)))
                e.Graphics.FillRectangle(brush, e.Bounds);

            Color bgColor = (tabCtrl.SelectedIndex == e.Index) ?
                Color.FromArgb(54, 57, 63) : Color.FromArgb(47, 49, 54);
            Color textColor = (tabCtrl.SelectedIndex == e.Index) ?
                Color.FromArgb(240, 71, 71) : Color.FromArgb(185, 187, 190);

            using (SolidBrush brush = new SolidBrush(bgColor))
                e.Graphics.FillRectangle(brush, tabRect);

            TextRenderer.DrawText(e.Graphics, tabPage.Text, e.Font, tabRect,
                textColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.FromArgb(47, 49, 54);
            dgv.ForeColor = Color.White;
            dgv.GridColor = Color.FromArgb(64, 68, 75);
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(47, 49, 54);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(240, 71, 71);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 49, 54);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersHeight = 30;
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(54, 57, 63);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(64, 68, 75);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowTemplate.Height = 26;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 53, 59);
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(64, 68, 75);
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void LoadUsersGrid()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "SELECT UserID, Username, ISNULL(FullName, 'N/A') AS FullName, ISNULL(Email, 'N/A') AS Email FROM Users";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvUsers.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading users: " + ex.Message); }
        }

        private void LoadStocksGrid()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"SELECT s.StockID, c.ModelName AS CarModel, s.Description, s.Price, s.Quantity 
                                   FROM Stocks s JOIN Cars c ON s.CarID = c.CarID ORDER BY c.ModelName";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvStocks.DataSource = dt;
                    if (dgvStocks.Columns.Contains("Price"))
                        dgvStocks.Columns["Price"].DefaultCellStyle.Format = "₱#,##0.00";
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading stocks: " + ex.Message); }
        }

        private void LoadOrderLogsGrid()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"SELECT o.OrderID, o.CustomerID, o.Username, c.ModelName AS CarModel, 
                                   o.Quantity, o.TotalAmount, CONVERT(varchar, o.OrderDate, 120) AS OrderDate, o.Status
                                   FROM OrderLogs o JOIN Cars c ON o.CarID = c.CarID ORDER BY o.OrderDate DESC";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvOrderLogs.DataSource = dt;
                    if (dgvOrderLogs.Columns.Contains("TotalAmount"))
                        dgvOrderLogs.Columns["TotalAmount"].DefaultCellStyle.Format = "₱#,##0.00";
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading order logs: " + ex.Message); }
        }

        private void LoadCarComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "SELECT CarID, ModelName FROM Cars ORDER BY ModelName";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cmbStockCar.DataSource = dt;
                    cmbStockCar.DisplayMember = "ModelName";
                    cmbStockCar.ValueMember = "CarID";
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading cars: " + ex.Message); }
        }

        // ==================== USER MANAGEMENT ====================
        private void txtUserSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtUserSearch.Text.Trim();
            if (dgvUsers.DataSource is DataTable dt)
                dt.DefaultView.RowFilter = string.IsNullOrEmpty(searchText) ? "" :
                    $"Username LIKE '%{searchText}%' OR FullName LIKE '%{searchText}%' OR Email LIKE '%{searchText}%'";
        }

        private void btnUserSearch_Click(object sender, EventArgs e) => txtUserSearch_TextChanged(sender, e);
        private void btnRefreshUsers_Click(object sender, EventArgs e) { LoadUsersGrid(); txtUserSearch.Text = ""; }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvUsers.SelectedRows[0];
                txtUpdateUsername.Text = row.Cells["Username"].Value?.ToString() ?? "";
                txtUpdateFullName.Text = row.Cells["FullName"].Value?.ToString() == "N/A" ? "" : row.Cells["FullName"].Value?.ToString() ?? "";
                txtUpdateEmail.Text = row.Cells["Email"].Value?.ToString() == "N/A" ? "" : row.Cells["Email"].Value?.ToString() ?? "";
                txtUpdatePassword.Text = "";
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUpdateUsername.Text)) { MessageBox.Show("Select a user."); return; }
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Users SET FullName=@FN, Email=@EM";
                    if (!string.IsNullOrEmpty(txtUpdatePassword.Text)) query += ", Password=@PW";
                    query += " WHERE Username=@UN";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FN", string.IsNullOrEmpty(txtUpdateFullName.Text) ? (object)DBNull.Value : txtUpdateFullName.Text);
                        cmd.Parameters.AddWithValue("@EM", string.IsNullOrEmpty(txtUpdateEmail.Text) ? (object)DBNull.Value : txtUpdateEmail.Text);
                        if (!string.IsNullOrEmpty(txtUpdatePassword.Text)) cmd.Parameters.AddWithValue("@PW", txtUpdatePassword.Text);
                        cmd.Parameters.AddWithValue("@UN", txtUpdateUsername.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("User updated!"); LoadUsersGrid(); ClearUserForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUpdateUsername.Text)) { MessageBox.Show("Select a user."); return; }
            if (txtUpdateUsername.Text == _username) { MessageBox.Show("Cannot delete yourself!"); return; }
            if (MessageBox.Show($"Delete '{txtUpdateUsername.Text}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(_connectionString))
                    {
                        conn.Open();
                        new SqlCommand("DELETE FROM OrderLogs WHERE Username=@U", conn) { Parameters = { new SqlParameter("@U", txtUpdateUsername.Text) } }.ExecuteNonQuery();
                        new SqlCommand("DELETE FROM Users WHERE Username=@U", conn) { Parameters = { new SqlParameter("@U", txtUpdateUsername.Text) } }.ExecuteNonQuery();
                    }
                    MessageBox.Show("User deleted!"); LoadUsersGrid(); ClearUserForm();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void ClearUserForm()
        {
            txtUpdateUsername.Text = ""; txtUpdateFullName.Text = ""; txtUpdateEmail.Text = ""; txtUpdatePassword.Text = "";
            dgvUsers.ClearSelection();
        }
        private void btnClearUserForm_Click(object sender, EventArgs e) => ClearUserForm();

        // ==================== STOCK MANAGEMENT ====================
        private void dgvStocks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStocks.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvStocks.SelectedRows[0];
                txtStockId.Text = row.Cells["StockID"].Value?.ToString() ?? "";
                txtStockDesc.Text = row.Cells["Description"].Value?.ToString() ?? "";
                txtStockPrice.Text = row.Cells["Price"].Value?.ToString() ?? "";
                txtStockQty.Text = row.Cells["Quantity"].Value?.ToString() ?? "";
                cmbStockCar.Text = row.Cells["CarModel"].Value?.ToString() ?? "";
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if (cmbStockCar.SelectedValue == null || string.IsNullOrEmpty(txtStockPrice.Text) || string.IsNullOrEmpty(txtStockQty.Text))
            { MessageBox.Show("Fill all fields."); return; }
            if (!decimal.TryParse(txtStockPrice.Text, out decimal price) || price <= 0) { MessageBox.Show("Invalid price."); return; }
            if (!int.TryParse(txtStockQty.Text, out int qty) || qty < 0) { MessageBox.Show("Invalid quantity."); return; }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string check = "SELECT StockID, Quantity FROM Stocks WHERE CarID=@C";
                    using (SqlCommand cc = new SqlCommand(check, conn))
                    {
                        cc.Parameters.AddWithValue("@C", cmbStockCar.SelectedValue);
                        using (SqlDataReader r = cc.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                int id = (int)r["StockID"]; int oldQty = (int)r["Quantity"]; r.Close();
                                new SqlCommand($"UPDATE Stocks SET Quantity={oldQty + qty}, Description=@D, Price=@P WHERE StockID={id}", conn)
                                { Parameters = { new SqlParameter("@D", txtStockDesc.Text), new SqlParameter("@P", price) } }.ExecuteNonQuery();
                                MessageBox.Show($"Added {qty}. Total: {oldQty + qty}");
                            }
                            else
                            {
                                r.Close();
                                new SqlCommand("INSERT INTO Stocks (CarID, Description, Price, Quantity) VALUES (@C, @D, @P, @Q)", conn)
                                { Parameters = { new SqlParameter("@C", cmbStockCar.SelectedValue), new SqlParameter("@D", txtStockDesc.Text), new SqlParameter("@P", price), new SqlParameter("@Q", qty) } }.ExecuteNonQuery();
                                MessageBox.Show("New stock added!");
                            }
                        }
                    }
                }
                LoadStocksGrid(); ClearStockForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStockId.Text))
            {
                MessageBox.Show("Please select a stock to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtStockPrice.Text) || string.IsNullOrEmpty(txtStockQty.Text))
            {
                MessageBox.Show("Please fill in both price and quantity.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtStockPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price (greater than 0).", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStockQty.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Please enter a valid quantity (0 or greater).", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Are you sure you want to update this stock?\n\nStock ID: {txtStockId.Text}\nDescription: {txtStockDesc.Text}\nPrice: ₱{price:N2}\nQuantity: {qty}",
                "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(_connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE Stocks SET Description = @Desc, Price = @Price, Quantity = @Qty WHERE StockID = @ID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Desc", string.IsNullOrEmpty(txtStockDesc.Text) ? (object)DBNull.Value : txtStockDesc.Text);
                            cmd.Parameters.AddWithValue("@Price", price);
                            cmd.Parameters.AddWithValue("@Qty", qty);
                            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtStockId.Text));

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Stock updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadStocksGrid();
                                ClearStockForm();
                            }
                            else
                            {
                                MessageBox.Show("No stock was updated. Please try again.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating stock: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStockId.Text)) { MessageBox.Show("Select a stock."); return; }
            if (MessageBox.Show("Delete this stock?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(_connectionString))
                    {
                        conn.Open();
                        new SqlCommand("DELETE FROM Stocks WHERE StockID=" + txtStockId.Text, conn).ExecuteNonQuery();
                    }
                    MessageBox.Show("Deleted!");
                    LoadStocksGrid();
                    ClearStockForm();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void ClearStockForm()
        {
            txtStockId.Text = "";
            txtStockDesc.Text = "";
            txtStockPrice.Text = "";
            txtStockQty.Text = "";
            if (cmbStockCar.Items.Count > 0)
                cmbStockCar.SelectedIndex = 0;
            dgvStocks.ClearSelection();
        }

        private void btnClearStockForm_Click(object sender, EventArgs e) => ClearStockForm();

        // ==================== ORDER LOGS ====================
        private void btnSearchCustomerId_Click(object sender, EventArgs e)
        {
            string cid = txtSearchCustomerId.Text.Trim();
            if (string.IsNullOrEmpty(cid)) { MessageBox.Show("Enter Customer ID."); return; }
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    SqlDataAdapter a = new SqlDataAdapter("SELECT o.OrderID, o.CustomerID, o.Username, c.ModelName, o.Quantity, o.TotalAmount, CONVERT(varchar, o.OrderDate, 120) AS OrderDate, o.Status FROM OrderLogs o JOIN Cars c ON o.CarID=c.CarID WHERE o.CustomerID=@C ORDER BY o.OrderDate DESC", conn);
                    a.SelectCommand.Parameters.AddWithValue("@C", cid);
                    DataTable dt = new DataTable(); a.Fill(dt);
                    dgvReceipt.DataSource = dt;
                    if (dt.Rows.Count == 0) MessageBox.Show("No orders found.");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            string ds = txtSearchDate.Text.Trim();
            if (string.IsNullOrEmpty(ds)) { MessageBox.Show("Enter date (yyyy-MM-dd)."); return; }
            try
            {
                DateTime d = DateTime.Parse(ds);
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    SqlDataAdapter a = new SqlDataAdapter("SELECT o.OrderID, o.CustomerID, o.Username, c.ModelName, o.Quantity, o.TotalAmount, CONVERT(varchar, o.OrderDate, 120) AS OrderDate, o.Status FROM OrderLogs o JOIN Cars c ON o.CarID=c.CarID WHERE CAST(o.OrderDate AS DATE)=@D ORDER BY o.OrderDate DESC", conn);
                    a.SelectCommand.Parameters.AddWithValue("@D", d.Date);
                    DataTable dt = new DataTable(); a.Fill(dt);
                    dgvOrderLogs.DataSource = dt; dgvReceipt.DataSource = dt;
                    if (dt.Rows.Count == 0) MessageBox.Show("No orders found.");
                }
            }
            catch { MessageBox.Show("Invalid date."); }
        }

        private void btnRefreshOrders_Click(object sender, EventArgs e)
        {
            LoadOrderLogsGrid(); dgvReceipt.DataSource = null;
            txtSearchCustomerId.Text = ""; txtSearchDate.Text = "";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}