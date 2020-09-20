using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Triangle
    {
        private int _a;
        private int _b;
        private int _c;

        public Triangle(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double GetArea()
        {
            double halfPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - _a) * (halfPerimeter - _b) * (halfPerimeter - _c));
        }
        public double GetPerimeter()
        {
            return _a + _b + _c;
        }
        public override string ToString()
        {
            return $"Треугольник со сторонами {_a}, {_b} и {_c}";
        }
    }
}
