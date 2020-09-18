using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Task1
{
    class Figure
    {
        protected Point _coordinates;
        public Point Coordinates { get; }
        
        public Figure()
        { }
        public Figure(int x, int y)
        {
            _coordinates = new Point(x, y);
        }

        public virtual void Draw()
        {
            Console.WriteLine(Coordinates);
        }
    }
}
