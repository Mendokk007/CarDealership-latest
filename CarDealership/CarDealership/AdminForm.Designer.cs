namespace CarDealership
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabStocks;
        private System.Windows.Forms.TabPage tabOrders;

        private System.Windows.Forms.Panel pnlUserSearch;
        private System.Windows.Forms.Label lblUserSearch;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.Button btnUserSearch;
        private System.Windows.Forms.Button btnRefreshUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel pnlUserUpdate;
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.Label lblUpdateSubtitle;
        private System.Windows.Forms.Label lblUpdateUsername;
        private System.Windows.Forms.TextBox txtUpdateUsername;
        private System.Windows.Forms.Label lblUpdateFullName;
        private System.Windows.Forms.TextBox txtUpdateFullName;
        private System.Windows.Forms.Label lblUpdateEmail;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.Label lblUpdatePassword;
        private System.Windows.Forms.TextBox txtUpdatePassword;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnClearUserForm;

        private System.Windows.Forms.Panel pnlStockTop;
        private System.Windows.Forms.Label lblStockTitle;
        private System.Windows.Forms.Label lblStockSubtitle;
        private System.Windows.Forms.Label lblStockId;
        private System.Windows.Forms.TextBox txtStockId;
        private System.Windows.Forms.Label lblStockCar;
        private System.Windows.Forms.ComboBox cmbStockCar;
        private System.Windows.Forms.Label lblStockDesc;
        private System.Windows.Forms.TextBox txtStockDesc;
        private System.Windows.Forms.Label lblStockPrice;
        private System.Windows.Forms.TextBox txtStockPrice;
        private System.Windows.Forms.Label lblStockQty;
        private System.Windows.Forms.TextBox txtStockQty;
        private System.Windows.Forms.Panel pnlStockBottom;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnDeleteStock;
        private System.Windows.Forms.Button btnClearStockForm;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.DataGridView dgvStocks;

        private System.Windows.Forms.Label lblOrderTitle;
        private System.Windows.Forms.Panel pnlOrderSearch;
        private System.Windows.Forms.Label lblSearchCust;
        private System.Windows.Forms.TextBox txtSearchCustomerId;
        private System.Windows.Forms.Button btnSearchCustomerId;
        private System.Windows.Forms.Label lblSearchDate;
        private System.Windows.Forms.TextBox txtSearchDate;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Button btnRefreshOrders;
        private System.Windows.Forms.Label lblAllOrders;
        private System.Windows.Forms.DataGridView dgvOrderLogs;
        private System.Windows.Forms.Panel pnlReceiptHeader;
        private System.Windows.Forms.Label lblReceipt;
        private System.Windows.Forms.Label lblReceiptHint;
        private System.Windows.Forms.DataGridView dgvReceipt;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.pnlUserUpdate = new System.Windows.Forms.Panel();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.lblUpdateSubtitle = new System.Windows.Forms.Label();
            this.lblUpdateUsername = new System.Windows.Forms.Label();
            this.txtUpdateUsername = new System.Windows.Forms.TextBox();
            this.lblUpdateFullName = new System.Windows.Forms.Label();
            this.txtUpdateFullName = new System.Windows.Forms.TextBox();
            this.lblUpdateEmail = new System.Windows.Forms.Label();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.lblUpdatePassword = new System.Windows.Forms.Label();
            this.txtUpdatePassword = new System.Windows.Forms.TextBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnClearUserForm = new System.Windows.Forms.Button();
            this.pnlUserSearch = new System.Windows.Forms.Panel();
            this.lblUserSearch = new System.Windows.Forms.Label();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.btnUserSearch = new System.Windows.Forms.Button();
            this.btnRefreshUsers = new System.Windows.Forms.Button();
            this.tabStocks = new System.Windows.Forms.TabPage();
            this.dgvStocks = new System.Windows.Forms.DataGridView();
            this.pnlStockBottom = new System.Windows.Forms.Panel();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnDeleteStock = new System.Windows.Forms.Button();
            this.btnClearStockForm = new System.Windows.Forms.Button();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.pnlStockTop = new System.Windows.Forms.Panel();
            this.lblStockTitle = new System.Windows.Forms.Label();
            this.lblStockSubtitle = new System.Windows.Forms.Label();
            this.lblStockId = new System.Windows.Forms.Label();
            this.txtStockId = new System.Windows.Forms.TextBox();
            this.lblStockCar = new System.Windows.Forms.Label();
            this.cmbStockCar = new System.Windows.Forms.ComboBox();
            this.lblStockDesc = new System.Windows.Forms.Label();
            this.txtStockDesc = new System.Windows.Forms.TextBox();
            this.lblStockPrice = new System.Windows.Forms.Label();
            this.txtStockPrice = new System.Windows.Forms.TextBox();
            this.lblStockQty = new System.Windows.Forms.Label();
            this.txtStockQty = new System.Windows.Forms.TextBox();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.dgvReceipt = new System.Windows.Forms.DataGridView();
            this.pnlReceiptHeader = new System.Windows.Forms.Panel();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.lblReceiptHint = new System.Windows.Forms.Label();
            this.dgvOrderLogs = new System.Windows.Forms.DataGridView();
            this.lblAllOrders = new System.Windows.Forms.Label();
            this.pnlOrderSearch = new System.Windows.Forms.Panel();
            this.lblSearchCust = new System.Windows.Forms.Label();
            this.txtSearchCustomerId = new System.Windows.Forms.TextBox();
            this.btnSearchCustomerId = new System.Windows.Forms.Button();
            this.lblSearchDate = new System.Windows.Forms.Label();
            this.txtSearchDate = new System.Windows.Forms.TextBox();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.btnRefreshOrders = new System.Windows.Forms.Button();
            this.lblOrderTitle = new System.Windows.Forms.Label();
            this.pnlTitleBar.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlUserUpdate.SuspendLayout();
            this.pnlUserSearch.SuspendLayout();
            this.tabStocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).BeginInit();
            this.pnlStockBottom.SuspendLayout();
            this.pnlStockTop.SuspendLayout();
            this.tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            this.pnlReceiptHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderLogs)).BeginInit();
            this.pnlOrderSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(47, 49, 54);
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.btnLogout);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1100, 55);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Admin Panel";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(217, 55, 55);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(240, 71, 71);
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 71, 71);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1005, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 30);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabUsers);
            this.tabControl.Controls.Add(this.tabStocks);
            this.tabControl.Controls.Add(this.tabOrders);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl.Location = new System.Drawing.Point(0, 55);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1100, 645);
            this.tabControl.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.BackColor = System.Drawing.Color.FromArgb(54, 57, 63);
            this.tabUsers.Controls.Add(this.dgvUsers);
            this.tabUsers.Controls.Add(this.pnlUserUpdate);
            this.tabUsers.Controls.Add(this.pnlUserSearch);
            this.tabUsers.Location = new System.Drawing.Point(4, 29);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(1092, 612);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Users";
            // 
            // dgvUsers
            // 
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(3, 48);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(1086, 366);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.SelectionChanged += new System.EventHandler(this.dgvUsers_SelectionChanged);
            // 
            // pnlUserUpdate
            // 
            this.pnlUserUpdate.BackColor = System.Drawing.Color.FromArgb(47, 49, 54);
            this.pnlUserUpdate.Controls.Add(this.lblUpdateTitle);
            this.pnlUserUpdate.Controls.Add(this.lblUpdateSubtitle);
            this.pnlUserUpdate.Controls.Add(this.lblUpdateUsername);
            this.pnlUserUpdate.Controls.Add(this.txtUpdateUsername);
            this.pnlUserUpdate.Controls.Add(this.lblUpdateFullName);
            this.pnlUserUpdate.Controls.Add(this.txtUpdateFullName);
            this.pnlUserUpdate.Controls.Add(this.lblUpdateEmail);
            this.pnlUserUpdate.Controls.Add(this.txtUpdateEmail);
            this.pnlUserUpdate.Controls.Add(this.lblUpdatePassword);
            this.pnlUserUpdate.Controls.Add(this.txtUpdatePassword);
            this.pnlUserUpdate.Controls.Add(this.btnUpdateUser);
            this.pnlUserUpdate.Controls.Add(this.btnDeleteUser);
            this.pnlUserUpdate.Controls.Add(this.btnClearUserForm);
            this.pnlUserUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUserUpdate.Location = new System.Drawing.Point(3, 414);
            this.pnlUserUpdate.Name = "pnlUserUpdate";
            this.pnlUserUpdate.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlUserUpdate.Size = new System.Drawing.Size(1086, 195);
            this.pnlUserUpdate.TabIndex = 1;
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.AutoSize = true;
            this.lblUpdateTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUpdateTitle.ForeColor = System.Drawing.Color.FromArgb(240, 71, 71);
            this.lblUpdateTitle.Location = new System.Drawing.Point(12, 10);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(78, 21);
            this.lblUpdateTitle.TabIndex = 0;
            this.lblUpdateTitle.Text = "Edit User";
            // 
            // lblUpdateSubtitle
            // 
            this.lblUpdateSubtitle.AutoSize = true;
            this.lblUpdateSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUpdateSubtitle.ForeColor = System.Drawing.Color.FromArgb(185, 187, 190);
            this.lblUpdateSubtitle.Location = new System.Drawing.Point(12, 32);
            this.lblUpdateSubtitle.Name = "lblUpdateSubtitle";
            this.lblUpdateSubtitle.Size = new System.Drawing.Size(122, 13);
            this.lblUpdateSubtitle.TabIndex = 1;
            this.lblUpdateSubtitle.Text = "Select a user from grid";
            // 
            // lblUpdateUsername
            // 
            this.lblUpdateUsername.AutoSize = true;
            this.lblUpdateUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateUsername.ForeColor = System.Drawing.Color.FromArgb(185, 187, 190);
            this.lblUpdateUsername.Location = new System.Drawing.Point(12, 60);
            this.lblUpdateUsername.Name = "lblUpdateUsername";
            this.lblUpdateUsername.Size = new System.Drawing.Size(80, 19);
            this.lblUpdateUsername.TabIndex = 2;
            this.lblUpdateUsername.Text = "Username:";
            this.lblUpdateUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUpdateUsername
            // 
            this.txtUpdateUsername.BackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.txtUpdateUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpdateUsername.Enabled = false;
            this.txtUpdateUsername.ForeColor = System.Drawing.Color.White;
            this.txtUpdateUsername.Location = new System.Drawing.Point(92, 57);
            this.txtUpdateUsername.Name = "txtUpdateUsername";
            this.txtUpdateUsername.Size = new System.Drawing.Size(200, 25);
            this.txtUpdateUsername.TabIndex = 3;
            // 
            // lblUpdateFullName
            // 
            this.lblUpdateFullName.AutoSize = true;
            this.lblUpdateFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateFullName.ForeColor = System.Drawing.Color.FromArgb(185, 187, 190);
            this.lblUpdateFullName.Location = new System.Drawing.Point(320, 60);
            this.lblUpdateFullName.Name = "lblUpdateFullName";
            this.lblUpdateFullName.Size = new System.Drawing.Size(80, 19);
            this.lblUpdateFullName.TabIndex = 4;
            this.lblUpdateFullName.Text = "Full Name:";
            this.lblUpdateFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUpdateFullName
            // 
            this.txtUpdateFullName.BackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.txtUpdateFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpdateFullName.ForeColor = System.Drawing.Color.White;
            this.txtUpdateFullName.Location = new System.Drawing.Point(400, 57);
            this.txtUpdateFullName.Name = "txtUpdateFullName";
            this.txtUpdateFullName.Size = new System.Drawing.Size(250, 25);
            this.txtUpdateFullName.TabIndex = 5;
            // 
            // lblUpdateEmail
            // 
            this.lblUpdateEmail.AutoSize = true;
            this.lblUpdateEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateEmail.ForeColor = System.Drawing.Color.FromArgb(185, 187, 190);
            this.lblUpdateEmail.Location = new System.Drawing.Point(12, 95);
            this.lblUpdateEmail.Name = "lblUpdateEmail";
            this.lblUpdateEmail.Size = new System.Drawing.Size(49, 19);
            this.lblUpdateEmail.TabIndex = 6;
            this.lblUpdateEmail.Text = "Email:";
            this.lblUpdateEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.BackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.txtUpdateEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpdateEmail.ForeColor = System.Drawing.Color.White;
            this.txtUpdateEmail.Location = new System.Drawing.Point(60, 92);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(350, 25);
            this.txtUpdateEmail.TabIndex = 7;
            // 
            // lblUpdatePassword
            // 
            this.lblUpdatePassword.AutoSize = true;
            this.lblUpdatePassword.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdatePassword.ForeColor = System.Drawing.Color.FromArgb(185, 187, 190);
            this.lblUpdatePassword.Location = new System.Drawing.Point(440, 95);
            this.lblUpdatePassword.Name = "lblUpdatePassword";
            this.lblUpdatePassword.Size = new System.Drawing.Size(77, 19);
            this.lblUpdatePassword.TabIndex = 8;
            this.lblUpdatePassword.Text = "Password:";
            this.lblUpdatePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUpdatePassword
            // 
            this.txtUpdatePassword.BackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.txtUpdatePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpdatePassword.ForeColor = System.Drawing.Color.White;
            this.txtUpdatePassword.Location = new System.Drawing.Point(515, 92);
            this.txtUpdatePassword.Name = "txtUpdatePassword";
            this.txtUpdatePassword.Size = new System.Drawing.Size(180, 25);
            this.txtUpdatePassword.TabIndex = 9;
            this.txtUpdatePassword.UseSystemPasswordChar = true;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(240, 71, 71);
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(217, 55, 55);
            this.btnUpdateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(217, 55, 55);
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Location = new System.Drawing.Point(12, 140);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(120, 38);
            this.btnUpdateUser.TabIndex = 10;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(240, 71, 71);
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(217, 55, 55);
            this.btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(217, 55, 55);
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(142, 140);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(120, 38);
            this.btnDeleteUser.TabIndex = 11;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnClearUserForm
            // 
            this.btnClearUserForm.BackColor = System.Drawing.Color.FromArgb(94, 99, 107);
            this.btnClearUserForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearUserForm.FlatAppearance.BorderSize = 0;
            this.btnClearUserForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.btnClearUserForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.btnClearUserForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearUserForm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClearUserForm.ForeColor = System.Drawing.Color.White;
            this.btnClearUserForm.Location = new System.Drawing.Point(272, 140);
            this.btnClearUserForm.Name = "btnClearUserForm";
            this.btnClearUserForm.Size = new System.Drawing.Size(100, 38);
            this.btnClearUserForm.TabIndex = 12;
            this.btnClearUserForm.Text = "Clear";
            this.btnClearUserForm.UseVisualStyleBackColor = false;
            this.btnClearUserForm.Click += new System.EventHandler(this.btnClearUserForm_Click);
            // 
            // pnlUserSearch
            // 
            this.pnlUserSearch.BackColor = System.Drawing.Color.FromArgb(47, 49, 54);
            this.pnlUserSearch.Controls.Add(this.lblUserSearch);
            this.pnlUserSearch.Controls.Add(this.txtUserSearch);
            this.pnlUserSearch.Controls.Add(this.btnUserSearch);
            this.pnlUserSearch.Controls.Add(this.btnRefreshUsers);
            this.pnlUserSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserSearch.Location = new System.Drawing.Point(3, 3);
            this.pnlUserSearch.Name = "pnlUserSearch";
            this.pnlUserSearch.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.pnlUserSearch.Size = new System.Drawing.Size(1086, 45);
            this.pnlUserSearch.TabIndex = 2;
            // 
            // lblUserSearch
            // 
            this.lblUserSearch.AutoSize = true;
            this.lblUserSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblUserSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUserSearch.ForeColor = System.Drawing.Color.FromArgb(185, 187, 190);
            this.lblUserSearch.Location = new System.Drawing.Point(10, 12);
            this.lblUserSearch.Name = "lblUserSearch";
            this.lblUserSearch.Size = new System.Drawing.Size(45, 15);
            this.lblUserSearch.TabIndex = 0;
            this.lblUserSearch.Text = "Search:";
            this.lblUserSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.BackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.txtUserSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserSearch.ForeColor = System.Drawing.Color.White;
            this.txtUserSearch.Location = new System.Drawing.Point(65, 9);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(200, 23);
            this.txtUserSearch.TabIndex = 1;
            this.txtUserSearch.TextChanged += new System.EventHandler(this.txtUserSearch_TextChanged);
            // 
            // btnUserSearch
            // 
            this.btnUserSearch.BackColor = System.Drawing.Color.FromArgb(240, 71, 71);
            this.btnUserSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserSearch.FlatAppearance.BorderSize = 0;
            this.btnUserSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(217, 55, 55);
            this.btnUserSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(217, 55, 55);
            this.btnUserSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUserSearch.ForeColor = System.Drawing.Color.White;
            this.btnUserSearch.Location = new System.Drawing.Point(275, 7);
            this.btnUserSearch.Name = "btnUserSearch";
            this.btnUserSearch.Size = new System.Drawing.Size(75, 27);
            this.btnUserSearch.TabIndex = 2;
            this.btnUserSearch.Text = "Search";
            this.btnUserSearch.UseVisualStyleBackColor = false;
            this.btnUserSearch.Click += new System.EventHandler(this.btnUserSearch_Click);
            // 
            // btnRefreshUsers
            // 
            this.btnRefreshUsers.BackColor = System.Drawing.Color.FromArgb(94, 99, 107);
            this.btnRefreshUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshUsers.FlatAppearance.BorderSize = 0;
            this.btnRefreshUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.btnRefreshUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.btnRefreshUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshUsers.ForeColor = System.Drawing.Color.White;
            this.btnRefreshUsers.Location = new System.Drawing.Point(360, 7);
            this.btnRefreshUsers.Name = "btnRefreshUsers";
            this.btnRefreshUsers.Size = new System.Drawing.Size(75, 27);
            this.btnRefreshUsers.TabIndex = 3;
            this.btnRefreshUsers.Text = "Refresh";
            this.btnRefreshUsers.UseVisualStyleBackColor = false;
            this.btnRefreshUsers.Click += new System.EventHandler(this.btnRefreshUsers_Click);
            // 
            // tabStocks
            // 
            this.tabStocks.BackColor = System.Drawing.Color.FromArgb(54, 57, 63);
            this.tabStocks.Controls.Add(this.dgvStocks);
            this.tabStocks.Controls.Add(this.pnlStockBottom);
            this.tabStocks.Controls.Add(this.pnlStockTop);
            this.tabStocks.Location = new System.Drawing.Point(4, 29);
            this.tabStocks.Name = "tabStocks";
            this.tabStocks.Padding = new System.Windows.Forms.Padding(3);
            this.tabStocks.Size = new System.Drawing.Size(1092, 612);
            this.tabStocks.TabIndex = 1;
            this.tabStocks.Text = "Stocks";
            // 
            // dgvStocks
            // 
            this.dgvStocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStocks.Location = new System.Drawing.Point(3, 113);
            this.dgvStocks.Name = "dgvStocks";
            this.dgvStocks.Size = new System.Drawing.Size(1086, 441);
            this.dgvStocks.TabIndex = 0;
            this.dgvStocks.SelectionChanged += new System.EventHandler(this.dgvStocks_SelectionChanged);
            // 
            // pnlStockBottom
            // 
            this.pnlStockBottom.BackColor = System.Drawing.Color.FromArgb(47, 49, 54);
            this.pnlStockBottom.Controls.Add(this.btnAddStock);
            this.pnlStockBottom.Controls.Add(this.btnDeleteStock);
            this.pnlStockBottom.Controls.Add(this.btnClearStockForm);
            this.pnlStockBottom.Controls.Add(this.btnUpdateStock);
            this.pnlStockBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStockBottom.Location = new System.Drawing.Point(3, 554);
            this.pnlStockBottom.Name = "pnlStockBottom";
            this.pnlStockBottom.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlStockBottom.Size = new System.Drawing.Size(1086, 55);
            this.pnlStockBottom.TabIndex = 1;
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.FromArgb(240, 71, 71);
            this.btnAddStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStock.FlatAppearance.BorderSize = 0;
            this.btnAddStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(217, 55, 55);
            this.btnAddStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(217, 55, 55);
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddStock.ForeColor = System.Drawing.Color.White;
            this.btnAddStock.Location = new System.Drawing.Point(12, 8);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(120, 35);
            this.btnAddStock.TabIndex = 0;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.BackColor = System.Drawing.Color.FromArgb(240, 71, 71);
            this.btnDeleteStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStock.FlatAppearance.BorderSize = 0;
            this.btnDeleteStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(217, 55, 55);
            this.btnDeleteStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(217, 55, 55);
            this.btnDeleteStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteStock.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStock.Location = new System.Drawing.Point(142, 8);
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Size = new System.Drawing.Size(110, 35);
            this.btnDeleteStock.TabIndex = 1;
            this.btnDeleteStock.Text = "Delete";
            this.btnDeleteStock.UseVisualStyleBackColor = false;
            this.btnDeleteStock.Click += new System.EventHandler(this.btnDeleteStock_Click);
            // 
            // btnClearStockForm
            // 
            this.btnClearStockForm.BackColor = System.Drawing.Color.FromArgb(94, 99, 107);
            this.btnClearStockForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearStockForm.FlatAppearance.BorderSize = 0;
            this.btnClearStockForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.btnClearStockForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.btnClearStockForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearStockForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearStockForm.ForeColor = System.Drawing.Color.White;
            this.btnClearStockForm.Location = new System.Drawing.Point(262, 8);
            this.btnClearStockForm.Name = "btnClearStockForm";
            this.btnClearStockForm.Size = new System.Drawing.Size(110, 35);
            this.btnClearStockForm.TabIndex = 2;
            this.btnClearStockForm.Text = "Clear";
            this.btnClearStockForm.UseVisualStyleBackColor = false;
            this.btnClearStockForm.Click += new System.EventHandler(this.btnClearStockForm_Click);
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.BackColor = System.Drawing.Color.FromArgb(59, 165, 93);
            this.btnUpdateStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStock.FlatAppearance.BorderSize = 0;
            this.btnUpdateStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(39, 145, 73);
            this.btnUpdateStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(39, 145, 73);
            this.btnUpdateStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateStock.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStock.Location = new System.Drawing.Point(382, 8);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(110, 35);
            this.btnUpdateStock.TabIndex = 3;
            this.btnUpdateStock.Text = "Update";
            this.btnUpdateStock.UseVisualStyleBackColor = false;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // pnlStockTop
            // 
            this.pnlStockTop.BackColor = System.Drawing.Color.FromArgb(47, 49, 54);
            this.pnlStockTop.Controls.Add(this.lblStockTitle);
            this.pnlStockTop.Controls.Add(this.lblStockSubtitle);
            this.pnlStockTop.Controls.Add(this.lblStockId);
            this.pnlStockTop.Controls.Add(this.txtStockId);
            this.pnlStockTop.Controls.Add(this.lblStockCar);
            this.pnlStockTop.Controls.Add(this.cmbStockCar);
            this.pnlStockTop.Controls.Add(this.lblStockDesc);
            this.pnlStockTop.Controls.Add(this.txtStockDesc);
            this.pnlStockTop.Controls.Add(this.lblStockPrice);
            this.pnlStockTop.Controls.Add(this.txtStockPrice);
            this.pnlStockTop.Controls.Add(this.lblStockQty);
            this.pnlStockTop.Controls.Add(this.txtStockQty);
            this.pnlStockTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStockTop.Location = new System.Drawing.Point(3, 3);
            this.pnlStockTop.Name = "pnlStockTop";
            this.pnlStockTop.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlStockTop.Size = new System.Drawing.Size(1086, 110);
            this.pnlStockTop.TabIndex = 2;
            // 
            // lblStockTitle
            // 
            this.lblStockTitle.AutoSize = true;
            this.lblStockTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblStockTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStockTitle.ForeColor = System.Drawing.Color.FromArgb(240, 71, 71);
            this.lblStockTitle.Location = new System.Drawing.Point(12, 8);
            this.lblStockTitle.Name = "lblStockTitle";
            this.lblStockTitle.Size = new System.Drawing.Size(158, 21);
            this.lblStockTitle.TabIndex = 0;
            this.lblStockTitle.Text = "Stock Management";
            // 
            // lblStockSubtitle
            // 
            this.lblStockSubtitle.AutoSize = true;
            this.lblStockSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblStockSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStockSubtitle.ForeColor = System.Drawing.Color.FromArgb(185, 187, 190);
            this.lblStockSubtitle.Location = new System.Drawing.Point(12, 30);
            this.lblStockSubtitle.Name = "lblStockSubtitle";
            this.lblStockSubtitle.Size = new System.Drawing.Size(153, 13);
            this.lblStockSubtitle.TabIndex = 1;
            this.lblStockSubtitle.Text = "Add stock or select to delete";
            // 
            // lblStockId
            // 
            this.lblStockId.AutoSize = true;
            this.lblStockId.BackColor = System.Drawing.Color.Transparent;
            this.lblStockId.ForeColor = System.Drawing.Color.FromArgb(185, 187, 190);
            this.lblStockId.Location = new System.Drawing.Point(12, 60);
            this.lblStockId.Name = "lblStockId";
            this.lblStockId.Size = new System.Drawing.Size(27, 19);
            this.lblStockId.TabIndex = 2;
            this.lblStockId.Text = "ID:";
            this.lblStockId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStockId
            // 
            this.txtStockId.BackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.txtStockId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockId.Enabled = false;
            this.txtStockId.ForeColor = System.Drawing.Color.White;
            this.txtStockId.Location = new System.Drawing.Point(40, 57);
            this.txtStockId.Name = "txtStockId";
            this.txtStockId.Size = new System.Drawing.Size(55, 25);
            this.txtStockId.TabIndex = 3;
            // 
            // lblStockCar
            // 
            this.lblStockCar.AutoSize = true;
            this.lblStockCar.BackColor = System.Drawing.Color.Transparent;
            this.lblStockCar.ForeColor = System.Drawing.Color.FromArgb(185, 187, 190);
            this.lblStockCar.Location = new System.Drawing.Point(105, 60);
            this.lblStockCar.Name = "lblStockCar";
            this.lblStockCar.Size = new System.Drawing.Size(37, 19);
            this.lblStockCar.TabIndex = 4;
            this.lblStockCar.Text = "Car:";
            this.lblStockCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbStockCar
            // 
            this.cmbStockCar.BackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.cmbStockCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStockCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStockCar.ForeColor = System.Drawing.Color.White;
            this.cmbStockCar.Location = new System.Drawing.Point(148, 57);
            this.cmbStockCar.Name = "cmbStockCar";
            this.cmbStockCar.Size = new System.Drawing.Size(180, 25);
            this.cmbStockCar.TabIndex = 5;
            // 
            // lblStockDesc
            // 
            this.lblStockDesc.AutoSize = true;
            this.lblStockDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblStockDesc.ForeColor = System.Drawing.Color.FromArgb(185, 187, 190);
            this.lblStockDesc.Location = new System.Drawing.Point(338, 60);
            this.lblStockDesc.Name = "lblStockDesc";
            this.lblStockDesc.Size = new System.Drawing.Size(44, 19);
            this.lblStockDesc.TabIndex = 6;
            this.lblStockDesc.Text = "Desc:";
            this.lblStockDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStockDesc
            // 
            this.txtStockDesc.BackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.txtStockDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockDesc.ForeColor = System.Drawing.Color.White;
            this.txtStockDesc.Location = new System.Drawing.Point(383, 57);
            this.txtStockDesc.Name = "txtStockDesc";
            this.txtStockDesc.Size = new System.Drawing.Size(220, 25);
            this.txtStockDesc.TabIndex = 7;
            // 
            // lblStockPrice
            // 
            this.lblStockPrice.AutoSize = true;
            this.lblStockPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblStockPrice.ForeColor = System.Drawing.Color.FromArgb(185, 187, 190);
            this.lblStockPrice.Location = new System.Drawing.Point(623, 60);
            this.lblStockPrice.Name = "lblStockPrice";
            this.lblStockPrice.Size = new System.Drawing.Size(47, 19);
            this.lblStockPrice.TabIndex = 8;
            this.lblStockPrice.Text = "Price:";
            this.lblStockPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStockPrice
            // 
            this.txtStockPrice.BackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.txtStockPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockPrice.ForeColor = System.Drawing.Color.White;
            this.txtStockPrice.Location = new System.Drawing.Point(676, 57);
            this.txtStockPrice.Name = "txtStockPrice";
            this.txtStockPrice.Size = new System.Drawing.Size(120, 25);
            this.txtStockPrice.TabIndex = 9;
            // 
            // lblStockQty
            // 
            this.lblStockQty.AutoSize = true;
            this.lblStockQty.BackColor = System.Drawing.Color.Transparent;
            this.lblStockQty.ForeColor = System.Drawing.Color.FromArgb(185, 187, 190);
            this.lblStockQty.Location = new System.Drawing.Point(808, 60);
            this.lblStockQty.Name = "lblStockQty";
            this.lblStockQty.Size = new System.Drawing.Size(37, 19);
            this.lblStockQty.TabIndex = 10;
            this.lblStockQty.Text = "Qty:";
            this.lblStockQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStockQty
            // 
            this.txtStockQty.BackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.txtStockQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockQty.ForeColor = System.Drawing.Color.White;
            this.txtStockQty.Location = new System.Drawing.Point(851, 57);
            this.txtStockQty.Name = "txtStockQty";
            this.txtStockQty.Size = new System.Drawing.Size(60, 25);
            this.txtStockQty.TabIndex = 11;
            // 
            // tabOrders
            // 
            this.tabOrders.BackColor = System.Drawing.Color.FromArgb(54, 57, 63);
            this.tabOrders.Controls.Add(this.dgvReceipt);
            this.tabOrders.Controls.Add(this.pnlReceiptHeader);
            this.tabOrders.Controls.Add(this.dgvOrderLogs);
            this.tabOrders.Controls.Add(this.lblAllOrders);
            this.tabOrders.Controls.Add(this.pnlOrderSearch);
            this.tabOrders.Controls.Add(this.lblOrderTitle);
            this.tabOrders.Location = new System.Drawing.Point(4, 29);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(1092, 612);
            this.tabOrders.TabIndex = 2;
            this.tabOrders.Text = "Orders";
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReceipt.Location = new System.Drawing.Point(10, 365);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.Size = new System.Drawing.Size(1072, 239);
            this.dgvReceipt.TabIndex = 0;
            // 
            // pnlReceiptHeader
            // 
            this.pnlReceiptHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReceiptHeader.BackColor = System.Drawing.Color.FromArgb(47, 49, 54);
            this.pnlReceiptHeader.Controls.Add(this.lblReceipt);
            this.pnlReceiptHeader.Controls.Add(this.lblReceiptHint);
            this.pnlReceiptHeader.Location = new System.Drawing.Point(10, 330);
            this.pnlReceiptHeader.Name = "pnlReceiptHeader";
            this.pnlReceiptHeader.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pnlReceiptHeader.Size = new System.Drawing.Size(1072, 30);
            this.pnlReceiptHeader.TabIndex = 1;
            // 
            // lblReceipt
            // 
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.BackColor = System.Drawing.Color.Transparent;
            this.lblReceipt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblReceipt.ForeColor = System.Drawing.Color.FromArgb(240, 71, 71);
            this.lblReceipt.Location = new System.Drawing.Point(10, 5);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(108, 19);
            this.lblReceipt.TabIndex = 0;
            this.lblReceipt.Text = "Receipt Details";
            // 
            // lblReceiptHint
            // 
            this.lblReceiptHint.AutoSize = true;
            this.lblReceiptHint.BackColor = System.Drawing.Color.Transparent;
            this.lblReceiptHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblReceiptHint.ForeColor = System.Drawing.Color.FromArgb(185, 187, 190);
            this.lblReceiptHint.Location = new System.Drawing.Point(130, 7);
            this.lblReceiptHint.Name = "lblReceiptHint";
            this.lblReceiptHint.Size = new System.Drawing.Size(154, 13);
            this.lblReceiptHint.TabIndex = 1;
            this.lblReceiptHint.Text = "- Search Customer ID to view";
            // 
            // dgvOrderLogs
            // 
            this.dgvOrderLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderLogs.Location = new System.Drawing.Point(10, 120);
            this.dgvOrderLogs.Name = "dgvOrderLogs";
            this.dgvOrderLogs.Size = new System.Drawing.Size(1072, 200);
            this.dgvOrderLogs.TabIndex = 2;
            // 
            // lblAllOrders
            // 
            this.lblAllOrders.AutoSize = true;
            this.lblAllOrders.BackColor = System.Drawing.Color.Transparent;
            this.lblAllOrders.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAllOrders.ForeColor = System.Drawing.Color.White;
            this.lblAllOrders.Location = new System.Drawing.Point(10, 95);
            this.lblAllOrders.Name = "lblAllOrders";
            this.lblAllOrders.Size = new System.Drawing.Size(77, 19);
            this.lblAllOrders.TabIndex = 3;
            this.lblAllOrders.Text = "All Orders";
            // 
            // pnlOrderSearch
            // 
            this.pnlOrderSearch.BackColor = System.Drawing.Color.FromArgb(47, 49, 54);
            this.pnlOrderSearch.Controls.Add(this.lblSearchCust);
            this.pnlOrderSearch.Controls.Add(this.txtSearchCustomerId);
            this.pnlOrderSearch.Controls.Add(this.btnSearchCustomerId);
            this.pnlOrderSearch.Controls.Add(this.lblSearchDate);
            this.pnlOrderSearch.Controls.Add(this.txtSearchDate);
            this.pnlOrderSearch.Controls.Add(this.btnSearchDate);
            this.pnlOrderSearch.Controls.Add(this.btnRefreshOrders);
            this.pnlOrderSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrderSearch.Location = new System.Drawing.Point(3, 3);
            this.pnlOrderSearch.Name = "pnlOrderSearch";
            this.pnlOrderSearch.Padding = new System.Windows.Forms.Padding(10);
            this.pnlOrderSearch.Size = new System.Drawing.Size(1086, 50);
            this.pnlOrderSearch.TabIndex = 4;
            // 
            // lblSearchCust
            // 
            this.lblSearchCust.AutoSize = true;
            this.lblSearchCust.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchCust.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearchCust.ForeColor = System.Drawing.Color.FromArgb(185, 187, 190);
            this.lblSearchCust.Location = new System.Drawing.Point(10, 14);
            this.lblSearchCust.Name = "lblSearchCust";
            this.lblSearchCust.Size = new System.Drawing.Size(48, 15);
            this.lblSearchCust.TabIndex = 0;
            this.lblSearchCust.Text = "Cust ID:";
            this.lblSearchCust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearchCustomerId
            // 
            this.txtSearchCustomerId.BackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.txtSearchCustomerId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchCustomerId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchCustomerId.ForeColor = System.Drawing.Color.White;
            this.txtSearchCustomerId.Location = new System.Drawing.Point(65, 11);
            this.txtSearchCustomerId.Name = "txtSearchCustomerId";
            this.txtSearchCustomerId.Size = new System.Drawing.Size(140, 23);
            this.txtSearchCustomerId.TabIndex = 1;
            // 
            // btnSearchCustomerId
            // 
            this.btnSearchCustomerId.BackColor = System.Drawing.Color.FromArgb(240, 71, 71);
            this.btnSearchCustomerId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCustomerId.FlatAppearance.BorderSize = 0;
            this.btnSearchCustomerId.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(217, 55, 55);
            this.btnSearchCustomerId.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(217, 55, 55);
            this.btnSearchCustomerId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomerId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearchCustomerId.ForeColor = System.Drawing.Color.White;
            this.btnSearchCustomerId.Location = new System.Drawing.Point(215, 9);
            this.btnSearchCustomerId.Name = "btnSearchCustomerId";
            this.btnSearchCustomerId.Size = new System.Drawing.Size(110, 26);
            this.btnSearchCustomerId.TabIndex = 2;
            this.btnSearchCustomerId.Text = "Show Receipt";
            this.btnSearchCustomerId.UseVisualStyleBackColor = false;
            this.btnSearchCustomerId.Click += new System.EventHandler(this.btnSearchCustomerId_Click);
            // 
            // lblSearchDate
            // 
            this.lblSearchDate.AutoSize = true;
            this.lblSearchDate.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearchDate.ForeColor = System.Drawing.Color.FromArgb(185, 187, 190);
            this.lblSearchDate.Location = new System.Drawing.Point(350, 14);
            this.lblSearchDate.Name = "lblSearchDate";
            this.lblSearchDate.Size = new System.Drawing.Size(34, 15);
            this.lblSearchDate.TabIndex = 3;
            this.lblSearchDate.Text = "Date:";
            this.lblSearchDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearchDate
            // 
            this.txtSearchDate.BackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.txtSearchDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchDate.ForeColor = System.Drawing.Color.White;
            this.txtSearchDate.Location = new System.Drawing.Point(395, 11);
            this.txtSearchDate.Name = "txtSearchDate";
            this.txtSearchDate.Size = new System.Drawing.Size(130, 23);
            this.txtSearchDate.TabIndex = 4;
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.BackColor = System.Drawing.Color.FromArgb(240, 71, 71);
            this.btnSearchDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchDate.FlatAppearance.BorderSize = 0;
            this.btnSearchDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(217, 55, 55);
            this.btnSearchDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(217, 55, 55);
            this.btnSearchDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearchDate.ForeColor = System.Drawing.Color.White;
            this.btnSearchDate.Location = new System.Drawing.Point(535, 9);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(80, 26);
            this.btnSearchDate.TabIndex = 5;
            this.btnSearchDate.Text = "Search";
            this.btnSearchDate.UseVisualStyleBackColor = false;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // btnRefreshOrders
            // 
            this.btnRefreshOrders.BackColor = System.Drawing.Color.FromArgb(94, 99, 107);
            this.btnRefreshOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshOrders.FlatAppearance.BorderSize = 0;
            this.btnRefreshOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.btnRefreshOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 68, 75);
            this.btnRefreshOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshOrders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshOrders.ForeColor = System.Drawing.Color.White;
            this.btnRefreshOrders.Location = new System.Drawing.Point(625, 9);
            this.btnRefreshOrders.Name = "btnRefreshOrders";
            this.btnRefreshOrders.Size = new System.Drawing.Size(80, 26);
            this.btnRefreshOrders.TabIndex = 6;
            this.btnRefreshOrders.Text = "Refresh";
            this.btnRefreshOrders.UseVisualStyleBackColor = false;
            this.btnRefreshOrders.Click += new System.EventHandler(this.btnRefreshOrders_Click);
            // 
            // lblOrderTitle
            // 
            this.lblOrderTitle.AutoSize = true;
            this.lblOrderTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderTitle.ForeColor = System.Drawing.Color.FromArgb(240, 71, 71);
            this.lblOrderTitle.Location = new System.Drawing.Point(10, 10);
            this.lblOrderTitle.Name = "lblOrderTitle";
            this.lblOrderTitle.Size = new System.Drawing.Size(164, 21);
            this.lblOrderTitle.TabIndex = 5;
            this.lblOrderTitle.Text = "Order Logs & Receipts";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(32, 34, 37);
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlTitleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlUserUpdate.ResumeLayout(false);
            this.pnlUserUpdate.PerformLayout();
            this.pnlUserSearch.ResumeLayout(false);
            this.pnlUserSearch.PerformLayout();
            this.tabStocks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).EndInit();
            this.pnlStockBottom.ResumeLayout(false);
            this.pnlStockTop.ResumeLayout(false);
            this.pnlStockTop.PerformLayout();
            this.tabOrders.ResumeLayout(false);
            this.tabOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            this.pnlReceiptHeader.ResumeLayout(false);
            this.pnlReceiptHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderLogs)).EndInit();
            this.pnlOrderSearch.ResumeLayout(false);
            this.pnlOrderSearch.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}