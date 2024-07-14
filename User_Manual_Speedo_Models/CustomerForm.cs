using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee_User_Manual;
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System.Diagnostics;
using System.Xml;
using System.Reflection;

namespace User_Manual_Speedo_Models
{
    /// <summary>
    /// Author: Kieran Burns
    /// Date Finalized: 08/06/2024
    /// </summary>
    public partial class CustomerForm : Form, IMedia
    {
        private LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;
        private VideoView _videoView;
        public CustomerForm()
        {
            InitializeComponent();
            //AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            InitializeVLC();

            // Attach the Load event handler
            this.Load += new EventHandler(CustomerForm_Load);
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

        }

        public void InititalizeSpecificVideo(string title, string videoFileName)
        {
            // Clear any existing controls in the panel
            pnlVideo.Controls.Clear();

            // Add the VideoView control to the panel
            pnlVideo.Controls.Add(_videoView);

            // Sets the title
            tutorialTitle.Text = title;

            // Sets the colour to black
            tutorialTitle.ForeColor = Color.Black;

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

        //************************ EVENT HANDLERS ********************************
        private void CustomerForm_Load(object sender, EventArgs e)
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
            tutorialTitle.ForeColor = Color.Red;
            tutorialTitle.Text += " - Video ended";
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Login", "Login.mp4");
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

        private void linkManageAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Manage Account", "Manage_Account.mp4");
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Register", "Register.mp4");
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

        private void linkAddBasket_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Add To Basket", "Add_Basket.mp4");
        }

        private void linkBasket_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Basket Functionality", "Basket.mp4");
        }

        private void linkPayment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Payment", "Payment.mp4");
        }

        private void linkMyOrders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("My Orders Dashboard", "My_Orders.mp4");
        }

        private void linkMyInvoices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("My Invoices Dashboard", "My_Invoices.mp4");
        }

        private void linkPrintReturn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Print Return Slip", "Print_Return.mp4");
        }

        private void linkTutorials_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Tutorials", "Tutorials.mp4");
        }

        private void linkLogOff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call Initialize Specific Video Method
            InititalizeSpecificVideo("Log Off", "Log_Off.mp4");
        }

        private void linkMembershipStatus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Sets the Membership Status
            tutorialTitle.Text = "Membership Status";

            // Sets the colour to black
            tutorialTitle.ForeColor = Color.Black;

            // Stop and dispose of the media player if it is playing a video
            if (_mediaPlayer.IsPlaying)
            {
                _mediaPlayer.Stop();
                _mediaPlayer.Media.Dispose();
            }

            // Clear any existing controls in the panel
            pnlVideo.Controls.Clear();

            // Create and set properties for the labels
            Label labelMembershipChanges = new Label
            {
                Text = "Membership Changes:\n\nThe user's membership status only impacts the shipping costs for a given order.\n\nThe user can change their memberships between the following:",
                AutoSize = true,
                Location = new Point(10, 10)
            };

            Label labelStandard = new Label
            {
                Text = "Standard: Shipping is £4.99",
                AutoSize = true,
                Location = new Point(10, 90)
            };

            Label labelPremium = new Label
            {
                Text = "Premium: Shipping is £2.99",
                AutoSize = true,
                Location = new Point(10, 120)
            };

            Label labelCorporate = new Label
            {
                Text = "Corporate: Shipping is £0.99",
                AutoSize = true,
                Location = new Point(10, 150)
            };

            // Add labels to the pnlVideo panel
            pnlVideo.Controls.Add(labelMembershipChanges);
            pnlVideo.Controls.Add(labelStandard);
            pnlVideo.Controls.Add(labelPremium);
            pnlVideo.Controls.Add(labelCorporate);
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
