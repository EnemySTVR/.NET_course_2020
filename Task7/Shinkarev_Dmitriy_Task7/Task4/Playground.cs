using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Playground
    {
        private int _width, _height;
        private GameObject[,] _playground;

        public GameObject this[int x, int y]
        {
            get
            {
                return _playground[x, y];
            }
            set
            {
                _playground[x, y] = value;
            }
        }

        public int Width { get; }
        public int Height { get; }

        public Playground(int width, int height)
        {
            _playground = new GameObject[width, height];
        }

        public void AddObject(GameObject obj) {  }
        public void RemoveObject(int x, int y) {  }
    }
}
