using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SalesandInventory.UserControls
{
    public partial class dashboardContent : UserControl
    {
        private Dbconn dbConnection;

        public dashboardContent()
        {
            InitializeComponent();
            try
            {
                dbConnection = new Dbconn();
                Load += dashboardContent_Load;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database connection: " + ex.Message);
            }
        }

        private void dashboardContent_Load(object sender, EventArgs e)
        {
            startDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            endDate.Value = DateTime.Now;
            GetTotalSales();
            GetTotalProfit();
            GetTopSelling();
            GetTotalInventory();
            GetLowStockCount();
            GetTotalInventoryItem();
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

        private void GetTopSelling()
        {
            string query = @"
        SELECT ProductID, SUM(Quantity) AS TotalQuantity
        FROM OrderItems
        WHERE SoldDate BETWEEN @StartDate AND @EndDate
        GROUP BY ProductID
        ORDER BY TotalQuantity DESC
        LIMIT 1"; // Get only the top-selling product

            try
            {
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StartDate", startDate.Value);
                        command.Parameters.AddWithValue("@EndDate", endDate.Value);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int productId = reader.GetInt32("ProductID");
                                int totalQuantity = reader.GetInt32("TotalQuantity");

                                // Now retrieve the product name based on ProductID using a new connection
                                string productNameQuery = "SELECT ProductName FROM inventory WHERE productID = @ProductID";
                                using (MySqlConnection nameConnection = dbConnection.GetConnection()) // New connection
                                {
                                    nameConnection.Open();
                                    using (MySqlCommand nameCommand = new MySqlCommand(productNameQuery, nameConnection))
                                    {
                                        nameCommand.Parameters.AddWithValue("@ProductID", productId);
                                        object nameResult = nameCommand.ExecuteScalar();

                                        if (nameResult != null)
                                        {
                                            string productName = nameResult.ToString();
                                            lblTopselling.Text = $"{productName}";
                                            lblQty.Text = $"({totalQuantity} sold)";
                                        }
                                        else
                                        {
                                            lblTopselling.Text = "No products sold.";
                                            lblQty.Text = "( )";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                lblTopselling.Text = "No products sold.";
                                lblQty.Text = "( )";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving top selling product: " + ex.Message);
            }
        }

        private void GetTotalInventory()
        {
            decimal totalInventoryValue = 0;

            // Adjust the query to sum SellingPrice * Quantity from the Inventory table
            string query = "SELECT SUM(sellingPrice * quantity) FROM inventory";

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
                            totalInventoryValue = Convert.ToDecimal(result);
                        }
                    }
                }

                if (totalInventoryValue > 0)
                {
                    lblTotalinventoryval.Text = $"{totalInventoryValue:C}";
                }
                else
                {
                    lblTotalinventoryval.Text = "₱0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving total inventory value: " + ex.Message);
            }
        }

        private DataTable GetLowStockProducts()
        {
            DataTable lowStockTable = new DataTable();
            string query = "SELECT productID, productName, productType, brand, model, quantity, maxQuantity " +
                           "FROM inventory " +
                           "WHERE quantity < (0.2 * maxQuantity)";

            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();
                    MySqlCommand command = new MySqlCommand(query, mysqlConnection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(lowStockTable); // Fill the DataTable with low stock products
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving low stock products: " + ex.Message);
            }

            return lowStockTable; // Return the DataTable containing low stock products
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
        private void GetLowStockCount()
        {
            int lowStockCount = 0;
            string query = "SELECT COUNT(*) FROM inventory WHERE quantity < (0.2 * maxQuantity)";

            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();
                    MySqlCommand command = new MySqlCommand(query, mysqlConnection);
                    lowStockCount = Convert.ToInt32(command.ExecuteScalar()); // Get the count of low stock products
                }

                // Update the label with the count of low stock products
                lowStockCountLabel.Text = $"{lowStockCount} Product(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving low stock count: " + ex.Message);
            }
        }


        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            GetTotalSales();
            GetTotalProfit();
            GetTopSelling();

        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            GetTotalSales();
            GetTotalProfit();
            GetTopSelling();

        }

        private void lowStockPanel_Click(object sender, EventArgs e)
        {
            DataTable lowStockData = GetLowStockProducts(); // Get low stock products

            if (lowStockData.Rows.Count > 0)
            {
                // Create and show the Low Stock Form as a modal dialog
                LowStockForm lowStockForm = new LowStockForm(lowStockData);
                lowStockForm.ShowDialog(); // Show as modal dialog
            }
            else
            {
                MessageBox.Show("No products are currently in low stock.");
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            startDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            endDate.Value = DateTime.Now;
            GetTotalSales();
            GetTotalProfit();
            GetTopSelling();
            GetTotalInventory();
            GetLowStockCount();
            GetTotalInventoryItem();
            MessageBox.Show("Refreshed");
        }
    }
}