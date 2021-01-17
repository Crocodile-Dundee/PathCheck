
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
            this.lbl_SelectedPath = new System.Windows.Forms.Label();
            this.btn_SelectPath = new System.Windows.Forms.Button();
            this.lbl_SelectedPath_Tag = new System.Windows.Forms.Label();
            this.ltv_PathElements = new System.Windows.Forms.ListView();
            this.nud_LimitCount = new System.Windows.Forms.NumericUpDown();
            this.nud_WarningCount = new System.Windows.Forms.NumericUpDown();
            this.nud_LimitCount_Tag = new System.Windows.Forms.Label();
            this.nud_WarningCount_Tag = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.fld_Browser = new System.Windows.Forms.FolderBrowserDialog();
            this.col_Element = new System.Windows.Forms.ColumnHeader();
            this.col_Length = new System.Windows.Forms.ColumnHeader();
            this.sst_Status = new System.Windows.Forms.StatusStrip();
            this.sst_Status_TotalElements = new System.Windows.Forms.ToolStripStatusLabel();
            this.sst_Status_WarningElements = new System.Windows.Forms.ToolStripStatusLabel();
            this.sst_Status_ExceededElements = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nud_LimitCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_WarningCount)).BeginInit();
            this.sst_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_SelectedPath
            // 
            this.lbl_SelectedPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_SelectedPath.Location = new System.Drawing.Point(12, 37);
            this.lbl_SelectedPath.Name = "lbl_SelectedPath";
            this.lbl_SelectedPath.Size = new System.Drawing.Size(1021, 29);
            this.lbl_SelectedPath.TabIndex = 0;
            this.lbl_SelectedPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_SelectPath
            // 
            this.btn_SelectPath.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SelectPath.Location = new System.Drawing.Point(1039, 37);
            this.btn_SelectPath.Name = "btn_SelectPath";
            this.btn_SelectPath.Size = new System.Drawing.Size(31, 31);
            this.btn_SelectPath.TabIndex = 1;
            this.btn_SelectPath.Text = "···";
            this.btn_SelectPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_SelectPath.UseVisualStyleBackColor = true;
            // 
            // lbl_SelectedPath_Tag
            // 
            this.lbl_SelectedPath_Tag.AutoSize = true;
            this.lbl_SelectedPath_Tag.Location = new System.Drawing.Point(12, 9);
            this.lbl_SelectedPath_Tag.Name = "lbl_SelectedPath_Tag";
            this.lbl_SelectedPath_Tag.Size = new System.Drawing.Size(98, 20);
            this.lbl_SelectedPath_Tag.TabIndex = 2;
            this.lbl_SelectedPath_Tag.Text = "Selected Path";
            // 
            // ltv_PathElements
            // 
            this.ltv_PathElements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Element,
            this.col_Length});
            this.ltv_PathElements.HideSelection = false;
            this.ltv_PathElements.Location = new System.Drawing.Point(12, 124);
            this.ltv_PathElements.Name = "ltv_PathElements";
            this.ltv_PathElements.Size = new System.Drawing.Size(1058, 495);
            this.ltv_PathElements.TabIndex = 3;
            this.ltv_PathElements.UseCompatibleStateImageBehavior = false;
            this.ltv_PathElements.View = System.Windows.Forms.View.Details;
            // 
            // nud_LimitCount
            // 
            this.nud_LimitCount.Location = new System.Drawing.Point(60, 90);
            this.nud_LimitCount.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nud_LimitCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_LimitCount.Name = "nud_LimitCount";
            this.nud_LimitCount.Size = new System.Drawing.Size(80, 27);
            this.nud_LimitCount.TabIndex = 4;
            this.nud_LimitCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_LimitCount.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            // 
            // nud_WarningCount
            // 
            this.nud_WarningCount.Location = new System.Drawing.Point(411, 90);
            this.nud_WarningCount.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nud_WarningCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_WarningCount.Name = "nud_WarningCount";
            this.nud_WarningCount.Size = new System.Drawing.Size(80, 27);
            this.nud_WarningCount.TabIndex = 5;
            this.nud_WarningCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_WarningCount.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // nud_LimitCount_Tag
            // 
            this.nud_LimitCount_Tag.AutoSize = true;
            this.nud_LimitCount_Tag.Location = new System.Drawing.Point(12, 92);
            this.nud_LimitCount_Tag.Name = "nud_LimitCount_Tag";
            this.nud_LimitCount_Tag.Size = new System.Drawing.Size(171, 20);
            this.nud_LimitCount_Tag.TabIndex = 6;
            this.nud_LimitCount_Tag.Text = "Limit:                       chars";
            // 
            // nud_WarningCount_Tag
            // 
            this.nud_WarningCount_Tag.AutoSize = true;
            this.nud_WarningCount_Tag.Location = new System.Drawing.Point(270, 92);
            this.nud_WarningCount_Tag.Name = "nud_WarningCount_Tag";
            this.nud_WarningCount_Tag.Size = new System.Drawing.Size(266, 20);
            this.nud_WarningCount_Tag.TabIndex = 7;
            this.nud_WarningCount_Tag.Text = "Show Warning from                       chars";
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
            // col_Element
            // 
            this.col_Element.Text = "Element";
            this.col_Element.Width = 900;
            // 
            // col_Length
            // 
            this.col_Length.Text = "Length";
            this.col_Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_Length.Width = 154;
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
            // sst_Status_WarningElements
            // 
            this.sst_Status_WarningElements.AutoSize = false;
            this.sst_Status_WarningElements.Name = "sst_Status_WarningElements";
            this.sst_Status_WarningElements.Size = new System.Drawing.Size(200, 20);
            this.sst_Status_WarningElements.Text = "Warnings: ---";
            this.sst_Status_WarningElements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sst_Status_ExceededElements
            // 
            this.sst_Status_ExceededElements.AutoSize = false;
            this.sst_Status_ExceededElements.Name = "sst_Status_ExceededElements";
            this.sst_Status_ExceededElements.Size = new System.Drawing.Size(200, 20);
            this.sst_Status_ExceededElements.Text = "Exceeded Elements: ---";
            this.sst_Status_ExceededElements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.sst_Status);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.nud_LimitCount);
            this.Controls.Add(this.nud_LimitCount_Tag);
            this.Controls.Add(this.nud_WarningCount);
            this.Controls.Add(this.ltv_PathElements);
            this.Controls.Add(this.lbl_SelectedPath_Tag);
            this.Controls.Add(this.btn_SelectPath);
            this.Controls.Add(this.lbl_SelectedPath);
            this.Controls.Add(this.nud_WarningCount_Tag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PathCheck";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_LimitCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_WarningCount)).EndInit();
            this.sst_Status.ResumeLayout(false);
            this.sst_Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SelectedPath;
        private System.Windows.Forms.Button btn_SelectPath;
        private System.Windows.Forms.Label lbl_SelectedPath_Tag;
        private System.Windows.Forms.ListView ltv_PathElements;
        private System.Windows.Forms.NumericUpDown nud_LimitCount;
        private System.Windows.Forms.NumericUpDown nud_WarningCount;
        private System.Windows.Forms.Label nud_LimitCount_Tag;
        private System.Windows.Forms.Label nud_WarningCount_Tag;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.FolderBrowserDialog fld_Browser;
        private System.Windows.Forms.ColumnHeader col_Element;
        private System.Windows.Forms.ColumnHeader col_Length;
        private System.Windows.Forms.StatusStrip sst_Status;
        private System.Windows.Forms.ToolStripStatusLabel sst_Status_TotalElements;
        private System.Windows.Forms.ToolStripStatusLabel sst_Status_ExceededElements;
        private System.Windows.Forms.ToolStripStatusLabel sst_Status_WarningElements;
    }
}

