
namespace OP_Car_Dealer.AdminFormPanels
{
    partial class AdminOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminOrdersForm));
            this.contentHeaderLabel = new System.Windows.Forms.Label();
            this.contentHeaderPanel = new System.Windows.Forms.Panel();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tempPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.decline = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.labelDealer = new System.Windows.Forms.Label();
            this.contentHeaderPanel.SuspendLayout();
            this.flowPanel.SuspendLayout();
            this.tempPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contentHeaderLabel
            // 
            this.contentHeaderLabel.AutoSize = true;
            this.contentHeaderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.contentHeaderLabel.Location = new System.Drawing.Point(12, 7);
            this.contentHeaderLabel.Name = "contentHeaderLabel";
            this.contentHeaderLabel.Size = new System.Drawing.Size(96, 25);
            this.contentHeaderLabel.TabIndex = 1;
            this.contentHeaderLabel.Text = "Pesanan";
            // 
            // contentHeaderPanel
            // 
            this.contentHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(208)))));
            this.contentHeaderPanel.Controls.Add(this.contentHeaderLabel);
            this.contentHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.contentHeaderPanel.Name = "contentHeaderPanel";
            this.contentHeaderPanel.Size = new System.Drawing.Size(1250, 30);
            this.contentHeaderPanel.TabIndex = 1;
            // 
            // flowPanel
            // 
            this.flowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanel.AutoScroll = true;
            this.flowPanel.BackColor = System.Drawing.Color.Cornsilk;
            this.flowPanel.Controls.Add(this.tempPanel);
            this.flowPanel.Location = new System.Drawing.Point(0, 36);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(1257, 573);
            this.flowPanel.TabIndex = 8;
            // 
            // tempPanel
            // 
            this.tempPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tempPanel.BackColor = System.Drawing.Color.Wheat;
            this.tempPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tempPanel.Controls.Add(this.labelDealer);
            this.tempPanel.Controls.Add(this.label2);
            this.tempPanel.Controls.Add(this.pictureBox1);
            this.tempPanel.Controls.Add(this.decline);
            this.tempPanel.Controls.Add(this.name);
            this.tempPanel.Location = new System.Drawing.Point(3, 3);
            this.tempPanel.Name = "tempPanel";
            this.tempPanel.Size = new System.Drawing.Size(1254, 254);
            this.tempPanel.TabIndex = 3;
            this.tempPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // decline
            // 
            this.decline.BackColor = System.Drawing.Color.Crimson;
            this.decline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("decline.BackgroundImage")));
            this.decline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.decline.Location = new System.Drawing.Point(1155, 97);
            this.decline.Name = "decline";
            this.decline.Size = new System.Drawing.Size(81, 58);
            this.decline.TabIndex = 4;
            this.decline.UseVisualStyleBackColor = false;
            this.decline.Click += new System.EventHandler(this.decline_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.name.Location = new System.Drawing.Point(461, 114);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(73, 25);
            this.name.TabIndex = 2;
            this.name.Text = "nama";
            // 
            // labelDealer
            // 
            this.labelDealer.AutoSize = true;
            this.labelDealer.Location = new System.Drawing.Point(461, 18);
            this.labelDealer.Name = "labelDealer";
            this.labelDealer.Size = new System.Drawing.Size(73, 25);
            this.labelDealer.TabIndex = 7;
            this.labelDealer.Text = "label3";
            // 
            // AdminOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1250, 612);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.contentHeaderPanel);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AdminOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPesananForm";
            this.contentHeaderPanel.ResumeLayout(false);
            this.contentHeaderPanel.PerformLayout();
            this.flowPanel.ResumeLayout(false);
            this.tempPanel.ResumeLayout(false);
            this.tempPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label contentHeaderLabel;
        private System.Windows.Forms.Panel contentHeaderPanel;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Panel tempPanel;
        private System.Windows.Forms.Label labelDealer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button decline;
        private System.Windows.Forms.Label name;
    }
}