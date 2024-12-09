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
    public partial class Supplier_Management : UserControl
    {
        private Dbconn dbConnection;
        private DataTable dtSuppliers;
        public Supplier_Management()
        {
            InitializeComponent();
            try
            {
                dbConnection = new Dbconn(); // Ensure this is initialized
                columnFilterCbx.SelectedIndex = 0;
                BindData(); // Call BindData after dbConnection is initialized
                searchBarTxt.TextChanged += new EventHandler(searchBarTxt_TextChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database connection: " + ex.Message);
            }
        }

        private void searchBarTxt_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridView();
        }

        private void FilterDataGridView()
        {
            string filterColumn = columnFilterCbx.SelectedItem.ToString(); // Get selected column name
            string filterValue = searchBarTxt.Text.Trim(); // Get search text

            if (dtSuppliers != null) // Ensure that dtUsers is not null
            {
                if (!string.IsNullOrEmpty(filterValue))
                {
                    // Check if the selected column is userID
                    if (filterColumn.Equals("supplierID", StringComparison.OrdinalIgnoreCase))
                    {
                        // Try to parse the filterValue as an integer
                        if (int.TryParse(filterValue, out int numericValue))
                        {
                            // Use numeric comparison for userID
                            dtSuppliers.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, numericValue);
                        }
                        else
                        {
                            // If input is invalid for userID, clear the filter and show a message
                            dtSuppliers.DefaultView.RowFilter = string.Empty; // Clear filter
                            MessageBox.Show("Please enter a valid numeric value for supplierID.");
                            searchBarTxt.Clear();
                        }
                    }
                  
                    else
                    {
                        // For other columns, use LIKE for string comparison
                        dtSuppliers.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterColumn, filterValue);
                    }
                }
                else
                {
                    dtSuppliers.DefaultView.RowFilter = string.Empty; // Clear filter if no text is entered
                }

                supplierGridView.DataSource = dtSuppliers.DefaultView; // Update DataGridView source
            }
        }

        private void BindData()
        {
            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open(); // Ensure the connection is opened
                    MySqlCommand view = new MySqlCommand("SELECT supplierID, supplierName, contactNo, email, dateCreated, dateUpdated FROM supplier", mysqlConnection);
                    MySqlDataAdapter supplierTable = new MySqlDataAdapter(view);
                    dtSuppliers = new DataTable(); // Initialize the class-level DataTable
                    supplierTable.Fill(dtSuppliers); // Fill the DataTable with data
                    supplierGridView.DataSource = dtSuppliers; // Bind DataTable to DataGridView

                    // Set column headers
                    supplierGridView.Columns["supplierID"].HeaderText = "ID";
                    supplierGridView.Columns["supplierName"].HeaderText = "Supplier Name";
                    supplierGridView.Columns["contactNo"].HeaderText = "Contact Number";
                    supplierGridView.Columns["email"].HeaderText = "Email";
                    supplierGridView.Columns["dateCreated"].HeaderText = "Date Created";
                    supplierGridView.Columns["dateUpdated"].HeaderText = "Date Updated";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data from Supplier Table: " + ex.Message);
            }
        }


        private void createSupplier_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(creSupplierName.Text))
            {
                MessageBox.Show("Supplier Name cannot be empty.");
                creSupplierName.Focus();
                return; // Exit the method
            }

            if (string.IsNullOrWhiteSpace(creEmail.Text))
            {
                MessageBox.Show("Email cannot be empty.");
                creEmail.Focus();
                return; // Exit the method
            }

            if (creContact.Text.Length != 11)
            {
                MessageBox.Show("Contact Number must be exactly 11 characters long.");
                creContact.Focus();
                return; // Exit the method
            }

            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();
                    MySqlCommand createSupplier = new MySqlCommand("INSERT INTO supplier (supplierName, contactNo, email, dateCreated) " +
                        "VALUES (@supplierName, @contactNo, @email, @dateCreated)", mysqlConnection);

                    createSupplier.Parameters.AddWithValue("@supplierName", creSupplierName.Text);
                    createSupplier.Parameters.AddWithValue("@contactNo", creContact.Text);
                    createSupplier.Parameters.AddWithValue("@email", creEmail.Text);
                    createSupplier.Parameters.AddWithValue("@dateCreated", DateTime.Now);

                    createSupplier.ExecuteNonQuery();

                    MessageBox.Show("Supplier Successfully Created");
                    creSupplierName.Clear();
                    creContact.Clear();
                    creEmail.Clear();

                    BindData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating user: " + ex.Message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (updateBtn.Tag != null)
            {
                int supplierID = (int)updateBtn.Tag;

                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();
                    MySqlCommand updateCommand = new MySqlCommand("UPDATE supplier SET supplierName = @supplierName, contactNo = @contactNo, email = @email, dateUpdated = @dateUpdated WHERE supplierID = @supplierID", mysqlConnection);
                    updateCommand.Parameters.AddWithValue("@supplierName", updateSupplierName.Text);
                    updateCommand.Parameters.AddWithValue("@contactNo", updateContact.Text);
                    updateCommand.Parameters.AddWithValue("@email", updateEmail.Text);
                    updateCommand.Parameters.AddWithValue("@dateUpdated", DateTime.Now);
                    updateCommand.Parameters.AddWithValue("@supplierID", supplierID);

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User updated successfully!");
                        updateSupplierName.Clear();
                        updateContact.Clear();
                        updateEmail.Clear();
                        BindData();
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Please try again.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to update.");
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {

        }

        private void Supplier_Management_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void supplierGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) // This means a header cell was clicked
            {
                return; // Exit early; do nothing
            }
            // Get the index of the selected row
            int rowIndex = e.RowIndex;

            updateSupplierName.Text = supplierGridView.Rows[rowIndex].Cells["supplierName"].Value.ToString();
            updateContact.Text = supplierGridView.Rows[rowIndex].Cells["contactNo"].Value.ToString();
            updateEmail.Text = supplierGridView.Rows[rowIndex].Cells["email"].Value.ToString();
           
            int supplierID = Convert.ToInt32(supplierGridView.Rows[rowIndex].Cells["supplierID"].Value);
            updateBtn.Tag = supplierID; // Store userID in button's Tag property for easy access
        }

     
    }
}

