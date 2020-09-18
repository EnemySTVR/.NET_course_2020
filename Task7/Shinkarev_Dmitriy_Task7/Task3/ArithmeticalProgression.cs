using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class ArithmeticalProgression : ISeries, IIndexable
    {
		double start, step;
		int currentIndex;

		public ArithmeticalProgression(double start, double step)
		{
			this.start = start;
			this.step = step;
			currentIndex = 0;
		}

		public double GetCurrent()
		{
			return start + step * currentIndex;
		}

		public bool MoveNext()
		{
			currentIndex++;
			return true;
		}

		public void Reset()
		{
			currentIndex = 0;
		}

        public double this[int index]
        {
            get
            {
                return start + step * (index + 1);
            }
        }

        public override string ToString()
        {
			return "Арифметическая прогрессия";
        }
    }
}
