using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Prize
    {
        private static int _idGenerator = 0;
        private int _id;
        private string _name;
        private string _description;

        public int Id { get => _id; }
        public string Name { get => _name; }
        public string Description { get => _description; }

        public Prize(string name, string description)
        {
            _idGenerator++;
            _id = _idGenerator;
            _name = name;
            _description = description;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
