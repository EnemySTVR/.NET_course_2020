using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using DAL;
using Entities;

namespace BLL
{
    public class PrizeBL
    {
        private int idGenerator = 0;
        private PrizeDAO prizeDAO;
        public Prize SelectedPrize { get; set; }
        public SelfSortingBindingList<Prize> _prizes;

        public PrizeBL()
        {
            prizeDAO = new PrizeDAO();
            _prizes = new SelfSortingBindingList<Prize>();
            foreach (var prize in prizeDAO.GetDataSource())
            {
                _prizes.Add(prize);
            }
        }

        public SelfSortingBindingList<Prize> GetDataSource()
        {
            return _prizes;
        }

        public void Add(string name, string description)
        {
            var newPrize = new Prize(idGenerator, name, description);
            prizeDAO.Add(newPrize);
            _prizes.Add(newPrize);
            idGenerator++;
        }

        public void RemoveSelectedPrize()
        {
            prizeDAO.Remove(SelectedPrize);
            _prizes.Remove(SelectedPrize);
        }

        public void ChangeSelectedPrize(string name, string description)
        {
            var newPrize = new Prize(SelectedPrize.Id, name, description);
            prizeDAO.ChangePrize(SelectedPrize, newPrize);
            int index = _prizes.IndexOf(SelectedPrize);
            _prizes.Remove(SelectedPrize);
            _prizes.Insert(index, newPrize);
        }

        public void SortByProperty(string propertyName)
        {
            _prizes.SortItemsByProperty(propertyName);
            prizeDAO.SortByProperty(propertyName);
        }
    }
}
