using System;
using System.Collections;
using System.Windows.Forms;
using Task1.SecondForms;

namespace Task1
{
    public partial class mainWindow : Form
    {
        private User _selectedUser;
        private Prize _selectedPrize;
        PrizeForm prizeForm;
        UserForm userForm;
        RevardForm revardForm;

        public mainWindow()
        {
            InitializeComponent();
            #region Это удалится позже
            var u1 = new User("petia", "pupkin", DateTime.Now);
            var u2 = new User("vasia", "lupin", DateTime.Now);
            DataController.Users.Add(u1);
            DataController.Users.Add(u2);

            var p1 = new Prize("nobel", "shnobel");
            var p2 = new Prize("klassniy", "perviy paren na sele");
            DataController.Prizes.Add(p1);
            DataController.Prizes.Add(p2);

            u1.AddPrize(p1);
            u1.AddPrize(p2);
            u2.AddPrize(p2);
            #endregion
            userDataView.DataSource = DataController.Users;
            prizeDataView.DataSource = DataController.Prizes;


        }

        private void AddUserButtonClick(object sender, EventArgs e)
        {
            userForm = new UserForm();
            userForm.ShowDialog();
        }

        private void ChangeUserButtonClick(object sender, EventArgs e)
        {
            if (_selectedUser == null)
            {
                MessageBox.Show("Please select a user.");
            }
            else
            {
                userForm = new UserForm(_selectedUser);
                userForm.ShowDialog();
                PullSelectedUser();
                SetUserInfoLabelText(_selectedUser);
            }
        }

        private void DeleteUserButtonClick(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete?", "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataController.Users.Remove(_selectedUser);
            }
            userInformationPanel.Visible = false;
            ResetSelectedItems();
        }

        private void AddPrizeButtonClick(object sender, EventArgs e)
        {
            prizeForm = new PrizeForm();
            prizeForm.ShowDialog();
        }

        private void RevardUserButtonClick(object sender, EventArgs e)
        {
            if (_selectedUser == null)
            {
                MessageBox.Show("Please select a user.");
            }
            else
            {
                revardForm = new RevardForm(_selectedUser);
                revardForm.ShowDialog();
                PullSelectedUser();
                SetUserInfoLabelText(_selectedUser);
            }
        }

        private void ChangePrizeButtonClick(object sender, EventArgs e)
        {
            if (_selectedPrize == null)
            {
                MessageBox.Show("Please select a prize.");
            }
            else
            {
                prizeForm = new PrizeForm(_selectedPrize);
                prizeForm.ShowDialog();
                PullSelectedPrize();
                SetPriseInfoLabelText(_selectedPrize);
            }
        }

        private void DeletePrizeButtonClick(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Are you sure you want to delete?", "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataController.Prizes.Remove(_selectedPrize);
                DataController.RemovePrizeFromUsers(_selectedPrize);
            }
            prizeInformationPanel.Visible = false;
            ResetSelectedItems();
        }


        private void ChangeSelectedUser(object sender, EventArgs e)
        {
            userInformationPanel.Visible = true;

            PullSelectedUser();
            SetUserInfoLabelText(_selectedUser);
        }

        private void ChangeSelectedPrize(object sender, EventArgs e)
        {
            prizeInformationPanel.Visible = true;

            PullSelectedPrize();
            SetPriseInfoLabelText(_selectedPrize);
        }

        private void ChangeTabPage(object sender, TabControlCancelEventArgs e)
        {
            ResetSelectedItems();
            switch (tabControl.SelectedTab.Text)
            {
                case "Users":
                    prizeInformationPanel.Visible = false;
                    prizeButtonPanel.Visible = false;
                    if (_selectedUser != null && DataController.Users.Contains(_selectedUser))
                    {
                        userInformationPanel.Visible = true;
                    }
                    userButtonPanel.Visible = true;
                    break;
                case "Prizes":
                    userInformationPanel.Visible = false;
                    userButtonPanel.Visible = false;
                    if (_selectedPrize != null && DataController.Prizes.Contains(_selectedPrize))
                    {
                        prizeInformationPanel.Visible = true;
                    }
                    prizeButtonPanel.Visible = true;
                    break;
            }
        }

        private void PullSelectedUser()
        {
            DataGridViewSelectedCellCollection cells = userDataView.SelectedCells;
            int rowIndex = cells[0].RowIndex;
            _selectedUser = (User)userDataView.Rows[rowIndex].DataBoundItem;
        }

        private void SetUserInfoLabelText(User selectedUser)
        {
            firstNameLabel.Text = selectedUser.FirstName;
            lastNameLabel.Text = selectedUser.LastName;
            birthDateLabel.Text = selectedUser.BirthDate.ToString();
            ageLabel.Text = selectedUser.Age;
            userPrizesBox.DataSource = selectedUser.Prizes;
        }

        private void PullSelectedPrize()
        {
            DataGridViewSelectedCellCollection cells = prizeDataView.SelectedCells;
            int rowIndex = cells[0].RowIndex;
            _selectedPrize = (Prize)prizeDataView.Rows[rowIndex].DataBoundItem;
        }

        private void SetPriseInfoLabelText(Prize selectedPrize)
        {
            prizeNameLabel.Text = selectedPrize.Name;
            prizeDescriptionLabel.Text = selectedPrize.Description;
        }

        private void ResetSelectedItems()
        {
            _selectedUser = DataController.Users[0];
            _selectedPrize = DataController.Prizes[0];

            SetUserInfoLabelText(_selectedUser);
            SetPriseInfoLabelText(_selectedPrize);

            userDataView.Rows[0].Selected = true;
            prizeDataView.Rows[0].Selected = true;
        }

        private void OrderByCollumnHandler(object sender, DataGridViewCellMouseEventArgs e)
        {
            var collumnName = ((DataGridView)sender).Columns[e.ColumnIndex].Name;
            var arg = new object[1] { collumnName };
            var sourceType = ((DataGridView)sender).DataSource.GetType();
            var methodInfo = sourceType.GetMethod("SortItemsByProperty");
            foreach (var source in DataController.SourceList)
            {
                if (sourceType.Equals(source.GetType()))
                {
                    methodInfo.Invoke(source, arg);
                }
            }

            ResetSelectedItems();
        }

        

        private class RowComparer : IComparer
        {
            private static int _sortOrdedModifer = 1;
            private static int _targetColumnIndex;

            public RowComparer(int targetColumnIndex, SortOrder sortOrder)
            {
                _targetColumnIndex = targetColumnIndex;

                if (sortOrder == SortOrder.Descending)
                {
                    _sortOrdedModifer = -1;
                }
                else if (sortOrder == SortOrder.Ascending)
                {
                    _sortOrdedModifer = 1;
                }
            }

            public int Compare(object x, object y)
            {
                var dataGridViewRow1 = (DataGridViewRow)x;
                var dataGridViewRow2 = (DataGridViewRow)y;

                int compareResult = String.Compare(
                    dataGridViewRow1.Cells[_targetColumnIndex].Value.ToString(),
                    dataGridViewRow2.Cells[_targetColumnIndex].Value.ToString());

                return compareResult * _sortOrdedModifer;
            }
        }
    }

    
}
