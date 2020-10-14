using BLL;
using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PL
{
    public partial class RevardForm : Form
    {
        // TODO: Реализовать сортировку combo box по вводимому значению.
        List<PrizeVO> availablePrizes;
        UserBL userBL;
        public RevardForm(UserBL userBL, ICollection<PrizeVO> allPrizes)
        {
            InitializeComponent();
            this.userBL = userBL;
            availablePrizes = new List<PrizeVO>();
            foreach (var prize in allPrizes)
            {
                if (!userBL.SelectedUser.Prizes.Contains(prize))
                {
                    availablePrizes.Add(prize);
                }
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

        //private void IsInputChanged(object sender, EventArgs e)
        //{
        //    var input = choosePrizeComboBox.Text;
        //    choosePrizeComboBox.DataSource = availablePrizes.Where(x => x.Name.Contains(input)) as IList;
        //    if (input.Equals(""))
        //    {
        //        choosePrizeComboBox.DataSource = availablePrizes;
        //    }
        //}
    }
}
