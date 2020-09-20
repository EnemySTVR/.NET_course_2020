using System;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace Task4
{
    class Program
    {
        delegate void StringSummation (string row, int N);
        delegate void StringBuilderSummation (StringBuilder row, int N);
        static void Main(string[] args)
        {
            // Разница становится ощутимой при N > 1000.
            int N = 1000;
            string row1 = "";
            StringBuilder row2 = new StringBuilder();

            StringSummation stringSummation = StringSummationMethod;
            StringBuilderSummation stringBuilderSummation = StringBuilderSummationMethod;

            ShowExecutionTime(stringSummation, row1, N);
            ShowExecutionTime(stringBuilderSummation, row2, N);

            Console.ReadKey();
        }

        private static void StringSummationMethod(string row, int N)
        {
            for (int i = 0; i < N; i++)
            {
                row += "*";
            }
        }

        private static void StringBuilderSummationMethod(StringBuilder row, int N)
        {
            for (int i = 0; i < N; i++)
            {
                row.Append("*");
            }
        }

        private static void ShowExecutionTime(object senderDelegate, object senderRow, int numberOfRepetitions)
        {
            Stopwatch stopWatch = new Stopwatch();

            switch (senderDelegate)
            {
                case StringSummation stringSummation:
                    var row1 = senderRow as string;
                    stopWatch.Start();

                    stringSummation(row1, numberOfRepetitions);

                    stopWatch.Stop();
                    break;
                case StringBuilderSummation stringBuilderSummation:
                    var row2 = senderRow as StringBuilder;
                    stopWatch.Start();

                    stringBuilderSummation(row2, numberOfRepetitions);

                    stopWatch.Stop();
                    break;
                default:
                    Console.WriteLine("Это узкоспециализированный метод ориентированный на то, что ты точно знаешь, что в него передаёшь.");
                    break;
            }

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format
                (
                    "{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds
                );
            string delegatedMethodName = senderDelegate.GetType().Name;
            Console.WriteLine($"Время исполнения {numberOfRepetitions} сложений {delegatedMethodName}: {elapsedTime}");

        }
    }
}
