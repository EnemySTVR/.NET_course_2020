using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Task1
{
    class Line : Figure
    {
        private Point _point_A;
        private Point _point_B;

        public Point ACoordinates
        {
            get
            {
                return _point_A;
            }
        }
        public Point BCoordinates
        {
            get
            {
                return _point_B;
            }
        }

        public Line(int a_x, int a_y, int b_x, int b_y)
        {
            int x = (a_x + b_x) / 2;
            int y = (a_y + b_y) / 2;

            _coordinates = new Point(x, y);
            _point_A = new Point(a_x, a_y);
            _point_B = new Point(b_x, b_y);
        }

        public override void Draw()
        {
            Console.WriteLine($"Линия от {_point_A} до {_point_B}. Находится по координатам {_coordinates}");
        }
    }
}
