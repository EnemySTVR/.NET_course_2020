using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
			ISeries progression = new ArithmeticalProgression(0, 2);
			Console.WriteLine("Progression:");
			PrintSeries(progression);
			GetObjectOfIndex(progression as IIndexable, 4);


			ISeries list = new List(new double[] { 5, 8, 6, 3, 1 });
			Console.WriteLine("List:");
			PrintSeries(list);
			GetObjectOfIndex(list as IIndexable, 3);
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

		static void GetObjectOfIndex(IIndexable collection, int index)
        {
            try
            {

                Console.WriteLine($"Объект в <{collection.ToString()}> с индексом {index}: {collection[index]}");
			}
			catch (IndexOutOfRangeException e)
			{
                Console.WriteLine(e.Message);
			}
		}
	}
}
