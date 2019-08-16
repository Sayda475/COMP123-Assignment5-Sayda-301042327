namespace COMP123_Assignment5_Sayda_301042327.Views
{
    partial class StartForm
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
            this.OrderLabel = new System.Windows.Forms.Label();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.SaveOrderButton = new System.Windows.Forms.Button();
            this.ExistButton = new System.Windows.Forms.Button();
            this.StartFormPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StartFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.OrderLabel.Location = new System.Drawing.Point(185, 18);
            this.OrderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(428, 31);
            this.OrderLabel.TabIndex = 0;
            this.OrderLabel.Text = "Order and Save Money Today!!!";
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.BackColor = System.Drawing.Color.LightGray;
            this.NewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.NewOrderButton.Location = new System.Drawing.Point(271, 309);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(271, 47);
            this.NewOrderButton.TabIndex = 1;
            this.NewOrderButton.Text = "New Order";
            this.NewOrderButton.UseVisualStyleBackColor = false;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // SaveOrderButton
            // 
            this.SaveOrderButton.BackColor = System.Drawing.Color.LightGray;
            this.SaveOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveOrderButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.SaveOrderButton.Location = new System.Drawing.Point(271, 380);
            this.SaveOrderButton.Name = "SaveOrderButton";
            this.SaveOrderButton.Size = new System.Drawing.Size(271, 47);
            this.SaveOrderButton.TabIndex = 2;
            this.SaveOrderButton.Text = "Saved Order";
            this.SaveOrderButton.UseVisualStyleBackColor = false;
            this.SaveOrderButton.Click += new System.EventHandler(this.SaveOrderButton_Click);
            // 
            // ExistButton
            // 
            this.ExistButton.BackColor = System.Drawing.Color.LightGray;
            this.ExistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.ExistButton.Location = new System.Drawing.Point(271, 447);
            this.ExistButton.Name = "ExistButton";
            this.ExistButton.Size = new System.Drawing.Size(271, 47);
            this.ExistButton.TabIndex = 3;
            this.ExistButton.Text = "Exist";
            this.ExistButton.UseVisualStyleBackColor = false;
            this.ExistButton.Click += new System.EventHandler(this.ExistButton_Click);
            // 
            // StartFormPictureBox
            // 
            this.StartFormPictureBox.Image = global::COMP123_Assignment5_Sayda_301042327.Properties.Resources.money;
            this.StartFormPictureBox.Location = new System.Drawing.Point(201, 98);
            this.StartFormPictureBox.Name = "StartFormPictureBox";
            this.StartFormPictureBox.Size = new System.Drawing.Size(402, 177);
            this.StartFormPictureBox.TabIndex = 4;
            this.StartFormPictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.StartFormPictureBox);
            this.Controls.Add(this.ExistButton);
            this.Controls.Add(this.SaveOrderButton);
            this.Controls.Add(this.NewOrderButton);
            this.Controls.Add(this.OrderLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.StartFormPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button SaveOrderButton;
        private System.Windows.Forms.Button ExistButton;
        private System.Windows.Forms.PictureBox StartFormPictureBox;
    }
}

