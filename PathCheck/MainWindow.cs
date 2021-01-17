using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathCheck
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.Text = $"{Assembly.GetExecutingAssembly().GetName().Name.ToString()} - Version {Assembly.GetEntryAssembly().GetName().Version.ToString()}";
        }
    }
}
