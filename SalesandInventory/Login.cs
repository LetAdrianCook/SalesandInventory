using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SalesandInventory
{
    public partial class Login : Form
    {
        // Create an instance of Dbconn
        private readonly Dbconn dbConnection;

        public Login()
        {
            InitializeComponent();
            // Initialize Dbconn with your database credentials
            dbConnection = new Dbconn();
            passInput.KeyPress += new KeyPressEventHandler(passInput_KeyPress);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    string username = userInput.Text.Trim();
                    string password = passInput.Text.Trim();

                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Please enter both Username and Password.");
                        return;
                    }

                    mysqlConnection.Open();

                    // Include status in the SELECT statement
                    MySqlCommand mySqlCommand = new MySqlCommand("SELECT userId, firstName, middleName, lastName, userPass, userSalt, userType, dateCreated, status FROM users WHERE userName = @username", mysqlConnection);
                    mySqlCommand.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve additional fields for session
                            int userId = reader.GetInt32("userId");
                            string firstName = reader.GetString("firstName");
                            string middleName = reader.GetString("middleName");
                            string lastName = reader.GetString("lastName");
                            string storedHashedPassword = reader.GetString("userPass");
                            string storedSaltBase64 = reader.GetString("userSalt");
                            string userType = reader.GetString("userType");
                            DateTime dateCreated = reader.GetDateTime("dateCreated");
                            string status = reader.GetString("status"); // Retrieve status

                            // Check if account is deactivated
                            if (status.Equals("Deactivated", StringComparison.OrdinalIgnoreCase))
                            {
                                MessageBox.Show("Your account is deactivated. Please reach out to admin to activate.");
                                return; // Exit the method without logging in
                            }

                            byte[] salt = Convert.FromBase64String(storedSaltBase64);
                            string hashedInputPassword = PasswordHelper.HashPasswordWithSalt(password, salt);

                            if (hashedInputPassword == storedHashedPassword)
                            {
                                SessionManager.CurrentSession = new UserSession
                                {
                                    UserId = userId,
                                    UserName = username,
                                    FirstName = firstName,
                                    MiddleName = middleName,
                                    LastName = lastName,
                                    UserType = userType,
                                    DateCreated = dateCreated
                                };

                                // Open dashboard and pass session data
                                OpenDashboard(userType);
                            }
                            else
                            {
                                MessageBox.Show("Invalid Login Credentials");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Login Credentials");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void OpenDashboard(string userType)
        {
            switch (userType.ToLower())
            {
                case "admin":
                    Dashboard adminForm = new Dashboard();
                    adminForm.Show();
                    this.Hide();
                    break;
                case "sales":
                    PosDashboard pos = new PosDashboard();
                    pos.Show();
                    this.Hide();
                    break;
                case "inventory":
                    InventoryDashboard inv = new InventoryDashboard();
                    inv.Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Unknown User Type");
                    break;
            }
        }

        private void exitApp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void passInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Call the login button click event
                loginBtn_Click(sender, e);
            }
        }
    }
}