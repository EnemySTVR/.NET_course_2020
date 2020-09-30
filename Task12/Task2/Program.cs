using System;
using System.Text;

namespace Task2
{
    
    class Program
    {
        private static bool isExit = false;

        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                ReadArgs(args);
            }
            else
            {
                Console.WriteLine("Task2 commands.\n" +

                    "Information:\n" +
                    "\t-i\n" +
                    "\t--info\n" +
                    "Start observ file changes:\n" +
                    "\t-obs @folder_path\n" +
                    "\t--observ @folder_path\n" +
                    "Back up to:\n" +
                    "\t-b @date_time\n" +
                    "\t--backup @date_time\n" +
                    "Stop observ:\n" +
                    "\t-s\n" +
                    "\t--stop\n" +
                    "Exit:\n" +
                    "\t-e\n" +
                    "\t--exit");

                do
                {
                    string userInput = Console.ReadLine();
                    string[] arguments = userInput.Split();
                    ReadArgs(arguments);
                }
                while (isExit == false);

                DataController.StopObserv();
            }
        }

        private static void ReadArgs(string[] args)
        {
            switch (args[0])
            {
                case "-i":
                case "--info":
                    Console.WriteLine("" +
                        "Information:\n" +
                        "\t-i\n" +
                        "\t--info\n" +
                        "Start observ file changes:\n" +
                        "\t-obs @folder_path\n" +
                        "\t--observ @folder_path\n" +
                        "Back up to:\n" +
                        "\t-b @date_time\n" +
                        "\t--backup @date_time" +
                        "Stop observ:\n" +
                        "\t-s\n" +
                        "\t--stop\n" +
                        "Exit:\n" +
                        "\t-e\n" +
                        "\t--exit");
                    break;
                case "-obs":
                case "--observ":
                    DataController.StartObserv(args[1]);
                    break;
                case "-b":
                case "--backup":
                    var secondArg = new StringBuilder();
                    for (int i = 1; i < args.Length; i++)
                    {
                        secondArg.Append(args[i] + " ");
                    }
                    DataController.BackUpTo(secondArg.ToString());
                    break;
                case "-s":
                case "--stop":
                    DataController.StopObserv();
                    break;
                case "-e":
                case "--exit":
                    isExit = true;
                    break;
                default:
                    {
                        Console.WriteLine("Invalid argument!");
                    }
                    break;
            }
        }
    }
}
