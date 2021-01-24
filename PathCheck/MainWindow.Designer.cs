
namespace PathCheck
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_SelectedDir = new System.Windows.Forms.Label();
            this.btn_SelectDir = new System.Windows.Forms.Button();
            this.lbl_SelectedDir_Tag = new System.Windows.Forms.Label();
            this.ltv_PathElements = new System.Windows.Forms.ListView();
            this.col_Type = new System.Windows.Forms.ColumnHeader();
            this.col_Path = new System.Windows.Forms.ColumnHeader();
            this.col_Length = new System.Windows.Forms.ColumnHeader();
            this.col_State = new System.Windows.Forms.ColumnHeader();
            this.nud_ExceededPathLength = new System.Windows.Forms.NumericUpDown();
            this.nud_CriticalPathLength = new System.Windows.Forms.NumericUpDown();
            this.lbl_ExccededPathLength = new System.Windows.Forms.Label();
            this.lbl_ShowCritical = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.fld_Browser = new System.Windows.Forms.FolderBrowserDialog();
            this.lbl_chars1 = new System.Windows.Forms.Label();
            this.lbl_chars0 = new System.Windows.Forms.Label();
            this.lbl_Total_Tag = new System.Windows.Forms.Label();
            this.lbl_Critical_Tag = new System.Windows.Forms.Label();
            this.lbl_Exceeded_Tag = new System.Windows.Forms.Label();
            this.lbl_Elements = new System.Windows.Forms.Label();
            this.lbl_Total_Count = new System.Windows.Forms.Label();
            this.lbl_Critical_Count = new System.Windows.Forms.Label();
            this.lbl_Exceeded_Count = new System.Windows.Forms.Label();
            this.opt_CriticalOnly = new System.Windows.Forms.RadioButton();
            this.opt_ExceededOnly = new System.Windows.Forms.RadioButton();
            this.opt_AllElements = new System.Windows.Forms.RadioButton();
            this.lbl_LoadingHint = new System.Windows.Forms.Label();
            this.btn_SaveSettings = new System.Windows.Forms.Button();
            this.grp_Settings = new System.Windows.Forms.GroupBox();
            this.grp_Result = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ExceededPathLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CriticalPathLength)).BeginInit();
            this.grp_Settings.SuspendLayout();
            this.grp_Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_SelectedDir
            // 
            this.lbl_SelectedDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_SelectedDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_SelectedDir.Location = new System.Drawing.Point(12, 37);
            this.lbl_SelectedDir.Name = "lbl_SelectedDir";
            this.lbl_SelectedDir.Size = new System.Drawing.Size(1271, 29);
            this.lbl_SelectedDir.TabIndex = 0;
            this.lbl_SelectedDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_SelectedDir.Click += new System.EventHandler(this.lbl_SelectedDir_Click);
            // 
            // btn_SelectDir
            // 
            this.btn_SelectDir.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SelectDir.Location = new System.Drawing.Point(1289, 36);
            this.btn_SelectDir.Name = "btn_SelectDir";
            this.btn_SelectDir.Size = new System.Drawing.Size(31, 31);
            this.btn_SelectDir.TabIndex = 1;
            this.btn_SelectDir.Text = "···";
            this.btn_SelectDir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_SelectDir.UseVisualStyleBackColor = true;
            this.btn_SelectDir.Click += new System.EventHandler(this.btn_SelectDir_Click);
            // 
            // lbl_SelectedDir_Tag
            // 
            this.lbl_SelectedDir_Tag.AutoSize = true;
            this.lbl_SelectedDir_Tag.Location = new System.Drawing.Point(12, 9);
            this.lbl_SelectedDir_Tag.Name = "lbl_SelectedDir_Tag";
            this.lbl_SelectedDir_Tag.Size = new System.Drawing.Size(131, 20);
            this.lbl_SelectedDir_Tag.TabIndex = 2;
            this.lbl_SelectedDir_Tag.Text = "Selected Directory";
            // 
            // ltv_PathElements
            // 
            this.ltv_PathElements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Type,
            this.col_Path,
            this.col_Length,
            this.col_State});
            this.ltv_PathElements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ltv_PathElements.FullRowSelect = true;
            this.ltv_PathElements.GridLines = true;
            this.ltv_PathElements.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ltv_PathElements.HideSelection = false;
            this.ltv_PathElements.Location = new System.Drawing.Point(12, 78);
            this.ltv_PathElements.Name = "ltv_PathElements";
            this.ltv_PathElements.ShowItemToolTips = true;
            this.ltv_PathElements.Size = new System.Drawing.Size(1070, 654);
            this.ltv_PathElements.TabIndex = 3;
            this.ltv_PathElements.UseCompatibleStateImageBehavior = false;
            this.ltv_PathElements.View = System.Windows.Forms.View.Details;
            this.ltv_PathElements.Click += new System.EventHandler(this.ltv_PathElements_Click);
            // 
            // col_Type
            // 
            this.col_Type.Text = "Type";
            this.col_Type.Width = 0;
            // 
            // col_Path
            // 
            this.col_Path.Text = "Path";
            this.col_Path.Width = 930;
            // 
            // col_Length
            // 
            this.col_Length.Text = "Length";
            this.col_Length.Width = 114;
            // 
            // col_State
            // 
            this.col_State.Text = "State";
            this.col_State.Width = 0;
            // 
            // nud_ExceededPathLength
            // 
            this.nud_ExceededPathLength.Location = new System.Drawing.Point(44, 57);
            this.nud_ExceededPathLength.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nud_ExceededPathLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_ExceededPathLength.Name = "nud_ExceededPathLength";
            this.nud_ExceededPathLength.Size = new System.Drawing.Size(80, 27);
            this.nud_ExceededPathLength.TabIndex = 4;
            this.nud_ExceededPathLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_ExceededPathLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_ExceededPathLength.ValueChanged += new System.EventHandler(this.nud_ExceededPathLength_ValueChanged);
            // 
            // nud_CriticalPathLength
            // 
            this.nud_CriticalPathLength.Location = new System.Drawing.Point(44, 121);
            this.nud_CriticalPathLength.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nud_CriticalPathLength.Name = "nud_CriticalPathLength";
            this.nud_CriticalPathLength.Size = new System.Drawing.Size(80, 27);
            this.nud_CriticalPathLength.TabIndex = 5;
            this.nud_CriticalPathLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_CriticalPathLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_CriticalPathLength.ValueChanged += new System.EventHandler(this.nud_CriticalPathLength_ValueChanged);
            // 
            // lbl_ExccededPathLength
            // 
            this.lbl_ExccededPathLength.AutoSize = true;
            this.lbl_ExccededPathLength.Location = new System.Drawing.Point(42, 34);
            this.lbl_ExccededPathLength.Name = "lbl_ExccededPathLength";
            this.lbl_ExccededPathLength.Size = new System.Drawing.Size(119, 20);
            this.lbl_ExccededPathLength.TabIndex = 6;
            this.lbl_ExccededPathLength.Text = "Exceeded length";
            // 
            // lbl_ShowCritical
            // 
            this.lbl_ShowCritical.AutoSize = true;
            this.lbl_ShowCritical.Location = new System.Drawing.Point(42, 98);
            this.lbl_ShowCritical.Name = "lbl_ShowCritical";
            this.lbl_ShowCritical.Size = new System.Drawing.Size(101, 20);
            this.lbl_ShowCritical.TabIndex = 7;
            this.lbl_ShowCritical.Text = "Critical length";
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Update.Location = new System.Drawing.Point(1088, 315);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(232, 31);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "Update";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_chars1
            // 
            this.lbl_chars1.AutoSize = true;
            this.lbl_chars1.Location = new System.Drawing.Point(130, 59);
            this.lbl_chars1.Name = "lbl_chars1";
            this.lbl_chars1.Size = new System.Drawing.Size(43, 20);
            this.lbl_chars1.TabIndex = 10;
            this.lbl_chars1.Text = "chars";
            // 
            // lbl_chars0
            // 
            this.lbl_chars0.AutoSize = true;
            this.lbl_chars0.Location = new System.Drawing.Point(130, 123);
            this.lbl_chars0.Name = "lbl_chars0";
            this.lbl_chars0.Size = new System.Drawing.Size(43, 20);
            this.lbl_chars0.TabIndex = 11;
            this.lbl_chars0.Text = "chars";
            // 
            // lbl_Total_Tag
            // 
            this.lbl_Total_Tag.Location = new System.Drawing.Point(26, 66);
            this.lbl_Total_Tag.Name = "lbl_Total_Tag";
            this.lbl_Total_Tag.Size = new System.Drawing.Size(82, 20);
            this.lbl_Total_Tag.TabIndex = 12;
            this.lbl_Total_Tag.Text = "Total:";
            // 
            // lbl_Critical_Tag
            // 
            this.lbl_Critical_Tag.BackColor = System.Drawing.Color.Yellow;
            this.lbl_Critical_Tag.Location = new System.Drawing.Point(26, 93);
            this.lbl_Critical_Tag.Name = "lbl_Critical_Tag";
            this.lbl_Critical_Tag.Size = new System.Drawing.Size(82, 20);
            this.lbl_Critical_Tag.TabIndex = 13;
            this.lbl_Critical_Tag.Text = "Critical:";
            // 
            // lbl_Exceeded_Tag
            // 
            this.lbl_Exceeded_Tag.BackColor = System.Drawing.Color.Red;
            this.lbl_Exceeded_Tag.ForeColor = System.Drawing.Color.White;
            this.lbl_Exceeded_Tag.Location = new System.Drawing.Point(26, 120);
            this.lbl_Exceeded_Tag.Name = "lbl_Exceeded_Tag";
            this.lbl_Exceeded_Tag.Size = new System.Drawing.Size(82, 20);
            this.lbl_Exceeded_Tag.TabIndex = 14;
            this.lbl_Exceeded_Tag.Text = "Exceeded:";
            // 
            // lbl_Elements
            // 
            this.lbl_Elements.AutoSize = true;
            this.lbl_Elements.Location = new System.Drawing.Point(26, 39);
            this.lbl_Elements.Name = "lbl_Elements";
            this.lbl_Elements.Size = new System.Drawing.Size(69, 20);
            this.lbl_Elements.TabIndex = 15;
            this.lbl_Elements.Text = "Elements";
            // 
            // lbl_Total_Count
            // 
            this.lbl_Total_Count.Location = new System.Drawing.Point(108, 66);
            this.lbl_Total_Count.Name = "lbl_Total_Count";
            this.lbl_Total_Count.Size = new System.Drawing.Size(85, 20);
            this.lbl_Total_Count.TabIndex = 16;
            this.lbl_Total_Count.Text = "---";
            // 
            // lbl_Critical_Count
            // 
            this.lbl_Critical_Count.BackColor = System.Drawing.Color.Yellow;
            this.lbl_Critical_Count.Location = new System.Drawing.Point(108, 93);
            this.lbl_Critical_Count.Name = "lbl_Critical_Count";
            this.lbl_Critical_Count.Size = new System.Drawing.Size(85, 20);
            this.lbl_Critical_Count.TabIndex = 17;
            this.lbl_Critical_Count.Text = "---";
            // 
            // lbl_Exceeded_Count
            // 
            this.lbl_Exceeded_Count.BackColor = System.Drawing.Color.Red;
            this.lbl_Exceeded_Count.ForeColor = System.Drawing.Color.White;
            this.lbl_Exceeded_Count.Location = new System.Drawing.Point(108, 120);
            this.lbl_Exceeded_Count.Name = "lbl_Exceeded_Count";
            this.lbl_Exceeded_Count.Size = new System.Drawing.Size(85, 20);
            this.lbl_Exceeded_Count.TabIndex = 18;
            this.lbl_Exceeded_Count.Text = "---";
            // 
            // opt_CriticalOnly
            // 
            this.opt_CriticalOnly.AutoSize = true;
            this.opt_CriticalOnly.Location = new System.Drawing.Point(31, 213);
            this.opt_CriticalOnly.Name = "opt_CriticalOnly";
            this.opt_CriticalOnly.Size = new System.Drawing.Size(108, 24);
            this.opt_CriticalOnly.TabIndex = 19;
            this.opt_CriticalOnly.Text = "Critical only";
            this.opt_CriticalOnly.UseVisualStyleBackColor = true;
            this.opt_CriticalOnly.CheckedChanged += new System.EventHandler(this.opt_CriticalOnly_CheckedChanged);
            // 
            // opt_ExceededOnly
            // 
            this.opt_ExceededOnly.AutoSize = true;
            this.opt_ExceededOnly.Location = new System.Drawing.Point(31, 243);
            this.opt_ExceededOnly.Name = "opt_ExceededOnly";
            this.opt_ExceededOnly.Size = new System.Drawing.Size(126, 24);
            this.opt_ExceededOnly.TabIndex = 20;
            this.opt_ExceededOnly.Text = "Exceeded only";
            this.opt_ExceededOnly.UseVisualStyleBackColor = true;
            this.opt_ExceededOnly.CheckedChanged += new System.EventHandler(this.opt_ExceededOnly_CheckedChanged);
            // 
            // opt_AllElements
            // 
            this.opt_AllElements.AutoSize = true;
            this.opt_AllElements.Checked = true;
            this.opt_AllElements.Location = new System.Drawing.Point(31, 183);
            this.opt_AllElements.Name = "opt_AllElements";
            this.opt_AllElements.Size = new System.Drawing.Size(112, 24);
            this.opt_AllElements.TabIndex = 21;
            this.opt_AllElements.TabStop = true;
            this.opt_AllElements.Text = "All elements";
            this.opt_AllElements.UseVisualStyleBackColor = true;
            this.opt_AllElements.CheckedChanged += new System.EventHandler(this.opt_AllElements_CheckedChanged);
            // 
            // lbl_LoadingHint
            // 
            this.lbl_LoadingHint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_LoadingHint.Location = new System.Drawing.Point(12, 78);
            this.lbl_LoadingHint.Name = "lbl_LoadingHint";
            this.lbl_LoadingHint.Size = new System.Drawing.Size(1070, 654);
            this.lbl_LoadingHint.TabIndex = 22;
            this.lbl_LoadingHint.Text = "Loading Directory...";
            this.lbl_LoadingHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_SaveSettings
            // 
            this.btn_SaveSettings.Location = new System.Drawing.Point(43, 165);
            this.btn_SaveSettings.Name = "btn_SaveSettings";
            this.btn_SaveSettings.Size = new System.Drawing.Size(125, 30);
            this.btn_SaveSettings.TabIndex = 23;
            this.btn_SaveSettings.Text = "Save";
            this.btn_SaveSettings.UseVisualStyleBackColor = true;
            this.btn_SaveSettings.Click += new System.EventHandler(this.btn_SaveSettings_Click);
            // 
            // grp_Settings
            // 
            this.grp_Settings.Controls.Add(this.lbl_ExccededPathLength);
            this.grp_Settings.Controls.Add(this.btn_SaveSettings);
            this.grp_Settings.Controls.Add(this.lbl_ShowCritical);
            this.grp_Settings.Controls.Add(this.nud_CriticalPathLength);
            this.grp_Settings.Controls.Add(this.nud_ExceededPathLength);
            this.grp_Settings.Controls.Add(this.lbl_chars1);
            this.grp_Settings.Controls.Add(this.lbl_chars0);
            this.grp_Settings.Location = new System.Drawing.Point(1088, 78);
            this.grp_Settings.Name = "grp_Settings";
            this.grp_Settings.Size = new System.Drawing.Size(232, 215);
            this.grp_Settings.TabIndex = 24;
            this.grp_Settings.TabStop = false;
            this.grp_Settings.Text = "Settings";
            // 
            // grp_Result
            // 
            this.grp_Result.Controls.Add(this.lbl_Elements);
            this.grp_Result.Controls.Add(this.lbl_Total_Tag);
            this.grp_Result.Controls.Add(this.opt_AllElements);
            this.grp_Result.Controls.Add(this.lbl_Critical_Tag);
            this.grp_Result.Controls.Add(this.opt_ExceededOnly);
            this.grp_Result.Controls.Add(this.lbl_Exceeded_Tag);
            this.grp_Result.Controls.Add(this.opt_CriticalOnly);
            this.grp_Result.Controls.Add(this.lbl_Total_Count);
            this.grp_Result.Controls.Add(this.lbl_Exceeded_Count);
            this.grp_Result.Controls.Add(this.lbl_Critical_Count);
            this.grp_Result.Location = new System.Drawing.Point(1088, 375);
            this.grp_Result.Name = "grp_Result";
            this.grp_Result.Size = new System.Drawing.Size(232, 358);
            this.grp_Result.TabIndex = 25;
            this.grp_Result.TabStop = false;
            this.grp_Result.Text = "Result";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 753);
            this.Controls.Add(this.grp_Result);
            this.Controls.Add(this.grp_Settings);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.ltv_PathElements);
            this.Controls.Add(this.lbl_SelectedDir_Tag);
            this.Controls.Add(this.btn_SelectDir);
            this.Controls.Add(this.lbl_SelectedDir);
            this.Controls.Add(this.lbl_LoadingHint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PathCheck";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_ExceededPathLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CriticalPathLength)).EndInit();
            this.grp_Settings.ResumeLayout(false);
            this.grp_Settings.PerformLayout();
            this.grp_Result.ResumeLayout(false);
            this.grp_Result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SelectedDir;
        private System.Windows.Forms.Button btn_SelectDir;
        private System.Windows.Forms.Label lbl_SelectedDir_Tag;
        private System.Windows.Forms.ListView ltv_PathElements;
        private System.Windows.Forms.NumericUpDown nud_ExceededPathLength;
        private System.Windows.Forms.NumericUpDown nud_CriticalPathLength;
        private System.Windows.Forms.Label lbl_ExccededPathLength;
        private System.Windows.Forms.Label lbl_ShowCritical;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.FolderBrowserDialog fld_Browser;
        private System.Windows.Forms.ColumnHeader col_Type;
        private System.Windows.Forms.ColumnHeader col_Path;
        private System.Windows.Forms.ColumnHeader col_Length;
        private System.Windows.Forms.ColumnHeader col_State;
        private System.Windows.Forms.Label lbl_chars1;
        private System.Windows.Forms.Label lbl_chars0;
        private System.Windows.Forms.Label lbl_Total_Tag;
        private System.Windows.Forms.Label lbl_Critical_Tag;
        private System.Windows.Forms.Label lbl_Exceeded_Tag;
        private System.Windows.Forms.Label lbl_Elements;
        private System.Windows.Forms.Label lbl_Total_Count;
        private System.Windows.Forms.Label lbl_Critical_Count;
        private System.Windows.Forms.Label lbl_Exceeded_Count;
        private System.Windows.Forms.RadioButton opt_CriticalOnly;
        private System.Windows.Forms.RadioButton opt_ExceededOnly;
        private System.Windows.Forms.RadioButton opt_AllElements;
        private System.Windows.Forms.Label lbl_LoadingHint;
        private System.Windows.Forms.Button btn_SaveSettings;
        private System.Windows.Forms.GroupBox grp_Settings;
        private System.Windows.Forms.GroupBox grp_Result;
    }
}

