
namespace Astraea
{
    partial class Launcher
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
            this.LaucherHeader = new System.Windows.Forms.Label();
            this.LauncherLoadingLabel = new System.Windows.Forms.Label();
            this.LauncherProgressBar = new Siticone.Desktop.UI.WinForms.SiticoneProgressBar();
            this.LauncherDragControl = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.LauncherElipse = new Siticone.Desktop.UI.WinForms.SiticoneElipse(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // LaucherHeader
            // 
            this.LaucherHeader.AutoSize = true;
            this.LaucherHeader.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaucherHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.LaucherHeader.Location = new System.Drawing.Point(190, 4);
            this.LaucherHeader.Name = "LaucherHeader";
            this.LaucherHeader.Size = new System.Drawing.Size(124, 35);
            this.LaucherHeader.TabIndex = 2;
            this.LaucherHeader.Text = "Astraea";
            this.LaucherHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LauncherLoadingLabel
            // 
            this.LauncherLoadingLabel.AutoSize = true;
            this.LauncherLoadingLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LauncherLoadingLabel.ForeColor = System.Drawing.Color.White;
            this.LauncherLoadingLabel.Location = new System.Drawing.Point(198, 74);
            this.LauncherLoadingLabel.Name = "LauncherLoadingLabel";
            this.LauncherLoadingLabel.Size = new System.Drawing.Size(107, 24);
            this.LauncherLoadingLabel.TabIndex = 3;
            this.LauncherLoadingLabel.Text = "Loading...";
            this.LauncherLoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LauncherProgressBar
            // 
            this.LauncherProgressBar.Location = new System.Drawing.Point(75, 119);
            this.LauncherProgressBar.Name = "LauncherProgressBar";
            this.LauncherProgressBar.ShadowDecoration.Parent = this.LauncherProgressBar;
            this.LauncherProgressBar.Size = new System.Drawing.Size(337, 24);
            this.LauncherProgressBar.TabIndex = 4;
            this.LauncherProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // LauncherDragControl
            // 
            this.LauncherDragControl.TargetControl = this;
            // 
            // LauncherElipse
            // 
            this.LauncherElipse.BorderRadius = 9;
            this.LauncherElipse.TargetControl = this;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(474, 176);
            this.Controls.Add(this.LauncherProgressBar);
            this.Controls.Add(this.LauncherLoadingLabel);
            this.Controls.Add(this.LaucherHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Launcher";
            this.Text = "Astraea";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LaucherHeader;
        private Siticone.Desktop.UI.WinForms.SiticoneProgressBar LauncherProgressBar;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl LauncherDragControl;
        private Siticone.Desktop.UI.WinForms.SiticoneElipse LauncherElipse;
        public System.Windows.Forms.Label LauncherLoadingLabel;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

