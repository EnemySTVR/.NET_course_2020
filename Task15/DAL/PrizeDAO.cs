using Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DAL
{
    public class PrizeDAO
    {
        private static SelfSortingBindingList<Prize> _prizes = new SelfSortingBindingList<Prize>();

        public PrizeDAO()
        {
            var p1 = new Prize(1, "nobel", "shnobel");
            var p2 = new Prize(2, "klassniy", "perviy paren na sele");
            _prizes.Add(p1);
            _prizes.Add(p2);
        }

        public ReadOnlyCollection<Prize> GetDataSource()
        {
            return new ReadOnlyCollection<Prize>(_prizes);
        }

        public void Add(Prize prize)
        {
            _prizes.Add(prize);
            UserDAO.RemovePrizeFromUsers(prize);
        }

        public void Remove(Prize prize)
        {
            _prizes.Remove(prize);
            
        }

        public void ChangePrize(Prize oldPrize, Prize newPrize)
        {
            int index = _prizes.IndexOf(oldPrize);
            _prizes.Remove(oldPrize);
            _prizes.Insert(index, newPrize);
        }

        public static Prize SearchPrizeByName(string name)
        {
            foreach (var prize in _prizes)
            {
                if (name.Equals((prize).Name))
                {
                    return prize;
                }
            }
            return null;
        }

        public void SortByProperty(string propertyName)
        {
            _prizes.SortItemsByProperty(propertyName);
        }
    }
}
