using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class TestObject
    {
        public string Name { get; set; }

        
        public override string ToString()
        {
            return $"Hello! This is test object {Name}!";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is TestObject operand))
                return false;

            return Name.Equals(operand.Name);
        }
    }
}
