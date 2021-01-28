namespace PathCheck
{
    partial class AboutWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            this.btn_OK = new System.Windows.Forms.Button();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.lbl_Copyright = new System.Windows.Forms.Label();
            this.dlg_ExportToXML = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_github = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_OK.Location = new System.Drawing.Point(719, 409);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(120, 34);
            this.btn_OK.TabIndex = 28;
            this.btn_OK.Text = "OK";
            // 
            // pic_Logo
            // 
            this.pic_Logo.BackColor = System.Drawing.Color.White;
            this.pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_Logo.Image")));
            this.pic_Logo.Location = new System.Drawing.Point(12, 11);
            this.pic_Logo.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.pic_Logo.Size = new System.Drawing.Size(183, 436);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_Logo.TabIndex = 31;
            this.pic_Logo.TabStop = false;
            // 
            // line
            // 
            this.line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line.Location = new System.Drawing.Point(22, 206);
            this.line.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(586, 1);
            this.line.TabIndex = 37;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.Location = new System.Drawing.Point(18, 19);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(40, 20);
            this.lbl_Title.TabIndex = 36;
            this.lbl_Title.Text = "Title";
            // 
            // lbl_Description
            // 
            this.lbl_Description.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Description.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Description.Location = new System.Drawing.Point(22, 91);
            this.lbl_Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Padding = new System.Windows.Forms.Padding(4);
            this.lbl_Description.Size = new System.Drawing.Size(588, 92);
            this.lbl_Description.TabIndex = 35;
            this.lbl_Description.Text = "Description";
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Version.Location = new System.Drawing.Point(18, 48);
            this.lbl_Version.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.lbl_Version.MaximumSize = new System.Drawing.Size(0, 21);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(57, 20);
            this.lbl_Version.TabIndex = 33;
            this.lbl_Version.Text = "Version";
            this.lbl_Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Copyright
            // 
            this.lbl_Copyright.AutoSize = true;
            this.lbl_Copyright.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Copyright.Location = new System.Drawing.Point(18, 231);
            this.lbl_Copyright.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.lbl_Copyright.MaximumSize = new System.Drawing.Size(0, 21);
            this.lbl_Copyright.Name = "lbl_Copyright";
            this.lbl_Copyright.Size = new System.Drawing.Size(74, 20);
            this.lbl_Copyright.TabIndex = 34;
            this.lbl_Copyright.Text = "Copyright";
            this.lbl_Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_github);
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Controls.Add(this.lbl_Copyright);
            this.panel1.Controls.Add(this.line);
            this.panel1.Controls.Add(this.lbl_Version);
            this.panel1.Controls.Add(this.lbl_Description);
            this.panel1.Location = new System.Drawing.Point(201, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 391);
            this.panel1.TabIndex = 34;
            // 
            // lbl_github
            // 
            this.lbl_github.AutoSize = true;
            this.lbl_github.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_github.Location = new System.Drawing.Point(19, 355);
            this.lbl_github.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.lbl_github.MaximumSize = new System.Drawing.Size(0, 21);
            this.lbl_github.Name = "lbl_github";
            this.lbl_github.Size = new System.Drawing.Size(212, 20);
            this.lbl_github.TabIndex = 41;
            this.lbl_github.Text = "github.com/Crocodile-Dundee";
            this.lbl_github.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btn_OK;
            this.ClientSize = new System.Drawing.Size(860, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_Logo);
            this.Controls.Add(this.btn_OK);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutWindow";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.Load += new System.EventHandler(this.AboutWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.Label lbl_Copyright;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.SaveFileDialog dlg_ExportToXML;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_github;
    }
}
