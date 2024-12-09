namespace SalesandInventory
{
    partial class LowStockForm
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
            lowStockDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)lowStockDataGridView).BeginInit();
            SuspendLayout();
            // 
            // lowStockDataGridView
            // 
            lowStockDataGridView.AllowUserToAddRows = false;
            lowStockDataGridView.AllowUserToDeleteRows = false;
            lowStockDataGridView.BackgroundColor = Color.White;
            lowStockDataGridView.BorderStyle = BorderStyle.Fixed3D;
            lowStockDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lowStockDataGridView.Location = new Point(12, 12);
            lowStockDataGridView.Name = "lowStockDataGridView";
            lowStockDataGridView.ReadOnly = true;
            lowStockDataGridView.RowHeadersWidth = 62;
            lowStockDataGridView.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lowStockDataGridView.Size = new Size(524, 426);
            lowStockDataGridView.TabIndex = 15;
            // 
            // LowStockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 450);
            Controls.Add(lowStockDataGridView);
            Name = "LowStockForm";
            Text = "LowStockForm";
            ((System.ComponentModel.ISupportInitialize)lowStockDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView lowStockDataGridView;
    }
}