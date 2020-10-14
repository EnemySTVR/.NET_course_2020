using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task.SecondForms
{
    public partial class RevardForm : Form
    {
        User _selectedUser;
        List<Prize> availablePrizes;
        public RevardForm(User user)
        {
            InitializeComponent();
            availablePrizes = new List<Prize>(DataController.Prizes);
            foreach (var prize in user.Prizes)
            {
                availablePrizes.Remove(prize);
            }
            if (availablePrizes.Count > 0)
            {
                choosePrizeComboBox.DataSource = availablePrizes;
            }
            else
            {
                newPrizeDescriptionLabel.Text = "This user has already received all available rewards.";
                revardAcceptButton.Enabled = false;
            }


            _selectedUser = user;
        }

        private void ChangeComboBoxItem(object sender, EventArgs e)
        {
            int itemIndex = choosePrizeComboBox.SelectedIndex;
            newPrizeDescriptionLabel.Text = availablePrizes[itemIndex].Description;
        }

        private void RevardUserButtonClick(object sender, EventArgs e)
        {
            int userIndex = DataController.Users.IndexOf(_selectedUser);
            var prize = availablePrizes[choosePrizeComboBox.SelectedIndex];
            DataController.Users[userIndex].AddPrize(prize);
        }
    }
}
