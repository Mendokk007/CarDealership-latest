using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CarDealership
{
    public partial class EditProfileForm : Form
    {
        private string _connectionString;
        private string _username;
        private byte[] _profileImageData;

        // For form dragging
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public EditProfileForm(string connectionString, string username)
        {
            InitializeComponent();
            _connectionString = connectionString;
            _username = username;

            pbProfileImage.BackColor = Color.Transparent;
            LoadUserData();
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LoadUserData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "SELECT FullName, Email, ProfileImage FROM Users WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", _username);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFullName.Text = reader["FullName"]?.ToString() ?? "";
                                txtEmail.Text = reader["Email"]?.ToString() ?? "";

                                if (reader["ProfileImage"] != DBNull.Value)
                                {
                                    _profileImageData = (byte[])reader["ProfileImage"];
                                    DisplayProfileImage(_profileImageData);
                                }
                                else
                                {
                                    CreateDefaultProfileImage();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
                CreateDefaultProfileImage();
            }
        }

        private void DisplayProfileImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return;

            try
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    using (Image img = Image.FromStream(ms))
                    {
                        pbProfileImage.Image = MakeCircularImage(img, 150, 150);
                    }
                }
            }
            catch { CreateDefaultProfileImage(); }
        }

        private void CreateDefaultProfileImage()
        {
            Bitmap bmp = new Bitmap(150, 150);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(217, 55, 55)))
                    g.FillEllipse(brush, 0, 0, 150, 150);

                using (Font font = new Font("Segoe UI", 48, FontStyle.Bold))
                using (Brush wBrush = new SolidBrush(Color.White))
                {
                    StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    string initial = !string.IsNullOrEmpty(_username) ? _username[0].ToString().ToUpper() : "?";
                    g.DrawString(initial, font, wBrush, new Rectangle(0, 0, 150, 150), sf);
                }
            }
            pbProfileImage.Image = bmp;
        }

        private Image MakeCircularImage(Image img, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(0, 0, width, height);
                    g.SetClip(path);
                    g.DrawImage(img, 0, 0, width, height);
                }
            }
            return bmp;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (Image original = Image.FromStream(fs))
                            {
                                using (Bitmap bmp = new Bitmap(original, new Size(300, 300)))
                                {
                                    using (MemoryStream ms = new MemoryStream())
                                    {
                                        bmp.Save(ms, ImageFormat.Png);
                                        _profileImageData = ms.ToArray();
                                    }
                                }
                            }
                        }
                        DisplayProfileImage(_profileImageData);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Selected file is not a valid image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Users SET FullName=@FN, Email=@EM, ProfileImage=@PI WHERE Username=@UN";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FN", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@EM", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@PI", (object)_profileImageData ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@UN", _username);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Save Error: " + ex.Message); }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}