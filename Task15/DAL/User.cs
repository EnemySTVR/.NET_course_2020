using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
    }
}
