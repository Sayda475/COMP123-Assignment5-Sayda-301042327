namespace COMP123_Assignment5_Sayda_301042327.Views
{
    partial class SelectForm
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
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectFormLabel = new System.Windows.Forms.Label();
            this.HardwareLabel = new System.Windows.Forms.Label();
            this.SelectionTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AllowUserToAddRows = false;
            this.ProductDataGridView.AllowUserToDeleteRows = false;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Location = new System.Drawing.Point(12, 74);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.ReadOnly = true;
            this.ProductDataGridView.Size = new System.Drawing.Size(749, 334);
            this.ProductDataGridView.TabIndex = 0;
            // 
            // SelectFormLabel
            // 
            this.SelectFormLabel.AutoSize = true;
            this.SelectFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFormLabel.Location = new System.Drawing.Point(196, 19);
            this.SelectFormLabel.Name = "SelectFormLabel";
            this.SelectFormLabel.Size = new System.Drawing.Size(420, 25);
            this.SelectFormLabel.TabIndex = 1;
            this.SelectFormLabel.Text = "Welcome to DollarComputer Hardware List";
            // 
            // HardwareLabel
            // 
            this.HardwareLabel.AutoSize = true;
            this.HardwareLabel.Location = new System.Drawing.Point(70, 435);
            this.HardwareLabel.Name = "HardwareLabel";
            this.HardwareLabel.Size = new System.Drawing.Size(107, 25);
            this.HardwareLabel.TabIndex = 2;
            this.HardwareLabel.Text = "You Select";
            // 
            // SelectionTextBox
            // 
            this.SelectionTextBox.Location = new System.Drawing.Point(201, 430);
            this.SelectionTextBox.Name = "SelectionTextBox";
            this.SelectionTextBox.ReadOnly = true;
            this.SelectionTextBox.Size = new System.Drawing.Size(560, 30);
            this.SelectionTextBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Coral;
            this.CancelButton.Location = new System.Drawing.Point(245, 481);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(114, 40);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.NextButton.Location = new System.Drawing.Point(428, 481);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(114, 40);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectionTextBox);
            this.Controls.Add(this.HardwareLabel);
            this.Controls.Add(this.SelectFormLabel);
            this.Controls.Add(this.ProductDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.Label SelectFormLabel;
        private System.Windows.Forms.Label HardwareLabel;
        private System.Windows.Forms.TextBox SelectionTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}