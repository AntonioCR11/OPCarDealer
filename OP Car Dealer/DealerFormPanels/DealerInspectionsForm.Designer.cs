
namespace OP_Car_Dealer.DealerFormPanels
{
    partial class DealerInspectionsForm
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
            this.contentHeaderLabel = new System.Windows.Forms.Label();
            this.contentHeaderPanel = new System.Windows.Forms.Panel();
            this.inspectionDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextbox = new OP_Car_Dealer.CustomControls.NeonTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.contentHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contentHeaderLabel
            // 
            this.contentHeaderLabel.AutoSize = true;
            this.contentHeaderLabel.Font = new System.Drawing.Font("Verdana", 12F);
            this.contentHeaderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.contentHeaderLabel.Location = new System.Drawing.Point(12, 6);
            this.contentHeaderLabel.Name = "contentHeaderLabel";
            this.contentHeaderLabel.Size = new System.Drawing.Size(94, 18);
            this.contentHeaderLabel.TabIndex = 0;
            this.contentHeaderLabel.Text = "Inspection";
            // 
            // contentHeaderPanel
            // 
            this.contentHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(208)))));
            this.contentHeaderPanel.Controls.Add(this.contentHeaderLabel);
            this.contentHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.contentHeaderPanel.Name = "contentHeaderPanel";
            this.contentHeaderPanel.Size = new System.Drawing.Size(800, 30);
            this.contentHeaderPanel.TabIndex = 2;
            // 
            // inspectionDataGridView
            // 
            this.inspectionDataGridView.AllowUserToAddRows = false;
            this.inspectionDataGridView.AllowUserToDeleteRows = false;
            this.inspectionDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
            this.inspectionDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.inspectionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inspectionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inspectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inspectionDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.inspectionDataGridView.Location = new System.Drawing.Point(12, 77);
            this.inspectionDataGridView.Name = "inspectionDataGridView";
            this.inspectionDataGridView.ReadOnly = true;
            this.inspectionDataGridView.RowHeadersVisible = false;
            this.inspectionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inspectionDataGridView.Size = new System.Drawing.Size(776, 411);
            this.inspectionDataGridView.TabIndex = 28;
            this.inspectionDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inspectionDataGridView_CellContentDoubleClick);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.SystemColors.Control;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(208)))));
            this.searchButton.Location = new System.Drawing.Point(556, 35);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 33);
            this.searchButton.TabIndex = 31;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            this.searchTextbox.Location = new System.Drawing.Point(94, 35);
            this.searchTextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.searchTextbox.Multiline = false;
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Padding = new System.Windows.Forms.Padding(6);
            this.searchTextbox.PasswordChar = false;
            this.searchTextbox.Placeholder = "";
            this.searchTextbox.Size = new System.Drawing.Size(454, 33);
            this.searchTextbox.TabIndex = 30;
            this.searchTextbox.Texts = "";
            this.searchTextbox.UnderlinedStyle = false;
            this.searchTextbox._TextChanged += new System.EventHandler(this.searchTextbox__TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Search:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.BackColor = System.Drawing.SystemColors.Control;
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(208)))));
            this.createButton.Location = new System.Drawing.Point(675, 35);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(113, 33);
            this.createButton.TabIndex = 32;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // DealerInspectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inspectionDataGridView);
            this.Controls.Add(this.contentHeaderPanel);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "DealerInspectionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DealerInspectionsForm";
            this.contentHeaderPanel.ResumeLayout(false);
            this.contentHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contentHeaderLabel;
        private System.Windows.Forms.Panel contentHeaderPanel;
        private System.Windows.Forms.DataGridView inspectionDataGridView;
        private System.Windows.Forms.Button searchButton;
        private CustomControls.NeonTextbox searchTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createButton;
    }
}