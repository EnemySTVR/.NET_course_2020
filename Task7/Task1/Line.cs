using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Task1
{
    class Line : Figure
    {
        private Point _pointA;
        private Point _pointB;

        public Point A
        {
            get
            {
                return _pointA;
            }
        }
        public Point B
        {
            get
            {
                return _pointB;
            }
        }

        public Line(int aXCoordinates, int aYCoordinates, int bXCoordinates, int bYCoordinates)
        {
            int x = (aXCoordinates + bXCoordinates) / 2;
            int y = (aYCoordinates + bYCoordinates) / 2;

            _coordinates = new Point(x, y);
            _pointA = new Point(aXCoordinates, aYCoordinates);
            _pointB = new Point(bXCoordinates, bYCoordinates);
        }

        public override void Draw()
        {
            Console.WriteLine
                ($"Линия от {_pointA} до {_pointB}. Находится по координатам {_coordinates}");
        }
    }
}
