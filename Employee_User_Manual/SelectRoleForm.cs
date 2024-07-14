using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_User_Manual
{
    /// <summary>
    /// Author: Kieran Burns
    /// Date Finalized: 06/06/2024
    /// </summary>
    public partial class SelectRoleForm : Form
    {
        public SelectRoleForm()
        {
            InitializeComponent();
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create an instance of the main menu form
            Form1 menu = new Form1();

            // Handle the FormClosed event of the new form
            menu.FormClosed += (s, args) => Application.Exit();

            // Hide this form
            this.Hide();

            // Show the form
            menu.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string[] linkLabels =
            {
                "Login","Manage Account", "About", "Contact", "Products", "Home", "Categories", "Advanced Dashboard",
                "Reports","Register Employee", "Manage Employee",
                "Manage Customers", "Record Products", "Manage Products", "Create Invoice",
                "Manage Invoices", "Dispatch Goods", "Manage Dispatches", "Create Order",
                "Manage Orders", "Log Off"
            };

            string role = "Admin";

            // Create an instance of the employee form, passing the linklabels and role to the front end
            EmployeeForm employeeForm = new EmployeeForm(linkLabels, role);

            // Handle the FormClosed event of the new form
            employeeForm.FormClosed += (s, args) => Application.Exit();

            // Hide this form
            this.Hide();

            // Show the form
            employeeForm.Show();
        }

        private void btnSalesManager_Click(object sender, EventArgs e)
        {
            string[] linkLabels =
            {
                "Login","Manage Account", "About", "Contact", "Products", "Home", "Categories",
                "Advanced Dashboard", "Reports",
                "Manage Customers", "Record Products", "Manage Products", "Create Order",
                "Manage Orders", "Log Off"
            };

            string role = "Sales Manager";

            // Create an instance of the employee form, passing the linklabels and role to the front end
            EmployeeForm employeeForm = new EmployeeForm(linkLabels, role);

            // Handle the FormClosed event of the new form
            employeeForm.FormClosed += (s, args) => Application.Exit();

            // Hide this form
            this.Hide();

            // Show the form
            employeeForm.Show();
        }

        private void btnAssistantManager_Click(object sender, EventArgs e)
        {
            string[] linkLabels =
            {
                "Login", "Manage Account", "About", "Contact", "Products", "Home", "Categories", "Dashboard",
                "Manage Customers", "Record Products", "Manage Products",
                "Manage Orders", "Log Off"
            };

            string role = "Assistant Manager";

            // Create an instance of the employee form, passing the linklabels and role to the front end
            EmployeeForm employeeForm = new EmployeeForm(linkLabels, role);

            // Handle the FormClosed event of the new form
            employeeForm.FormClosed += (s, args) => Application.Exit();

            // Hide this form
            this.Hide();

            // Show the form
            employeeForm.Show();
        }

        private void btnStockControlManager_Click(object sender, EventArgs e)
        {
            string[] linkLabels =
            {
                "Login", "Manage Account", "About", "Contact", "Products", "Home", "Categories", "Dashboard",
                "Manage Customers", "Record Products", "Manage Products",
                "Manage Orders", "Log Off"
            };

            string role = "Stock Control Manager";

            // Create an instance of the employee form, passing the linklabels and role to the front end
            EmployeeForm employeeForm = new EmployeeForm(linkLabels, role);

            // Handle the FormClosed event of the new form
            employeeForm.FormClosed += (s, args) => Application.Exit();

            // Hide this form
            this.Hide();

            // Show the form
            employeeForm.Show();
        }

        private void btnSalesAssistant_Click(object sender, EventArgs e)
        {
            string[] linkLabels =
            {
                "Login", "Manage Account", "About", "Contact", "Products", "Home", "Categories", "Dashboard",
                "Manage Customers", "Record Products", "Manage Products",
                "Create Order","Manage Orders", "Log Off"
            };

            string role = "Sales Assistant Manager";

            // Create an instance of the employee form, passing the linklabels and role to the front end
            EmployeeForm employeeForm = new EmployeeForm(linkLabels, role);

            // Handle the FormClosed event of the new form
            employeeForm.FormClosed += (s, args) => Application.Exit();

            // Hide this form
            this.Hide();

            // Show the form
            employeeForm.Show();
        }

        private void btnWarehouseAssistant_Click(object sender, EventArgs e)
        {
            string[] linkLabels =
            {
                "Login","Manage Account", "About", "Contact", "Products", "Home", "Categories", "Dashboard",
                "Manage Customers", "Record Products", "Manage Products",
                "Dispatch Goods", "Manage Dispatches",
                "Manage Orders", "Log Off"
            };

            string role = "Warehouse Assistant";

            // Create an instance of the employee form, passing the linklabels and role to the front end
            EmployeeForm employeeForm = new EmployeeForm(linkLabels, role);

            // Handle the FormClosed event of the new form
            employeeForm.FormClosed += (s, args) => Application.Exit();

            // Hide this form
            this.Hide();

            // Show the form
            employeeForm.Show();
        }

        private void btnInvoiceClerk_Click(object sender, EventArgs e)
        {
            string[] linkLabels =
            {
                "Login","Manage Account", "About", "Contact", "Products", "Home", "Categories", "Dashboard",
                "Manage Customers", "Record Products", "Manage Products", 
                "Create Invoice","Manage Invoices",
                "Manage Orders", "Log Off"
            };

            string role = "Invoice Clerk";

            // Create an instance of the employee form, passing the linklabels and role to the front end
            EmployeeForm employeeForm = new EmployeeForm(linkLabels, role);

            // Handle the FormClosed event of the new form
            employeeForm.FormClosed += (s, args) => Application.Exit();

            // Hide this form
            this.Hide();

            // Show the form
            employeeForm.Show();
        }
    }
}
