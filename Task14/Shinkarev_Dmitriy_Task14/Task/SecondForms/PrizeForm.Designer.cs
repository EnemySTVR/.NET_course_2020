namespace Task.SecondForms
{
    partial class PrizeForm
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
            this.addPrizeLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.newPrizeNameLabel = new System.Windows.Forms.Label();
            this.newPrizeNameTextBox = new System.Windows.Forms.TextBox();
            this.newPrizeDescriptionLabel = new System.Windows.Forms.Label();
            this.newPrizeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.newPrizeButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.newPrizeAcceptButton = new System.Windows.Forms.Button();
            this.newPrizeCancelButton = new System.Windows.Forms.Button();
            this.addPrizeLayoutPanel.SuspendLayout();
            this.newPrizeButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPrizeLayoutPanel
            // 
            this.addPrizeLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPrizeLayoutPanel.Controls.Add(this.newPrizeNameLabel);
            this.addPrizeLayoutPanel.Controls.Add(this.newPrizeNameTextBox);
            this.addPrizeLayoutPanel.Controls.Add(this.newPrizeDescriptionLabel);
            this.addPrizeLayoutPanel.Controls.Add(this.newPrizeDescriptionTextBox);
            this.addPrizeLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.addPrizeLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.addPrizeLayoutPanel.Name = "addPrizeLayoutPanel";
            this.addPrizeLayoutPanel.Size = new System.Drawing.Size(301, 282);
            this.addPrizeLayoutPanel.TabIndex = 0;
            // 
            // newPrizeNameLabel
            // 
            this.newPrizeNameLabel.AutoSize = true;
            this.newPrizeNameLabel.Location = new System.Drawing.Point(3, 0);
            this.newPrizeNameLabel.Name = "newPrizeNameLabel";
            this.newPrizeNameLabel.Size = new System.Drawing.Size(84, 15);
            this.newPrizeNameLabel.TabIndex = 0;
            this.newPrizeNameLabel.Text = "Name of prize:";
            // 
            // newPrizeNameTextBox
            // 
            this.newPrizeNameTextBox.Location = new System.Drawing.Point(3, 18);
            this.newPrizeNameTextBox.Name = "newPrizeNameTextBox";
            this.newPrizeNameTextBox.Size = new System.Drawing.Size(298, 23);
            this.newPrizeNameTextBox.TabIndex = 1;
            // 
            // newPrizeDescriptionLabel
            // 
            this.newPrizeDescriptionLabel.AutoSize = true;
            this.newPrizeDescriptionLabel.Location = new System.Drawing.Point(3, 44);
            this.newPrizeDescriptionLabel.Name = "newPrizeDescriptionLabel";
            this.newPrizeDescriptionLabel.Size = new System.Drawing.Size(70, 15);
            this.newPrizeDescriptionLabel.TabIndex = 2;
            this.newPrizeDescriptionLabel.Text = "Description:";
            // 
            // newPrizeDescriptionTextBox
            // 
            this.newPrizeDescriptionTextBox.Location = new System.Drawing.Point(3, 62);
            this.newPrizeDescriptionTextBox.Multiline = true;
            this.newPrizeDescriptionTextBox.Name = "newPrizeDescriptionTextBox";
            this.newPrizeDescriptionTextBox.Size = new System.Drawing.Size(298, 206);
            this.newPrizeDescriptionTextBox.TabIndex = 3;
            // 
            // newPrizeButtonPanel
            // 
            this.newPrizeButtonPanel.ColumnCount = 2;
            this.newPrizeButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.newPrizeButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.newPrizeButtonPanel.Controls.Add(this.newPrizeAcceptButton, 0, 0);
            this.newPrizeButtonPanel.Controls.Add(this.newPrizeCancelButton, 1, 0);
            this.newPrizeButtonPanel.Location = new System.Drawing.Point(12, 300);
            this.newPrizeButtonPanel.Name = "newPrizeButtonPanel";
            this.newPrizeButtonPanel.RowCount = 1;
            this.newPrizeButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.newPrizeButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.newPrizeButtonPanel.Size = new System.Drawing.Size(301, 44);
            this.newPrizeButtonPanel.TabIndex = 1;
            // 
            // newPrizeAcceptButton
            // 
            this.newPrizeAcceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPrizeAcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.newPrizeAcceptButton.Location = new System.Drawing.Point(3, 3);
            this.newPrizeAcceptButton.MaximumSize = new System.Drawing.Size(0, 25);
            this.newPrizeAcceptButton.Name = "newPrizeAcceptButton";
            this.newPrizeAcceptButton.Size = new System.Drawing.Size(144, 25);
            this.newPrizeAcceptButton.TabIndex = 0;
            this.newPrizeAcceptButton.Text = "Вариативно";
            this.newPrizeAcceptButton.UseVisualStyleBackColor = true;
            // 
            // newPrizeCancelButton
            // 
            this.newPrizeCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPrizeCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.newPrizeCancelButton.Location = new System.Drawing.Point(153, 3);
            this.newPrizeCancelButton.MaximumSize = new System.Drawing.Size(0, 25);
            this.newPrizeCancelButton.Name = "newPrizeCancelButton";
            this.newPrizeCancelButton.Size = new System.Drawing.Size(145, 25);
            this.newPrizeCancelButton.TabIndex = 1;
            this.newPrizeCancelButton.Text = "Cancel";
            this.newPrizeCancelButton.UseVisualStyleBackColor = true;
            // 
            // PrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(325, 356);
            this.Controls.Add(this.newPrizeButtonPanel);
            this.Controls.Add(this.addPrizeLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrizeForm";
            this.Text = "Вариативно";
            this.addPrizeLayoutPanel.ResumeLayout(false);
            this.addPrizeLayoutPanel.PerformLayout();
            this.newPrizeButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel addPrizeLayoutPanel;
        private System.Windows.Forms.Label newPrizeNameLabel;
        private System.Windows.Forms.TextBox newPrizeNameTextBox;
        private System.Windows.Forms.Label newPrizeDescriptionLabel;
        private System.Windows.Forms.TextBox newPrizeDescriptionTextBox;
        private System.Windows.Forms.TableLayoutPanel newPrizeButtonPanel;
        private System.Windows.Forms.Button newPrizeAcceptButton;
        private System.Windows.Forms.Button newPrizeCancelButton;
    }
}