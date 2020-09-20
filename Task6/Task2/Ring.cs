using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Ring : Round
    {
        private Round interiorRound;
        public int InteriorRadius
        {
            get
            {
                return interiorRound.Radius;
            }
        }
        public new double Lenght
        {
            get
            {
                return base.Lenght + interiorRound.Lenght;
            }
        }
        public new double Area
        {
            get
            {
                return base.Area - interiorRound.Area;
            }
        }
        public Ring(int xCoordinates, int yCoordinates, int externalRadius, int interiorRadius)
            :base(xCoordinates, yCoordinates, externalRadius)
        {
            interiorRound = new Round(xCoordinates, yCoordinates, interiorRadius);
        }
    }
}
