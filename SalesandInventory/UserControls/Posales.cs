using SalesandInventory;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Printing;
using System.Globalization;
using Mysqlx.Crud;
using Microsoft.VisualBasic.ApplicationServices;

namespace Sales_Inv
{
    public partial class UserControl2 : UserControl
    {

        private Dbconn dbConnection;
        private DataTable dtinventory;
        private List<OrderItem> orderItems = new List<OrderItem>();
        public UserControl2()
        {
            InitializeComponent();
            try
            {
                dbConnection = new Dbconn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database connection: " + ex.Message);
            }
            this.inventoryGridView.CellClick += new DataGridViewCellEventHandler(this.inventoryGridView_CellClick);
            columnFilterCbx.SelectedIndex = 0;
            cmbDiscount.SelectedIndex = 0;
            txtAmountReceived.Text = "0";
            this.txtQuantity.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            this.txtAmountReceived.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            searchBarTxt.TextChanged += new EventHandler(searchBarTxt_TextChanged);
            txtAmountReceived.TextChanged += new EventHandler(txtAmountReceived_TextChanged);
            orderDataGridView.CellClick += orderDataGridView_CellClick;

            // Subscribe to SelectedIndexChanged event
            cmbDiscount.SelectedIndexChanged += (s, e) => UpdateTotalPrice();
            BindData();
        }



        private void searchBarTxt_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridView();
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            // Allow control keys (like backspace)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow digits
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Allow decimal separator only if it doesn't already exist
            if (e.KeyChar.ToString() == decimalSeparator && !((TextBox)sender).Text.Contains(decimalSeparator))
            {
                return;
            }

            // Reject invalid key press
            e.Handled = true;
        }



        private void FilterDataGridView()
        {
            string filterColumn = columnFilterCbx.SelectedItem.ToString();
            string filterValue = searchBarTxt.Text.Trim();

            if (dtinventory != null)
            {
                if (!string.IsNullOrEmpty(filterValue))
                {

                    if (filterColumn.Equals("productID", StringComparison.OrdinalIgnoreCase))
                    {

                        if (int.TryParse(filterValue, out int numericValue))
                        {

                            dtinventory.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, numericValue);
                        }
                        else
                        {

                            dtinventory.DefaultView.RowFilter = string.Empty;
                            MessageBox.Show("Please enter a valid numeric value for productID.");
                            searchBarTxt.Clear();
                        }
                    }
                    else
                    {
                        // For other columns, use LIKE for string comparison
                        dtinventory.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterColumn, filterValue);
                    }
                }
                else
                {
                    dtinventory.DefaultView.RowFilter = string.Empty; // Clear filter if no text is entered
                }

