using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Task1
{
    class Cycle
    {
        private List<Human> _list;
        private LinkedList<Human> _linked;

        public Cycle()
        {
            _list = new List<Human>();
        }

        public void Add(Human human)
        {
            _list.Add(human);
        }

        public void ShowElements()
        {
            foreach (var h in _list)
            {
                Console.WriteLine(h);
            }
        }

        public void RemoveEachSecondItemLinked()
        {
             while (_list.Count > 1)
             {
                _list.Add(_list.First());
                _list.Remove(_list.First());
                _list.Remove(_list.First());
             }

        }

        public void RemoveEachSecondItemLinst()
        {
            var temp = new List<Human>();
            if (_list.Count > 1)
            {
                foreach (var h in _linked)
                {
                    if (_list.IndexOf(h) % 2 == 0)
                    {
                        temp.Add(h);
                    }

                }
                _list = temp;

                if (_list.Count % 2 != 0)
                {
                    _list.Add(_list.First());
                    _list.Remove(_list.First());
                }

                RemoveEachSecondItemLinst();
            }
        }

        


    }
}
