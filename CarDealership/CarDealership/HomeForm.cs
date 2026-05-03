using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CarDealership
{
    public partial class HomeForm : Form
    {
        private string _connectionString;
        private string _username;
        private List<Car> cars;
        private int currentIndex = 0;
        private PictureBox pbProfilePicture;
        private LinkLabel lnkEditProfile;
        private Label lblUserGreetingText;
        private Panel pnlProfileContainer;

        // For form dragging
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public HomeForm(string connectionString, string username)
        {
            InitializeComponent();
            _connectionString = connectionString;
            _username = username;

            // Make the entire top panel draggable
            MakeDraggable(pnlTopBar);

            // Also make child controls draggable so they don't block the drag
            MakeDraggable(pbLogo);
            MakeDraggable(pnlProfileContainer);
            if (pbProfilePicture != null) MakeDraggable(pbProfilePicture);
            if (lblUserGreetingText != null) MakeDraggable(lblUserGreetingText);

            // Add profile section to the left side of the top bar
            AddProfileSection();

            // Load user greeting and profile picture
            LoadUserGreeting();

            // Load logo
            LoadLogo();

            pbCarImage.BackColor = Color.Transparent;
            pbCarImage.SizeMode = PictureBoxSizeMode.Zoom;

            LoadCars();
        }

        private void MakeDraggable(Control control)
        {
            if (control == null) return;
            control.MouseDown += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, 0xA1, 0x2, 0);
                }
            };
        }

        private void AddProfileSection()
        {
            // Create panel for profile section on the left side
            pnlProfileContainer = new Panel();
            pnlProfileContainer.Size = new Size(250, 70);
            pnlProfileContainer.Location = new Point(0, 0);
            pnlProfileContainer.BackColor = Color.Transparent;

            // Make the profile container draggable
            MakeDraggable(pnlProfileContainer);

            // Create circular profile picture
            pbProfilePicture = new PictureBox();
            pbProfilePicture.Size = new Size(50, 50);
            pbProfilePicture.Location = new Point(15, 10);
            pbProfilePicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfilePicture.BackColor = Color.Transparent;
            pbProfilePicture.Cursor = Cursors.Hand;
            pbProfilePicture.Click += PbProfilePicture_Click;
            MakeDraggable(pbProfilePicture);

            // Create welcome label
            Label lblWelcome = new Label();
            lblWelcome.Text = "Welcome,";
            lblWelcome.Location = new Point(75, 12);
            lblWelcome.Size = new Size(60, 15);
            lblWelcome.Font = new Font("Segoe UI", 9F);
            lblWelcome.ForeColor = Color.FromArgb(185, 187, 190);
            lblWelcome.BackColor = Color.Transparent;
            MakeDraggable(lblWelcome);

            // Create user greeting label
            lblUserGreetingText = new Label();
            lblUserGreetingText.Location = new Point(75, 30);
            lblUserGreetingText.Size = new Size(160, 20);
            lblUserGreetingText.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblUserGreetingText.ForeColor = Color.White;
            lblUserGreetingText.BackColor = Color.Transparent;
            lblUserGreetingText.Text = _username;
            MakeDraggable(lblUserGreetingText);

            // Create edit profile link label
            lnkEditProfile = new LinkLabel();
            lnkEditProfile.Text = "Edit Profile";
            lnkEditProfile.Location = new Point(75, 50);
            lnkEditProfile.Size = new Size(70, 15);
            lnkEditProfile.Font = new Font("Segoe UI", 8F);
            lnkEditProfile.LinkColor = Color.FromArgb(240, 71, 71);
            lnkEditProfile.ActiveLinkColor = Color.FromArgb(217, 55, 55);
            lnkEditProfile.VisitedLinkColor = Color.FromArgb(240, 71, 71);
            lnkEditProfile.Cursor = Cursors.Hand;
            lnkEditProfile.BackColor = Color.Transparent;
            lnkEditProfile.LinkClicked += LnkEditProfile_LinkClicked;

            // Add controls to profile panel
            pnlProfileContainer.Controls.Add(pbProfilePicture);
            pnlProfileContainer.Controls.Add(lblWelcome);
            pnlProfileContainer.Controls.Add(lblUserGreetingText);
            pnlProfileContainer.Controls.Add(lnkEditProfile);

            // Add profile panel to top bar
            pnlTopBar.Controls.Add(pnlProfileContainer);
        }

        private void LoadLogo()
        {
            // Try to load logo from file
            string logoPath = Path.Combine(Application.StartupPath, "logo.png");

            // Also check in a Logos folder
            if (!File.Exists(logoPath))
            {
                string logosFolder = Path.Combine(Application.StartupPath, "Logos");
                if (Directory.Exists(logosFolder))
                {
                    logoPath = Path.Combine(logosFolder, "logo.png");
                }
            }

            if (File.Exists(logoPath))
            {
                try
                {
                    using (FileStream fs = new FileStream(logoPath, FileMode.Open, FileAccess.Read))
                    {
                        Image original = Image.FromStream(fs);
                        // Resize image to fit the logo area (100x50) while maintaining aspect ratio
                        Bitmap resized = new Bitmap(100, 50);
                        using (Graphics g = Graphics.FromImage(resized))
                        {
                            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            g.DrawImage(original, 0, 0, 100, 50);
                        }
                        pbLogo.Image = resized;
                        original.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading logo: " + ex.Message);
                    CreateDefaultLogo();
                }
            }
            else
            {
                CreateDefaultLogo();
            }
        }

        private void CreateDefaultLogo()
        {
            // Create a default logo with text (fallback if no image found)
            Bitmap bmp = new Bitmap(100, 50);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                using (Font font = new Font("Segoe UI", 10, FontStyle.Bold))
                using (Brush brush = new SolidBrush(Color.White))
                {
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    g.DrawString("2F", font, brush, new Rectangle(0, 0, 100, 25), sf);
                    g.DrawString("SUPER CARS", new Font("Segoe UI", 8, FontStyle.Bold), brush, new Rectangle(0, 25, 100, 25), sf);
                }
            }
            pbLogo.Image = bmp;
        }

        private void LoadUserGreeting()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "SELECT FullName, ProfileImage FROM Users WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", _username);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string fullName = reader["FullName"] != DBNull.Value ? reader["FullName"].ToString() : null;
                                string displayName = string.IsNullOrEmpty(fullName) ? _username : fullName;
                                lblUserGreetingText.Text = displayName;

                                if (reader["ProfileImage"] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader["ProfileImage"];
                                    DisplayProfileImage(imageData);
                                }
                                else
                                {
                                    CreateDefaultProfileImage();
                                }
                            }
                            else
                            {
                                lblUserGreetingText.Text = _username;
                                CreateDefaultProfileImage();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblUserGreetingText.Text = _username;
                CreateDefaultProfileImage();
                Console.WriteLine("Error loading user greeting: " + ex.Message);
            }
        }

        private void DisplayProfileImage(byte[] imageData)
        {
            if (imageData != null && imageData.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        using (Image img = Image.FromStream(ms))
                        {
                            pbProfilePicture.Image = MakeCircularImage(img, 50, 50);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error displaying profile image: " + ex.Message);
                    CreateDefaultProfileImage();
                }
            }
            else
            {
                CreateDefaultProfileImage();
            }
        }

        private void CreateDefaultProfileImage()
        {
            Bitmap bmp = new Bitmap(50, 50);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                g.SmoothingMode = SmoothingMode.AntiAlias;

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(217, 55, 55))) // Darker red as default
                {
                    g.FillEllipse(brush, 0, 0, 50, 50);
                }

                using (Font font = new Font("Segoe UI", 20, FontStyle.Bold))
                using (Brush brush = new SolidBrush(Color.White))
                {
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;

                    string initial = _username.Length > 0 ? _username[0].ToString().ToUpper() : "?";
                    g.DrawString(initial, font, brush, new Rectangle(0, 0, 50, 50), sf);
                }
            }
            pbProfilePicture.Image = bmp;
        }

        private Image MakeCircularImage(Image img, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                g.SmoothingMode = SmoothingMode.AntiAlias;

                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, width, height);
                g.SetClip(path);

                g.DrawImage(img, 0, 0, width, height);
            }
            return bmp;
        }

        private void PbProfilePicture_Click(object sender, EventArgs e)
        {
            OpenEditProfileForm();
        }

        private void LnkEditProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenEditProfileForm();
        }

        private void OpenEditProfileForm()
        {
            timerCarousel.Stop();
            EditProfileForm editForm = new EditProfileForm(_connectionString, _username);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadUserGreeting();
            }
            timerCarousel.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            timerCarousel.Stop();
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                timerCarousel.Start();
            }
        }

        private void LoadCars()
        {
            cars = new List<Car>();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "SELECT CarID, ModelName, Price, ImageUrl, Year, Description FROM Cars";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cars.Add(new Car
                                {
                                    CarID = (int)reader["CarID"],
                                    ModelName = reader["ModelName"].ToString(),
                                    Price = (decimal)reader["Price"],
                                    ImageUrl = reader["ImageUrl"]?.ToString() ?? "",
                                    Year = reader["Year"] != DBNull.Value ? (int)reader["Year"] : 0,
                                    Description = reader["Description"]?.ToString() ?? ""
                                });
                            }
                        }
                    }
                }

                if (cars.Count > 0)
                {
                    ShowCar(currentIndex);
                    timerCarousel.Start();
                }
                else
                {
                    MessageBox.Show("No cars available to display.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cars: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowCar(int index)
        {
            if (cars == null || cars.Count == 0) return;

            try
            {
                var car = cars[index];
                lblCarName.Text = $"{car.ModelName} {(car.Year > 0 ? $"({car.Year})" : "")}";
                lblCarPrice.Text = car.Price.ToString("C");

                if (pbCarImage.Image != null)
                {
                    pbCarImage.Image.Dispose();
                    pbCarImage.Image = null;
                }

                if (!string.IsNullOrEmpty(car.ImageUrl))
                {
                    LoadImageFromFile(car.ImageUrl);
                }
                else
                {
                    CreatePlaceholderImage(car.ModelName, "No image path");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying car: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadImageFromFile(string imagePath)
        {
            try
            {
                string fullPath = Path.Combine(Application.StartupPath, imagePath);

                if (!File.Exists(fullPath))
                {
                    string fileName = Path.GetFileName(imagePath);
                    fullPath = Path.Combine(Application.StartupPath, "CarImages", fileName);
                }

                if (File.Exists(fullPath))
                {
                    using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        using (Image original = Image.FromStream(fs))
                        {
                            Bitmap bmp = new Bitmap(original.Width, original.Height, PixelFormat.Format32bppArgb);
                            using (Graphics g = Graphics.FromImage(bmp))
                            {
                                g.Clear(Color.Transparent);
                                g.DrawImage(original, 0, 0, original.Width, original.Height);
                            }
                            pbCarImage.Image = bmp;
                        }
                    }
                }
                else
                {
                    CreatePlaceholderImage("Image Not Found", Path.GetFileName(imagePath));
                }
            }
            catch (Exception ex)
            {
                CreatePlaceholderImage("Error", ex.Message);
            }
        }

        private void CreatePlaceholderImage(string line1, string line2)
        {
            Bitmap placeholder = new Bitmap(600, 250);
            using (Graphics g = Graphics.FromImage(placeholder))
            {
                g.Clear(Color.FromArgb(64, 68, 75));
                using (Font font1 = new Font("Segoe UI", 16, FontStyle.Bold))
                using (Font font2 = new Font("Segoe UI", 10))
                using (Brush brush = new SolidBrush(Color.White))
                using (Brush brush2 = new SolidBrush(Color.FromArgb(185, 187, 190)))
                {
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;

                    g.DrawString(line1, font1, brush, new Rectangle(0, 80, 600, 50), sf);
                    g.DrawString(line2, font2, brush2, new Rectangle(0, 140, 600, 30), sf);
                }
            }
            pbCarImage.Image = placeholder;
        }

        private void timerCarousel_Tick(object sender, EventArgs e)
        {
            if (cars == null || cars.Count == 0) return;
            currentIndex = (currentIndex + 1) % cars.Count;
            ShowCar(currentIndex);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (cars == null || cars.Count == 0) return;
            timerCarousel.Stop();
            currentIndex--;
            if (currentIndex < 0) currentIndex = cars.Count - 1;
            ShowCar(currentIndex);
            timerCarousel.Start();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cars == null || cars.Count == 0) return;
            timerCarousel.Stop();
            currentIndex = (currentIndex + 1) % cars.Count;
            ShowCar(currentIndex);
            timerCarousel.Start();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (cars == null || cars.Count == 0)
            {
                MessageBox.Show("No cars available to select.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Car selectedCar = cars[currentIndex];
            PurchaseForm purchaseForm = new PurchaseForm(selectedCar, _username, _connectionString);
            purchaseForm.ShowDialog();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }

    public class Car
    {
        public int CarID { get; set; }
        public string ModelName { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
    }
}