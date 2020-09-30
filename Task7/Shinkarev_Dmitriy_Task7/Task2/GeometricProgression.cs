using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
	class GeometricProgression : ISeries
	{
		double _start;
		double _step;
		double _current;

		public GeometricProgression(double start, double step)
		{
			_start = start;
			_step = step;
			_current = start;
		}

		public double GetCurrent()
		{
			return _current;
		}

		public bool MoveNext()
		{
			_current *= _step;
			return true;
		}

		public void Reset()
		{
			_current = _start;
		}
	}
}
