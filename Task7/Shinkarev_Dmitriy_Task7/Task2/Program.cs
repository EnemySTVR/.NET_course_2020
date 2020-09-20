using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
			var progression = new GeometricProgression(2, 2);
			Console.WriteLine("Geometric Progression:");
			PrintSeries(progression);
		}

		static void PrintSeries(ISeries series)
		{
			series.Reset();
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(series.GetCurrent());
				series.MoveNext();
			}
		}
	}
}
