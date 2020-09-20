using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class User
    {
        private string _firstName;
        private string _lastName;
        private string _surName;
        private int _age;
        private DateTime _birth;

        public User(string firstName, string lastName, string surName, DateTime birth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _surName = surName;
            _age = DateTime.Now.Year - birth.Year;
            if (DateTime.Now.DayOfYear < birth.DayOfYear)
            {
                _age--;
            }
            _birth = birth;
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
        }
        public string SurName
        {
            get
            {
                return _surName;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
        }
        public DateTime Date_of_Birth
        {
            get
            {
                return _birth;
            }
        }
    }
}
