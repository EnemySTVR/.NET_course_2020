using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class GeometricProgression : ISeries
    {
		double start, step, current;

		public GeometricProgression(double start, double step)
		{
			this.start = start;
			this.step = step;
			current = start;
		}

		public double GetCurrent()
		{
			return current;
		}

		public bool MoveNext()
		{
			current *= step;
			return true;
		}

		public void Reset()
		{
			current = start;
		}
	}
}
