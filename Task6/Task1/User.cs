using System;

namespace Task1
{
    class User
    {
        private string _first_name;
        private string _last_name;
        private string _sur_name;
        private int _age;
        private DateTime _birth;

        public User(string first_name, string last_name, string sur_name, DateTime birth)
        {
            _first_name = first_name;
            _last_name = last_name;
            _sur_name = sur_name;
            _age = DateTime.Now.Year - birth.Year;
            if(DateTime.Now.DayOfYear < birth.DayOfYear)
            {
                _age--;
            }
            _birth = birth;
        }

        public string FirstName 
        { 
            get
            {
                return _first_name;
            } 
        }
        public string LastName
        {
            get
            {
                return _last_name;
            }
        }
        public string SurName
        {
            get
            {
                return _sur_name;
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
