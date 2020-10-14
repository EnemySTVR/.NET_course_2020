using DAL;
using Entities;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

namespace BLL
{
    public class PrizeBL
    {
        private PrizeDAO prizeDAO;
        private int idGenerator = 0;
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
            return MakeDataView(_prizes);
        }

        public void Add(string name, string description)
        {
            var newPrize = new PrizeVO(idGenerator, name, description);
            prizeDAO.Add(newPrize);
            _prizes.Add(newPrize);
            SelectedPrize = _prizes.Last();
            idGenerator++;
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
            var newPrize = new PrizeVO(SelectedPrize.Id, name, description);
            prizeDAO.ChangePrize(SelectedPrize, newPrize);
            int index = _prizes.IndexOf(SelectedPrize);
            _prizes.Remove(SelectedPrize);
            _prizes.Insert(index, newPrize);
        }

        public void SetSelectedItemById(int id)
        {
            var temp = _prizes.Where(x => x.Id == id);
            if (temp.Count() > 0)
            {
                SelectedPrize = temp.First();
            }
        }

        private DataView MakeDataView<T>(T list)
            where T : IList
        {

            DataTable table = new DataTable();

            if (list.Count == 0)
            {
                return null;
            }

            var properties = list[0].GetType().GetProperties();
            foreach (var property in properties)
            {
                table.Columns.Add(property.Name, property.PropertyType);
            }

            if (list.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var row = table.NewRow();
                    for (int j = 0; j < properties.Length; j++)
                    {
                        row[properties[j].Name] = properties[j].GetValue(list[i]);
                    }
                    table.Rows.Add(row);
                }
            }
            return new DataView(table);
        }
    }
}
