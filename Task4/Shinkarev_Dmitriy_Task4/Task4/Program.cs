using System;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace Task4
{
    class Program
    {
        // Разница становится ощутимой при N > 10000.
        delegate void StringSummation (string str, int N);
        delegate void StringBuilderSummation (StringBuilder sb, int N);
        static void Main(string[] args)
        {
            
            int N = 100000;
            string str = "";
            StringBuilder sb = new StringBuilder();

            StringSummation stringSummation = StringSummationMethod;
            StringBuilderSummation stringBuilderSummation = StringBuilderSummationMethod;

            ShowBuildTime(stringSummation, str, N);
            ShowBuildTime(stringBuilderSummation, sb, N);

            Console.ReadKey();
        }

        private static void StringSummationMethod(string str, int N)
        {
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
        }

        private static void StringBuilderSummationMethod(StringBuilder sb, int N)
        {
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
        }

        private static void ShowBuildTime(object sender_delegate, object sender_row, int number_of_repetitions)
        {
            Stopwatch stopWatch = new Stopwatch();
            var delegated_method_name = sender_delegate.GetType().Name;

            switch (delegated_method_name)
            {
                
                case "StringSummation":

                    var ssd = sender_delegate as StringSummation;
                    var str = sender_row as string;
                    stopWatch.Start();

                    ssd(str, number_of_repetitions);

                    stopWatch.Stop();
                    break;

                case "StringBuilderSummation":

                    var sbsd = sender_delegate as StringBuilderSummation;
                    var sb = sender_row as StringBuilder;
                    stopWatch.Start();

                    sbsd(sb, number_of_repetitions);

                    stopWatch.Stop();
                    break;

                default:
                    Console.WriteLine("Это узкоспециализированный метод ориентированный на то, что ты точно знаешь, что в него передаёшь.");
                    break;
            }

            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds);
            Console.WriteLine($"Время исполнения {number_of_repetitions} сложений {delegated_method_name}: " + elapsedTime);

        }
    }
}
