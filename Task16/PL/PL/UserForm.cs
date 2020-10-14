using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PL
{
    public partial class UserForm : Form
    {
        UserBL userBL;

        public UserForm(UserBL userBL, ICollection<PrizeVO> prizes, bool isNewUser)
        {
            InitializeComponent();
            this.userBL = userBL;
            newUserBirthDatePicker.MinDate = DateTime.Now.AddYears(-150);
            newUserBirthDatePicker.MaxDate = DateTime.Now;

            if (isNewUser)
            {
                Text = "Add user";
                newUserAcceptButton.Text = "Add";
                newUserAcceptButton.Click += AddUserButtonClick;

                newUserPrizesCheckedBox.Items.AddRange(prizes.ToArray());
            }
            else
            {
                Text = "Change user";
                newUserAcceptButton.Text = "Change";
                newUserAcceptButton.Click += ChangeUserButtonClick;

                newUserFirstNameTextBox.Text = userBL.SelectedUser.FirstName;
                newUserLastNameTextBox.Text = userBL.SelectedUser.LastName;
                newUserBirthDatePicker.Value = userBL.SelectedUser.BirthDate;
                newUserPrizesCheckedBox.Items.AddRange(prizes.ToArray());
                for (int i = 0; i < newUserPrizesCheckedBox.Items.Count; i++)
                {
                    if (userBL.SelectedUser.Prizes.Contains(newUserPrizesCheckedBox.Items[i]))
                    {
                        newUserPrizesCheckedBox.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void AddUserButtonClick(object sender, EventArgs e)
        {
            string firstName = newUserFirstNameTextBox.Text;
            string lastName = newUserLastNameTextBox.Text;
            DateTime birthDate = newUserBirthDatePicker.Value;
            var prizes = new List<PrizeVO>();
            foreach (var prize in newUserPrizesCheckedBox.CheckedItems)
            {
                prizes.Add(prize as PrizeVO);
            }
            userBL.Add(firstName, lastName, birthDate, prizes);
        }
        private void ChangeUserButtonClick(object sender, EventArgs e)
        {
            string firstName = newUserFirstNameTextBox.Text;
            string lastName = newUserLastNameTextBox.Text;
            DateTime birthDate = newUserBirthDatePicker.Value;
            var prizes = new List<PrizeVO>();
            foreach (var prize in newUserPrizesCheckedBox.CheckedItems)
            {
                prizes.Add(prize as PrizeVO);
            }
            userBL.ChangeSelectedUser(firstName, lastName, birthDate, prizes);
        }
    }
}
