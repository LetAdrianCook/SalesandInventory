using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesandInventory.UserControls
{
    public partial class Report : UserControl
    {

        private Dbconn dbConnection;
        private DataTable dtSales;
        private DataTable dtSalesItem;
        public Report()
        {
            InitializeComponent();
            try
            {
                dbConnection = new Dbconn();
                Load += Report_Load;
                columnFilterCbx.SelectedIndex = 0;
                searchBarTxt.TextChanged += new EventHandler(searchBarTxt_TextChanged);
                ocolumnFilterCbx.SelectedIndex = 0;
                osearchBarTxt.TextChanged += new EventHandler(osearchBarTxt_TextChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database connection: " + ex.Message);
            }
        }


        private void Report_Load(object sender, EventArgs e)
        {
            startDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            endDate.Value = DateTime.Now;
            BindData();
            BindData2();
            GetTotalSales();
            GetTotalProfit();
            GetTotalInventoryItem();
            GetTotalOrders();
        }

        private void searchBarTxt_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridView();
        }

        private void FilterDataGridView()
        {
            string filterColumn = columnFilterCbx.SelectedItem.ToString(); // Get selected column name
            string filterValue = searchBarTxt.Text.Trim(); // Get search text

            if (dtSales != null) // Ensure that dtSales is not null
            {
                if (!string.IsNullOrEmpty(filterValue))
                {
                    // Check if the selected column is OrderID
                    if (filterColumn.Equals("OrderID", StringComparison.OrdinalIgnoreCase))
                    {
                        // Try to parse the filterValue as an integer
                        if (int.TryParse(filterValue, out int numericValue))
                        {
                            // Use numeric comparison for OrderID
                            dtSales.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, numericValue);
                        }
                        else
                        {
                            // If input is invalid for OrderID, clear the filter and show a message
                            dtSales.DefaultView.RowFilter = string.Empty; // Clear filter
                            MessageBox.Show("Please enter a valid numeric value for OrderID.");
                            searchBarTxt.Clear();
                        }
                    }
                    else if (filterColumn.Equals("UserID", StringComparison.OrdinalIgnoreCase))
                    {
                        // Check if the input value is a valid number for UserID
                        if (int.TryParse(filterValue, out int userIdValue))
                        {
                            // Use numeric comparison for UserID
                            dtSales.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, userIdValue);
                        }
                        else
                        {
                            // If input is invalid for UserID, clear the filter and show a message
                            dtSales.DefaultView.RowFilter = string.Empty; // Clear filter
                            MessageBox.Show("Please enter a valid numeric value for UserID.");
                            searchBarTxt.Clear();
                        }
                    }
                
                    
                    else
                    {
                        // For other columns, use LIKE for string comparison
                        dtSales.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterColumn, filterValue);
                    }
                }
                else
                {
                    dtSales.DefaultView.RowFilter = string.Empty; // Clear filter if no text is entered
                }

                salesGridView.DataSource = dtSales.DefaultView; // Update DataGridView source
            }
        }

        private void osearchBarTxt_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridViewO();
        }

        private void FilterDataGridViewO()
        {
            string filterColumn = ocolumnFilterCbx.SelectedItem.ToString(); // Get selected column name
            string filterValue = osearchBarTxt.Text.Trim(); // Get search text

            if (dtSalesItem != null) // Ensure that dtSalesItem is not null
            {
                if (!string.IsNullOrEmpty(filterValue))
                {
                    // Check if the selected column is OrderItemID, OrderID, ProductID, or SoldDate
                    if (filterColumn.Equals("OrderItemID", StringComparison.OrdinalIgnoreCase) ||
                        filterColumn.Equals("OrderID", StringComparison.OrdinalIgnoreCase) ||
                        filterColumn.Equals("ProductID", StringComparison.OrdinalIgnoreCase))
                    {
                        // Try to parse the filterValue as an integer
                        if (int.TryParse(filterValue, out int numericValue))
                        {
                            // Use numeric comparison for the selected ID column
                            dtSalesItem.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, numericValue);
                        }
                        else
                        {
                            // If input is invalid for numeric columns, clear the filter and show a message
                            dtSalesItem.DefaultView.RowFilter = string.Empty; // Clear filter
                            MessageBox.Show($"Please enter a valid numeric value for {filterColumn}.");
                            osearchBarTxt.Clear();
                        }
                    }
                   
                    else
                    {
                        // For other columns, use LIKE for string comparison
                        dtSalesItem.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterColumn, filterValue);
                    }
                }
                else
                {
                    dtSalesItem.DefaultView.RowFilter = string.Empty; // Clear filter if no text is entered
                }

                orderItemsGridView.DataSource = dtSalesItem.DefaultView; // Update DataGridView source
            }
        }

        private void BindData()
        {
            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open(); // Ensure the connection is opened
                    MySqlCommand view = new MySqlCommand("SELECT OrderID, UserID, subTotal, discount, totalPrice, amountReceived, changeAmount, OrderDate FROM Orders", mysqlConnection);
                    MySqlDataAdapter salesTable = new MySqlDataAdapter(view);
                    dtSales = new DataTable(); // Initialize the class-level DataTable
                    salesTable.Fill(dtSales); // Fill the DataTable with data
                    salesGridView.DataSource = dtSales; // Bind DataTable to DataGridView

                    // Set column headers
                    salesGridView.Columns["OrderID"].HeaderText = "OrderID";
                    salesGridView.Columns["UserID"].HeaderText = "UserID";
                    salesGridView.Columns["subTotal"].HeaderText = "subTotal";
                    salesGridView.Columns["totalPrice"].HeaderText = "totalPrice";
                    salesGridView.Columns["amountReceived"].HeaderText = "amountReceived";
                    salesGridView.Columns["changeAmount"].HeaderText = "changeAmount";
                    salesGridView.Columns["OrderDate"].HeaderText = "Order Date";
           
    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data from Supplier Table: " + ex.Message);
            }
        }

        private void BindData2()
        {
            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open(); // Ensure the connection is opened
                    MySqlCommand view = new MySqlCommand("SELECT ProductID, Quantity, SellingPrice, TotalPrice, UnitCost, Profit, SoldDate, OrderItemID, OrderID   FROM OrderItems", mysqlConnection);
                    MySqlDataAdapter salesTable = new MySqlDataAdapter(view);
                    dtSalesItem = new DataTable(); // Initialize the class-level DataTable
                    salesTable.Fill(dtSalesItem); // Fill the DataTable with data
                    orderItemsGridView.DataSource = dtSalesItem; // Bind DataTable to DataGridView

                    // Set column headers
                  
                    orderItemsGridView.Columns["ProductID"].HeaderText = "ProductID";
                    orderItemsGridView.Columns["Quantity"].HeaderText = "Quantity";
                    orderItemsGridView.Columns["SellingPrice"].HeaderText = "Selling Price";
                    orderItemsGridView.Columns["TotalPrice"].HeaderText = "Total Price";
                    orderItemsGridView.Columns["UnitCost"].HeaderText = "Unit Cost";
                    orderItemsGridView.Columns["Profit"].HeaderText = "Profit";
                    orderItemsGridView.Columns["SoldDate"].HeaderText = "Sold Date";
                    orderItemsGridView.Columns["OrderItemID"].HeaderText = "OrderItemID";
                    orderItemsGridView.Columns["OrderID"].HeaderText = "OrderID";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data from Supplier Table: " + ex.Message);
            }
        }

        private void GetTotalProfit()
        {
            decimal totalProfit = 0;

            string query = "SELECT SUM(Profit) FROM OrderItems WHERE SoldDate BETWEEN @StartDate AND @EndDate";

            try
            {
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StartDate", startDate.Value);
                        command.Parameters.AddWithValue("@EndDate", endDate.Value);

                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalProfit = Convert.ToDecimal(result);
                        }
                    }
                }


                if (totalProfit > 0)
                {
                    lblTotalprofit.Text = $"{totalProfit:C}";
                }
                else
                {
                    lblTotalprofit.Text = "₱0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving total profit: " + ex.Message);
            }
        }

        private void GetTotalSales()
        {
            decimal totalSales = 0;

            string query = "SELECT SUM(TotalPrice) FROM Orders WHERE OrderDate BETWEEN @StartDate AND @EndDate";

            try
            {
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StartDate", startDate.Value);
                        command.Parameters.AddWithValue("@EndDate", endDate.Value);

                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalSales = Convert.ToDecimal(result);
                        }
                    }
                }


                if (totalSales > 0)
                {
                    lblTotalSales.Text = $"{totalSales:C}";
                }
                else
                {
                    lblTotalSales.Text = "₱0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving total sales: " + ex.Message);
            }
        }

        private void GetTotalInventoryItem()
        {
            decimal totalInventoryItem = 0;

            // Adjust the query to sum SellingPrice * Quantity from the Inventory table
            string query = "SELECT SUM(quantity) FROM inventory";

            try
            {
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {

                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalInventoryItem = Convert.ToInt64(result);
                        }
                    }
                }

                if (totalInventoryItem > 0)
                {
                    lblTotalinventoryitem.Text = $"{totalInventoryItem} Products";
                }
                else
                {
                    lblTotalinventoryitem.Text = "₱0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving total inventory value: " + ex.Message);
            }
        }

        private void GetTotalOrders()
        {
            decimal totalOrders = 0;

            // Adjust the query to sum SellingPrice * Quantity from the Inventory table
            string query = "SELECT COUNT(*) FROM Orders WHERE OrderDate BETWEEN @StartDate AND @EndDate";

            try
            {
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StartDate", startDate.Value);
                        command.Parameters.AddWithValue("@EndDate", endDate.Value);

                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalOrders = Convert.ToInt64(result);
                        }
                    }
                }

                if (totalOrders > 0)
                {
                    lblTotalorders.Text = $"{totalOrders} Orders";
                }
                else
                {
                    lblTotalorders.Text = "No orders";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving total Total Orders: " + ex.Message);
            }
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            GetTotalSales();
            GetTotalProfit();
            GetTotalInventoryItem();
            GetTotalOrders();
        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            GetTotalSales();
            GetTotalProfit();
            GetTotalInventoryItem();
            GetTotalOrders();
        }


    }
}
