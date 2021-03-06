﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Task2
{
    class Round
    {
        private Point _coordinates;
        private int _radius;

        public Point Coordinates
        {
            get
            {
                return _coordinates;
            }
        }
        public int Radius
        {
            get
            {
                return _radius;
            }
        }
        public double Lenght
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

        public Round(int xCoordinates, int yCoordinates, int radius)
        {
            _coordinates = new Point(xCoordinates, yCoordinates);
            _radius = radius;
        }
    }
}
