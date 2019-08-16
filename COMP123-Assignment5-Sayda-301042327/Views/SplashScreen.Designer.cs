namespace COMP123_Assignment5_Sayda_301042327.Views
{
    partial class SplashScreen
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
            this.IntoLabel = new System.Windows.Forms.Label();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.BrandLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IntoLabel
            // 
            this.IntoLabel.AutoSize = true;
            this.IntoLabel.BackColor = System.Drawing.Color.Transparent;
            this.IntoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntoLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.IntoLabel.Location = new System.Drawing.Point(-1, 4);
            this.IntoLabel.Name = "IntoLabel";
            this.IntoLabel.Size = new System.Drawing.Size(349, 29);
            this.IntoLabel.TabIndex = 0;
            this.IntoLabel.Text = "Good Product But Less Price";
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 3000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.BackColor = System.Drawing.Color.Transparent;
            this.BrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.BrandLabel.Location = new System.Drawing.Point(568, 521);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(310, 29);
            this.BrandLabel.TabIndex = 1;
            this.BrandLabel.Text = " ...With Dollar Computers!";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::COMP123_Assignment5_Sayda_301042327.Properties.Resources.dollarComputer1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.ControlBox = false;
            this.Controls.Add(this.BrandLabel);
            this.Controls.Add(this.IntoLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IntoLabel;
        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.Label BrandLabel;
    }
}