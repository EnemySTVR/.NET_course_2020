using BLL;
using Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace PL
{
    public partial class MainForm : Form
    {
        private UserBL userBL;
        private PrizeBL prizeBL;

        PrizeForm prizeForm;
        UserForm userForm;
        RevardForm revardForm;
        public MainForm()
        {
            InitializeComponent();
            userBL = new UserBL();
            prizeBL = new PrizeBL();
            userDataView.DataSource = userBL.GetDataSource();
            prizeDataView.DataSource = prizeBL.GetDataSource();
        }
        
        private void AddUserButtonClick(object sender, EventArgs e)
        {
            userForm = new UserForm(userBL, prizeBL.Prizes, true);
            var result = userForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                userInformationPanel.Visible = true;
                ResetUserDataSource();
                SelectRowByItemId(userDataView, userBL.SelectedUser.Id);
                SetUserInfoLabelText(userBL.SelectedUser);
            }
        }

        private void ChangeUserButtonClick(object sender, EventArgs e)
        {
            if (userBL.SelectedUser == null)
            {
                MessageBox.Show("Please select a user.");
            }
            else
            {
                userForm = new UserForm(userBL, prizeBL.Prizes, false);
                var result = userForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ResetUserDataSource();
                    SetUserInfoLabelText(userBL.SelectedUser);
                }
            }
        }

        private void DeleteUserButtonClick(object sender, EventArgs e)
        {
            if (userBL.SelectedUser == null)
            {
                MessageBox.Show("Please select a user.");
            }
            else
            {
                var result = MessageBox.Show("Are you sure you want to delete?", "Are you sure?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    userBL.RemoveSelectedUser();
                }
                ResetUserDataSource();
                if (userBL.SelectedUser != null)
                {
                    SelectRowByItemId(userDataView, userBL.SelectedUser.Id);
                    SetUserInfoLabelText(userBL.SelectedUser);
                }
            }
        }

        private void RevardUserButtonClick(object sender, EventArgs e)
        {
            if (userBL.SelectedUser == null)
            {
                MessageBox.Show("Please select a user.");
            }
            else
            {
                revardForm = new RevardForm(userBL, prizeBL.Prizes);
                var result = revardForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    SetUserInfoLabelText(userBL.SelectedUser);
                }
            }
        }

        private void AddPrizeButtonClick(object sender, EventArgs e)
        {
            prizeForm = new PrizeForm(prizeBL, true);
            var result = prizeForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                prizeInformationPanel.Visible = true;
                ResetPrizeDataSource();
                SelectRowByItemId(prizeDataView, prizeBL.SelectedPrize.Id);
                SetPriseInfoLabelText(prizeBL.SelectedPrize);
            }
        }

        private void ChangePrizeButtonClick(object sender, EventArgs e)
        {
            if (prizeBL.SelectedPrize == null)
            {
                MessageBox.Show("Please select a prize.");
            }
            else
            {
                prizeForm = new PrizeForm(prizeBL, false);
                var result = prizeForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ResetPrizeDataSource();
                    SetPriseInfoLabelText(prizeBL.SelectedPrize);
                }
            }
        }

        private void DeletePrizeButtonClick(object sender, EventArgs e)
        {
            if (prizeBL.SelectedPrize == null)
            {
                MessageBox.Show("Please select a prize.");
            }
            else
            {
                var result = MessageBox.Show("Are you sure you want to delete?", "Are you sure?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    prizeBL.RemoveSelectedPrize();
                }
                ResetPrizeDataSource();
                if (prizeBL.SelectedPrize != null)
                {
                    SelectRowByItemId(prizeDataView, prizeBL.SelectedPrize.Id);
                    SetPriseInfoLabelText(prizeBL.SelectedPrize);
                }
            }
        }


        private void SelectRowByItemId(DataGridView dataGridView, int id)
        {
            var allRows = ((DataView)dataGridView.DataSource).Table.Rows;
            var rowWithSelectItem = ((DataView)dataGridView.DataSource).Table.Select($"Id = {id}")[0];
            int rowIndex = allRows.IndexOf(rowWithSelectItem);
            dataGridView.Rows[rowIndex].Selected = true;
        }

        private void ChangeSelectedUser(object sender, EventArgs e)
        {
            userInformationPanel.Visible = true;

            PullSelectedUser();
            SetUserInfoLabelText(userBL.SelectedUser);
        }

        private void ChangeSelectedPrize(object sender, EventArgs e)
        {
            prizeInformationPanel.Visible = true;

            PullSelectedPrize();
            SetPriseInfoLabelText(prizeBL.SelectedPrize);
        }

        private void ChangeTabPage(object sender, TabControlCancelEventArgs e)
        {
            ResetSelectedItems();
            switch (tabControl.SelectedTab.Text)
            {
                case "Users":
                    prizeInformationPanel.Visible = false;
                    prizeButtonPanel.Visible = false;
                    if (userBL.SelectedUser != null)
                    {
                        userInformationPanel.Visible = true;
                    }
                    userButtonPanel.Visible = true;
                    break;
                case "Prizes":
                    userInformationPanel.Visible = false;
                    userButtonPanel.Visible = false;
                    if (prizeBL.SelectedPrize != null)
                    {
                        prizeInformationPanel.Visible = true;
                    }
                    prizeButtonPanel.Visible = true;
                    break;
            }
        }

        private void PullSelectedUser()
        {
            int rowIndex = userDataView.SelectedCells[0].RowIndex;
            var row = userDataView.Rows[rowIndex];
            userBL.SetSelectedItemById((int)row.Cells["Id"].Value);
        }

        private void PullSelectedPrize()
        {
            int rowIndex = prizeDataView.SelectedCells[0].RowIndex;
            var row = prizeDataView.Rows[rowIndex];
            prizeBL.SetSelectedItemById((int)row.Cells["Id"].Value);
        }

        private void SetUserInfoLabelText(UserVO selectedUser)
        {
            firstNameLabel.Text = selectedUser.FirstName;
            lastNameLabel.Text = selectedUser.LastName;
            birthDateLabel.Text = selectedUser.BirthDate.ToString();
            ageLabel.Text = selectedUser.Age;
            userPrizesBox.DataSource = selectedUser.Prizes;
        }

        private void SetPriseInfoLabelText(PrizeVO selectedPrize)
        {
            prizeNameLabel.Text = selectedPrize.Name;
            prizeDescriptionLabel.Text = selectedPrize.Description;
        }

        private void ResetSelectedItems()
        {
            userDataView.Rows[0].Selected = true;
            prizeDataView.Rows[0].Selected = true;

            PullSelectedUser();
            PullSelectedPrize();

            SetUserInfoLabelText(userBL.SelectedUser);
            SetPriseInfoLabelText(prizeBL.SelectedPrize);
        }

        private void ResetPrizeDataSource()
        {
            prizeDataView.DataSource = prizeBL.GetDataSource();
        }

        private void ResetUserDataSource()
        {
            userDataView.DataSource = userBL.GetDataSource();
        }

        private void OrderByCollumnHandler(object sender, DataGridViewCellMouseEventArgs e)
        {
            var source = ((DataGridView)sender).DataSource as DataView;
            var columnName = source.Table.Columns[e.ColumnIndex];
            source.Sort = columnName + " ASC";

            ResetSelectedItems();
        }
    }
}
