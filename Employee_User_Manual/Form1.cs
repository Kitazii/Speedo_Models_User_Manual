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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVideoTutorials_Click(object sender, EventArgs e)
        {
            // Create an instance of SelectRoleForm
            SelectRoleForm roleForm = new SelectRoleForm();

            // Handle the FormClosed event of the new form
            roleForm.FormClosed += (s, args) => Application.Exit();

            // Hide this form
            this.Hide();

            // Show the form
            roleForm.Show();
        }
    }
}
