using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_User_Manual
{
    /// <summary>
    /// Author: Kieran Burns
    /// Date Finalized: 08/06/2024
    /// </summary>
    public partial class EmployeeForm : Form, IMedia
    {
        private LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;
        private VideoView _videoView;
        public EmployeeForm(string[] linkLabels, string role)
        {
            InitializeComponent();
            //AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            InitializeVLC();
            InitializeLinkLabels(linkLabels, role);

            // Attach the Load event handler
            this.Load += new EventHandler(EmployeeForm_Load);
        }

        //************************ INTERFACE METHODS ********************************
        public void InitializeVLC()
        {
            // Specify the path to the VLC libraries directory
            string vlcLibDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libvlc");

            // Initialize the Core with the specified VLC library directory
            Core.Initialize(vlcLibDirectory);

            // Create a new instance of LibVLC with options
            _libVLC = new LibVLC("--no-xlib");

            // Create a new MediaPlayer instance
            _mediaPlayer = new MediaPlayer(_libVLC);

            // Attach the EndReached event handler
            _mediaPlayer.EndReached += MediaPlayer_EndReached;

            // Create a VideoView control and set its MediaPlayer property
            _videoView = new VideoView { MediaPlayer = _mediaPlayer, Dock = DockStyle.Fill };

            // Add the VideoView control to the panel
            pnlVideo.Controls.Add(_videoView);
        }

        public void InititalizeSpecificVideo(string title, string videoFileName)
        {
            // Sets the title
            lblTutorialTitle.Text = title;

            // Sets the colour to black
            lblTutorialTitle.ForeColor = Color.Black;

            // Construct the video file path
            string projectRootPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string videoFilePath = Path.Combine(projectRootPath, "Videos", videoFileName);

            //string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //string videoFilePath = Path.Combine(baseDirectory, "Videos", videoFileName);

            // Check if the file exists
            if (File.Exists(videoFilePath))
            {
                var media = new Media(_libVLC, videoFilePath, FromType.FromPath);
                _mediaPlayer.Media = media;
                _mediaPlayer.Play();
            }
            else
            {
                MessageBox.Show("Video file not found: " + videoFilePath);
            }
        }

        //************************ OTHER REGULAR METHODS ********************************
        public void InitializeLinkLabels(string[] linkLabels, string role)
        {
            // Dictionary to map labels to their respective event handlers
            var linkLabelEvents = new Dictionary<string, LinkLabelLinkClickedEventHandler>
                {
                    { "Login", linkLogin_LinkClicked },
                    { "Manage Account", linkManageAccount_LinkClicked },
                    { "Advanced Dashboard", linkAdvancedDashboard_LinkClicked },
                    { "Dashboard", linkDashboard_LinkClicked },
                    { "About", linkAbout_LinkClicked },
                    { "Contact", linkContact_LinkClicked },
                    { "Products", linkProducts_LinkClicked },
                    { "Home", linkHome_LinkClicked },
                    { "Categories", linkCategories_LinkClicked },
                    { "Reports", linkReports_LinkClicked },
                    { "Register Employee", linkRegisterEmployee_LinkClicked },
                    { "Manage Employee", linkManageEmployee_LinkClicked },
                    { "Manage Customers", linkManageCustomers_LinkClicked },
                    { "Record Products", linkRecordProducts_LinkClicked },
                    { "Manage Products", linkManageProducts_LinkClicked },
                    { "Create Invoice", linkCreateInvoice_LinkClicked },
                    { "Manage Invoices", linkManageInvoices_LinkClicked },
                    { "Dispatch Goods", linkDispatchGoods_LinkClicked },
                    { "Manage Dispatches", linkManageDispatches_LinkClicked },
                    { "Create Order", linkCreateOrder_LinkClicked },
                    { "Manage Orders", linkManageOrders_LinkClicked },
                    { "Log Off", linkLogOff_LinkClicked }
                };

            int yPos = 10;
            foreach (string label in linkLabels)
            {
                LinkLabel linkLabel = new LinkLabel
                {
                    Text = label,
                    Name = "link" + label.Replace(" ", ""),
                    Location = new Point(10, yPos),
                    AutoSize = true
                };

                // Check if there is an event handler for this label
                if (linkLabelEvents.TryGetValue(label, out var eventHandler))
                {
                    linkLabel.LinkClicked += eventHandler;
                }

                this.flowLayoutPanel2.Controls.Add(linkLabel);
                yPos += 20; // Adjust this value based on the size of your link labels
            }

            lblRoleTitle.Text = role;
        }

        //************************ Event Handlers ********************************
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // Preload the first video
            InititalizeSpecificVideo("Login", "Login.mp4");
        }

        //private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        //{
        //    string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dlls");
        //    string assemblyPath = Path.Combine(folderPath, new AssemblyName(args.Name).Name + ".dll");
        //    if (File.Exists(assemblyPath))
        //    {
        //        return Assembly.LoadFrom(assemblyPath);
        //    }
        //    return null;
        //}

        private void MediaPlayer_EndReached(object sender, EventArgs e)
        {
            // Set the color and text
            lblTutorialTitle.ForeColor = Color.Red;
            lblTutorialTitle.Text += " - Video ended";
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Login", "Login.mp4");
        }

        private void linkManageAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Manage Account", "Manage_Account.mp4");
        }

        private void linkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("About", "About.mp4");
        }

        private void linkContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Contact Us", "Contact.mp4");
        }

        private void linkProducts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Shop Products", "Products.mp4");
        }

        private void linkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Home", "Home.mp4");
        }

        private void linkCategories_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Filter By Category", "Categories.mp4");
        }

        private void linkAdvancedDashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Advanced Dashboard", "Advanced_Dashboard.mp4");
        }

        private void linkDashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Dashboard", "Dashboard.mp4");
        }

        private void linkReports_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Reports", "Reports.mp4");
        }

        private void linkRegisterEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Register Employee", "Register_Employee.mp4");
        }

        private void linkManageEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Manage Employee", "Manage_Employee.mp4");
        }

        private void linkManageCustomers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Manage Customers", "Manage_Customers.mp4");
        }

        private void linkRecordProducts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Record Products", "Record_Products.mp4");
        }

        private void linkManageProducts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Manage Products", "Manage_Products.mp4");
        }

        private void linkCreateInvoice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Create Invoice", "Create_Invoice.mp4");
        }

        private void linkManageInvoices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Manage Invoices", "Manage_Invoices.mp4");
        }

        private void linkDispatchGoods_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Dispatch Goods", "Dispatch_Goods.mp4");
        }

        private void linkManageDispatches_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Manage Dispatches", "Manage_Dispatches.mp4");
        }

        private void linkCreateOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Create Order", "Create_Order.mp4");
        }

        private void linkManageOrders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Manage Orders", "Manage_Orders.mp4");
        }

        private void linkLogOff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Log Off", "Log_Off.mp4");
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create an instance of the select role form
            SelectRoleForm roleForm = new SelectRoleForm();

            // Handle the FormClosed event of the new form
            roleForm.FormClosed += (s, args) => Application.Exit();

            // Hide this form
            this.Hide();

            // Show the form
            roleForm.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!_mediaPlayer.IsPlaying)
            {
                _mediaPlayer.Play();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (_mediaPlayer.IsPlaying)
            {
                _mediaPlayer.Pause();
            }
        }
    }
}
