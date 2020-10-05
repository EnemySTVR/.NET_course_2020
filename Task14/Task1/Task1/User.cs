using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class User
    {
        private static int _idGenerator = 0;
        private int _id;
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private int _age;
        private List<Prize> _userPrizes = new List<Prize>();

        public string Id { get => _id.ToString(); }
        public string FirstName { get => _firstName; }
        public string LastName { get => _lastName; }
        public string BirthDate { get => _birthDate.ToString("dd.MM.yyyy"); }
        public List<Prize> Prizes { get => new List<Prize>(_userPrizes); }
        public string Age
        {
            get
            {
                if (DateTime.Now.DayOfYear < _birthDate.DayOfYear)
                {
                    return ( DateTime.Now.Year - _birthDate.Year - 1).ToString() + " years old";
                }
                else 
                {
                    return (DateTime.Now.Year - _birthDate.Year).ToString() + " years old";
                }
            }
        }

        public User(string firstName, string lastName, DateTime birthDate)
        {
            _idGenerator++;
            _id = _idGenerator;
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
        }

        public void AddPrize(Prize prize)
        {
            _userPrizes.Add(prize);
        }
    }
}
