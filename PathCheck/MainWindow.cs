using PathCheck.Properties;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PathCheck
{
    /// <summary>
    /// Main Window Class
    /// </summary>
    public partial class MainWindow : Form
    {

        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Declarations
        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// Get instance of PathChecks
        /// </summary>
        private PathChecks PatchCheck = PathChecks.GetInstance();


        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Form
        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// Form: Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            // Show Settings
            nud_ExceededPathLength.Value = Convert.ToDecimal(Settings.Default.ExceededLimit);
            nud_CriticalPathLength.Value = Convert.ToDecimal(Settings.Default.CriticalLimit);
        }
        
        /// <summary>
        /// Form: Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Form
            this.Text = $"{Assembly.GetExecutingAssembly().GetName().Name} - Version {Assembly.GetEntryAssembly().GetName().Version.Major}.{Assembly.GetEntryAssembly().GetName().Version.Minor}{Assembly.GetEntryAssembly().GetName().Version.Revision}";
            this.Size = new Size(1350, 800);
        }


        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Controls
        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// Button: Select Directory to analyse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SelectDir_Click(object sender, EventArgs e)
        {
            if (fld_Browser.ShowDialog() == DialogResult.OK)
            {
                PatchCheck.SelectedDir = fld_Browser.SelectedPath;
                lbl_SelectedDir.Text = PatchCheck.SelectedDir;

                Analyse(PatchCheck.SelectedDir);
            }
        }

        /// <summary>
        /// Label: Open Selected Directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_SelectedDir_Click(object sender, EventArgs e)
        {
            if (lbl_SelectedDir.Text != string.Empty)
            {
                Process.Start("explorer.exe", lbl_SelectedDir.Text);
            }
        }

        /// <summary>
        /// Button: Update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            Analyse(PatchCheck.SelectedDir);
        }

        /// <summary>
        /// NumericUpdown: Set exceeded length
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nud_ExceededPathLength_ValueChanged(object sender, EventArgs e)
        {
            if (nud_ExceededPathLength.Value <= nud_CriticalPathLength.Value)
            {
                nud_CriticalPathLength.Value = nud_ExceededPathLength.Value - 1;
            }
        }

        /// <summary>
        /// NumericUpDown: Set critical length
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nud_CriticalPathLength_ValueChanged(object sender, EventArgs e)
        {
            if (nud_CriticalPathLength.Value >= nud_ExceededPathLength.Value)
            {
                nud_ExceededPathLength.Value = nud_CriticalPathLength.Value + 1;
            }
        }

        /// <summary>
        /// Button: Save settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveSettings_Click(object sender, EventArgs e)
        {
            Settings.Default.ExceededLimit = Convert.ToInt32(nud_ExceededPathLength.Value);
            Settings.Default.CriticalLimit = Convert.ToInt32(nud_CriticalPathLength.Value);
            Settings.Default.Save();
        }

        /// <summary>
        /// RadioButton: Show all elments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opt_AllElements_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_AllElements.Checked)
            {
                Analyse(PatchCheck.SelectedDir);
            }
        }

        /// <summary>
        /// RadioButton: Show Cricital Only
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opt_CriticalOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_CriticalOnly.Checked)
            {
                Analyse(PatchCheck.SelectedDir);
            }
        }

        /// <summary>
        /// RadioButton: Show Exceeded Only
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opt_ExceededOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_ExceededOnly.Checked)
            {
                Analyse(PatchCheck.SelectedDir);
            }
        }

        /// <summary>
        /// ListView: Click item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ltv_PathElements_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.GetDirectoryName(ltv_PathElements.SelectedItems[0].SubItems[1].Text));
        }


        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Methods
        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// Analyse directory and show result
        /// </summary>
        /// <param name="selectedDir"></param>
        private void Analyse(string selectedDir)
        {
            // Hide Controls
            ltv_PathElements.Visible = false;
            grp_Settings.Enabled = false;
            grp_Result.Enabled = false;
            Application.DoEvents();

            // Analyse
            PatchCheck.AnalyseSelectedDir(PatchCheck.SelectedDir, Settings.Default.CriticalLimit, Settings.Default.ExceededLimit);

            // Show results counts
            lbl_Total_Count.Text = PatchCheck.TotalElementsCount.ToString();
            lbl_Critical_Count.Text = PatchCheck.CriticalElementsCount.ToString();
            lbl_Exceeded_Count.Text = PatchCheck.ExceededElementsCount.ToString();

            // Show elements in ListView

            // - Begin Update process
            ltv_PathElements.BeginUpdate();

            // - Config listview
            ltv_PathElements.Items.Clear();
            ltv_PathElements.View = View.Details;
            ltv_PathElements.HoverSelection = true;

            // - Show elements
            foreach (DataRow row in PatchCheck.AnalyseResultTable.Rows)
            {
                // Create ListView item
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < PatchCheck.AnalyseResultTable.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }

                item.UseItemStyleForSubItems = false;

                if (item.SubItems[3].Text == Convert.ToInt32(PathChecks.ElementLength.Critical).ToString())
                {
                    item.SubItems[2].BackColor = Color.Yellow;
                    item.SubItems[2].ForeColor = Color.Black;
                }
                else if (item.SubItems[3].Text == Convert.ToInt32(PathChecks.ElementLength.Exceeded).ToString())
                {
                    item.SubItems[2].BackColor = Color.Red;
                    item.SubItems[2].ForeColor = Color.White;
                }
                else
                {
                    item.SubItems[2].BackColor = Color.White;
                    item.SubItems[2].ForeColor = Color.Black;
                }


                // Show All Elements
                if (opt_AllElements.Checked)
                {
                    ltv_PathElements.Items.Add(item);
                }

                // Show Critical Elements Only
                if (opt_CriticalOnly.Checked)
                {
                    if (item.SubItems[3].Text == Convert.ToInt32(PathChecks.ElementLength.Critical).ToString())
                    {
                        ltv_PathElements.Items.Add(item);
                    }
                }

                // Show Exceeded Elements Only
                if (opt_ExceededOnly.Checked)
                {
                    if (item.SubItems[3].Text == Convert.ToInt32(PathChecks.ElementLength.Exceeded).ToString())
                    {
                        ltv_PathElements.Items.Add(item);
                    }
                }
                
            }

            ltv_PathElements.EndUpdate();

            // Show Controls
            ltv_PathElements.Visible = true;
            grp_Settings.Enabled = true;
            grp_Result.Enabled = true;
            Application.DoEvents();
        }


    }
}
