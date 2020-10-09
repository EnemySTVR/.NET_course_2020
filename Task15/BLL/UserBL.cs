using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using DAL;
using Entities;

namespace BLL
{
    public class UserBL
    {
        private int idGenegator = 0;
        private UserDAO userDAO;
        public User SelectedUser { get; set; }
        private SelfSortingBindingList<User> _users;

        public UserBL()
        {
            userDAO = new UserDAO();
            _users = new SelfSortingBindingList<User>();
            foreach (var user in userDAO.GetDataSource())
            {
                _users.Add(user);
            }
        }
        public SelfSortingBindingList<User> GetDataSource()
        {
            return _users;
        }

        public void Add(string firstName, string lastName, DateTime birthDate, List<Prize> prizes)
        {
            var newUser = new User(idGenegator, firstName, lastName, birthDate, prizes);
            userDAO.Add(newUser);
            _users.Add(newUser);
            idGenegator++;
        }

        public void RemoveSelectedUser()
        {
            userDAO.Remove(SelectedUser);
            _users.Remove(SelectedUser);
        }

        public void ChangeSelectedUser(string firstName, string lastName, DateTime birthDate, List<Prize> prizes)
        {
            var newUser = new User(SelectedUser.Id, firstName, lastName, birthDate, prizes);
            userDAO.ChangeUser(SelectedUser, newUser);
            int index =_users.IndexOf(SelectedUser);
            _users.Remove(SelectedUser);
            _users.Insert(index, newUser);
        }

        public void RevardSelectedUser(Prize prize)
        {
            SelectedUser.AddPrize(prize);

        }

        public void SortByProperty(string propertyName)
        {
            _users.SortItemsByProperty(propertyName);
            userDAO.SortByProperty(propertyName);
        }
    }
}
