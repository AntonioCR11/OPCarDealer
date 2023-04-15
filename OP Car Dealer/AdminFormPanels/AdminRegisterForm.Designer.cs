
namespace OP_Car_Dealer.AdminFormPanels
{
    partial class AdminRegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contentHeaderPanel = new System.Windows.Forms.Panel();
            this.contentHeaderLabel = new System.Windows.Forms.Label();
            this.modePanel = new System.Windows.Forms.Panel();
            this.registerModeLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.typesComboBox = new System.Windows.Forms.ComboBox();
            this.typesLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextbox = new OP_Car_Dealer.CustomControls.NeonTextbox();
            this.addressTextbox = new OP_Car_Dealer.CustomControls.NeonTextbox();
            this.emailTextbox = new OP_Car_Dealer.CustomControls.NeonTextbox();
            this.passwordTextbox = new OP_Car_Dealer.CustomControls.NeonTextbox();
            this.usernameTextbox = new OP_Car_Dealer.CustomControls.NeonTextbox();
            this.searchTextbox = new OP_Car_Dealer.CustomControls.NeonTextbox();
            this.contentHeaderPanel.SuspendLayout();
            this.modePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contentHeaderPanel
            // 
            this.contentHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(208)))));
            this.contentHeaderPanel.Controls.Add(this.contentHeaderLabel);
            this.contentHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.contentHeaderPanel.Name = "contentHeaderPanel";
            this.contentHeaderPanel.Size = new System.Drawing.Size(950, 30);
            this.contentHeaderPanel.TabIndex = 0;
            // 
            // contentHeaderLabel
            // 
            this.contentHeaderLabel.AutoSize = true;
            this.contentHeaderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.contentHeaderLabel.Location = new System.Drawing.Point(12, 7);
            this.contentHeaderLabel.Name = "contentHeaderLabel";
            this.contentHeaderLabel.Size = new System.Drawing.Size(76, 18);
            this.contentHeaderLabel.TabIndex = 1;
            this.contentHeaderLabel.Text = "Register";
            // 
            // modePanel
            // 
            this.modePanel.BackColor = System.Drawing.Color.LightGray;
            this.modePanel.Controls.Add(this.registerModeLabel);
            this.modePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.modePanel.Location = new System.Drawing.Point(0, 30);
            this.modePanel.Name = "modePanel";
            this.modePanel.Size = new System.Drawing.Size(950, 31);
            this.modePanel.TabIndex = 11;
            // 
            // registerModeLabel
            // 
            this.registerModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registerModeLabel.AutoSize = true;
            this.registerModeLabel.Location = new System.Drawing.Point(825, 6);
            this.registerModeLabel.Name = "registerModeLabel";
            this.registerModeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.registerModeLabel.Size = new System.Drawing.Size(113, 18);
            this.registerModeLabel.TabIndex = 0;
            this.registerModeLabel.Text = "Mode: Insert";
            this.registerModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(208)))));
            this.saveButton.Location = new System.Drawing.Point(825, 112);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(113, 78);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Enabled = false;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(208)))));
            this.deleteButton.Location = new System.Drawing.Point(825, 68);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(113, 33);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Search:";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.SystemColors.Control;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(208)))));
            this.searchButton.Location = new System.Drawing.Point(671, 68);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 33);
            this.searchButton.TabIndex = 26;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AllowUserToDeleteRows = false;
            this.userDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            this.userDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.userDataGridView.Location = new System.Drawing.Point(16, 199);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.RowHeadersVisible = false;
            this.userDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDataGridView.Size = new System.Drawing.Size(922, 289);
            this.userDataGridView.TabIndex = 27;
            this.userDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGridView_CellContentDoubleClick);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(26, 119);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(97, 18);
            this.usernameLabel.TabIndex = 28;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(235, 119);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(92, 18);
            this.passwordLabel.TabIndex = 30;
            this.passwordLabel.Text = "Password:";
            // 
            // typesComboBox
            // 
            this.typesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.typesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typesComboBox.FormattingEnabled = true;
            this.typesComboBox.Items.AddRange(new object[] {
            "admin",
            "karyawan"});
            this.typesComboBox.Location = new System.Drawing.Point(623, 116);
            this.typesComboBox.Name = "typesComboBox";
            this.typesComboBox.Size = new System.Drawing.Size(161, 26);
            this.typesComboBox.TabIndex = 32;
            // 
            // typesLabel
            // 
            this.typesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.typesLabel.AutoSize = true;
            this.typesLabel.Location = new System.Drawing.Point(554, 119);
            this.typesLabel.Name = "typesLabel";
            this.typesLabel.Size = new System.Drawing.Size(61, 18);
            this.typesLabel.TabIndex = 33;
            this.typesLabel.Text = "Types:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(63, 164);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(60, 18);
            this.emailLabel.TabIndex = 34;
            this.emailLabel.Text = "Email:";
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(247, 164);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(80, 18);
            this.addressLabel.TabIndex = 36;
            this.addressLabel.Text = "Address:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(550, 164);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(65, 18);
            this.phoneLabel.TabIndex = 38;
            this.phoneLabel.Text = "Phone:";
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextbox.BackColor = System.Drawing.Color.White;
            this.phoneTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(208)))));
            this.phoneTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.phoneTextbox.BorderSize = 2;
            this.phoneTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.phoneTextbox.Location = new System.Drawing.Point(623, 157);
            this.phoneTextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.phoneTextbox.Multiline = false;
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Padding = new System.Windows.Forms.Padding(6);
            this.phoneTextbox.PasswordChar = false;
            this.phoneTextbox.Placeholder = "";
            this.phoneTextbox.Size = new System.Drawing.Size(161, 33);
            this.phoneTextbox.TabIndex = 39;
            this.phoneTextbox.Texts = "";
            this.phoneTextbox.UnderlinedStyle = false;
            // 
            // addressTextbox
            // 
            this.addressTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextbox.BackColor = System.Drawing.Color.White;
            this.addressTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(208)))));
            this.addressTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.addressTextbox.BorderSize = 2;
            this.addressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addressTextbox.Location = new System.Drawing.Point(340, 157);
            this.addressTextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.addressTextbox.Multiline = false;
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Padding = new System.Windows.Forms.Padding(6);
            this.addressTextbox.PasswordChar = false;
            this.addressTextbox.Placeholder = "";
            this.addressTextbox.Size = new System.Drawing.Size(202, 33);
            this.addressTextbox.TabIndex = 37;
            this.addressTextbox.Texts = "";
            this.addressTextbox.UnderlinedStyle = false;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextbox.BackColor = System.Drawing.Color.White;
            this.emailTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(208)))));
            this.emailTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.emailTextbox.BorderSize = 2;
            this.emailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailTextbox.Location = new System.Drawing.Point(131, 157);
            this.emailTextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.emailTextbox.Multiline = false;
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Padding = new System.Windows.Forms.Padding(6);
            this.emailTextbox.PasswordChar = false;
            this.emailTextbox.Placeholder = "";
            this.emailTextbox.Size = new System.Drawing.Size(96, 33);
            this.emailTextbox.TabIndex = 35;
            this.emailTextbox.Texts = "";
            this.emailTextbox.UnderlinedStyle = false;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextbox.BackColor = System.Drawing.Color.White;
            this.passwordTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(208)))));
            this.passwordTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.passwordTextbox.BorderSize = 2;
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordTextbox.Location = new System.Drawing.Point(340, 112);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.passwordTextbox.Multiline = false;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Padding = new System.Windows.Forms.Padding(6);
            this.passwordTextbox.PasswordChar = false;
            this.passwordTextbox.Placeholder = "";
            this.passwordTextbox.Size = new System.Drawing.Size(202, 33);
            this.passwordTextbox.TabIndex = 31;
            this.passwordTextbox.Texts = "";
            this.passwordTextbox.UnderlinedStyle = false;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextbox.BackColor = System.Drawing.Color.White;
            this.usernameTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(208)))));
            this.usernameTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.usernameTextbox.BorderSize = 2;
            this.usernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameTextbox.Location = new System.Drawing.Point(131, 112);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.usernameTextbox.Multiline = false;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Padding = new System.Windows.Forms.Padding(6);
            this.usernameTextbox.PasswordChar = false;
            this.usernameTextbox.Placeholder = "";
            this.usernameTextbox.Size = new System.Drawing.Size(96, 33);
            this.usernameTextbox.TabIndex = 29;
            this.usernameTextbox.Texts = "";
            this.usernameTextbox.UnderlinedStyle = false;
            // 
            // searchTextbox
            // 
            this.searchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextbox.BackColor = System.Drawing.Color.White;
            this.searchTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(208)))));
            this.searchTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.searchTextbox.BorderSize = 2;
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchTextbox.Location = new System.Drawing.Point(131, 67);
            this.searchTextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.searchTextbox.Multiline = false;
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Padding = new System.Windows.Forms.Padding(6);
            this.searchTextbox.PasswordChar = false;
            this.searchTextbox.Placeholder = "";
            this.searchTextbox.Size = new System.Drawing.Size(525, 33);
            this.searchTextbox.TabIndex = 25;
            this.searchTextbox.Texts = "";
            this.searchTextbox.UnderlinedStyle = false;
            // 
            // AdminRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.typesLabel);
            this.Controls.Add(this.typesComboBox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.modePanel);
            this.Controls.Add(this.contentHeaderPanel);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminRegisterForm";
            this.Load += new System.EventHandler(this.AdminRegisterForm_Load);
            this.contentHeaderPanel.ResumeLayout(false);
            this.contentHeaderPanel.PerformLayout();
            this.modePanel.ResumeLayout(false);
            this.modePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel contentHeaderPanel;
        private System.Windows.Forms.Label contentHeaderLabel;
        private System.Windows.Forms.Panel modePanel;
        private System.Windows.Forms.Label registerModeLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private CustomControls.NeonTextbox searchTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Label usernameLabel;
        private CustomControls.NeonTextbox usernameTextbox;
        private CustomControls.NeonTextbox passwordTextbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.ComboBox typesComboBox;
        private System.Windows.Forms.Label typesLabel;
        private CustomControls.NeonTextbox emailTextbox;
        private System.Windows.Forms.Label emailLabel;
        private CustomControls.NeonTextbox addressTextbox;
        private System.Windows.Forms.Label addressLabel;
        private CustomControls.NeonTextbox phoneTextbox;
        private System.Windows.Forms.Label phoneLabel;
    }
}