namespace Silentify
{
    partial class Dashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.VersionCard = new Bunifu.Framework.UI.BunifuCards();
            this.UpdateSilentify = new Bunifu.Framework.UI.BunifuThinButton2();
            this.VersionLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.GithubCard = new Bunifu.Framework.UI.BunifuCards();
            this.GithubImageButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.AdblockCard = new Bunifu.Framework.UI.BunifuCards();
            this.InstallAdblock = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AdblockStatusLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.HostListLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.VersionCard.SuspendLayout();
            this.GithubCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GithubImageButton)).BeginInit();
            this.AdblockCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // VersionCard
            // 
            this.VersionCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VersionCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.VersionCard.BorderRadius = 25;
            this.VersionCard.BottomSahddow = false;
            this.VersionCard.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(97)))));
            this.VersionCard.Controls.Add(this.UpdateSilentify);
            this.VersionCard.Controls.Add(this.VersionLabel);
            this.VersionCard.Controls.Add(this.bunifuLabel1);
            this.VersionCard.LeftSahddow = false;
            this.VersionCard.Location = new System.Drawing.Point(515, 20);
            this.VersionCard.Margin = new System.Windows.Forms.Padding(20);
            this.VersionCard.Name = "VersionCard";
            this.VersionCard.RightSahddow = false;
            this.VersionCard.ShadowDepth = 20;
            this.VersionCard.Size = new System.Drawing.Size(193, 178);
            this.VersionCard.TabIndex = 0;
            // 
            // UpdateSilentify
            // 
            this.UpdateSilentify.ActiveBorderThickness = 1;
            this.UpdateSilentify.ActiveCornerRadius = 20;
            this.UpdateSilentify.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(97)))));
            this.UpdateSilentify.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.UpdateSilentify.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(97)))));
            this.UpdateSilentify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.UpdateSilentify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateSilentify.BackgroundImage")));
            this.UpdateSilentify.ButtonText = "Check for Update";
            this.UpdateSilentify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateSilentify.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSilentify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(97)))));
            this.UpdateSilentify.IdleBorderThickness = 1;
            this.UpdateSilentify.IdleCornerRadius = 20;
            this.UpdateSilentify.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.UpdateSilentify.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(97)))));
            this.UpdateSilentify.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(97)))));
            this.UpdateSilentify.Location = new System.Drawing.Point(12, 128);
            this.UpdateSilentify.Margin = new System.Windows.Forms.Padding(5);
            this.UpdateSilentify.Name = "UpdateSilentify";
            this.UpdateSilentify.Size = new System.Drawing.Size(167, 41);
            this.UpdateSilentify.TabIndex = 8;
            this.UpdateSilentify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateSilentify.Click += new System.EventHandler(this.UpdateSilentify_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VersionLabel.AutoEllipsis = false;
            this.VersionLabel.AutoSize = false;
            this.VersionLabel.CursorType = null;
            this.VersionLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.VersionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.VersionLabel.Location = new System.Drawing.Point(0, 60);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VersionLabel.Size = new System.Drawing.Size(193, 27);
            this.VersionLabel.TabIndex = 5;
            this.VersionLabel.Text = "Unknown";
            this.VersionLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuLabel1.Location = new System.Drawing.Point(0, 21);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(193, 27);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "Silentify version:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GithubCard
            // 
            this.GithubCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GithubCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.GithubCard.BorderRadius = 25;
            this.GithubCard.BottomSahddow = false;
            this.GithubCard.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(97)))));
            this.GithubCard.Controls.Add(this.GithubImageButton);
            this.GithubCard.LeftSahddow = false;
            this.GithubCard.Location = new System.Drawing.Point(279, 20);
            this.GithubCard.Margin = new System.Windows.Forms.Padding(20);
            this.GithubCard.Name = "GithubCard";
            this.GithubCard.RightSahddow = false;
            this.GithubCard.ShadowDepth = 20;
            this.GithubCard.Size = new System.Drawing.Size(193, 178);
            this.GithubCard.TabIndex = 1;
            // 
            // GithubImageButton
            // 
            this.GithubImageButton.Image = ((System.Drawing.Image)(resources.GetObject("GithubImageButton.Image")));
            this.GithubImageButton.ImageActive = null;
            this.GithubImageButton.Location = new System.Drawing.Point(32, 25);
            this.GithubImageButton.Name = "GithubImageButton";
            this.GithubImageButton.Size = new System.Drawing.Size(131, 131);
            this.GithubImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GithubImageButton.TabIndex = 1;
            this.GithubImageButton.TabStop = false;
            this.GithubImageButton.Zoom = 10;
            this.GithubImageButton.Click += new System.EventHandler(this.GithubImageButton_Click);
            // 
            // AdblockCard
            // 
            this.AdblockCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdblockCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.AdblockCard.BorderRadius = 25;
            this.AdblockCard.BottomSahddow = false;
            this.AdblockCard.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(97)))));
            this.AdblockCard.Controls.Add(this.InstallAdblock);
            this.AdblockCard.Controls.Add(this.AdblockStatusLabel);
            this.AdblockCard.Controls.Add(this.HostListLabel);
            this.AdblockCard.LeftSahddow = false;
            this.AdblockCard.Location = new System.Drawing.Point(42, 20);
            this.AdblockCard.Margin = new System.Windows.Forms.Padding(20);
            this.AdblockCard.Name = "AdblockCard";
            this.AdblockCard.RightSahddow = false;
            this.AdblockCard.ShadowDepth = 20;
            this.AdblockCard.Size = new System.Drawing.Size(193, 178);
            this.AdblockCard.TabIndex = 1;
            // 
            // InstallAdblock
            // 
            this.InstallAdblock.ActiveBorderThickness = 1;
            this.InstallAdblock.ActiveCornerRadius = 20;
            this.InstallAdblock.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(97)))));
            this.InstallAdblock.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.InstallAdblock.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(97)))));
            this.InstallAdblock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.InstallAdblock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InstallAdblock.BackgroundImage")));
            this.InstallAdblock.ButtonText = "Install";
            this.InstallAdblock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstallAdblock.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallAdblock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(97)))));
            this.InstallAdblock.IdleBorderThickness = 1;
            this.InstallAdblock.IdleCornerRadius = 20;
            this.InstallAdblock.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.InstallAdblock.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(97)))));
            this.InstallAdblock.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(97)))));
            this.InstallAdblock.Location = new System.Drawing.Point(12, 128);
            this.InstallAdblock.Margin = new System.Windows.Forms.Padding(5);
            this.InstallAdblock.Name = "InstallAdblock";
            this.InstallAdblock.Size = new System.Drawing.Size(167, 41);
            this.InstallAdblock.TabIndex = 7;
            this.InstallAdblock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InstallAdblock.Click += new System.EventHandler(this.InstallAdblock_Click);
            // 
            // AdblockStatusLabel
            // 
            this.AdblockStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdblockStatusLabel.AutoEllipsis = false;
            this.AdblockStatusLabel.AutoSize = false;
            this.AdblockStatusLabel.CursorType = null;
            this.AdblockStatusLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AdblockStatusLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AdblockStatusLabel.Location = new System.Drawing.Point(0, 60);
            this.AdblockStatusLabel.Name = "AdblockStatusLabel";
            this.AdblockStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AdblockStatusLabel.Size = new System.Drawing.Size(193, 27);
            this.AdblockStatusLabel.TabIndex = 6;
            this.AdblockStatusLabel.Text = "Unknown";
            this.AdblockStatusLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HostListLabel
            // 
            this.HostListLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HostListLabel.AutoEllipsis = false;
            this.HostListLabel.AutoSize = false;
            this.HostListLabel.CursorType = null;
            this.HostListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.HostListLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.HostListLabel.Location = new System.Drawing.Point(0, 21);
            this.HostListLabel.Name = "HostListLabel";
            this.HostListLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HostListLabel.Size = new System.Drawing.Size(193, 27);
            this.HostListLabel.TabIndex = 1;
            this.HostListLabel.Text = "Adblock status:";
            this.HostListLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(42, 221);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(666, 17);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic);
            this.bunifuLabel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuLabel2.Location = new System.Drawing.Point(42, 205);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(362, 16);
            this.bunifuLabel2.TabIndex = 7;
            this.bunifuLabel2.Text = "You can click on the buttons above, or hover over them to learn more!";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuLabel2.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.AdblockCard);
            this.Controls.Add(this.GithubCard);
            this.Controls.Add(this.VersionCard);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(750, 420);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.VersionCard.ResumeLayout(false);
            this.GithubCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GithubImageButton)).EndInit();
            this.AdblockCard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards VersionCard;
        private Bunifu.Framework.UI.BunifuCards GithubCard;
        private Bunifu.Framework.UI.BunifuCards AdblockCard;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel HostListLabel;
        private Bunifu.UI.WinForms.BunifuLabel VersionLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 InstallAdblock;
        private Bunifu.UI.WinForms.BunifuLabel AdblockStatusLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 UpdateSilentify;
        private Bunifu.Framework.UI.BunifuImageButton GithubImageButton;
    }
}
