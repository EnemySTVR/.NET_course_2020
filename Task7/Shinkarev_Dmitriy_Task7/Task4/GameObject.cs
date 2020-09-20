using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Task4
{
    abstract class GameObject
    {
        protected Point _coordinates;

        public Point Coordinates { get { return _coordinates; } set { _coordinates = value; } }

        public GameObject(int xCoordinates, int yCoordinates)
        {
        }
    }
}
