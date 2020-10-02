using System;

namespace Task1
{
    class User
    {
        private string _firstName;
        private string _lastName;
        private string _surName;
        private DateTime _birth;

        public User(string firstName, string lastName, string surName, DateTime birth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _surName = surName;
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
                if (DateTime.Now.DayOfYear < _birth.DayOfYear)
                {
                    return DateTime.Now.Year - _birth.Year - 1;
                }
                return DateTime.Now.Year - _birth.Year;
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
