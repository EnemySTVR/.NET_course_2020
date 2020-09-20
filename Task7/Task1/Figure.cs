using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Task1
{
    abstract class Figure
    {
        protected Point _coordinates;
        public Point Coordinates { get; }
        
        public Figure()
        { }
        public Figure(int xCoordinates, int yCoordinates)
        {
            _coordinates = new Point(xCoordinates, yCoordinates);
        }

        public virtual void Draw()
        { }
    }
}
