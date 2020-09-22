using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Human
    {
        private string _name;

        public Human(string name)
        {
            _name = name;
        }
        public override string ToString()
        {
            return _name;
        }
    }
}
