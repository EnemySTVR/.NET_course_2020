using DAL;
using Entities;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

namespace BLL
{
    public class PrizeBL
    {
        private PrizeDAO prizeDAO;
        public PrizeVO SelectedPrize { get; set; }
        private List<PrizeVO> _prizes;

        public ReadOnlyCollection<PrizeVO> Prizes
        {
            get => new ReadOnlyCollection<PrizeVO>(_prizes);
        }

        public PrizeBL()
        {
            prizeDAO = new PrizeDAO();
            _prizes = new List<PrizeVO>();
            foreach (var prize in prizeDAO.GetDataSource())
            {
                _prizes.Add(prize);
            }
        }

        public DataView GetDataSource()
        {
            return TablesManager.CreateDataView(_prizes);
        }

        public void Add(string name, string description)
        {
            var newPrize = new PrizeVO(name, description);
            prizeDAO.AddAndSetId(newPrize);
            _prizes.Add(newPrize);
            SelectedPrize = newPrize;
        }

        public void RemoveSelectedPrize()
        {
            int index = _prizes.IndexOf(SelectedPrize);
            prizeDAO.Remove(SelectedPrize);
            _prizes.Remove(SelectedPrize);

            if (_prizes.Count == 0)
            {
                SelectedPrize = null;
                return;
            }

            if (index == _prizes.Count)
            {
                index--;
            }
            SelectedPrize = _prizes[index];
        }

        public void ChangeSelectedPrize(string name, string description)
        {
            prizeDAO.ChangePrize(SelectedPrize, name, description);
            int index = _prizes.IndexOf(SelectedPrize);
            int id = SelectedPrize.Id;
            _prizes.Remove(SelectedPrize);
            _prizes.Insert(index, new PrizeVO(id, name, description));
        }

        public void SetSelectedItemById(int id)
        {
            var temp = _prizes.Where(x => x.Id == id);
            if (temp.Count() > 0)
            {
                SelectedPrize = temp.First();
            }
        }
    }
}
