using Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DAL
{
    public class PrizeDAO
    {
        private static List<PrizeVO> _prizes = new List<PrizeVO>();

        public PrizeDAO()
        {
            var p1 = new PrizeVO(1, "nobel", "shnobel");
            var p2 = new PrizeVO(2, "klassniy", "perviy paren na sele");
            _prizes.Add(p1);
            _prizes.Add(p2);
        }

        public ReadOnlyCollection<PrizeVO> GetDataSource()
        {
            return new ReadOnlyCollection<PrizeVO>(_prizes);
        }

        public void Add(PrizeVO prize)
        {
            _prizes.Add(prize);
            UserDAO.RemovePrizeFromUsers(prize);
        }

        public void Remove(PrizeVO prize)
        {
            _prizes.Remove(prize);

        }

        public void ChangePrize(PrizeVO oldPrize, PrizeVO newPrize)
        {
            int index = _prizes.IndexOf(oldPrize);
            _prizes.Remove(oldPrize);
            _prizes.Insert(index, newPrize);
        }

        public static PrizeVO SearchPrizeByName(string name)
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
    }
}
