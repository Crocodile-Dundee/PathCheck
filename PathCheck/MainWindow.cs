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
            // Form
            this.Text = $"{Assembly.GetExecutingAssembly().GetName().Name.ToString()} - Version {Assembly.GetEntryAssembly().GetName().Version.ToString()}";
            this.Size = new Size(1100, 700);
        }


        private void btn_SelectDir_Click(object sender, EventArgs e)
        {
            if (fld_Browser.ShowDialog() == DialogResult.OK)
            {
                PathChecks.SelectedDir = fld_Browser.SelectedPath;
                lbl_SelectedDir.Text = PathChecks.SelectedDir;

                PathChecks.AnalyseSelectedDir(PathChecks.SelectedDir);

                foreach (DataRow row in PathChecks.AnalyseResultTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < PathChecks.AnalyseResultTable.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    ltv_PathElements.Items.Add(item);
                }
            }
        }


    }
}
