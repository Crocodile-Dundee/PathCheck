using System;
using System.Reflection;
using System.Windows.Forms;
using Lib_AboutApp;
using Lib_AboutEnv;

namespace PathCheck
{

    /// <summary>
    /// Class of the AboutWindow
    /// </summary>
    partial class AboutWindow : Form
    {

        // ---------------------------------------------------------------------------------
        // Declarations
        // ---------------------------------------------------------------------------------


        // ---------------------------------------------------------------------------------
        // Declarations
        // ---------------------------------------------------------------------------------
        // Form
        // ---------------------------------------------------------------------------------

        /// <summary>
        /// Constructor
        /// </summary>
        public AboutWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutWindow_Load(object sender, EventArgs e)
        {
            // Form
            this.Text = "About PathCheck";

            // Controls
            lbl_Title.Text = "PathCheck";

            lbl_Version.Text = $"Version {Assembly.GetEntryAssembly().GetName().Version.Major}.{Assembly.GetEntryAssembly().GetName().Version.Minor}{Assembly.GetEntryAssembly().GetName().Version.Revision}";


            lbl_Description.Text = "Checks length of all elements within a directory.";

            lbl_Copyright.Text = "License: Creative Commons Zero v1.0 Universal";
        }


        // ---------------------------------------------------------------------------------
        // Form
        // ---------------------------------------------------------------------------------
        // Controls
        // ---------------------------------------------------------------------------------


        // ---------------------------------------------------------------------------------
        // Controls
        // ---------------------------------------------------------------------------------
        // Methods
        // ---------------------------------------------------------------------------------


    }
}
