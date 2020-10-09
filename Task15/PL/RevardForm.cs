using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PL
{
    public partial class RevardForm : Form
    {
        List<Prize> availablePrizes;
        UserBL userBL;
        public RevardForm(UserBL userBL, IList<Prize> allPrizes)
        {
            InitializeComponent();
            this.userBL = userBL;
            availablePrizes = new List<Prize>(allPrizes);
            foreach (var prize in userBL.SelectedUser.Prizes)
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
        }

        private void ChangeComboBoxItem(object sender, EventArgs e)
        {
            int itemIndex = choosePrizeComboBox.SelectedIndex;
            newPrizeDescriptionLabel.Text = availablePrizes[itemIndex].Description;
        }

        private void RevardUserButtonClick(object sender, EventArgs e)
        {
            var prize = availablePrizes[choosePrizeComboBox.SelectedIndex];
            userBL.RevardSelectedUser(prize);
            
        }
    }
}
