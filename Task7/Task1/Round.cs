using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Round : Figure
    {
        private int _x_radius;
        private int _y_radius;
        private int _middle_radius;
        public double Perimeter
        {
            get
            {
                return 2 * Math.PI * _middle_radius;
            }
        }
        public double Area
        {
            get
            {
                return Math.Pow(_middle_radius, 2) * Math.PI;
            }
        }
        public Round(int x, int y, int x_radius, int y_radius) 
            :base(x, y)
        {
            _x_radius = x_radius;
            _y_radius = y_radius;
            _middle_radius = (x_radius + y_radius) / 2;
        }

        public override void Draw()
        {
            Console.WriteLine($"Не правильная окружность с радиусом по оси X {_x_radius} и радиусом по оси Y {_y_radius}. Находится по координатам {_coordinates}.");
        }
    }
}
