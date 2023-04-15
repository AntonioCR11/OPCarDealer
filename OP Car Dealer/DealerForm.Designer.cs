
namespace OP_Car_Dealer
{
    partial class DealerForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.reportsNavButton = new System.Windows.Forms.Button();
            this.inspectionsNavButton = new System.Windows.Forms.Button();
            this.transactionsNavButton = new System.Windows.Forms.Button();
            this.ordersNavButton = new System.Windows.Forms.Button();
            this.catalogNavButton = new System.Windows.Forms.Button();
            this.sidebarHeaderPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            this.sidebarHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Controls.Add(this.exitButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 30);
            this.headerPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Verdana", 12F);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.headerLabel.Location = new System.Drawing.Point(12, 5);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(182, 25);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Welcome, Dealer";
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
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Log Off";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.sidebarPanel.Controls.Add(this.reportsNavButton);
            this.sidebarPanel.Controls.Add(this.inspectionsNavButton);
            this.sidebarPanel.Controls.Add(this.transactionsNavButton);
            this.sidebarPanel.Controls.Add(this.ordersNavButton);
            this.sidebarPanel.Controls.Add(this.catalogNavButton);
            this.sidebarPanel.Controls.Add(this.sidebarHeaderPanel);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 30);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(200, 470);
            this.sidebarPanel.TabIndex = 1;
            // 
            // reportsNavButton
            // 
            this.reportsNavButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsNavButton.FlatAppearance.BorderSize = 0;
            this.reportsNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsNavButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reportsNavButton.Location = new System.Drawing.Point(0, 234);
            this.reportsNavButton.Name = "reportsNavButton";
            this.reportsNavButton.Size = new System.Drawing.Size(200, 36);
            this.reportsNavButton.TabIndex = 6;
            this.reportsNavButton.Text = "Laporan";
            this.reportsNavButton.UseVisualStyleBackColor = true;
            this.reportsNavButton.Click += new System.EventHandler(this.reportsNavButton_Click);
            // 
            // inspectionsNavButton
            // 
            this.inspectionsNavButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.inspectionsNavButton.FlatAppearance.BorderSize = 0;
            this.inspectionsNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inspectionsNavButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inspectionsNavButton.Location = new System.Drawing.Point(0, 198);
            this.inspectionsNavButton.Name = "inspectionsNavButton";
            this.inspectionsNavButton.Size = new System.Drawing.Size(200, 36);
            this.inspectionsNavButton.TabIndex = 5;
            this.inspectionsNavButton.Text = "Inspeksi";
            this.inspectionsNavButton.UseVisualStyleBackColor = true;
            this.inspectionsNavButton.Click += new System.EventHandler(this.inspectionsNavButton_Click);
            // 
            // transactionsNavButton
            // 
            this.transactionsNavButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.transactionsNavButton.FlatAppearance.BorderSize = 0;
            this.transactionsNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionsNavButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.transactionsNavButton.Location = new System.Drawing.Point(0, 162);
            this.transactionsNavButton.Name = "transactionsNavButton";
            this.transactionsNavButton.Size = new System.Drawing.Size(200, 36);
            this.transactionsNavButton.TabIndex = 4;
            this.transactionsNavButton.Text = "Transaksi";
            this.transactionsNavButton.UseVisualStyleBackColor = true;
            this.transactionsNavButton.Click += new System.EventHandler(this.transactionsNavButton_Click);
            // 
            // ordersNavButton
            // 
            this.ordersNavButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordersNavButton.FlatAppearance.BorderSize = 0;
            this.ordersNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersNavButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ordersNavButton.Location = new System.Drawing.Point(0, 126);
            this.ordersNavButton.Name = "ordersNavButton";
            this.ordersNavButton.Size = new System.Drawing.Size(200, 36);
            this.ordersNavButton.TabIndex = 3;
            this.ordersNavButton.Text = "Pesanan";
            this.ordersNavButton.UseVisualStyleBackColor = true;
            this.ordersNavButton.Click += new System.EventHandler(this.ordersNavButton_Click);
            // 
            // catalogNavButton
            // 
            this.catalogNavButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.catalogNavButton.FlatAppearance.BorderSize = 0;
            this.catalogNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catalogNavButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.catalogNavButton.Location = new System.Drawing.Point(0, 90);
            this.catalogNavButton.Name = "catalogNavButton";
            this.catalogNavButton.Size = new System.Drawing.Size(200, 36);
            this.catalogNavButton.TabIndex = 2;
            this.catalogNavButton.Text = "Katalog";
            this.catalogNavButton.UseVisualStyleBackColor = true;
            this.catalogNavButton.Click += new System.EventHandler(this.catalogNavButton_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(145, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 51);
            this.label1.TabIndex = 12;
            this.label1.Text = "OP Car";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 30);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(600, 470);
            this.mainPanel.TabIndex = 2;
            // 
            // DealerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Verdana", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "DealerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
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
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Button inspectionsNavButton;
        private System.Windows.Forms.Button transactionsNavButton;
        private System.Windows.Forms.Button ordersNavButton;
        private System.Windows.Forms.Button catalogNavButton;
        private System.Windows.Forms.Panel sidebarHeaderPanel;
        private System.Windows.Forms.Button reportsNavButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}