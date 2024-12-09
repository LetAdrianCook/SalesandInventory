using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SalesandInventory.UserControls
{
    public partial class CreateUserWindow : UserControl
    {
        private Dbconn dbConnection;
        private DataTable dtUsers;

        public CreateUserWindow()
        {
            InitializeComponent();
            try
            {
                dbConnection = new Dbconn(); // Ensure this is initialized
                columnFilterCbx.SelectedIndex = 0;
                salesType.Checked = true;
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

            if (dtUsers != null) // Ensure that dtUsers is not null
            {
                if (!string.IsNullOrEmpty(filterValue))
                {
                    // Check if the selected column is userID
                    if (filterColumn.Equals("userID", StringComparison.OrdinalIgnoreCase))
                    {
                        // Try to parse the filterValue as an integer
                        if (int.TryParse(filterValue, out int numericValue))
                        {
                            // Use numeric comparison for userID
                            dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, numericValue);
                        }
                        else
                        {
                            // If input is invalid for userID, clear the filter and show a message
                            dtUsers.DefaultView.RowFilter = string.Empty; // Clear filter
                            MessageBox.Show("Please enter a valid numeric value for userID.");
                            searchBarTxt.Clear();
                        }
                    }
                    

                    else
                    {
                        // For other columns, use LIKE for string comparison
                        dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterColumn, filterValue);
                    }
                }
                else
                {
                    dtUsers.DefaultView.RowFilter = string.Empty; // Clear filter if no text is entered
                }

                userGridView.DataSource = dtUsers.DefaultView; // Update DataGridView source
            }
        }



        private void createUser_Click(object sender, EventArgs e)
        {
            string userType = string.Empty;

            if (salesType.Checked)
            {
                userType = "Sales";
            }
            else if (invType.Checked)
            {
                userType = "Inventory";
            }

            if (string.IsNullOrWhiteSpace(creUsername.Text))
            {
                MessageBox.Show("Username cannot be empty.");

                return; // Exit the method
            }
            if (string.IsNullOrWhiteSpace(crePassword.Text) && (crePassword.Text.Length != 8))
            {
                MessageBox.Show("Password cannot be empty.");

                return; // Exit the method
            }
            if (string.IsNullOrWhiteSpace(creFirstname.Text))
            {
                MessageBox.Show("First Name cannot be empty.");

                return; // Exit the method
            }
            if (string.IsNullOrWhiteSpace(creLastName.Text))
            {
                MessageBox.Show("First Name cannot be empty.");

                return; // Exit the method
            }
            try
            {
                byte[] salt; // Declare a variable to hold the salt
                string hashedPassword = PasswordHelper.HashPassword(crePassword.Text, out salt); // Hash the password

                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();
                    MySqlCommand createUser = new MySqlCommand("INSERT INTO users (userName, userPass, userSalt, userType, firstName, middleName, lastName, status, dateCreated) " +
                "VALUES (@userName, @userPass, @userSalt, @userType, @firstName, @middleName, @lastName, @status , @dateCreated)", mysqlConnection);

                    createUser.Parameters.AddWithValue("@userName", creUsername.Text);
                    createUser.Parameters.AddWithValue("@userPass", hashedPassword); // Store hashed password
                    createUser.Parameters.AddWithValue("@userSalt", Convert.ToBase64String(salt)); // Store salt as Base64 string
                    createUser.Parameters.AddWithValue("@userType", userType);
                    createUser.Parameters.AddWithValue("@firstName", creFirstname.Text);
                    createUser.Parameters.AddWithValue("@middleName", creMiddleName.Text); // Assuming you have this field
                    createUser.Parameters.AddWithValue("@lastName", creLastName.Text);
                    createUser.Parameters.AddWithValue("@status", "Active");
                    createUser.Parameters.AddWithValue("@dateCreated", DateTime.Now); // Set dateCreated to current date and time


                    createUser.ExecuteNonQuery();

                    MessageBox.Show("User Successfully Created");
                    creUsername.Clear();
                    crePassword.Clear();
                    creFirstname.Clear();
                    creMiddleName.Clear();
                    creLastName.Clear();
                    salesType.Checked = false;
                    invType.Checked = false;

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
                int userId = (int)updateBtn.Tag; // Retrieve userID from button's Tag

                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();
                    MySqlCommand updateCommand = new MySqlCommand("UPDATE users SET firstName = @firstName, middleName = @middleName, lastName = @lastName, dateUpdated = @dateUpdated WHERE userID = @userID", mysqlConnection);
                    updateCommand.Parameters.AddWithValue("@firstName", updateFirstNameTxt.Text);
                    updateCommand.Parameters.AddWithValue("@middleName", updateMiddleNameTxt.Text);
                    updateCommand.Parameters.AddWithValue("@lastName", updateLastNameTxt.Text);
                    updateCommand.Parameters.AddWithValue("@dateUpdated", DateTime.Now);
                    updateCommand.Parameters.AddWithValue("@userID", userId); // Use appropriate ID for your table

                    // Execute the command
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User updated successfully!");
                        updateFirstNameTxt.Clear();
                        updateMiddleNameTxt.Clear();
                        updateLastNameTxt.Clear();
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
                MessageBox.Show("Please select a user to update.");
            }
        }

        private void BindData()
        {
            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open(); // Ensure the connection is opened
                    MySqlCommand view = new MySqlCommand("SELECT userID, userName, userType, firstName, middleName, lastName, status, dateCreated, dateUpdated FROM users WHERE userType IN ('Sales', 'Inventory')", mysqlConnection);
                    MySqlDataAdapter userTable = new MySqlDataAdapter(view);
                    dtUsers = new DataTable(); // Initialize the class-level DataTable
                    userTable.Fill(dtUsers); // Fill the DataTable with data
                    userGridView.DataSource = dtUsers; // Bind DataTable to DataGridView

                    // Set column headers
                    userGridView.Columns["userID"].HeaderText = "ID";
                    userGridView.Columns["userName"].HeaderText = "Username";
                    userGridView.Columns["userType"].HeaderText = "User Type";
                    userGridView.Columns["firstName"].HeaderText = "First Name";
                    userGridView.Columns["middleName"].HeaderText = "Middle Name";
                    userGridView.Columns["lastName"].HeaderText = "Last Name";
                    userGridView.Columns["status"].HeaderText = "Status";
                    userGridView.Columns["dateCreated"].HeaderText = "Date Created";
                    userGridView.Columns["dateUpdated"].HeaderText = "Date Updated";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }
        }

        private void CreateUserWindow_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void userGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) // This means a header cell was clicked
            {
                return; // Exit early; do nothing
            }
            // Get the index of the selected row
            int rowIndex = e.RowIndex;

            // Populate TextBoxes with data from the selected row
            updateFirstNameTxt.Text = userGridView.Rows[rowIndex].Cells["firstName"].Value.ToString();
            updateMiddleNameTxt.Text = userGridView.Rows[rowIndex].Cells["middleName"].Value.ToString();
            updateLastNameTxt.Text = userGridView.Rows[rowIndex].Cells["lastName"].Value.ToString();

            // Store the userID for updating later
            // Assuming userID is in a column named "userID"
            int userId = Convert.ToInt32(userGridView.Rows[rowIndex].Cells["userID"].Value);
            updateBtn.Tag = userId; // Store userID in button's Tag property for easy access
        }

        private void activateBtn_Click(object sender, EventArgs e)
        {
            // Get the user ID from the Tag property of the button
            if (updateBtn.Tag != null)
            {
                int userId = (int)updateBtn.Tag; // Retrieve user ID stored in Tag

                // Confirm with the user before proceeding
                var result = MessageBox.Show("Are you sure you want to activate this account?",
                                              "Confirm Activation",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                        {
                            mysqlConnection.Open();

                            // Update the user's status to 'Active'
                            MySqlCommand activateCommand = new MySqlCommand("UPDATE users SET status = 'Active' WHERE userID = @userId", mysqlConnection);
                            activateCommand.Parameters.AddWithValue("@userId", userId);

                            int rowsAffected = activateCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User account activated successfully.");
                                BindData(); // Refresh the DataGridView to reflect changes
                            }
                            else
                            {
                                MessageBox.Show("Error activating account. Please try again.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while activating the account: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No user selected. Please select a user to activate.");
            }
        }
    }
}