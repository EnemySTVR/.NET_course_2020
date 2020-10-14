using Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DAL
{
    public class UserDAO
    {
        private static List<UserVO> _users = new List<UserVO>();

        public UserDAO()
        {
            var u1 = new UserVO(3, "petia", "pupkin", DateTime.Now, new List<PrizeVO>());
            var u2 = new UserVO(4, "vasia", "lupin", DateTime.Now, new List<PrizeVO>());
            _users.Add(u1);
            _users.Add(u2);
        }

        public ReadOnlyCollection<UserVO> GetDataSource()
        {
            return new ReadOnlyCollection<UserVO>(_users);
        }
        public void Add(UserVO user)
        {
            _users.Add(user);
        }

        public void Remove(UserVO user)
        {
            _users.Remove(user);
        }

        public void ChangeUser(UserVO oldUser, UserVO newUser)
        {
            int index = _users.IndexOf(oldUser);
            _users.Remove(oldUser);
            _users.Insert(index, newUser);
        }

        public void RevardUser(UserVO user, PrizeVO prize)
        {
            int index = _users.IndexOf(user);
            _users[index].AddPrize(prize);
        }

        public static void RemovePrizeFromUsers(PrizeVO prize)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                _users[i].Prizes.Remove(prize);
            }
        }
    }
}
