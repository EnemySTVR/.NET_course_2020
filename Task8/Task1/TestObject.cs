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
    }
}
