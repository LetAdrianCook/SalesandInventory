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

namespace SalesandInventory.UserControls
{
    public partial class UserProfile : UserControl
    {
        private Dbconn dbConnection;
        public UserProfile()
        {
            InitializeComponent();
            try
            {
                dbConnection = new Dbconn(); // Ensure this is initialized
                DisplayUserInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database connection: " + ex.Message);
            }

        }

        private void DisplayUserInfo()
        {

            if (SessionManager.CurrentSession != null)
            {
                lblUserid.Text = SessionManager.CurrentSession.UserId.ToString();
                lblDatecreated.Text = SessionManager.CurrentSession.DateCreated.ToString("MM/dd/yyyy");
                lblUsertype.Text = SessionManager.CurrentSession.UserType;
                lblUsername.Text = SessionManager.CurrentSession.UserName;
                lblFname.Text = SessionManager.CurrentSession.FirstName;
                lblMname.Text = SessionManager.CurrentSession.MiddleName;
                lblLname.Text = SessionManager.CurrentSession.LastName;
            }
            else
            {
                MessageBox.Show("No user session found. Please log in.");
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            // Get current user's username from session
            string username = SessionManager.CurrentSession.UserName;
            string oldPassword = oldPasswordTextBox.Text;
            string confirmOldPassword = confirmOldPasswordTextBox.Text; // New line for confirming old password
            string newPassword = newPasswordTextBox.Text;
            string confirmNewPassword = confirmNewPasswordTextBox.Text;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(confirmOldPassword) ||
          string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmNewPassword))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (oldPassword != confirmOldPassword)
            {
                MessageBox.Show("Old passwords do not match.");
                return;
            }

            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("New passwords do not match.");
                return;
            }

            // Retrieve stored hashed password and salt from database
            byte[] storedSalt;
            string storedHashedPassword;

            using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
            {
                mysqlConnection.Open();
                MySqlCommand command = new MySqlCommand("SELECT userPass, userSalt FROM users WHERE userName = @userName", mysqlConnection);
                command.Parameters.AddWithValue("@userName", username);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        storedHashedPassword = reader["userPass"].ToString();
                        storedSalt = Convert.FromBase64String(reader["userSalt"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                        return;
                    }
                }
            }

            // Verify old password
            if (!PasswordHelper.VerifyHashedPassword(oldPassword, storedHashedPassword, storedSalt))
            {
                MessageBox.Show("Old password is incorrect.");
                return;
            }

            // Hash the new password
            byte[] newSalt; // New salt for the new password
            string newHashedPassword = PasswordHelper.HashPassword(newPassword, out newSalt);

            // Update the database with the new hashed password and salt
            using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
            {
                mysqlConnection.Open();
                MySqlCommand updateCommand = new MySqlCommand("UPDATE users SET userPass = @userPass, userSalt = @userSalt WHERE userName = @userName", mysqlConnection);
                updateCommand.Parameters.AddWithValue("@userPass", newHashedPassword);
                updateCommand.Parameters.AddWithValue("@userSalt", Convert.ToBase64String(newSalt));
                updateCommand.Parameters.AddWithValue("@userName", username);

                int rowsAffected = updateCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password changed successfully.");
                    // Optionally clear text boxes or navigate away
                    oldPasswordTextBox.Clear();
                    newPasswordTextBox.Clear();
                    confirmNewPasswordTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Error updating password.");
                }
            }
        }

        private void deactivateAccountButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to deactivate your account? " +
                                 "If you want to activate your account again, please reach out to admin.",
                                 "Confirm Deactivation",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning);

            // Check if the user confirmed the deactivation
            if (result == DialogResult.Yes)
            {
                // Get current user's username from session
                string username = SessionManager.CurrentSession.UserName;

                // Update the user's status in the database
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();
                    MySqlCommand deactivateCommand = new MySqlCommand("UPDATE users SET status = 'Deactivated' WHERE userName = @userName", mysqlConnection);
                    deactivateCommand.Parameters.AddWithValue("@userName", username);

                    int rowsAffected = deactivateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Your account has been deactivated successfully.");

                        // Optionally clear session data or perform other cleanup
                        SessionManager.CurrentSession = null; // Clear session data

                        // Hide the PosDashboard form
                        Form posDashboardForm = this.FindForm(); // Assuming this user control is within PosDashboard
                        if (posDashboardForm != null)
                        {
                            posDashboardForm.Hide(); // Hide the PosDashboard form
                        }

                        // Redirect to login form
                        Login loginForm = new Login();
                        loginForm.Show();
                    }

                    else
                    {
                        MessageBox.Show("Error deactivating account. Please try again.");
                    }
                }
            }
        }
    }
}
