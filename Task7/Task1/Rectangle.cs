using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Task1
{
    class Rectangle : Figure
    {
        private int _height;
        private int _width;

        public double Perimeter
        {
            get
            {
                return _height * 2 + _width * 2;
            }
        }
        public double Area
        {
            get
            {
                return _height * _width;
            }
        }

        public Rectangle(int height, int width, int x, int y)
            :base(x, y)
        {
            _height = height;
            _width = width;
        }

        public override void Draw()
        {
            Console.WriteLine($"Прямоугольник со сторонами {_width} и {_height}. Находится по координатам {_coordinates}");
        }
    }
}
