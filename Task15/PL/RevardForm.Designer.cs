namespace PL
{
    partial class RevardForm
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
            this.choosePrizeComboBox = new System.Windows.Forms.ComboBox();
            this.revardPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.choosePrizeLabel = new System.Windows.Forms.Label();
            this.newPrizeDescriptionLabel = new System.Windows.Forms.Label();
            this.revardButtonBox = new System.Windows.Forms.TableLayoutPanel();
            this.revardAcceptButton = new System.Windows.Forms.Button();
            this.revardCancelButton = new System.Windows.Forms.Button();
            this.revardPanel.SuspendLayout();
            this.revardButtonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // choosePrizeComboBox
            // 
            this.choosePrizeComboBox.FormattingEnabled = true;
            this.choosePrizeComboBox.Location = new System.Drawing.Point(3, 18);
            this.choosePrizeComboBox.Name = "choosePrizeComboBox";
            this.choosePrizeComboBox.Size = new System.Drawing.Size(298, 23);
            this.choosePrizeComboBox.TabIndex = 0;
            this.choosePrizeComboBox.SelectedIndexChanged += new System.EventHandler(this.ChangeComboBoxItem);
            // 
            // revardPanel
            // 
            this.revardPanel.Controls.Add(this.choosePrizeLabel);
            this.revardPanel.Controls.Add(this.choosePrizeComboBox);
            this.revardPanel.Controls.Add(this.newPrizeDescriptionLabel);
            this.revardPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.revardPanel.Location = new System.Drawing.Point(12, 12);
            this.revardPanel.Name = "revardPanel";
            this.revardPanel.Size = new System.Drawing.Size(301, 282);
            this.revardPanel.TabIndex = 1;
            // 
            // choosePrizeLabel
            // 
            this.choosePrizeLabel.AutoSize = true;
            this.choosePrizeLabel.Location = new System.Drawing.Point(3, 0);
            this.choosePrizeLabel.Name = "choosePrizeLabel";
            this.choosePrizeLabel.Size = new System.Drawing.Size(98, 15);
            this.choosePrizeLabel.TabIndex = 1;
            this.choosePrizeLabel.Text = "Сhoose a reward:";
            // 
            // newPrizeDescriptionLabel
            // 
            this.newPrizeDescriptionLabel.AutoSize = true;
            this.newPrizeDescriptionLabel.Location = new System.Drawing.Point(3, 44);
            this.newPrizeDescriptionLabel.Name = "newPrizeDescriptionLabel";
            this.newPrizeDescriptionLabel.Size = new System.Drawing.Size(0, 15);
            this.newPrizeDescriptionLabel.TabIndex = 2;
            // 
            // revardButtonBox
            // 
            this.revardButtonBox.ColumnCount = 2;
            this.revardButtonBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.revardButtonBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.revardButtonBox.Controls.Add(this.revardAcceptButton, 0, 0);
            this.revardButtonBox.Controls.Add(this.revardCancelButton, 1, 0);
            this.revardButtonBox.Location = new System.Drawing.Point(12, 300);
            this.revardButtonBox.Name = "revardButtonBox";
            this.revardButtonBox.RowCount = 1;
            this.revardButtonBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.revardButtonBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.revardButtonBox.Size = new System.Drawing.Size(301, 44);
            this.revardButtonBox.TabIndex = 2;
            // 
            // revardAcceptButton
            // 
            this.revardAcceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.revardAcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.revardAcceptButton.Location = new System.Drawing.Point(3, 3);
            this.revardAcceptButton.MaximumSize = new System.Drawing.Size(0, 25);
            this.revardAcceptButton.Name = "revardAcceptButton";
            this.revardAcceptButton.Size = new System.Drawing.Size(144, 25);
            this.revardAcceptButton.TabIndex = 0;
            this.revardAcceptButton.Text = "Revard";
            this.revardAcceptButton.UseVisualStyleBackColor = true;
            this.revardAcceptButton.Click += new System.EventHandler(this.RevardUserButtonClick);
            // 
            // revardCancelButton
            // 
            this.revardCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.revardCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.revardCancelButton.Location = new System.Drawing.Point(153, 3);
            this.revardCancelButton.MaximumSize = new System.Drawing.Size(0, 25);
            this.revardCancelButton.Name = "revardCancelButton";
            this.revardCancelButton.Size = new System.Drawing.Size(145, 25);
            this.revardCancelButton.TabIndex = 1;
            this.revardCancelButton.Text = "Cancel";
            this.revardCancelButton.UseVisualStyleBackColor = true;
            // 
            // RevardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(325, 356);
            this.Controls.Add(this.revardButtonBox);
            this.Controls.Add(this.revardPanel);
            this.Name = "RevardForm";
            this.Text = "Revard user";
            this.revardPanel.ResumeLayout(false);
            this.revardPanel.PerformLayout();
            this.revardButtonBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox choosePrizeComboBox;
        private System.Windows.Forms.FlowLayoutPanel revardPanel;
        private System.Windows.Forms.Label choosePrizeLabel;
        private System.Windows.Forms.Label newPrizeDescriptionLabel;
        private System.Windows.Forms.TableLayoutPanel revardButtonBox;
        private System.Windows.Forms.Button revardAcceptButton;
        private System.Windows.Forms.Button revardCancelButton;
    }
}