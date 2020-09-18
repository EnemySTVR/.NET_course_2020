using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Employee : User
    {
        private DateTime _date_of_make;
        /// <summary>
        /// Returns the number of years of work.
        /// </summary>
        public int Length_of_work
        { 
            get
            {
                var result = DateTime.Now.Year - _date_of_make.Year;
                if (DateTime.Now.DayOfYear < _date_of_make.DayOfYear)
                {
                    result--;
                }
                return result;
            }
        }
        public string Position { get; set; }
        
        public Employee(string position, string first_name, string last_name, string sur_name, DateTime birth) 
            : base(first_name, last_name, sur_name, birth)
        {
            Position = position;
            _date_of_make = DateTime.Now;
        }


    }
}
