
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
            this.sst_Status = new System.Windows.Forms.StatusStrip();
            this.sst_Status_TotalElements = new System.Windows.Forms.ToolStripStatusLabel();
            this.sst_Status_ExceededElements = new System.Windows.Forms.ToolStripStatusLabel();
            this.sst_Status_WarningElements = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ExceededPathLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CriticalPathLength)).BeginInit();
            this.sst_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_SelectedDir
            // 
            this.lbl_SelectedDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_SelectedDir.Location = new System.Drawing.Point(12, 37);
            this.lbl_SelectedDir.Name = "lbl_SelectedDir";
            this.lbl_SelectedDir.Size = new System.Drawing.Size(1021, 29);
            this.lbl_SelectedDir.TabIndex = 0;
            this.lbl_SelectedDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_SelectDir
            // 
            this.btn_SelectDir.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SelectDir.Location = new System.Drawing.Point(1039, 37);
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
            this.ltv_PathElements.HideSelection = false;
            this.ltv_PathElements.Location = new System.Drawing.Point(12, 124);
            this.ltv_PathElements.Name = "ltv_PathElements";
            this.ltv_PathElements.Size = new System.Drawing.Size(1058, 495);
            this.ltv_PathElements.TabIndex = 3;
            this.ltv_PathElements.UseCompatibleStateImageBehavior = false;
            this.ltv_PathElements.View = System.Windows.Forms.View.Details;
            // 
            // col_Type
            // 
            this.col_Type.Text = "Type";
            // 
            // col_Path
            // 
            this.col_Path.Text = "Path";
            this.col_Path.Width = 800;
            // 
            // col_Length
            // 
            this.col_Length.Text = "Length";
            this.col_Length.Width = 80;
            // 
            // col_State
            // 
            this.col_State.Text = "State";
            this.col_State.Width = 114;
            // 
            // nud_ExceededPathLength
            // 
            this.nud_ExceededPathLength.Location = new System.Drawing.Point(181, 90);
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
            // 
            // nud_CriticalPathLength
            // 
            this.nud_CriticalPathLength.Location = new System.Drawing.Point(517, 90);
            this.nud_CriticalPathLength.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nud_CriticalPathLength.Minimum = new decimal(new int[] {
            1,
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
            // 
            // lbl_ExccededPathLength
            // 
            this.lbl_ExccededPathLength.AutoSize = true;
            this.lbl_ExccededPathLength.Location = new System.Drawing.Point(12, 92);
            this.lbl_ExccededPathLength.Name = "lbl_ExccededPathLength";
            this.lbl_ExccededPathLength.Size = new System.Drawing.Size(296, 20);
            this.lbl_ExccededPathLength.TabIndex = 6;
            this.lbl_ExccededPathLength.Text = "Show as exceeded from:                       chars";
            // 
            // lbl_ShowCritical
            // 
            this.lbl_ShowCritical.AutoSize = true;
            this.lbl_ShowCritical.Location = new System.Drawing.Point(368, 92);
            this.lbl_ShowCritical.Name = "lbl_ShowCritical";
            this.lbl_ShowCritical.Size = new System.Drawing.Size(273, 20);
            this.lbl_ShowCritical.TabIndex = 7;
            this.lbl_ShowCritical.Text = "Show as critical from                       chars";
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Update.Location = new System.Drawing.Point(958, 87);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(112, 31);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "Update";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // sst_Status
            // 
            this.sst_Status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sst_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sst_Status_TotalElements,
            this.sst_Status_ExceededElements,
            this.sst_Status_WarningElements});
            this.sst_Status.Location = new System.Drawing.Point(0, 627);
            this.sst_Status.Name = "sst_Status";
            this.sst_Status.Size = new System.Drawing.Size(1082, 26);
            this.sst_Status.SizingGrip = false;
            this.sst_Status.TabIndex = 9;
            this.sst_Status.Text = "sst_Status";
            // 
            // sst_Status_TotalElements
            // 
            this.sst_Status_TotalElements.AutoSize = false;
            this.sst_Status_TotalElements.Name = "sst_Status_TotalElements";
            this.sst_Status_TotalElements.Size = new System.Drawing.Size(200, 20);
            this.sst_Status_TotalElements.Text = "Total Elements: ---";
            this.sst_Status_TotalElements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sst_Status_ExceededElements
            // 
            this.sst_Status_ExceededElements.AutoSize = false;
            this.sst_Status_ExceededElements.Name = "sst_Status_ExceededElements";
            this.sst_Status_ExceededElements.Size = new System.Drawing.Size(200, 20);
            this.sst_Status_ExceededElements.Text = "Exceeded Elements: ---";
            this.sst_Status_ExceededElements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sst_Status_WarningElements
            // 
            this.sst_Status_WarningElements.AutoSize = false;
            this.sst_Status_WarningElements.Name = "sst_Status_WarningElements";
            this.sst_Status_WarningElements.Size = new System.Drawing.Size(200, 20);
            this.sst_Status_WarningElements.Text = "Warnings: ---";
            this.sst_Status_WarningElements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.sst_Status);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.nud_ExceededPathLength);
            this.Controls.Add(this.lbl_ExccededPathLength);
            this.Controls.Add(this.nud_CriticalPathLength);
            this.Controls.Add(this.ltv_PathElements);
            this.Controls.Add(this.lbl_SelectedDir_Tag);
            this.Controls.Add(this.btn_SelectDir);
            this.Controls.Add(this.lbl_SelectedDir);
            this.Controls.Add(this.lbl_ShowCritical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PathCheck";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_ExceededPathLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CriticalPathLength)).EndInit();
            this.sst_Status.ResumeLayout(false);
            this.sst_Status.PerformLayout();
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
        private System.Windows.Forms.StatusStrip sst_Status;
        private System.Windows.Forms.ToolStripStatusLabel sst_Status_TotalElements;
        private System.Windows.Forms.ToolStripStatusLabel sst_Status_ExceededElements;
        private System.Windows.Forms.ToolStripStatusLabel sst_Status_WarningElements;
        private System.Windows.Forms.ColumnHeader col_Length;
        private System.Windows.Forms.ColumnHeader col_State;
    }
}

