namespace Healthcare_Management_System.Forms
{
    partial class WelcomePage
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
            this.WprogressBar = new System.Windows.Forms.ProgressBar();
            this.LoadingLogo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // WprogressBar
            // 
            this.WprogressBar.Location = new System.Drawing.Point(252, 330);
            this.WprogressBar.Name = "WprogressBar";
            this.WprogressBar.Size = new System.Drawing.Size(561, 23);
            this.WprogressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.WprogressBar.TabIndex = 0;
            // 
            // LoadingLogo
            // 
            this.LoadingLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(40)))));
            this.LoadingLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoadingLogo.Image = global::Healthcare_Management_System.Properties.Resources.MedEaseLogo;
            this.LoadingLogo.InitialImage = null;
            this.LoadingLogo.Location = new System.Drawing.Point(293, 41);
            this.LoadingLogo.Margin = new System.Windows.Forms.Padding(0);
            this.LoadingLogo.Name = "LoadingLogo";
            this.LoadingLogo.Size = new System.Drawing.Size(461, 460);
            this.LoadingLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadingLogo.TabIndex = 1;
            this.LoadingLogo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1008, 621);
            this.Controls.Add(this.WprogressBar);
            this.Controls.Add(this.LoadingLogo);
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomePage";
            ((System.ComponentModel.ISupportInitialize)(this.LoadingLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar WprogressBar;
        private System.Windows.Forms.PictureBox LoadingLogo;
        private System.Windows.Forms.Timer timer1;
    }
}