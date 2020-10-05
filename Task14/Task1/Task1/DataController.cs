using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Text;

namespace Task1
{
    static public class DataController
    {
        private static BindingList<User> _users = new BindingList<User>();
        private static BindingList<Prize> _prizes = new BindingList<Prize>();

        public static BindingList<User> Users { get => _users; }
        public static BindingList<Prize> Prizes { get => _prizes; }

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
    }
}
