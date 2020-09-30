using System;
using System.Diagnostics.CodeAnalysis;

namespace Task1
{
    class Employee : User, IEquatable<Employee>
    {
        private DateTime _dateOfMake;
        /// <summary>
        /// Returns the number of years of work.
        /// </summary>
        public int LengthOfWork
        { 
            get
            {
                var result = DateTime.Now.Year - _dateOfMake.Year;
                if (DateTime.Now.DayOfYear < _dateOfMake.DayOfYear)
                {
                    result--;
                }
                return result;
            }
        }
        public string Position { get; set; }
        
        public Employee(string position, string firstName, string lastName, string surName, DateTime birth) 
            : base(firstName, lastName, surName, birth)
        {
            Position = position;
            _dateOfMake = DateTime.Now;
        }

        public bool Equals([AllowNull] Employee other)
        {
            if (Position.Equals(other.Position) &&
                FirstName.Equals(other.FirstName) &&
                LastName.Equals(other.LastName) &&
                SurName.Equals(other.SurName) &&
                DateOfBirth.Equals(other.DateOfBirth))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
