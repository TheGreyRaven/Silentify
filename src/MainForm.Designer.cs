namespace Silentify
{
    partial class Silentify
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Silentify));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Transition = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.spotifyLogo = new System.Windows.Forms.PictureBox();
            this.loadingProgress = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.loadingLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spotifyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 5;
            this.Elipse.TargetControl = this;
            // 
            // Transition
            // 
            this.Transition.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Transparent;
            this.Transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.Transition.DefaultAnimation = animation1;
            this.Transition.Interval = 50;
            this.Transition.MaxAnimationTime = 2000;
            // 
            // spotifyLogo
            // 
            this.Transition.SetDecoration(this.spotifyLogo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.spotifyLogo.Image = ((System.Drawing.Image)(resources.GetObject("spotifyLogo.Image")));
            this.spotifyLogo.Location = new System.Drawing.Point(275, 30);
            this.spotifyLogo.Name = "spotifyLogo";
            this.spotifyLogo.Size = new System.Drawing.Size(250, 250);
            this.spotifyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spotifyLogo.TabIndex = 0;
            this.spotifyLogo.TabStop = false;
            this.spotifyLogo.Visible = false;
            // 
            // loadingProgress
            // 
            this.loadingProgress.Animated = true;
            this.loadingProgress.AnimationInterval = 1;
            this.loadingProgress.AnimationSpeed = 1;
            this.loadingProgress.BackColor = System.Drawing.Color.Transparent;
            this.loadingProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadingProgress.BackgroundImage")));
            this.loadingProgress.CircleMargin = 10;
            this.Transition.SetDecoration(this.loadingProgress, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.loadingProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.loadingProgress.IsPercentage = true;
            this.loadingProgress.LineProgressThickness = 5;
            this.loadingProgress.LineThickness = 5;
            this.loadingProgress.Location = new System.Drawing.Point(357, 298);
            this.loadingProgress.Name = "loadingProgress";
            this.loadingProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.loadingProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(97)))));
            this.loadingProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.loadingProgress.Size = new System.Drawing.Size(87, 87);
            this.loadingProgress.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.loadingProgress.SubScriptMargin = new System.Windows.Forms.Padding(5, -35, 0, 0);
            this.loadingProgress.SubScriptText = "";
            this.loadingProgress.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.loadingProgress.SuperScriptMargin = new System.Windows.Forms.Padding(5, 50, 0, 0);
            this.loadingProgress.SuperScriptText = "%";
            this.loadingProgress.TabIndex = 16;
            this.loadingProgress.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.loadingProgress.Visible = false;
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoEllipsis = false;
            this.loadingLabel.AutoSize = false;
            this.loadingLabel.CursorType = null;
            this.Transition.SetDecoration(this.loadingLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.loadingLabel.Font = new System.Drawing.Font("Roboto", 20.25F);
            this.loadingLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.loadingLabel.Location = new System.Drawing.Point(93, 391);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loadingLabel.Size = new System.Drawing.Size(614, 59);
            this.loadingLabel.TabIndex = 17;
            this.loadingLabel.Text = "Please wait...";
            this.loadingLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.loadingLabel.Visible = false;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // Silentify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.loadingProgress);
            this.Controls.Add(this.spotifyLogo);
            this.Transition.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Silentify";
            this.Text = "Silentify";
            this.Load += new System.EventHandler(this.Silentify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spotifyLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuTransition Transition;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.PictureBox spotifyLogo;
        private Bunifu.UI.WinForms.BunifuCircleProgress loadingProgress;
        private Bunifu.UI.WinForms.BunifuLabel loadingLabel;
    }
}

