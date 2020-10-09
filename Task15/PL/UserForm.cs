using BLL;
using Entities;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PL
{
    public partial class UserForm : Form
    {
        UserBL userBL;
        PrizeBL prizeBL;

        public UserForm(UserBL userBL, PrizeBL prizeBL, bool isNewUser)
        {
            InitializeComponent();
            this.userBL = userBL;
            this.prizeBL = prizeBL;
            newUserBirthDatePicker.MinDate = DateTime.Now.AddYears(-150);
            newUserBirthDatePicker.MaxDate = DateTime.Now;

            if (isNewUser)
            {
                Text = "Add user";
                newUserAcceptButton.Text = "Add";
                newUserAcceptButton.Click += AddUserButtonClick;

                newUserPrizesCheckedBox.Items.AddRange(prizeBL.GetDataSource().ToArray());
            }
            else
            {
                Text = "Change user";
                newUserAcceptButton.Text = "Change";
                newUserAcceptButton.Click += ChangeUserButtonClick;

                newUserFirstNameTextBox.Text = userBL.SelectedUser.FirstName;
                newUserLastNameTextBox.Text = userBL.SelectedUser.LastName;
                newUserBirthDatePicker.Value = userBL.SelectedUser.BirthDate;
                newUserPrizesCheckedBox.Items.AddRange(prizeBL.GetDataSource().ToArray());
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
            var prizes = new List<Prize>();
            foreach (var prize in newUserPrizesCheckedBox.CheckedItems)
            {
                prizes.Add(prize as Prize);
            }
            userBL.Add(firstName, lastName, birthDate, prizes);
        }
        private void ChangeUserButtonClick(object sender, EventArgs e)
        {
            string firstName = newUserFirstNameTextBox.Text;
            string lastName = newUserLastNameTextBox.Text;
            DateTime birthDate = newUserBirthDatePicker.Value;
            var prizes = new List<Prize>();
            foreach (var prize in newUserPrizesCheckedBox.CheckedItems)
            {
                prizes.Add(prize as Prize);
            }
            userBL.ChangeSelectedUser(firstName, lastName, birthDate, prizes);
        }
    }
}
