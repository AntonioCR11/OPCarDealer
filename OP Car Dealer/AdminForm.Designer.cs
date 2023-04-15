
namespace OP_Car_Dealer
{
    partial class AdminForm
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.reportNavButton = new System.Windows.Forms.Button();
            this.ordersNavButton = new System.Windows.Forms.Button();
            this.transactionsNavButton = new System.Windows.Forms.Button();
            this.mobilNavButton = new System.Windows.Forms.Button();
            this.brandNavButton = new System.Windows.Forms.Button();
            this.registerNavButton = new System.Windows.Forms.Button();
            this.sidebarHeaderPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.inboxButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            this.sidebarHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.exitButton);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 30);
            this.headerPanel.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Verdana", 10F);
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitButton.Image = global::OP_Car_Dealer.Properties.Resources.logout_small;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(710, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(90, 30);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Log Off";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Verdana", 12F);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.headerLabel.Location = new System.Drawing.Point(12, 6);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(145, 18);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Welcome, Admin";
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.Controls.Add(this.inboxButton);
            this.sidebarPanel.Controls.Add(this.reportNavButton);
            this.sidebarPanel.Controls.Add(this.ordersNavButton);
            this.sidebarPanel.Controls.Add(this.transactionsNavButton);
            this.sidebarPanel.Controls.Add(this.mobilNavButton);
            this.sidebarPanel.Controls.Add(this.brandNavButton);
            this.sidebarPanel.Controls.Add(this.registerNavButton);
            this.sidebarPanel.Controls.Add(this.sidebarHeaderPanel);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 30);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(200, 470);
            this.sidebarPanel.TabIndex = 1;
            // 
            // reportNavButton
            // 
            this.reportNavButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportNavButton.FlatAppearance.BorderSize = 0;
            this.reportNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportNavButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reportNavButton.Location = new System.Drawing.Point(0, 270);
            this.reportNavButton.Name = "reportNavButton";
            this.reportNavButton.Size = new System.Drawing.Size(200, 36);
            this.reportNavButton.TabIndex = 7;
            this.reportNavButton.Text = "Laporan";
            this.reportNavButton.UseVisualStyleBackColor = true;
            this.reportNavButton.Click += new System.EventHandler(this.reportNavButton_Click);
            // 
            // ordersNavButton
            // 
            this.ordersNavButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordersNavButton.FlatAppearance.BorderSize = 0;
            this.ordersNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersNavButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ordersNavButton.Location = new System.Drawing.Point(0, 234);
            this.ordersNavButton.Name = "ordersNavButton";
            this.ordersNavButton.Size = new System.Drawing.Size(200, 36);
            this.ordersNavButton.TabIndex = 6;
            this.ordersNavButton.Text = "Pesanan";
            this.ordersNavButton.UseVisualStyleBackColor = true;
            this.ordersNavButton.Click += new System.EventHandler(this.ordersNavButton_Click);
            // 
            // transactionsNavButton
            // 
            this.transactionsNavButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.transactionsNavButton.FlatAppearance.BorderSize = 0;
            this.transactionsNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionsNavButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.transactionsNavButton.Location = new System.Drawing.Point(0, 198);
            this.transactionsNavButton.Name = "transactionsNavButton";
            this.transactionsNavButton.Size = new System.Drawing.Size(200, 36);
            this.transactionsNavButton.TabIndex = 5;
            this.transactionsNavButton.Text = "Transaksi";
            this.transactionsNavButton.UseVisualStyleBackColor = true;
            this.transactionsNavButton.Click += new System.EventHandler(this.transactionsNavButton_Click);
            // 
            // mobilNavButton
            // 
            this.mobilNavButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mobilNavButton.FlatAppearance.BorderSize = 0;
            this.mobilNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mobilNavButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mobilNavButton.Location = new System.Drawing.Point(0, 162);
            this.mobilNavButton.Name = "mobilNavButton";
            this.mobilNavButton.Size = new System.Drawing.Size(200, 36);
            this.mobilNavButton.TabIndex = 4;
            this.mobilNavButton.Text = "Mobil";
            this.mobilNavButton.UseVisualStyleBackColor = true;
            this.mobilNavButton.Click += new System.EventHandler(this.mobilNavButton_Click);
            // 
            // brandNavButton
            // 
            this.brandNavButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.brandNavButton.FlatAppearance.BorderSize = 0;
            this.brandNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brandNavButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.brandNavButton.Location = new System.Drawing.Point(0, 126);
            this.brandNavButton.Name = "brandNavButton";
            this.brandNavButton.Size = new System.Drawing.Size(200, 36);
            this.brandNavButton.TabIndex = 3;
            this.brandNavButton.Text = "Brand";
            this.brandNavButton.UseVisualStyleBackColor = true;
            this.brandNavButton.Click += new System.EventHandler(this.brandNavButton_Click);
            // 
            // registerNavButton
            // 
            this.registerNavButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.registerNavButton.FlatAppearance.BorderSize = 0;
            this.registerNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerNavButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registerNavButton.Location = new System.Drawing.Point(0, 90);
            this.registerNavButton.Name = "registerNavButton";
            this.registerNavButton.Size = new System.Drawing.Size(200, 36);
            this.registerNavButton.TabIndex = 0;
            this.registerNavButton.Text = "Register";
            this.registerNavButton.UseVisualStyleBackColor = true;
            this.registerNavButton.Click += new System.EventHandler(this.registerNavButton_Click);
            // 
            // sidebarHeaderPanel
            // 
            this.sidebarHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(206)))), ((int)(((byte)(235)))));
            this.sidebarHeaderPanel.Controls.Add(this.pictureBox1);
            this.sidebarHeaderPanel.Controls.Add(this.label1);
            this.sidebarHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidebarHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarHeaderPanel.Name = "sidebarHeaderPanel";
            this.sidebarHeaderPanel.Size = new System.Drawing.Size(200, 90);
            this.sidebarHeaderPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OP_Car_Dealer.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(143, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "OP Car";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(200, 30);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(600, 470);
            this.contentPanel.TabIndex = 2;
            // 
            // inboxButton
            // 
            this.inboxButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.inboxButton.FlatAppearance.BorderSize = 0;
            this.inboxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inboxButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inboxButton.Location = new System.Drawing.Point(0, 306);
            this.inboxButton.Name = "inboxButton";
            this.inboxButton.Size = new System.Drawing.Size(200, 36);
            this.inboxButton.TabIndex = 8;
            this.inboxButton.Text = "Inbox";
            this.inboxButton.UseVisualStyleBackColor = true;
            this.inboxButton.Click += new System.EventHandler(this.inboxButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Verdana", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome, Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarHeaderPanel.ResumeLayout(false);
            this.sidebarHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel sidebarHeaderPanel;
        private System.Windows.Forms.Button registerNavButton;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button reportNavButton;
        private System.Windows.Forms.Button ordersNavButton;
        private System.Windows.Forms.Button transactionsNavButton;
        private System.Windows.Forms.Button mobilNavButton;
        private System.Windows.Forms.Button brandNavButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inboxButton;
    }
}