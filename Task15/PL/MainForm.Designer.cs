namespace PL
{
    partial class MainForm
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
            this.prizeNameLabel = new System.Windows.Forms.Label();
            this.prizeDescriptionLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.userPrizesBox = new System.Windows.Forms.ListBox();
            this.prizeInformationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.userInformationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.informationPanel = new System.Windows.Forms.Panel();
            this.addPrizeButton = new System.Windows.Forms.Button();
            this.changePrizeButton = new System.Windows.Forms.Button();
            this.deletePrizeButton = new System.Windows.Forms.Button();
            this.prizeButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addUserButton = new System.Windows.Forms.Button();
            this.changeUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.revardUserButton = new System.Windows.Forms.Button();
            this.userButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.prizeDataView = new System.Windows.Forms.DataGridView();
            this.prizesTabPage = new System.Windows.Forms.TabPage();
            this.userDataView = new System.Windows.Forms.DataGridView();
            this.usersTabPage = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mainViewPanel = new System.Windows.Forms.TableLayoutPanel();
            this.prizeInformationPanel.SuspendLayout();
            this.userInformationPanel.SuspendLayout();
            this.informationPanel.SuspendLayout();
            this.prizeButtonPanel.SuspendLayout();
            this.userButtonPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prizeDataView)).BeginInit();
            this.prizesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataView)).BeginInit();
            this.usersTabPage.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.mainViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // prizeNameLabel
            // 
            this.prizeNameLabel.AutoSize = true;
            this.prizeNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prizeNameLabel.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prizeNameLabel.Location = new System.Drawing.Point(3, 0);
            this.prizeNameLabel.Name = "prizeNameLabel";
            this.prizeNameLabel.Size = new System.Drawing.Size(254, 47);
            this.prizeNameLabel.TabIndex = 0;
            this.prizeNameLabel.Text = "Prize";
            this.prizeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prizeDescriptionLabel
            // 
            this.prizeDescriptionLabel.AutoSize = true;
            this.prizeDescriptionLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.prizeDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prizeDescriptionLabel.Location = new System.Drawing.Point(5, 52);
            this.prizeDescriptionLabel.Margin = new System.Windows.Forms.Padding(5);
            this.prizeDescriptionLabel.Name = "prizeDescriptionLabel";
            this.prizeDescriptionLabel.Size = new System.Drawing.Size(250, 180);
            this.prizeDescriptionLabel.TabIndex = 1;
            this.prizeDescriptionLabel.Text = "Description";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.Location = new System.Drawing.Point(3, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(254, 30);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Фамилия";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.Location = new System.Drawing.Point(3, 30);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(254, 30);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "Имя";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthDateLabel.Location = new System.Drawing.Point(3, 60);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(254, 20);
            this.birthDateLabel.TabIndex = 2;
            this.birthDateLabel.Text = "Дата рождения";
            this.birthDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ageLabel.Location = new System.Drawing.Point(3, 80);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(254, 20);
            this.ageLabel.TabIndex = 3;
            this.ageLabel.Text = "Возраст";
            this.ageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prizesLabel.Location = new System.Drawing.Point(3, 100);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(254, 20);
            this.prizesLabel.TabIndex = 4;
            this.prizesLabel.Text = "Награды:";
            this.prizesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userPrizesBox
            // 
            this.userPrizesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userPrizesBox.FormattingEnabled = true;
            this.userPrizesBox.ItemHeight = 15;
            this.userPrizesBox.Location = new System.Drawing.Point(3, 123);
            this.userPrizesBox.Name = "userPrizesBox";
            this.userPrizesBox.Size = new System.Drawing.Size(254, 109);
            this.userPrizesBox.TabIndex = 5;
            // 
            // prizeInformationPanel
            // 
            this.prizeInformationPanel.ColumnCount = 1;
            this.prizeInformationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.prizeInformationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.prizeInformationPanel.Controls.Add(this.prizeNameLabel, 0, 0);
            this.prizeInformationPanel.Controls.Add(this.prizeDescriptionLabel, 0, 1);
            this.prizeInformationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prizeInformationPanel.Location = new System.Drawing.Point(0, 0);
            this.prizeInformationPanel.Name = "prizeInformationPanel";
            this.prizeInformationPanel.RowCount = 2;
            this.prizeInformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.prizeInformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.prizeInformationPanel.Size = new System.Drawing.Size(260, 237);
            this.prizeInformationPanel.TabIndex = 0;
            this.prizeInformationPanel.Visible = false;
            // 
            // userInformationPanel
            // 
            this.userInformationPanel.ColumnCount = 1;
            this.userInformationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.userInformationPanel.Controls.Add(this.lastNameLabel, 0, 0);
            this.userInformationPanel.Controls.Add(this.firstNameLabel, 0, 1);
            this.userInformationPanel.Controls.Add(this.birthDateLabel, 0, 2);
            this.userInformationPanel.Controls.Add(this.ageLabel, 0, 3);
            this.userInformationPanel.Controls.Add(this.prizesLabel, 0, 4);
            this.userInformationPanel.Controls.Add(this.userPrizesBox, 0, 5);
            this.userInformationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInformationPanel.Location = new System.Drawing.Point(0, 0);
            this.userInformationPanel.Name = "userInformationPanel";
            this.userInformationPanel.RowCount = 6;
            this.userInformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.userInformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.userInformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.userInformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.userInformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.userInformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.userInformationPanel.Size = new System.Drawing.Size(260, 237);
            this.userInformationPanel.TabIndex = 1;
            this.userInformationPanel.Visible = false;
            // 
            // informationPanel
            // 
            this.informationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informationPanel.Controls.Add(this.prizeInformationPanel);
            this.informationPanel.Controls.Add(this.userInformationPanel);
            this.informationPanel.Location = new System.Drawing.Point(3, 183);
            this.informationPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Size = new System.Drawing.Size(260, 237);
            this.informationPanel.TabIndex = 2;
            // 
            // addPrizeButton
            // 
            this.addPrizeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPrizeButton.Location = new System.Drawing.Point(3, 3);
            this.addPrizeButton.MinimumSize = new System.Drawing.Size(0, 25);
            this.addPrizeButton.Name = "addPrizeButton";
            this.addPrizeButton.Size = new System.Drawing.Size(254, 25);
            this.addPrizeButton.TabIndex = 0;
            this.addPrizeButton.Text = "Add";
            this.addPrizeButton.UseVisualStyleBackColor = true;
            this.addPrizeButton.Click += new System.EventHandler(this.AddPrizeButtonClick);
            // 
            // changePrizeButton
            // 
            this.changePrizeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changePrizeButton.Location = new System.Drawing.Point(3, 32);
            this.changePrizeButton.MinimumSize = new System.Drawing.Size(0, 25);
            this.changePrizeButton.Name = "changePrizeButton";
            this.changePrizeButton.Size = new System.Drawing.Size(254, 25);
            this.changePrizeButton.TabIndex = 1;
            this.changePrizeButton.Text = "Change";
            this.changePrizeButton.UseVisualStyleBackColor = true;
            this.changePrizeButton.Click += new System.EventHandler(this.ChangePrizeButtonClick);
            // 
            // deletePrizeButton
            // 
            this.deletePrizeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletePrizeButton.Location = new System.Drawing.Point(3, 61);
            this.deletePrizeButton.MinimumSize = new System.Drawing.Size(0, 25);
            this.deletePrizeButton.Name = "deletePrizeButton";
            this.deletePrizeButton.Size = new System.Drawing.Size(254, 25);
            this.deletePrizeButton.TabIndex = 2;
            this.deletePrizeButton.Text = "Delete";
            this.deletePrizeButton.UseVisualStyleBackColor = true;
            this.deletePrizeButton.Click += new System.EventHandler(this.DeletePrizeButtonClick);
            // 
            // prizeButtonPanel
            // 
            this.prizeButtonPanel.ColumnCount = 1;
            this.prizeButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.prizeButtonPanel.Controls.Add(this.addPrizeButton, 0, 0);
            this.prizeButtonPanel.Controls.Add(this.changePrizeButton, 0, 1);
            this.prizeButtonPanel.Controls.Add(this.deletePrizeButton, 0, 2);
            this.prizeButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prizeButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.prizeButtonPanel.Name = "prizeButtonPanel";
            this.prizeButtonPanel.RowCount = 4;
            this.prizeButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.prizeButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.prizeButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.prizeButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.prizeButtonPanel.Size = new System.Drawing.Size(260, 118);
            this.prizeButtonPanel.TabIndex = 1;
            this.prizeButtonPanel.Visible = false;
            // 
            // addUserButton
            // 
            this.addUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUserButton.Location = new System.Drawing.Point(3, 3);
            this.addUserButton.MinimumSize = new System.Drawing.Size(0, 25);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(254, 25);
            this.addUserButton.TabIndex = 0;
            this.addUserButton.Text = "Add";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.AddUserButtonClick);
            // 
            // changeUserButton
            // 
            this.changeUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeUserButton.Location = new System.Drawing.Point(3, 32);
            this.changeUserButton.MinimumSize = new System.Drawing.Size(0, 25);
            this.changeUserButton.Name = "changeUserButton";
            this.changeUserButton.Size = new System.Drawing.Size(254, 25);
            this.changeUserButton.TabIndex = 1;
            this.changeUserButton.Text = "Change";
            this.changeUserButton.UseVisualStyleBackColor = true;
            this.changeUserButton.Click += new System.EventHandler(this.ChangeUserButtonClick);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteUserButton.Location = new System.Drawing.Point(3, 61);
            this.deleteUserButton.MinimumSize = new System.Drawing.Size(0, 25);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(254, 25);
            this.deleteUserButton.TabIndex = 2;
            this.deleteUserButton.Text = "Delete";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.DeleteUserButtonClick);
            // 
            // revardUserButton
            // 
            this.revardUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.revardUserButton.Location = new System.Drawing.Point(3, 90);
            this.revardUserButton.MinimumSize = new System.Drawing.Size(0, 25);
            this.revardUserButton.Name = "revardUserButton";
            this.revardUserButton.Size = new System.Drawing.Size(254, 25);
            this.revardUserButton.TabIndex = 3;
            this.revardUserButton.Text = "Revard";
            this.revardUserButton.UseVisualStyleBackColor = true;
            this.revardUserButton.Click += new System.EventHandler(this.RevardUserButtonClick);
            // 
            // userButtonPanel
            // 
            this.userButtonPanel.ColumnCount = 1;
            this.userButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.userButtonPanel.Controls.Add(this.addUserButton, 0, 0);
            this.userButtonPanel.Controls.Add(this.changeUserButton, 0, 1);
            this.userButtonPanel.Controls.Add(this.deleteUserButton, 0, 2);
            this.userButtonPanel.Controls.Add(this.revardUserButton, 0, 3);
            this.userButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.userButtonPanel.Name = "userButtonPanel";
            this.userButtonPanel.RowCount = 4;
            this.userButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.userButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.userButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.userButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.userButtonPanel.Size = new System.Drawing.Size(260, 118);
            this.userButtonPanel.TabIndex = 0;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.userButtonPanel);
            this.buttonPanel.Controls.Add(this.prizeButtonPanel);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(3, 59);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(260, 118);
            this.buttonPanel.TabIndex = 1;
            // 
            // prizeDataView
            // 
            this.prizeDataView.AllowUserToAddRows = false;
            this.prizeDataView.AllowUserToDeleteRows = false;
            this.prizeDataView.AllowUserToResizeRows = false;
            this.prizeDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prizeDataView.BackgroundColor = System.Drawing.Color.White;
            this.prizeDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prizeDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prizeDataView.Location = new System.Drawing.Point(3, 3);
            this.prizeDataView.MultiSelect = false;
            this.prizeDataView.Name = "prizeDataView";
            this.prizeDataView.ReadOnly = true;
            this.prizeDataView.RowHeadersVisible = false;
            this.prizeDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prizeDataView.Size = new System.Drawing.Size(514, 410);
            this.prizeDataView.TabIndex = 0;
            this.prizeDataView.Text = "dataGridView2";
            this.prizeDataView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OrderByCollumnHandler);
            this.prizeDataView.Click += new System.EventHandler(this.ChangeSelectedPrize);
            // 
            // prizesTabPage
            // 
            this.prizesTabPage.Controls.Add(this.prizeDataView);
            this.prizesTabPage.Location = new System.Drawing.Point(4, 24);
            this.prizesTabPage.Name = "prizesTabPage";
            this.prizesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.prizesTabPage.Size = new System.Drawing.Size(520, 416);
            this.prizesTabPage.TabIndex = 1;
            this.prizesTabPage.Text = "Prizes";
            this.prizesTabPage.UseVisualStyleBackColor = true;
            // 
            // userDataView
            // 
            this.userDataView.AllowUserToAddRows = false;
            this.userDataView.AllowUserToDeleteRows = false;
            this.userDataView.AllowUserToResizeRows = false;
            this.userDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataView.BackgroundColor = System.Drawing.Color.White;
            this.userDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDataView.Location = new System.Drawing.Point(3, 3);
            this.userDataView.MultiSelect = false;
            this.userDataView.Name = "userDataView";
            this.userDataView.ReadOnly = true;
            this.userDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userDataView.RowHeadersVisible = false;
            this.userDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDataView.Size = new System.Drawing.Size(514, 410);
            this.userDataView.TabIndex = 0;
            this.userDataView.Text = "dataGridView1";
            this.userDataView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OrderByCollumnHandler);
            this.userDataView.Click += new System.EventHandler(this.ChangeSelectedUser);
            // 
            // usersTabPage
            // 
            this.usersTabPage.Controls.Add(this.userDataView);
            this.usersTabPage.Location = new System.Drawing.Point(4, 24);
            this.usersTabPage.Name = "usersTabPage";
            this.usersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.usersTabPage.Size = new System.Drawing.Size(520, 416);
            this.usersTabPage.TabIndex = 0;
            this.usersTabPage.Text = "Users";
            this.usersTabPage.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.usersTabPage);
            this.tabControl.Controls.Add(this.prizesTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(269, 3);
            this.tabControl.Name = "tabControl";
            this.mainViewPanel.SetRowSpan(this.tabControl, 2);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(528, 444);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.ChangeTabPage);
            // 
            // mainViewPanel
            // 
            this.mainViewPanel.AutoSize = true;
            this.mainViewPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mainViewPanel.ColumnCount = 2;
            this.mainViewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainViewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
            this.mainViewPanel.Controls.Add(this.tabControl, 1, 0);
            this.mainViewPanel.Controls.Add(this.buttonPanel, 0, 0);
            this.mainViewPanel.Controls.Add(this.informationPanel, 0, 1);
            this.mainViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainViewPanel.Location = new System.Drawing.Point(0, 0);
            this.mainViewPanel.Margin = new System.Windows.Forms.Padding(100, 10, 10, 10);
            this.mainViewPanel.Name = "mainViewPanel";
            this.mainViewPanel.RowCount = 1;
            this.mainViewPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainViewPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainViewPanel.Size = new System.Drawing.Size(800, 450);
            this.mainViewPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainViewPanel);
            this.Name = "MainForm";
            this.Text = "Task14";
            this.prizeInformationPanel.ResumeLayout(false);
            this.prizeInformationPanel.PerformLayout();
            this.userInformationPanel.ResumeLayout(false);
            this.userInformationPanel.PerformLayout();
            this.informationPanel.ResumeLayout(false);
            this.prizeButtonPanel.ResumeLayout(false);
            this.userButtonPanel.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prizeDataView)).EndInit();
            this.prizesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataView)).EndInit();
            this.usersTabPage.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.mainViewPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prizeNameLabel;
        private System.Windows.Forms.Label prizeDescriptionLabel;
        private System.Windows.Forms.TableLayoutPanel prizeInformationPanel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.ListBox userPrizesBox;
        private System.Windows.Forms.TableLayoutPanel userInformationPanel;
        private System.Windows.Forms.Panel informationPanel;

        private System.Windows.Forms.Button addPrizeButton;
        private System.Windows.Forms.Button changePrizeButton;
        private System.Windows.Forms.Button deletePrizeButton;
        private System.Windows.Forms.TableLayoutPanel prizeButtonPanel;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button changeUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button revardUserButton;
        private System.Windows.Forms.TableLayoutPanel userButtonPanel;
        private System.Windows.Forms.Panel buttonPanel;

        private System.Windows.Forms.DataGridView prizeDataView;
        private System.Windows.Forms.TabPage prizesTabPage;
        private System.Windows.Forms.DataGridView userDataView;
        private System.Windows.Forms.TabPage usersTabPage;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TableLayoutPanel mainViewPanel;
    }
}

