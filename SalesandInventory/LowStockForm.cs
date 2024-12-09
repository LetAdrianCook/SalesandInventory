using System;
using System.Data;
using System.Windows.Forms;

namespace SalesandInventory
{
    public partial class LowStockForm : Form
    {
        public LowStockForm(DataTable lowStockData)
        {
            InitializeComponent();
            LoadLowStockData(lowStockData);
        }

        private void LoadLowStockData(DataTable lowStockData)
        {
            // Bind the provided DataTable to the DataGridView
            lowStockDataGridView.DataSource = lowStockData;

            // Optionally set column headers or other properties
            lowStockDataGridView.Columns["productID"].HeaderText = "Product ID";
            lowStockDataGridView.Columns["productName"].HeaderText = "Product Name";
            lowStockDataGridView.Columns["productType"].HeaderText = "Product Type";
            lowStockDataGridView.Columns["brand"].HeaderText = "Brand";
            lowStockDataGridView.Columns["model"].HeaderText = "Model";
            lowStockDataGridView.Columns["quantity"].HeaderText = "Quantity";
            lowStockDataGridView.Columns["maxQuantity"].HeaderText = "Max Quantity";

            // Optionally adjust column widths
            foreach (DataGridViewColumn column in lowStockDataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Adjust as needed
            }
        }
    }
}