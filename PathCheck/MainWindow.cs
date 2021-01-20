using PathCheck.Properties;
using System;
using System.Data;
using System.Drawing;
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
            this.Text = $"{Assembly.GetExecutingAssembly().GetName().Name.ToString()} - Version {Assembly.GetEntryAssembly().GetName().Version.ToString()}";
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

                Update();
            }
        }

        /// <summary>
        /// Button: Update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            Update();
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


        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Methods
        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // Update the analysis
        private void Update()
        {
            ltv_PathElements.Visible = false;
            grp_Settings.Enabled = false;
            grp_Result.Enabled = false;
            Application.DoEvents();

            Analyse(PatchCheck.SelectedDir);

            ltv_PathElements.Visible = true;
            grp_Settings.Enabled = true;
            grp_Result.Enabled = true;
            Application.DoEvents();
        }

        /// <summary>
        /// Analyse directory and show result
        /// </summary>
        /// <param name="selectedDir"></param>
        private void Analyse(string selectedDir)
        {
            // Analyse
            PatchCheck.AnalyseSelectedDir(PatchCheck.SelectedDir, Settings.Default.CriticalLimit, Settings.Default.ExceededLimit);

            // Show element counts
            lbl_Total_Count.Text = PatchCheck.TotalElementsCount.ToString();
            lbl_Critical_Count.Text = PatchCheck.CriticalElementsCount.ToString();
            lbl_Exceeded_Count.Text = PatchCheck.ExceededElementsCount.ToString();

            // Show elements in ListView
            ltv_PathElements.Items.Clear();
            Application.DoEvents();

            foreach (DataRow row in PatchCheck.AnalyseResultTable.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < PatchCheck.AnalyseResultTable.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                ltv_PathElements.Items.Add(item);

                if (item.SubItems[3].Text == Convert.ToInt32(PathChecks.ElementLength.Critical).ToString())
                {
                    item.BackColor = Color.Yellow;
                    item.ForeColor = Color.Black;
                }
                else if (item.SubItems[3].Text == Convert.ToInt32(PathChecks.ElementLength.Exceeded).ToString())
                {
                    item.BackColor = Color.Red;
                    item.ForeColor = Color.White;
                }
                else
                {
                    item.BackColor = Color.White;
                    item.ForeColor = Color.Black;
                }
            }
        }


    }
}
