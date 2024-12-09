using MySql.Data.MySqlClient;
using SalesandInventory;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Sales_Inv
{
    public partial class InventoryRegister : UserControl
    {
        private Dbconn dbConnection;
        private DataTable dtinventory;
        private int selectedSupplierID; // Class-level variable to store selected supplier ID
        private string selectedSupplierName;

        public InventoryRegister()
        {
            InitializeComponent();
            try
            {
                dbConnection = new Dbconn(); // Ensure this initializes correctly
                LoadSuppliers();
                BindData();
                productTypeCbx.SelectedIndex = 0;

                columnFilterCbx.SelectedIndex = 0;
                supplierCbx.SelectedIndexChanged += new EventHandler(supplierCbx_SelectedIndexChanged);
                searchBarTxt.TextChanged += new EventHandler(searchBarTxt_TextChanged);
                this.quantityTxt.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
                this.maxQuantityTxt.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
                this.unitCostTxt.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
                this.sellingPriceTxt.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database connection: " + ex.Message);
            }
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


        private void searchBarTxt_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridView();
        }

        private void FilterDataGridView()
        {
            string filterColumn = columnFilterCbx.SelectedItem.ToString(); // Get selected column name
            string filterValue = searchBarTxt.Text.Trim(); // Get search text

            if (dtinventory != null) // Ensure that dtUsers is not null
            {
                if (!string.IsNullOrEmpty(filterValue))
                {
                    // Check if the selected column is userID
                    if (filterColumn.Equals("productID", StringComparison.OrdinalIgnoreCase))
                    {
                        // Try to parse the filterValue as an integer
                        if (int.TryParse(filterValue, out int numericValue))
                        {
                            // Use numeric comparison for userID
                            dtinventory.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, numericValue);
                        }
                        else
                        {
                            // If input is invalid for userID, clear the filter and show a message
                            dtinventory.DefaultView.RowFilter = string.Empty; // Clear filter
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



        private DataTable GetSuppliers()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT supplierID, supplierName FROM supplier"; // Adjust the query as necessary

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt); // Fill the DataTable with data from the database
                    }
                }
            }

            return dt; // Return the populated DataTable
        }

        private void LoadSuppliers()
        {
            DataTable dtSuppliers = GetSuppliers(); // Fetch suppliers from your database

            // Clear existing items
            supplierCbx.Items.Clear();

            foreach (DataRow row in dtSuppliers.Rows)
            {
                var item = new
                {
                    ID = row["supplierID"],
                    Name = row["supplierName"].ToString()
                };

                supplierCbx.Items.Add(item);
            }

            // Set display member for ComboBox
            supplierCbx.DisplayMember = "Name";
        }

        private void supplierCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (supplierCbx.SelectedItem != null)
            {
                dynamic selectedSupplier = supplierCbx.SelectedItem;
                selectedSupplierID = selectedSupplier.ID; // Store selected Supplier ID
                selectedSupplierName = selectedSupplier.Name; // Store selected Supplier Name

                // MessageBox.Show($"Selected Supplier ID: {selectedSupplierID}, Name: {selectedSupplierName}");
            }
        }

        private void BindData()
        {
            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open(); // Ensure the connection is opened
                    MySqlCommand view = new MySqlCommand("SELECT productID, supplierID, productName, productType, brand, model, quantity, maxQuantity, unitCost, sellingPrice, supplierName, status, dateCreated, dateUpdated FROM inventory", mysqlConnection);
                    MySqlDataAdapter invTable = new MySqlDataAdapter(view);
                    dtinventory = new DataTable(); // Initialize the class-level DataTable
                    invTable.Fill(dtinventory); // Fill the DataTable with data
                    inventoryGridView.DataSource = dtinventory; // Bind DataTable to DataGridView

                    // Set column headers
                    inventoryGridView.Columns["productID"].HeaderText = "Product ID";
                    inventoryGridView.Columns["supplierID"].HeaderText = "Supplier ID";
                    inventoryGridView.Columns["productName"].HeaderText = "Product Name";
                    inventoryGridView.Columns["productType"].HeaderText = "Product Type";
                    inventoryGridView.Columns["brand"].HeaderText = "Brand";
                    inventoryGridView.Columns["model"].HeaderText = "Model";
                    inventoryGridView.Columns["quantity"].HeaderText = "Quantity";
                    inventoryGridView.Columns["maxQuantity"].HeaderText = "Max Quantity";
                    inventoryGridView.Columns["unitCost"].HeaderText = "Unit Cost";
                    inventoryGridView.Columns["sellingPrice"].HeaderText = "Selling Price";
                    inventoryGridView.Columns["supplierName"].HeaderText = "Supplier Name";
                    inventoryGridView.Columns["status"].HeaderText = "Status";
                    inventoryGridView.Columns["dateCreated"].HeaderText = "Date Created";
                    inventoryGridView.Columns["dateUpdated"].HeaderText = "Date Updated";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data from Inventory Table: " + ex.Message);
            }
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            // Check for empty fields
            if (string.IsNullOrWhiteSpace(productNameTxt.Text) || string.IsNullOrWhiteSpace(productTypeCbx.Text) || string.IsNullOrWhiteSpace(brandTxt.Text) ||
                string.IsNullOrWhiteSpace(modelTxt.Text) || string.IsNullOrWhiteSpace(quantityTxt.Text) || string.IsNullOrWhiteSpace(maxQuantityTxt.Text) || string.IsNullOrWhiteSpace(unitCostTxt.Text) ||
                string.IsNullOrWhiteSpace(sellingPriceTxt.Text) || string.IsNullOrWhiteSpace(supplierCbx.Text))
            {
                MessageBox.Show("Fields cannot be empty.");
                return; // Exit the method
            }

            int quantity = Convert.ToInt32(quantityTxt.Text);
            int maxQuantity = Convert.ToInt32(maxQuantityTxt.Text);

            if (quantity > maxQuantity)
            {
                MessageBox.Show("Quantity cannot exceed maximum quantity.");
                return;
            }


            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();

                    // Check if the product name already exists
                    MySqlCommand checkProductExists = new MySqlCommand("SELECT COUNT(*) FROM inventory WHERE productName = @productName", mysqlConnection);
                    checkProductExists.Parameters.AddWithValue("@productName", productNameTxt.Text);

                    int productCount = Convert.ToInt32(checkProductExists.ExecuteScalar());

                    if (productCount > 0)
                    {
                        MessageBox.Show("A product with this name already exists. Please choose a different name.");
                        return; // Exit the method if the product already exists
                    }

                    // Proceed to add the product since it does not exist
                    MySqlCommand addProduct = new MySqlCommand("INSERT INTO inventory (supplierID, productName, productType, brand, model, quantity, maxQuantity, unitCost, sellingPrice, supplierName, status, dateCreated) " +
                        "VALUES (@supplierID, @productName, @productType, @brand, @model, @quantity, @maxQuantity, @unitCost, @sellingPrice, @supplierName, @status, @dateCreated)", mysqlConnection);

                    addProduct.Parameters.AddWithValue("@supplierID", selectedSupplierID); // Use stored Supplier ID
                    addProduct.Parameters.AddWithValue("@productName", productNameTxt.Text); // Product name
                    addProduct.Parameters.AddWithValue("@productType", productTypeCbx.SelectedItem); // Product type
                    addProduct.Parameters.AddWithValue("@brand", brandTxt.Text); // Brand
                    addProduct.Parameters.AddWithValue("@model", modelTxt.Text); // Model
                    addProduct.Parameters.AddWithValue("@quantity", Convert.ToInt32(quantityTxt.Text)); // Quantity
                    addProduct.Parameters.AddWithValue("@maxQuantity", Convert.ToInt32(maxQuantityTxt.Text)); // Quantity
                    addProduct.Parameters.AddWithValue("@unitCost", Convert.ToDecimal(unitCostTxt.Text)); // Unit cost
                    addProduct.Parameters.AddWithValue("@sellingPrice", Convert.ToDecimal(sellingPriceTxt.Text)); // Selling price
                    addProduct.Parameters.AddWithValue("@supplierName", selectedSupplierName); // Supplier name
                    addProduct.Parameters.AddWithValue("@status", "Functional"); // Status
                    addProduct.Parameters.AddWithValue("@dateCreated", DateTime.Now); // Date created

                    addProduct.ExecuteNonQuery();

                    MessageBox.Show("Product Successfully Added");

                    // Clear input fields after successful addition
                    ClearInputFields();

                    // Refresh data grid or clear input fields as needed
                    BindData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating product: " + ex.Message);
            }
        }

        // Method to clear input fields
        private void ClearInputFields()
        {
            productIDtxt.Clear();
            productNameTxt.Clear();
            productTypeCbx.SelectedIndex = 0;
            brandTxt.Clear();
            modelTxt.Clear();
            quantityTxt.Clear();
            unitCostTxt.Clear();
            sellingPriceTxt.Clear();
            supplierCbx.SelectedIndex = 0;
            maxQuantityTxt.Clear();
        }

        private void InventoryRegister_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void inventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inventoryGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) // This means a header cell was clicked
            {
                return; // Exit early; do nothing
            }
            // Get the index of the selected row
            int rowIndex = e.RowIndex;

            productIDtxt.Text = inventoryGridView.Rows[rowIndex].Cells["productID"].Value.ToString();
            productNameTxt.Text = inventoryGridView.Rows[rowIndex].Cells["productName"].Value.ToString();
            productTypeCbx.SelectedItem = inventoryGridView.Rows[rowIndex].Cells["productType"].Value.ToString();
            brandTxt.Text = inventoryGridView.Rows[rowIndex].Cells["brand"].Value.ToString();
            modelTxt.Text = inventoryGridView.Rows[rowIndex].Cells["model"].Value.ToString();
            quantityTxt.Text = inventoryGridView.Rows[rowIndex].Cells["quantity"].Value.ToString();
            maxQuantityTxt.Text = inventoryGridView.Rows[rowIndex].Cells["maxQuantity"].Value.ToString();
            unitCostTxt.Text = inventoryGridView.Rows[rowIndex].Cells["unitCost"].Value.ToString();
            sellingPriceTxt.Text = inventoryGridView.Rows[rowIndex].Cells["sellingPrice"].Value.ToString();
            supplierCbx.Text = inventoryGridView.Rows[rowIndex].Cells["supplierName"].Value.ToString();

            int productID = Convert.ToInt32(inventoryGridView.Rows[rowIndex].Cells["productID"].Value);
            updateBtn.Tag = productID; // Store userID in button's Tag property for easy access
        }

        private void inventoryGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            productIDtxt.Clear();
            productNameTxt.Clear();
            productTypeCbx.SelectedIndex = 0;
            brandTxt.Clear();
            modelTxt.Clear();
            quantityTxt.Clear();
            unitCostTxt.Clear();
            sellingPriceTxt.Clear();
            supplierCbx.SelectedIndex = 0;
            maxQuantityTxt.Clear();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productNameTxt.Text) || string.IsNullOrWhiteSpace(productTypeCbx.Text) || string.IsNullOrWhiteSpace(brandTxt.Text) ||
               string.IsNullOrWhiteSpace(modelTxt.Text) || string.IsNullOrWhiteSpace(quantityTxt.Text) || string.IsNullOrWhiteSpace(maxQuantityTxt.Text) || string.IsNullOrWhiteSpace(unitCostTxt.Text) ||
               string.IsNullOrWhiteSpace(sellingPriceTxt.Text) || string.IsNullOrWhiteSpace(supplierCbx.Text))
            {
                MessageBox.Show("Fields cannot be empty.");
                return; // Exit the method
            }

            int quantity = Convert.ToInt32(quantityTxt.Text);
            int maxQuantity = Convert.ToInt32(maxQuantityTxt.Text);

            if (quantity > maxQuantity)
            {
                MessageBox.Show("Quantity cannot exceed maximum quantity.");
                return;
            }

            if (updateBtn.Tag != null)
            {
                int productID = (int)updateBtn.Tag; // Retrieve userID from button's Tag

                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();
                    MySqlCommand updateCommand = new MySqlCommand("UPDATE inventory SET supplierID = @supplierID, productName = @productName, productType = @productType, brand = @brand, model = @model, quantity = @quantity, maxQuantity = @maxQuantity," +
                        "unitCost = @unitCost, sellingPrice = @sellingPrice, supplierName = @supplierName, dateUpdated = @dateUpdated WHERE productID = @productID", mysqlConnection);

                    updateCommand.Parameters.AddWithValue("@supplierID", selectedSupplierID);
                    updateCommand.Parameters.AddWithValue("@productName", productNameTxt.Text);
                    updateCommand.Parameters.AddWithValue("@productType", productTypeCbx.SelectedItem.ToString());
                    updateCommand.Parameters.AddWithValue("@brand", brandTxt.Text);
                    updateCommand.Parameters.AddWithValue("@model", modelTxt.Text);
                    updateCommand.Parameters.AddWithValue("@quantity", quantityTxt.Text);
                    updateCommand.Parameters.AddWithValue("@maxQuantity", maxQuantityTxt.Text);
                    updateCommand.Parameters.AddWithValue("@unitCost", unitCostTxt.Text);
                    updateCommand.Parameters.AddWithValue("@sellingPrice", sellingPriceTxt.Text);
                    updateCommand.Parameters.AddWithValue("@supplierName", selectedSupplierName);
                    updateCommand.Parameters.AddWithValue("@dateUpdated", DateTime.Now);
                    updateCommand.Parameters.AddWithValue("@productID", productID);

                    // Execute the command
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User updated successfully!");
                        ClearInputFields();
                        BindData(); // Refresh DataGridView to show updated data
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Please try again.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to update.");
            }
        }

        private void defectiveBtn_Click(object sender, EventArgs e)
        {

            if (updateBtn.Tag != null)
            {
                int productID = (int)updateBtn.Tag; // Retrieve userID from button's Tag

                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();
                    MySqlCommand updateCommand = new MySqlCommand("UPDATE inventory SET status = @status, dateUpdated = @dateUpdated WHERE productID = @productID", mysqlConnection);

                    updateCommand.Parameters.AddWithValue("@status", "Defective");
                    updateCommand.Parameters.AddWithValue("@dateUpdated", DateTime.Now);
                    updateCommand.Parameters.AddWithValue("@productID", productID);

                    // Execute the command
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product set to Defective!");
                        BindData(); // Refresh DataGridView to show updated data
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Please try again.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to update.");
            }

        }

        private void functionalBtn_Click(object sender, EventArgs e)
        {
            if (updateBtn.Tag != null)
            {
                int productID = (int)updateBtn.Tag; // Retrieve userID from button's Tag

                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();
                    MySqlCommand updateCommand = new MySqlCommand("UPDATE inventory SET status = @status, dateUpdated = @dateUpdated WHERE productID = @productID", mysqlConnection);

                    updateCommand.Parameters.AddWithValue("@status", "Functional");
                    updateCommand.Parameters.AddWithValue("@dateUpdated", DateTime.Now);
                    updateCommand.Parameters.AddWithValue("@productID", productID);

                    // Execute the command
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product set to Functional!");
                        BindData(); // Refresh DataGridView to show updated data
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Please try again.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to update.");
            }
        }
    }
}
