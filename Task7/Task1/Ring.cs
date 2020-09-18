using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Ring : Figure
    {
        private CorrectRound _interior_round;
        private CorrectRound _external_round;

        public int InteriorRadius
        {
            get
            {
                return _interior_round.Radius;
            }
        }
        public int ExternalRadius
        {
            get
            {
                return _external_round.Radius;
            }
        }
        public double Perimeter
        {
            get
            {
                return _external_round.Perimeter + _interior_round.Perimeter;
            }
        }
        public double Area
        {
            get
            {
                return _external_round.Area - _interior_round.Area;
            }
        }

        public Ring(int x, int y, int external_radius, int interior_radius)
            : base(x, y)
        {
            _interior_round = new CorrectRound(x, y, interior_radius);
            _external_round = new CorrectRound(x, y, external_radius);
        }

        public override void Draw()
        {
            Console.WriteLine($"Кольцо с внешним радиусом {_external_round.Radius} и внутренним радиусом {_interior_round.Radius}. Находится по координатам {_coordinates}.");
        }
    }
}
