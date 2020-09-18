using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Task1
{
    class CorrectRound : Figure
    {
        private int _radius;

        public int Radius
        {
            get
            {
                return _radius;
            }
        }
        public double Perimeter
        {
            get
            {
                return 2 * Math.PI * _radius;
            }
        }
        public double Area
        {
            get
            {
                return Math.Pow(_radius, 2) * Math.PI;
            }
        }

        public CorrectRound(int x, int y, int r)
            :base(x ,y)
        {
            _radius = r;
        }

        public override void Draw()
        {
            Console.WriteLine($"Правильная окружность с радиусом {_radius}. Находится по координатам {_coordinates}.");
        }
    }
}
