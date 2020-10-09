using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            userForm = new UserForm(userBL, prizeBL, true);
            userForm.ShowDialog();
            userDataView.Rows[userDataView.Rows.Count - 1].Selected = true;
            PullSelectedUser();
            SetUserInfoLabelText(userBL.SelectedUser);
            userInformationPanel.Visible = true;
        }

        private void ChangeUserButtonClick(object sender, EventArgs e)
        {
            if (userBL.SelectedUser == null)
            {
                MessageBox.Show("Please select a user.");
            }
            else
            {
                userForm = new UserForm(userBL, prizeBL, false);
                userForm.ShowDialog();
                PullSelectedUser();
                SetUserInfoLabelText(userBL.SelectedUser);
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
                userInformationPanel.Visible = false;
                userBL.SelectedUser = null;
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
                revardForm = new RevardForm(userBL, prizeBL.GetDataSource());
                revardForm.ShowDialog();
                PullSelectedUser();
                SetUserInfoLabelText(userBL.SelectedUser);
            }
        }

        private void AddPrizeButtonClick(object sender, EventArgs e)
        {
            prizeForm = new PrizeForm(prizeBL, true);
            prizeForm.ShowDialog();
            prizeDataView.Rows[prizeDataView.Rows.Count - 1].Selected = true;
            PullSelectedPrize();
            SetPriseInfoLabelText(prizeBL.SelectedPrize);
            prizeInformationPanel.Visible = true;
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
                prizeForm.ShowDialog();
                PullSelectedPrize();
                SetPriseInfoLabelText(prizeBL.SelectedPrize);
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
                prizeInformationPanel.Visible = false;
                ResetSelectedItems();
                SetPriseInfoLabelText(prizeBL.SelectedPrize);
            }
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
                    if (userBL.SelectedUser != null && userBL.GetDataSource().Contains(userBL.SelectedUser))
                    {
                        userInformationPanel.Visible = true;
                    }
                    userButtonPanel.Visible = true;
                    break;
                case "Prizes":
                    userInformationPanel.Visible = false;
                    userButtonPanel.Visible = false;
                    if (prizeBL.SelectedPrize != null && prizeBL.GetDataSource().Contains(prizeBL.SelectedPrize))
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
            userBL.SelectedUser = (User)userDataView.Rows[rowIndex].DataBoundItem;
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
            prizeBL.SelectedPrize = (Prize)prizeDataView.Rows[rowIndex].DataBoundItem;
        }

        private void SetPriseInfoLabelText(Prize selectedPrize)
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

        private void OrderByCollumnHandler(object sender, DataGridViewCellMouseEventArgs e)
        {
            var collumnName = ((DataGridView)sender).Columns[e.ColumnIndex].Name;
            switch (tabControl.SelectedIndex)
            {
                case 0:                    
                    userBL.SortByProperty(collumnName);
                    break;
                case 1:
                    prizeBL.SortByProperty(collumnName);
                    break;
                default:
                    break;
            }
            ResetSelectedItems();
            //var collumnName = ((DataGridView)sender).Columns[e.ColumnIndex].Name;
            //var arg = new object[1] { collumnName };
            //var sourceType = ((DataGridView)sender).DataSource.GetType();
            //var methodInfo = sourceType.GetMethod("SortItemsByProperty");
            //foreach (var source in DataController.SourceList)
            //{
            //    if (sourceType.Equals(source.GetType()))
            //    {
            //        methodInfo.Invoke(source, arg);
            //    }
            //}

            //ResetSelectedItems();
        }
    }
}
