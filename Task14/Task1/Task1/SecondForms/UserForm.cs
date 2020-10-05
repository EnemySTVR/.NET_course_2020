using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task1.SecondForms
{
    public partial class UserForm : Form
    {
        User _changedUser;
        public UserForm()
        {
            InitializeComponent();
            Text = "Add user";
            newUserAcceptButton.Text = "Add";
            newUserAcceptButton.Click += AddUserButtonClick;
            newUserPrizesCheckedBox.Items.AddRange(DataController.Prizes.ToArray());
            newUserBirthDatePicker.MinDate = DateTime.Now.AddYears(-150);
            newUserBirthDatePicker.MaxDate = DateTime.Now;

        }

        public UserForm(User changedUser)
        {
            InitializeComponent();
            Text = "Change user";
            newUserAcceptButton.Text = "Change";
            newUserAcceptButton.Click += ChangeUserButtonClick;
            newUserBirthDatePicker.MinDate = DateTime.Now.AddYears(-150);
            newUserBirthDatePicker.MaxDate = DateTime.Now;
            _changedUser = changedUser;
            newUserFirstNameTextBox.Text = changedUser.FirstName;
            newUserLastNameTextBox.Text = changedUser.LastName;
            newUserBirthDatePicker.Value = changedUser.BirthDate;
            newUserPrizesCheckedBox.Items.AddRange(DataController.Prizes.ToArray());
            for (int i = 0; i < newUserPrizesCheckedBox.Items.Count; i++)
            {
                if (changedUser.Prizes.Contains(newUserPrizesCheckedBox.Items[i]))
                {
                    newUserPrizesCheckedBox.SetItemChecked(i, true);
                }
            }
        }

        private void AddUserButtonClick(object sender, EventArgs e)
        {
            var user = new User(newUserFirstNameTextBox.Text, newUserLastNameTextBox.Text, newUserBirthDatePicker.Value);
            foreach (var item in newUserPrizesCheckedBox.CheckedItems)
            {
                var prize = DataController.SearchPrizeByName(item.ToString());
                user.AddPrize(prize);
            }
            DataController.Users.Add(user);
        }
        private void ChangeUserButtonClick(object sender, EventArgs e)
        {
            int index = DataController.Users.IndexOf(_changedUser);
            DataController.Users[index].ChangeFirstName(newUserFirstNameTextBox.Text);
            DataController.Users[index].ChangeLastName(newUserLastNameTextBox.Text);
            DataController.Users[index].ChangeBirthDate(newUserBirthDatePicker.Value);
            DataController.Users[index].Prizes.Clear();
            foreach (var item in newUserPrizesCheckedBox.CheckedItems)
            {
                var prize = DataController.SearchPrizeByName(item.ToString());
                DataController.Users[index].AddPrize(prize);
            }
        }
    }
}
