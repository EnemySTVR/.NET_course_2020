using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Ring : Round
    {
        private Round interior_round;
        public int InteriorRadius
        {
            get
            {
                return interior_round.Radius;
            }
        }
        public new double Lenght
        {
            get
            {
                return base.Lenght + interior_round.Lenght;
            }
        }
        public new double Area
        {
            get
            {
                return base.Area - interior_round.Area;
            }
        }
        public Ring(int x, int y, int external_radius, int interior_radius)
            :base(x, y, external_radius)
        {
            interior_round = new Round(x, y, interior_radius);

        }
    }
}
