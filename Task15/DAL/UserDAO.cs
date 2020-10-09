using Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DAL
{
    public class UserDAO
    {
        private static SelfSortingBindingList<User> _users = new SelfSortingBindingList<User>();

        public UserDAO()
        {
            var u1 = new User(3, "petia", "pupkin", DateTime.Now, new List<Prize>());
            var u2 = new User(4, "vasia", "lupin", DateTime.Now, new List<Prize>());
            _users.Add(u1);
            _users.Add(u2);
        }

        public ReadOnlyCollection<User> GetDataSource()
        {
            return new ReadOnlyCollection<User>(_users);
        }
        public void Add(User user)
        {
            _users.Add(user);
        }

        public void Remove(User user)
        {
            _users.Remove(user);
        }

        public void ChangeUser(User oldUser, User newUser)
        {
            int index = _users.IndexOf(oldUser);
            _users.Remove(oldUser);
            _users.Insert(index, newUser);
        }

        public void RevardUser(User user, Prize prize)
        {
            int index = _users.IndexOf(user);
            _users[index].AddPrize(prize);
        }

        public static void RemovePrizeFromUsers(Prize prize)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                _users[i].Prizes.Remove(prize);
            }
        }

        public void SortByProperty(string propertyName)
        {
            _users.SortItemsByProperty(propertyName);
        }
    }
}
