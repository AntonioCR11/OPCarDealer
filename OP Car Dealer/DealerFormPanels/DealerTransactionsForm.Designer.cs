
namespace OP_Car_Dealer.DealerFormPanels
{
    partial class DealerTransactionsForm
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
            this.transDataGridView = new System.Windows.Forms.DataGridView();
            this.contentHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contentHeaderLabel
            // 
            this.contentHeaderLabel.AutoSize = true;
            this.contentHeaderLabel.Font = new System.Drawing.Font("Verdana", 12F);
            this.contentHeaderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.contentHeaderLabel.Location = new System.Drawing.Point(12, 6);
            this.contentHeaderLabel.Name = "contentHeaderLabel";
            this.contentHeaderLabel.Size = new System.Drawing.Size(106, 25);
            this.contentHeaderLabel.TabIndex = 0;
            this.contentHeaderLabel.Text = "Transaksi";
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
            // transDataGridView
            // 
            this.transDataGridView.AllowUserToAddRows = false;
            this.transDataGridView.AllowUserToDeleteRows = false;
            this.transDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cyan;
            this.transDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.transDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.transDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transDataGridView.Location = new System.Drawing.Point(0, 76);
            this.transDataGridView.Name = "transDataGridView";
            this.transDataGridView.ReadOnly = true;
            this.transDataGridView.RowHeadersVisible = false;
            this.transDataGridView.RowHeadersWidth = 51;
            this.transDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transDataGridView.Size = new System.Drawing.Size(800, 412);
            this.transDataGridView.TabIndex = 10;
            this.transDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transDataGridView_CellContentDoubleClick);
            // 
            // DealerTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.transDataGridView);
            this.Controls.Add(this.contentHeaderPanel);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "DealerTransactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DealerTransactionsForm";
            this.contentHeaderPanel.ResumeLayout(false);
            this.contentHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label contentHeaderLabel;
        private System.Windows.Forms.Panel contentHeaderPanel;
        private System.Windows.Forms.DataGridView transDataGridView;
    }
}