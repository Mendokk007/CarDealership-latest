namespace CarDealership
{
    partial class EditProfileForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pbProfileImage;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pbProfileImage = new System.Windows.Forms.PictureBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileImage)).BeginInit();
            this.SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.BackColor = System.Drawing.Color.FromArgb(32, 34, 37);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Profile";

            // pnlTop
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(47, 49, 54);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(380, 35);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);

            // lblTitle
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(15, 6);
            this.lblTitle.Size = new System.Drawing.Size(150, 25);
            this.lblTitle.Text = "Edit Profile";

            // btnClose
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(217, 55, 55);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(240, 71, 71);
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 71, 71);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(345, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // pnlMain
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(32, 34, 37);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 35);
            this.pnlMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);

            // pbProfileImage
            this.pbProfileImage.Location = new System.Drawing.Point(115, 20);
            this.pbProfileImage.Size = new System.Drawing.Size(150, 150);
            this.pbProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // btnUploadImage
            this.btnUploadImage.BackColor = System.Drawing.Color.FromArgb(217, 55, 55);
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.FlatAppearance.BorderSize = 0;
            this.btnUploadImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(240, 71, 71);
            this.btnUploadImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 71, 71);
            this.btnUploadImage.ForeColor = System.Drawing.Color.White;
            this.btnUploadImage.Location = new System.Drawing.Point(130, 180);
            this.btnUploadImage.Size = new System.Drawing.Size(120, 28);
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);

            // lblFullName
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(185, 187, 190);
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFullName.Location = new System.Drawing.Point(90, 215);
            this.lblFullName.Size = new System.Drawing.Size(200, 15);
            this.lblFullName.Text = "FULL NAME";

            // txtFullName
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(47, 49, 54);
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.ForeColor = System.Drawing.Color.White;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.Location = new System.Drawing.Point(90, 235);
            this.txtFullName.Size = new System.Drawing.Size(200, 25);

            // lblEmail
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(185, 187, 190);
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(90, 275);
            this.lblEmail.Size = new System.Drawing.Size(200, 15);
            this.lblEmail.Text = "EMAIL";

            // txtEmail
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(47, 49, 54);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(90, 295);
            this.txtEmail.Size = new System.Drawing.Size(200, 25);

            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(217, 55, 55);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(240, 71, 71);
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 71, 71);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(90, 340);
            this.btnSave.Size = new System.Drawing.Size(95, 30);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(94, 99, 107);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(195, 340);
            this.btnCancel.Size = new System.Drawing.Size(95, 30);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Add Controls
            this.pnlMain.Controls.Add(this.pbProfileImage);
            this.pnlMain.Controls.Add(this.btnUploadImage);
            this.pnlMain.Controls.Add(this.lblFullName);
            this.pnlMain.Controls.Add(this.txtFullName);
            this.pnlMain.Controls.Add(this.lblEmail);
            this.pnlMain.Controls.Add(this.txtEmail);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.btnCancel);

            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);

            this.pnlTop.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileImage)).EndInit();
            this.ResumeLayout(false);
        }
    }
}