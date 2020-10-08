namespace PL
{
    partial class Form1
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
            this.plusButton = new System.Windows.Forms.Button();
            this.enterNumberTextBox = new System.Windows.Forms.TextBox();
            this.enterNumberTextLabel = new System.Windows.Forms.Label();
            this.resultTextLabel = new System.Windows.Forms.Label();
            this.resultViewLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(254, 196);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(75, 23);
            this.plusButton.TabIndex = 0;
            this.plusButton.Text = "+1";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // enterNumberTextBox
            // 
            this.enterNumberTextBox.Location = new System.Drawing.Point(254, 150);
            this.enterNumberTextBox.Name = "enterNumberTextBox";
            this.enterNumberTextBox.Size = new System.Drawing.Size(275, 23);
            this.enterNumberTextBox.TabIndex = 1;
            // 
            // enterNumberTextLabel
            // 
            this.enterNumberTextLabel.AutoSize = true;
            this.enterNumberTextLabel.Location = new System.Drawing.Point(254, 132);
            this.enterNumberTextLabel.Name = "enterNumberTextLabel";
            this.enterNumberTextLabel.Size = new System.Drawing.Size(82, 15);
            this.enterNumberTextLabel.TabIndex = 3;
            this.enterNumberTextLabel.Text = "Enter number:";
            // 
            // resultTextLabel
            // 
            this.resultTextLabel.AutoSize = true;
            this.resultTextLabel.Location = new System.Drawing.Point(254, 226);
            this.resultTextLabel.Name = "resultTextLabel";
            this.resultTextLabel.Size = new System.Drawing.Size(42, 15);
            this.resultTextLabel.TabIndex = 4;
            this.resultTextLabel.Text = "Result:";
            // 
            // resultViewLabel
            // 
            this.resultViewLabel.AutoSize = true;
            this.resultViewLabel.Location = new System.Drawing.Point(299, 226);
            this.resultViewLabel.Name = "resultViewLabel";
            this.resultViewLabel.Size = new System.Drawing.Size(0, 15);
            this.resultViewLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultViewLabel);
            this.Controls.Add(this.resultTextLabel);
            this.Controls.Add(this.enterNumberTextLabel);
            this.Controls.Add(this.enterNumberTextBox);
            this.Controls.Add(this.plusButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.TextBox enterNumberTextBox;
        private System.Windows.Forms.Label enterNumberTextLabel;
        private System.Windows.Forms.Label resultTextLabel;
        private System.Windows.Forms.Label resultViewLabel;
    }
}

