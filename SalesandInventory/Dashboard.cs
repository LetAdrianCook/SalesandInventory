
using MySqlX.XDevAPI;
using Sales_Inv;
using SalesandInventory.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesandInventory
{
    public partial class Dashboard : Form
    {
        NavigationControl navigationControl;
        NavigationButtons navigationButtons;
     

        Color btndDefaultColor = Color.FromArgb(30, 31, 34);
        Color btndSelectedColor = Color.FromArgb(49, 51, 56);
        public Dashboard()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButton();
   
            DisplayUserInfo();
        }


        private void DisplayUserInfo()
        {
            if (SessionManager.CurrentSession != null)
            {
                lblFullname.Text = $"{SessionManager.CurrentSession.FirstName} {SessionManager.CurrentSession.LastName}";
                lblUsertype.Text = $"{SessionManager.CurrentSession.UserType}";
            }
            else
            {
                MessageBox.Show("No user session found. Please log in.");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new dashboardContent(), new InventoryRegister(), new CreateUserWindow(), new Supplier_Management(), new Report()};

            navigationControl = new NavigationControl(userControls, dashPanel);
            navigationControl.Display(0);

        }
        private void InitializeNavigationButton()
        {
            List<Button> buttons = new List<Button>()
            { dbBtn, inventoryBtn, createBtn, supplierBtn, reportBtn};

            navigationButtons = new NavigationButtons(buttons, btndDefaultColor, btndSelectedColor);
            navigationButtons.Highlight(dbBtn);
        }

        private void dbBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButtons.Highlight(dbBtn); // Highlight the clicked button
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButtons.Highlight(inventoryBtn); // Highlight the clicked button
        }

        private void createBtn_Click_1(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButtons.Highlight(createBtn); // Highlight the clicked button
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
            navigationButtons.Highlight(supplierBtn); // Highlight the clicked button
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(4);
            navigationButtons.Highlight(reportBtn); // Highlight the clicked button
        }

        private void navbarTitle_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            SessionManager.ClearSession();
            MessageBox.Show("Logged Out");
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application Exited");
            Application.Exit();
        }

        private void dashPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sessionType_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

      
    }
}

