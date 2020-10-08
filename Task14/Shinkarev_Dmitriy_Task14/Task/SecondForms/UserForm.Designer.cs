namespace Task.SecondForms
{
    partial class UserForm
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
            this.addUserLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.newUserFirstNameLabel = new System.Windows.Forms.Label();
            this.newUserFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.newUserLastNameLabel = new System.Windows.Forms.Label();
            this.newUserLastNameTextBox = new System.Windows.Forms.TextBox();
            this.newUserBirthDateLabel = new System.Windows.Forms.Label();
            this.newUserBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.newUserPrizesLabel = new System.Windows.Forms.Label();
            this.newUserPrizesCheckedBox = new System.Windows.Forms.CheckedListBox();
            this.newUserButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.newUserAcceptButton = new System.Windows.Forms.Button();
            this.newUserCancelButton = new System.Windows.Forms.Button();
            this.addUserLayoutPanel.SuspendLayout();
            this.newUserButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addUserLayoutPanel
            // 
            this.addUserLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserLayoutPanel.Controls.Add(this.newUserFirstNameLabel);
            this.addUserLayoutPanel.Controls.Add(this.newUserFirstNameTextBox);
            this.addUserLayoutPanel.Controls.Add(this.newUserLastNameLabel);
            this.addUserLayoutPanel.Controls.Add(this.newUserLastNameTextBox);
            this.addUserLayoutPanel.Controls.Add(this.newUserBirthDateLabel);
            this.addUserLayoutPanel.Controls.Add(this.newUserBirthDatePicker);
            this.addUserLayoutPanel.Controls.Add(this.newUserPrizesLabel);
            this.addUserLayoutPanel.Controls.Add(this.newUserPrizesCheckedBox);
            this.addUserLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.addUserLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.addUserLayoutPanel.Name = "addUserLayoutPanel";
            this.addUserLayoutPanel.Size = new System.Drawing.Size(301, 282);
            this.addUserLayoutPanel.TabIndex = 0;
            // 
            // newUserFirstNameLabel
            // 
            this.newUserFirstNameLabel.AutoSize = true;
            this.newUserFirstNameLabel.Location = new System.Drawing.Point(3, 0);
            this.newUserFirstNameLabel.Name = "newUserFirstNameLabel";
            this.newUserFirstNameLabel.Size = new System.Drawing.Size(65, 15);
            this.newUserFirstNameLabel.TabIndex = 0;
            this.newUserFirstNameLabel.Text = "First name:";
            // 
            // newUserFirstNameTextBox
            // 
            this.newUserFirstNameTextBox.Location = new System.Drawing.Point(3, 18);
            this.newUserFirstNameTextBox.Name = "newUserFirstNameTextBox";
            this.newUserFirstNameTextBox.Size = new System.Drawing.Size(298, 23);
            this.newUserFirstNameTextBox.TabIndex = 1;
            // 
            // newUserLastNameLabel
            // 
            this.newUserLastNameLabel.AutoSize = true;
            this.newUserLastNameLabel.Location = new System.Drawing.Point(3, 44);
            this.newUserLastNameLabel.Name = "newUserLastNameLabel";
            this.newUserLastNameLabel.Size = new System.Drawing.Size(64, 15);
            this.newUserLastNameLabel.TabIndex = 2;
            this.newUserLastNameLabel.Text = "Last name:";
            // 
            // newUserLastNameTextBox
            // 
            this.newUserLastNameTextBox.Location = new System.Drawing.Point(3, 62);
            this.newUserLastNameTextBox.Name = "newUserLastNameTextBox";
            this.newUserLastNameTextBox.Size = new System.Drawing.Size(298, 23);
            this.newUserLastNameTextBox.TabIndex = 3;
            // 
            // newUserBirthDateLabel
            // 
            this.newUserBirthDateLabel.AutoSize = true;
            this.newUserBirthDateLabel.Location = new System.Drawing.Point(3, 88);
            this.newUserBirthDateLabel.Name = "newUserBirthDateLabel";
            this.newUserBirthDateLabel.Size = new System.Drawing.Size(61, 15);
            this.newUserBirthDateLabel.TabIndex = 4;
            this.newUserBirthDateLabel.Text = "Birth date:";
            // 
            // newUserBirthDatePicker
            // 
            this.newUserBirthDatePicker.Location = new System.Drawing.Point(3, 106);
            this.newUserBirthDatePicker.Name = "newUserBirthDatePicker";
            this.newUserBirthDatePicker.Size = new System.Drawing.Size(200, 23);
            this.newUserBirthDatePicker.TabIndex = 5;
            // 
            // newUserPrizesLabel
            // 
            this.newUserPrizesLabel.AutoSize = true;
            this.newUserPrizesLabel.Location = new System.Drawing.Point(3, 132);
            this.newUserPrizesLabel.Name = "newUserPrizesLabel";
            this.newUserPrizesLabel.Size = new System.Drawing.Size(40, 15);
            this.newUserPrizesLabel.TabIndex = 7;
            this.newUserPrizesLabel.Text = "Prizes:";
            // 
            // newUserPrizesCheckedBox
            // 
            this.newUserPrizesCheckedBox.FormattingEnabled = true;
            this.newUserPrizesCheckedBox.Location = new System.Drawing.Point(3, 150);
            this.newUserPrizesCheckedBox.Name = "newUserPrizesCheckedBox";
            this.newUserPrizesCheckedBox.Size = new System.Drawing.Size(298, 112);
            this.newUserPrizesCheckedBox.TabIndex = 6;
            // 
            // newUserButtonPanel
            // 
            this.newUserButtonPanel.ColumnCount = 2;
            this.newUserButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.newUserButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.newUserButtonPanel.Controls.Add(this.newUserAcceptButton, 0, 0);
            this.newUserButtonPanel.Controls.Add(this.newUserCancelButton, 1, 0);
            this.newUserButtonPanel.Location = new System.Drawing.Point(12, 300);
            this.newUserButtonPanel.Name = "newUserButtonPanel";
            this.newUserButtonPanel.RowCount = 1;
            this.newUserButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.newUserButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.newUserButtonPanel.Size = new System.Drawing.Size(301, 44);
            this.newUserButtonPanel.TabIndex = 1;
            // 
            // newUserAcceptButton
            // 
            this.newUserAcceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newUserAcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.newUserAcceptButton.Location = new System.Drawing.Point(3, 3);
            this.newUserAcceptButton.MaximumSize = new System.Drawing.Size(0, 25);
            this.newUserAcceptButton.Name = "newUserAcceptButton";
            this.newUserAcceptButton.Size = new System.Drawing.Size(144, 25);
            this.newUserAcceptButton.TabIndex = 0;
            this.newUserAcceptButton.Text = "Вариативно";
            this.newUserAcceptButton.UseVisualStyleBackColor = true;
            // 
            // newUserCancelButton
            // 
            this.newUserCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newUserCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.newUserCancelButton.Location = new System.Drawing.Point(153, 3);
            this.newUserCancelButton.MaximumSize = new System.Drawing.Size(0, 25);
            this.newUserCancelButton.Name = "newUserCancelButton";
            this.newUserCancelButton.Size = new System.Drawing.Size(145, 25);
            this.newUserCancelButton.TabIndex = 1;
            this.newUserCancelButton.Text = "Cancel";
            this.newUserCancelButton.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(325, 356);
            this.Controls.Add(this.newUserButtonPanel);
            this.Controls.Add(this.addUserLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.Text = "Вариативно";
            this.addUserLayoutPanel.ResumeLayout(false);
            this.addUserLayoutPanel.PerformLayout();
            this.newUserButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel addUserLayoutPanel;
        private System.Windows.Forms.Label newUserFirstNameLabel;
        private System.Windows.Forms.TextBox newUserFirstNameTextBox;
        private System.Windows.Forms.Label newUserLastNameLabel;
        private System.Windows.Forms.TextBox newUserLastNameTextBox;
        private System.Windows.Forms.Label newUserBirthDateLabel;
        private System.Windows.Forms.DateTimePicker newUserBirthDatePicker;
        private System.Windows.Forms.TableLayoutPanel newUserButtonPanel;
        private System.Windows.Forms.Button newUserAcceptButton;
        private System.Windows.Forms.Button newUserCancelButton;
        private System.Windows.Forms.Label newUserPrizesLabel;
        private System.Windows.Forms.CheckedListBox newUserPrizesCheckedBox;
    }
}