                inventoryGridView.DataSource = dtinventory.DefaultView; // Update DataGridView source
            }
        }
        private void BindData()
        {
            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open(); // Ensure the connection is opened

                    // SQL query to retrieve inventory data
                    string query = "SELECT productID, productName, productType, brand, model, quantity, unitCost, sellingPrice, supplierID, supplierName, status, dateCreated, dateUpdated FROM inventory WHERE status = 'Functional' AND quantity > 0";
                    MySqlCommand command = new MySqlCommand(query, mysqlConnection);

                    // Using MySqlDataAdapter to fill DataTable
                    MySqlDataAdapter invTable = new MySqlDataAdapter(command);
                    dtinventory = new DataTable(); // Initialize the class-level DataTable
                    invTable.Fill(dtinventory); // Fill the DataTable with data

                    // Bind DataTable to DataGridView
                    inventoryGridView.DataSource = dtinventory;

                    // Set column headers for better readability
                    SetColumnHeaders();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data from Inventory Table: " + ex.Message);
            }
        }

        private void SetColumnHeaders()
        {
            // Set column headers for better readability
            inventoryGridView.Columns["productID"].HeaderText = "Product ID";
            inventoryGridView.Columns["productName"].HeaderText = "Product Name";
            inventoryGridView.Columns["productType"].HeaderText = "Product Type";
            inventoryGridView.Columns["brand"].HeaderText = "Brand";
            inventoryGridView.Columns["model"].HeaderText = "Model";
            inventoryGridView.Columns["quantity"].HeaderText = "Quantity";
            inventoryGridView.Columns["unitCost"].HeaderText = "Unit Cost";
            inventoryGridView.Columns["sellingPrice"].HeaderText = "Selling Price";
            inventoryGridView.Columns["supplierID"].HeaderText = "Supplier ID";
            inventoryGridView.Columns["supplierName"].HeaderText = "Supplier Name";
            inventoryGridView.Columns["status"].HeaderText = "Status";
            inventoryGridView.Columns["dateCreated"].HeaderText = "Date Created";
            inventoryGridView.Columns["dateUpdated"].HeaderText = "Date Updated";

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the DataGridView
            if (orderDataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = orderDataGridView.SelectedRows[0];

                // Retrieve the ProductID from the selected row
                int productId = (int)selectedRow.Cells["ProductID"].Value;

                // Find the corresponding order item in orderItems
                var itemToRemove = orderItems.FirstOrDefault(o => o.ProductID == productId);

                if (itemToRemove != null)
                {
                    // Remove the item from orderItems
                    orderItems.Remove(itemToRemove);
                    MessageBox.Show("Selected item has been removed.");
                }
                else
                {
                    MessageBox.Show("Selected item not found.");
                }

                // Update the DataGridView to reflect changes
                UpdateOrderGrid();

                // Check if there are any items left in orderItems
                if (orderItems.Count == 0)
                {
                    MessageBox.Show("No items left.");
                }
                else
                {
                    // Optionally, you can select a new row after removal, if needed
                    if (orderDataGridView.Rows.Count > 0)
                    {
                        orderDataGridView.Rows[0].Selected = true; // Select the first row as an example
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void inventoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in a valid row (not a header)
            if (e.RowIndex < 0) // This means a header cell was clicked
            {
                return; // Exit early; do nothing
            }

            int rowIndex = e.RowIndex;

            // Populate text boxes with product information from the selected row
            txtProductId.Text = inventoryGridView.Rows[rowIndex].Cells["productID"].Value.ToString();
            txtProductName.Text = inventoryGridView.Rows[rowIndex].Cells["productName"].Value.ToString();
            txtAvailableQuantity.Text = inventoryGridView.Rows[rowIndex].Cells["quantity"].Value.ToString();
            txtPrice.Text = inventoryGridView.Rows[rowIndex].Cells["sellingPrice"].Value.ToString();

            // Accessing the DataRowView and creating a Product object
            var dataRowView = (DataRowView)inventoryGridView.Rows[rowIndex].DataBoundItem;

            // Assuming your Product class has a constructor that takes parameters for its properties
            var selectedProduct = new Product
            {
                ProductID = (int)dataRowView["productID"],
                ProductName = (string)dataRowView["productName"],
                Quantity = (int)dataRowView["quantity"],
                SellingPrice = (decimal)dataRowView["sellingPrice"]
            };

            btnAddToCart.Tag = selectedProduct; // Store the entire Product object in button's Tag property
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (btnAddToCart.Tag is Product product) // Retrieve Product object from Tag
            {
                int quantityToAdd;

                // Check if quantity input is valid
                if (string.IsNullOrWhiteSpace(txtQuantity.Text))
                {
                    MessageBox.Show("Please enter a quantity.");
                    return;
                }

                // Try to parse the quantity input
                if (int.TryParse(txtQuantity.Text, out quantityToAdd) && quantityToAdd > 0)
                {
                    // Check if requested quantity exceeds available quantity
                    if (quantityToAdd > product.Quantity)
                    {
                        MessageBox.Show($"Cannot add {quantityToAdd} items. Only {product.Quantity} available.");
                        return; // Exit the method if requested quantity exceeds available stock
                    }

                    // Check if product already exists in orderItems
                    var existingOrderItem = orderItems.FirstOrDefault(o => o.ProductID == product.ProductID);
                    if (existingOrderItem != null)
                    {
                        // If it exists, update the quantity to the new requested quantity
                        existingOrderItem.Quantity = quantityToAdd; // Update to new requested quantity
                        MessageBox.Show("Product quantity updated in cart.");
                    }
                    else
                    {
                        // If it doesn't exist, add a new item to the cart
                        orderItems.Add(new OrderItem
                        {
                            ProductID = product.ProductID,
                            ProductName = product.ProductName,
                            Quantity = quantityToAdd,
                            SellingPrice = product.SellingPrice,
                        });
                        MessageBox.Show("Product added to cart.");

                    }

                    UpdateOrderGrid(); // Refresh the order grid display
             
                }
                else
                {
                    MessageBox.Show("Please enter a valid positive integer for quantity.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product from inventory.");
            }
        }

        private void UpdateOrderGrid()
        {
            // Convert orderItems to a format suitable for DataGridView
            var orderData = orderItems.Select(o => new
            {
                o.ProductID,
                o.ProductName,
                o.Quantity,
                TotalPrice = o.TotalPrice // Use calculated property
            }).ToList();

            // Bind updated data to DataGridView
            orderDataGridView.DataSource = orderData;

            // Optionally update total price calculation if needed
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            // Calculate the subtotal from order items
            decimal subtotal = orderItems.Sum(o => o.TotalPrice); // Original total price without discount
            decimal totalPrice = subtotal; // Start with the subtotal for calculating total price
            decimal change = 0;
            

            // Get the amount received from the TextBox
            string amountText = txtAmountReceived.Text;

            // Try to parse the amount received
            if (!decimal.TryParse(amountText, out decimal amountReceived))
            {
                // If parsing fails, show an error message and return early
                txtChange.Text = "Input Amount"; // You can set this to an appropriate message or clear it
                return;
            }

            // Check if a discount is selected in the ComboBox
            if (cmbDiscount.SelectedItem != null)
            {
                // Get the selected discount value as a string
                string selectedDiscount = cmbDiscount.SelectedItem.ToString();

                // Debug output for selected discount
                Console.WriteLine($"Selected Discount: '{selectedDiscount}'");

                // Remove the '%' sign for parsing
                if (selectedDiscount.EndsWith("%"))
                {
                    selectedDiscount = selectedDiscount.TrimEnd('%');
                }

                // Try to parse the discount value as a decimal
                if (decimal.TryParse(selectedDiscount, out decimal discount))
                {
                    // Apply the discount to the total price
                    totalPrice -= subtotal * (discount / 100); // Apply discount to subtotal
                }
            }

            // Calculate change after determining total price and amount received
            change = amountReceived - totalPrice; // Calculate change based on final total price

            // Display the subtotal formatted as currency
            txtSubTotal.Text = subtotal.ToString("C"); // Assuming you have a TextBox for subtotal

            // Display the total price formatted as currency
            txtTotalPrice.Text = totalPrice.ToString("C");

            // Display the change formatted as currency
            txtChange.Text = change.ToString("C");
        }

        private void txtAmountReceived_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            // Prompt for confirmation
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to checkout?",
                                                          "Confirm Checkout",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

            // If the user clicks "No", exit the method
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            decimal totalPrice;
            string userId = SessionManager.CurrentSession.UserId.ToString();

            // Parse the total price from the text box
            string totalPriceText = txtSubTotal.Text.Replace("₱", "").Replace(",", "").Trim(); // Remove currency symbol and commas
            if (!decimal.TryParse(totalPriceText, NumberStyles.Any, CultureInfo.InvariantCulture, out totalPrice))
            {
                MessageBox.Show("Invalid total price.");
                return;
            }

            // Clean and parse the amount received
            string amountReceivedText = txtAmountReceived.Text.Replace(",", "").Trim(); // Remove commas
            decimal amountReceived;

            // Parse the amount received and validate it
            if (!decimal.TryParse(amountReceivedText, NumberStyles.Any, CultureInfo.InvariantCulture, out amountReceived) || amountReceived < totalPrice)
            {
                MessageBox.Show("Amount received must be equal to or greater than total price.");
                return;
            }

            string subTotalText = txtSubTotal.Text.Replace(",", "").Trim(); // Remove commas
            decimal subTotal;

            decimal.TryParse(subTotalText, NumberStyles.Any, CultureInfo.InvariantCulture, out subTotal);


            decimal change = amountReceived - totalPrice;


            // Get selected discount value
            string selectedDiscount = cmbDiscount.SelectedItem?.ToString() ?? "0%"; // Default to "0%" if nothing is selected

            int orderId = SaveTransaction(orderItems, totalPrice, amountReceived, subTotal, selectedDiscount, change);
            string orderID = orderId.ToString();

            if (orderId != -1) // Check if saving was successful
            {


                // Display the change in the designated text box
                txtChange.Text = change.ToString("C"); // Format as currency

                // Optionally show an invoice or receipt modal
                ShowInvoice(orderItems, totalPrice, amountReceived, orderID, userId, selectedDiscount);

                // Inform user of successful transaction
                //MessageBox.Show($"Transaction completed. Your Order ID is {orderId}.");

                BindData();
                newOrder_Click(this, EventArgs.Empty);
            }
        }

        private int SaveTransaction(List<OrderItem> orderItems, decimal totalPrice, decimal amountReceived, decimal subTotal, string selectedDiscount, decimal change)
        {
            int orderId = 0; // Initialize orderId variable
            int userId = SessionManager.CurrentSession.UserId; // Get UserID from session

            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();

                    // Insert order into Orders table and get OrderID
                    string insertOrderQuery = "INSERT INTO Orders (UserID, subTotal, discount, totalPrice, amountReceived, changeAmount, OrderDate) " +
                        "VALUES (@UserID, @subTotal, @discount, @totalPrice, @amountReceived, @changeAmount, NOW()); SELECT LAST_INSERT_ID();";

                    using (MySqlCommand command = new MySqlCommand(insertOrderQuery, mysqlConnection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@subTotal", subTotal);
                        command.Parameters.AddWithValue("@discount", selectedDiscount);
                        command.Parameters.AddWithValue("@totalPrice", totalPrice);
                        command.Parameters.AddWithValue("@amountReceived", amountReceived);
                        command.Parameters.AddWithValue("@changeAmount", change);
                        orderId = Convert.ToInt32(command.ExecuteScalar()); // Get the generated Order ID
                    }

                    // Insert each order item into OrderItems table
                    foreach (var item in orderItems)
                    {
                        decimal unitCost = GetUnitCost(item.ProductID); // Retrieve Unit Cost here

                        string insertItemQuery = "INSERT INTO OrderItems (OrderID, ProductID, Quantity, SellingPrice, UnitCost, SoldDate) VALUES (@OrderID, @ProductID, @Quantity, @SellingPrice, @UnitCost, NOW())";
                        using (MySqlCommand command = new MySqlCommand(insertItemQuery, mysqlConnection))
                        {
                            command.Parameters.AddWithValue("@OrderID", orderId); // Use the generated Order ID
                            command.Parameters.AddWithValue("@ProductID", item.ProductID);
                            command.Parameters.AddWithValue("@Quantity", item.Quantity);
                            command.Parameters.AddWithValue("@SellingPrice", item.SellingPrice);
                            command.Parameters.AddWithValue("@UnitCost", unitCost); // Use retrieved Unit Cost
                            command.ExecuteNonQuery();
                        }

                        // Deduct quantity from inventory
                        DeductFromInventory(item.ProductID, item.Quantity);
                    }
                }

                return orderId; // Return the generated Order ID
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving transaction: {ex.Message}");
                return -1; // Return an invalid ID to indicate failure
            }
        }

        private void DeductFromInventory(int productId, int quantity)
        {
            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();

                    string updateInventoryQuery = "UPDATE inventory SET quantity = quantity - @quantity WHERE productID = @productID AND quantity >= @quantity";

                    using (MySqlCommand command = new MySqlCommand(updateInventoryQuery, mysqlConnection))
                    {
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@productID", productId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Insufficient stock for product ID: " + productId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating inventory: {ex.Message}");
            }
        }

        private decimal GetUnitCost(int productId)
        {
            decimal unitCost = 0;

            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();

                    string selectUnitCostQuery = "SELECT UnitCost FROM inventory WHERE productID = @productID";

                    using (MySqlCommand command = new MySqlCommand(selectUnitCostQuery, mysqlConnection))
                    {
                        command.Parameters.AddWithValue("@productID", productId);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            unitCost = Convert.ToDecimal(result);
                        }
                        else
                        {
                            MessageBox.Show($"No unit cost found for Product ID: {productId}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving unit cost: {ex.Message}");
            }

            return unitCost;
        }
        private void ShowInvoice(List<OrderItem> orderItems, decimal totalPrice, decimal amountReceived, string orderID, string userId, string selectedDiscount)
        {
            // Create a PrintDocument for the receipt
            PrintDocument printDocument = new PrintDocument();

            // Set up the PrintPage event to define what gets printed
            printDocument.PrintPage += (senderPrint, ePrint) =>
            {
                float yPos = ePrint.MarginBounds.Top;

                ePrint.Graphics.DrawString("Invex Receipt", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, ePrint.MarginBounds.Left, yPos);
                yPos += 30;

                ePrint.Graphics.DrawString($"Order ID: {orderID}", new Font("Arial", 10), Brushes.Black, ePrint.MarginBounds.Left, yPos);
                yPos += 20;

                ePrint.Graphics.DrawString($"User ID: {userId}", new Font("Arial", 10), Brushes.Black, ePrint.MarginBounds.Left, yPos);
                yPos += 20;

                ePrint.Graphics.DrawString($"Order Date: {DateTime.Now.ToShortDateString()}", new Font("Arial", 10), Brushes.Black, ePrint.MarginBounds.Left, yPos);
                yPos += 20;
        

                // Draw a horizontal line after the order date
                ePrint.Graphics.DrawLine(Pens.Black, ePrint.MarginBounds.Left, yPos, ePrint.MarginBounds.Right, yPos);
                // Add some space after the line
                yPos += 20;

                foreach (var orderItem in orderItems)
                {
                    ePrint.Graphics.DrawString($"{orderItem.ProductName} - Qty: {orderItem.Quantity} - Total: {orderItem.TotalPrice:C}",
                        new Font("Arial", 10), Brushes.Black, ePrint.MarginBounds.Left, yPos);
                    yPos += 20;
                }

                // Draw a horizontal line after the order items
                ePrint.Graphics.DrawLine(Pens.Black, ePrint.MarginBounds.Left, yPos, ePrint.MarginBounds.Right, yPos);
                yPos += 20; // Add some space after the line

                // Calculate change
                decimal change = amountReceived - totalPrice;

                // Print footer information
                ePrint.Graphics.DrawString($"Total Price: {totalPrice:C}", new Font("Arial", 10), Brushes.Black, ePrint.MarginBounds.Left, yPos);
                yPos += 20;

                if (!string.IsNullOrEmpty(selectedDiscount))
                {
                    ePrint.Graphics.DrawString($"Discount: {selectedDiscount}", new Font("Arial", 10), Brushes.Black, ePrint.MarginBounds.Left, yPos);
                    yPos += 20;
                }

                ePrint.Graphics.DrawString($"Amount Received: {amountReceived:C}", new Font("Arial", 10), Brushes.Black, ePrint.MarginBounds.Left, yPos);
                yPos += 20;

                ePrint.Graphics.DrawString($"Change: {change:C}", new Font("Arial", 10), Brushes.Black, ePrint.MarginBounds.Left, yPos);
            };

            // Create and configure the PrintPreviewDialog
            using (PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog())
            {
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();

            }
        }

        private void newOrder_Click(object sender, EventArgs e)
        {
            BindData();
            orderItems.Clear();
            txtSubTotal.Clear();
            txtTotalPrice.Clear();
            txtChange.Clear();
            txtQuantity.Clear();
            txtProductId.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            inventoryGridView.ClearSelection();
            btnAddToCart.Tag = "";
            txtAvailableQuantity.Clear();
            txtAmountReceived.Clear();
            orderDataGridView.DataSource = null;
            cmbDiscount.SelectedIndex = 0;
            txtAmountReceived.Text = "0";
            MessageBox.Show("Successfully Resetted for New Order");
        }

        private void orderDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure that a valid row is clicked (not the header)
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = orderDataGridView.Rows[e.RowIndex];

                // Retrieve values from the selected row
                int productId = (int)selectedRow.Cells["ProductID"].Value; // Adjust the column name as necessary
                string productName = (string)selectedRow.Cells["ProductName"].Value;
                int quantity = (int)selectedRow.Cells["Quantity"].Value;
                decimal totalPrice = (decimal)selectedRow.Cells["TotalPrice"].Value;
            }
        }

    }
}