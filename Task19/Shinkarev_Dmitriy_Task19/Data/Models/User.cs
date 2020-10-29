using System;
using System.Collections.Generic;

namespace Shinkarev_Dmitriy_Task19.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age
        {
            get
            {
                if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
                {
                    return DateTime.Now.Year - BirthDate.Year - 1;
                }
                else
                {
                    return DateTime.Now.Year - BirthDate.Year;
                }
            }
        }

        public List<Reward> Rewards { get; set; }
    }
}
