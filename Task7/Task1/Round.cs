using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Round : Figure
    {
        private int _xRadius;
        private int _yRadius;
        private int _middleRadius;
        public double Perimeter
        {
            get
            {
                return 2 * Math.PI * _middleRadius;
            }
        }
        public double Area
        {
            get
            {
                return Math.Pow(_middleRadius, 2) * Math.PI;
            }
        }
        public Round(int x, int y, int xRadius, int yRadius) 
            :base(x, y)
        {
            _xRadius = xRadius;
            _yRadius = yRadius;
            _middleRadius = (xRadius + yRadius) / 2;
        }

        public override void Draw()
        {
            Console.WriteLine
                ($"Не правильная окружность с радиусом по оси X {_xRadius} и радиусом по оси Y {_yRadius}. Находится по координатам {_coordinates}.");
        }
    }
}
