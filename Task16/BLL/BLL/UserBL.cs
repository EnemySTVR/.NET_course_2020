using DAL;
using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BLL
{
    public class UserBL
    {
        private UserDAO userDAO;
        private int idGenegator = 0;
        public UserVO SelectedUser { get; set; }
        private List<UserVO> _users;

        public UserBL()
        {
            userDAO = new UserDAO();
            _users = new List<UserVO>();
            foreach (var user in userDAO.GetDataSource())
            {
                _users.Add(user);
            }
        }
        public DataView GetDataSource()
        {
            return MakeDataView(_users);
        }

        public void Add(string firstName, string lastName, DateTime birthDate, List<PrizeVO> prizes)
        {
            var newUser = new UserVO(idGenegator, firstName, lastName, birthDate, prizes);
            userDAO.Add(newUser);
            _users.Add(newUser);
            SelectedUser = _users.Last();
            idGenegator++;
        }

        public void RemoveSelectedUser()
        {
            int index = _users.IndexOf(SelectedUser);
            userDAO.Remove(SelectedUser);
            _users.Remove(SelectedUser);

            if (_users.Count == 0)
            {
                SelectedUser = null;
                return;
            }

            if (index == _users.Count)
            {
                index--;
            }
            SelectedUser = _users[index];
        }

        public void ChangeSelectedUser(string firstName, string lastName, DateTime birthDate, List<PrizeVO> prizes)
        {
            var newUser = new UserVO(SelectedUser.Id, firstName, lastName, birthDate, prizes);
            userDAO.ChangeUser(SelectedUser, newUser);
            int index = _users.IndexOf(SelectedUser);
            _users.Remove(SelectedUser);
            _users.Insert(index, newUser);
        }

        public void RevardSelectedUser(PrizeVO prize)
        {
            SelectedUser.AddPrize(prize);
        }

        public void DeleteRevardFromSelectedUser(PrizeVO prize)
        {
            SelectedUser.RemovePrize(prize);
        }

        public void SetSelectedItemById(int id)
        {
            var temp = _users.Where(x => x.Id == id);
            if (temp.Count() > 0)
            {
                SelectedUser = temp.First();
            }
        }

        private DataView MakeDataView<T>(T list)
            where T : IList
        {
            var table = new DataTable();


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
