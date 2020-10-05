using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Task1
{
    public partial class mainWindow : Form
    {
        private User _selectedUser;
        private Prize _selectedPrize;
        BindingList<User> _users = new BindingList<User>();
        BindingList<Prize> _prizes = new BindingList<Prize>();


        
        public mainWindow()
        {
            InitializeComponent();
            tabControl.Selecting += ChangeTabPage;
            userDataView.Click += ChangeSelectedUser;


            var u1 = new User("petia", "pupkin", DateTime.Now);
            var u2 = new User("vasia", "lupin", DateTime.Now);
            _users.Add(u1);
            _users.Add(u2);

            var p1 = new Prize("nobel", "shnobel");
            var p2 = new Prize("klassniy", "perviy paren na sele");

            u1.AddPrize(p1);
            u1.AddPrize(p2);
            u2.AddPrize(p2);

            userDataView.DataSource = _users;
        }

        private void ChangeSelectedUser(object sender, EventArgs e)
        {
            userInformationPanel.Visible = true;

            DataGridViewSelectedCellCollection cells = userDataView.SelectedCells;
            int rowIndex = cells[0].RowIndex;
            _selectedUser = (User)userDataView.Rows[rowIndex].DataBoundItem;


            firstNameLabel.Text = _selectedUser.FirstName;
            lastNameLabel.Text = _selectedUser.LastName;
            birthDateLabel.Text = _selectedUser.BirthDate;
            ageLabel.Text = _selectedUser.Age;
            userPrizesBox.DataSource = _selectedUser.Prizes;

        }

        private void ChangeTabPage(object sender, TabControlCancelEventArgs e)
        {
            switch (tabControl.SelectedTab.Text)
            {
                case "Users":
                    prizeInformationPanel.Visible = false;
                    prizeButtonPanel.Visible = false;
                    userInformationPanel.Visible = true;
                    userButtonPanel.Visible = true;
                    break;
                case "Prizes":
                    userInformationPanel.Visible = false;
                    userButtonPanel.Visible = false;
                    prizeInformationPanel.Visible = true;
                    prizeButtonPanel.Visible = true;
                    break;
            }
        }
    }
}
