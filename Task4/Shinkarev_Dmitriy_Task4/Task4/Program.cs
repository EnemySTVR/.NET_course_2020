using System;
using System.Diagnostics;
using System.Text;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 100;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < N; i++)
            {
                str += "*";
            }

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds);
            Console.WriteLine($"Время исполнения {N} сложений string: " + elapsedTime);

            Stopwatch stopWatchBuilder = new Stopwatch();
            stopWatchBuilder.Start();

            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }

            stopWatchBuilder.Stop();
            TimeSpan tsBuilder = stopWatchBuilder.Elapsed;

            string elapsedTimeBuilder = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            tsBuilder.Hours, tsBuilder.Minutes, tsBuilder.Seconds,
            tsBuilder.Milliseconds);
            Console.WriteLine($"Время исполнения {N} сложений StringBuilder: " + elapsedTimeBuilder);

            Console.ReadLine();

            // Разница становится ощутимой при N > 10000.
        }
    }
}
