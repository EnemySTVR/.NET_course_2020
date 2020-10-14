using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PL
{
    public partial class PrizeForm : Form
    {
        PrizeBL prizeBL;
        public PrizeForm(PrizeBL prizeBL, bool isNewPrize)
        {
            InitializeComponent();
            this.prizeBL = prizeBL;

            if (isNewPrize)
            {
                Text = "Add prize";
                newPrizeAcceptButton.Text = "Add";
                newPrizeAcceptButton.Click += AddPrizeButtonClick;
            }
            else
            {
                Text = "Change prize";
                newPrizeAcceptButton.Text = "Change";
                newPrizeAcceptButton.Click += ChangePrizeButtonClick;
                newPrizeNameTextBox.Text = prizeBL.SelectedPrize.Name;
                newPrizeDescriptionTextBox.Text = prizeBL.SelectedPrize.Description;
            }
        }

        private void AddPrizeButtonClick(object sender, EventArgs e)
        {
            string name = newPrizeNameTextBox.Text;
            string description = newPrizeDescriptionTextBox.Text;
            prizeBL.Add(name, description);
        }

        private void ChangePrizeButtonClick(object sender, EventArgs e)
        {
            string name = newPrizeNameTextBox.Text;
            string description = newPrizeDescriptionTextBox.Text;
            prizeBL.ChangeSelectedPrize(name, description);
        }
    }
}
