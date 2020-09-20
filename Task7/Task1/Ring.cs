using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Ring : Figure
    {
        private CorrectRound _interiorRound;
        private CorrectRound _externalRound;

        public int InteriorRadius
        {
            get
            {
                return _interiorRound.Radius;
            }
        }
        public int ExternalRadius
        {
            get
            {
                return _externalRound.Radius;
            }
        }
        public double Perimeter
        {
            get
            {
                return _externalRound.Perimeter + _interiorRound.Perimeter;
            }
        }
        public double Area
        {
            get
            {
                return _externalRound.Area - _interiorRound.Area;
            }
        }

        public Ring(int xCoordinates, int yCoordinates, int externalRadius, int interiorRadius)
            : base(xCoordinates, yCoordinates)
        {
            _interiorRound = new CorrectRound(xCoordinates, yCoordinates, interiorRadius);
            _externalRound = new CorrectRound(xCoordinates, yCoordinates, externalRadius);
        }

        public override void Draw()
        {
            Console.WriteLine
                ($"Кольцо с внешним радиусом {_externalRound.Radius} и внутренним радиусом {_interiorRound.Radius}. Находится по координатам {_coordinates}.");
        }
    }
}
