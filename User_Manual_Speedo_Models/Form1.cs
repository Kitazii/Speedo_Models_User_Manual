using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Manual_Speedo_Models
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
            // Create an instance of CustomerForm
            CustomerForm customerForm = new CustomerForm();

            // Handle the FormClosed event of the new form
            customerForm.FormClosed += (s, args) => Application.Exit();

            // Hide this form
            this.Hide();

            // Show the form
            customerForm.Show();
        }
    }
}
