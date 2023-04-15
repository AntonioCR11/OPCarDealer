
namespace OP_Car_Dealer.AdminFormPanels
{
    partial class AdminBrandForm
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
            this.contentHeaderPanel = new System.Windows.Forms.Panel();
            this.contentHeaderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.brandIdTextbox = new OP_Car_Dealer.CustomControls.NeonTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.brandNameTextbox = new OP_Car_Dealer.CustomControls.NeonTextbox();
            this.saveButton = new System.Windows.Forms.Button();
            this.brandDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.searchTextbox = new OP_Car_Dealer.CustomControls.NeonTextbox();
            this.searchButton = new System.Windows.Forms.Button();
            this.modePanel = new System.Windows.Forms.Panel();
            this.brandModeLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.contentHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandDataGridView)).BeginInit();
            this.modePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentHeaderPanel
            // 
            this.contentHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(208)))));
            this.contentHeaderPanel.Controls.Add(this.contentHeaderLabel);
            this.contentHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.contentHeaderPanel.Name = "contentHeaderPanel";
            this.contentHeaderPanel.Size = new System.Drawing.Size(800, 30);
            this.contentHeaderPanel.TabIndex = 0;
            // 
            // contentHeaderLabel
            // 
            this.contentHeaderLabel.AutoSize = true;
            this.contentHeaderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.contentHeaderLabel.Location = new System.Drawing.Point(12, 7);
            this.contentHeaderLabel.Name = "contentHeaderLabel";
            this.contentHeaderLabel.Size = new System.Drawing.Size(55, 18);
            this.contentHeaderLabel.TabIndex = 1;
            this.contentHeaderLabel.Text = "Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brand Id:";
            // 
            // brandIdTextbox
            // 
            this.brandIdTextbox.BackColor = System.Drawing.Color.White;
            this.brandIdTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(206)))), ((int)(((byte)(235)))));
            this.brandIdTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.brandIdTextbox.BorderSize = 2;
            this.brandIdTextbox.Enabled = false;
            this.brandIdTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.brandIdTextbox.Location = new System.Drawing.Point(105, 110);
            this.brandIdTextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.brandIdTextbox.Multiline = false;
            this.brandIdTextbox.Name = "brandIdTextbox";
            this.brandIdTextbox.Padding = new System.Windows.Forms.Padding(6);
            this.brandIdTextbox.PasswordChar = false;
            this.brandIdTextbox.Placeholder = "";
            this.brandIdTextbox.Size = new System.Drawing.Size(111, 33);
            this.brandIdTextbox.TabIndex = 2;
            this.brandIdTextbox.Texts = "";
            this.brandIdTextbox.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brand Name:";
            // 
            // brandNameTextbox
            // 
            this.brandNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brandNameTextbox.BackColor = System.Drawing.Color.White;
            this.brandNameTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(206)))), ((int)(((byte)(235)))));
            this.brandNameTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.brandNameTextbox.BorderSize = 2;
            this.brandNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.brandNameTextbox.Location = new System.Drawing.Point(347, 110);
            this.brandNameTextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.brandNameTextbox.Multiline = false;
            this.brandNameTextbox.Name = "brandNameTextbox";
            this.brandNameTextbox.Padding = new System.Windows.Forms.Padding(6);
            this.brandNameTextbox.PasswordChar = false;
            this.brandNameTextbox.Placeholder = "";
            this.brandNameTextbox.Size = new System.Drawing.Size(301, 33);
            this.brandNameTextbox.TabIndex = 4;
            this.brandNameTextbox.Texts = "";
            this.brandNameTextbox.UnderlinedStyle = false;
            this.brandNameTextbox._TextChanged += new System.EventHandler(this.brandNameTextbox__TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveButton.Enabled = false;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(208)))));
            this.saveButton.Location = new System.Drawing.Point(656, 110);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(132, 33);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // brandDataGridView
            // 
            this.brandDataGridView.AllowUserToAddRows = false;
            this.brandDataGridView.AllowUserToDeleteRows = false;
            this.brandDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brandDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brandDataGridView.Location = new System.Drawing.Point(12, 152);
            this.brandDataGridView.Name = "brandDataGridView";
            this.brandDataGridView.ReadOnly = true;
            this.brandDataGridView.RowHeadersVisible = false;
            this.brandDataGridView.Size = new System.Drawing.Size(776, 336);
            this.brandDataGridView.TabIndex = 6;
            this.brandDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.brandDataGridView_CellContentDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search:";
            // 
            // searchTextbox
            // 
            this.searchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextbox.BackColor = System.Drawing.Color.White;
            this.searchTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(206)))), ((int)(((byte)(235)))));
            this.searchTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.searchTextbox.BorderSize = 2;
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchTextbox.Location = new System.Drawing.Point(105, 74);
            this.searchTextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.searchTextbox.Multiline = false;
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Padding = new System.Windows.Forms.Padding(6);
            this.searchTextbox.PasswordChar = false;
            this.searchTextbox.Placeholder = "";
            this.searchTextbox.Size = new System.Drawing.Size(428, 33);
            this.searchTextbox.TabIndex = 8;
            this.searchTextbox.Texts = "";
            this.searchTextbox.UnderlinedStyle = false;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.SystemColors.Control;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(208)))));
            this.searchButton.Location = new System.Drawing.Point(535, 74);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 33);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // modePanel
            // 
            this.modePanel.BackColor = System.Drawing.Color.LightGray;
            this.modePanel.Controls.Add(this.brandModeLabel);
            this.modePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.modePanel.Location = new System.Drawing.Point(0, 30);
            this.modePanel.Name = "modePanel";
            this.modePanel.Size = new System.Drawing.Size(800, 31);
            this.modePanel.TabIndex = 10;
            // 
            // brandModeLabel
            // 
            this.brandModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brandModeLabel.AutoSize = true;
            this.brandModeLabel.Location = new System.Drawing.Point(675, 6);
            this.brandModeLabel.Name = "brandModeLabel";
            this.brandModeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.brandModeLabel.Size = new System.Drawing.Size(113, 18);
            this.brandModeLabel.TabIndex = 0;
            this.brandModeLabel.Text = "Mode: Insert";
            this.brandModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Enabled = false;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(208)))));
            this.deleteButton.Location = new System.Drawing.Point(654, 75);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(134, 33);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // AdminBrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modePanel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brandDataGridView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.brandNameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brandIdTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contentHeaderPanel);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AdminBrandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminBrandForm";
            this.contentHeaderPanel.ResumeLayout(false);
            this.contentHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandDataGridView)).EndInit();
            this.modePanel.ResumeLayout(false);
            this.modePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel contentHeaderPanel;
        private System.Windows.Forms.Label contentHeaderLabel;
        private System.Windows.Forms.Label label1;
        private CustomControls.NeonTextbox brandIdTextbox;
        private System.Windows.Forms.Label label2;
        private CustomControls.NeonTextbox brandNameTextbox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView brandDataGridView;
        private System.Windows.Forms.Label label3;
        private CustomControls.NeonTextbox searchTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel modePanel;
        private System.Windows.Forms.Label brandModeLabel;
        private System.Windows.Forms.Button deleteButton;
    }
}