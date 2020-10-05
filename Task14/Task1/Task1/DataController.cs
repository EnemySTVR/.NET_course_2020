using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Text;

namespace Task1
{
    static public class DataController
    {
        private static SelfSortingBindingList<User> _users = new SelfSortingBindingList<User>();
        private static SelfSortingBindingList<Prize> _prizes = new SelfSortingBindingList<Prize>();

        public static SelfSortingBindingList<User> Users { get => _users; }
        public static SelfSortingBindingList<Prize> Prizes { get => _prizes; }
        public static List<object> SourceList = new List<object>()
        {
            Users,
            Prizes
        };
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
        public static void RemovePrizeFromUsers(Prize prize)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                _users[i].Prizes.Remove(prize);
            }
        }

        
    }
}
