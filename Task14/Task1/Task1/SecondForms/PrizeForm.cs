using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Task1.SecondForms
{
    public partial class PrizeForm : Form
    {
        Prize _changedPrize;

        public PrizeForm()
        {
            InitializeComponent();
            Text = "Add prize";
            newPrizeAcceptButton.Text = "Add";
            newPrizeAcceptButton.Click += AddPrizeButtonClick;
        }

        public PrizeForm(Prize changedPrize)
        {
            InitializeComponent();
            Text = "Change prize";
            newPrizeAcceptButton.Text = "Change";
            newPrizeAcceptButton.Click += ChangePrizeButtonClick;
            _changedPrize = changedPrize;
            newPrizeNameTextBox.Text = changedPrize.Name;
            newPrizeDescriptionTextBox.Text = changedPrize.Description;
        }

        private void AddPrizeButtonClick(object sender, EventArgs e)
        {
            var prize = new Prize(newPrizeNameTextBox.Text, newPrizeDescriptionTextBox.Text);
            DataController.Prizes.Add(prize);
        }

        private void ChangePrizeButtonClick(object sender, EventArgs e)
        {
            int index = DataController.Prizes.IndexOf(_changedPrize);
            DataController.Prizes[index].ChangeName(newPrizeNameTextBox.Text);
            DataController.Prizes[index].ChangeDescription(newPrizeDescriptionTextBox.Text);

        }
    }
}
