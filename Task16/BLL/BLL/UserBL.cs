using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BLL
{
    public class UserBL
    {
        private UserDAO userDAO;
        public UserVO SelectedUser { get; set; }
        private List<UserVO> _users;

        public UserBL()
        {
            userDAO = new UserDAO();
            _users = userDAO.GetDataSource().ToList();
        }
        public DataView GetDataSource()
        {
            return TablesManager.CreateDataView(_users);
        }

        public void Add(string firstName, string lastName, DateTime birthDate, List<PrizeVO> prizes)
        {
            var newUser = new UserVO(firstName, lastName, birthDate, prizes);
            userDAO.AddAndSetId(newUser);
            _users.Add(newUser);
            SelectedUser = newUser;
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
            foreach (var prize in prizes)
            {
                if (!SelectedUser.Prizes.Contains(prize))
                {
                    userDAO.AddRevard(SelectedUser, prize);
                }
            }
            foreach (var prize in SelectedUser.Prizes)
            {
                if (!prizes.Contains(prize))
                {
                    userDAO.RemoveRevardLink(SelectedUser, prize);
                }
            }
            var newUser = new UserVO(SelectedUser.Id, firstName, lastName, birthDate, prizes);
            userDAO.ChangeUser(SelectedUser, firstName, lastName, birthDate);
            int index = _users.IndexOf(SelectedUser);
            _users.Remove(SelectedUser);
            _users.Insert(index, newUser);

        }

        public void RevardSelectedUser(PrizeVO prize)
        {
            SelectedUser.AddPrize(prize);
            userDAO.AddRevard(SelectedUser, prize);
        }

        public void DeleteRevardFromSelectedUser(PrizeVO prize)
        {
            SelectedUser.RemovePrize(prize);
            userDAO.AddRevard(SelectedUser, prize);
        }

        public void SetSelectedItemById(int id)
        {
            var temp = _users.Where(x => x.Id == id);
            if (temp.Count() > 0)
            {
                SelectedUser = temp.First();
            }
        }
    }
}
