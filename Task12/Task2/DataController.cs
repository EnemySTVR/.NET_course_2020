using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Timers;

namespace Task2
{
    static class DataController
    {
        private static FileSystemWatcher dataWatcher = new FileSystemWatcher();
        // Паттерн вынесен сюда, чтобы удобней было менять. Но менять его не стоит. Рухнет конвертер :)
        private static readonly string folderNamingPattern = "dd-MM-yyyy_H.mm.ss";
        private static string targetFolderPath;
        private static Timer timer = new Timer(1000);
        private static bool isChanged = true;

        public static void StartObserv(string path)
        {
            targetFolderPath = path;

            ArchiveTheChange(null, null);

            

            dataWatcher.Path = targetFolderPath;
            dataWatcher.IncludeSubdirectories = false;

            dataWatcher.Filter = "*.txt";
            dataWatcher.NotifyFilter = NotifyFilters.FileName
                                     | NotifyFilters.LastWrite
                                     | NotifyFilters.Size
                                     | NotifyFilters.LastAccess
                                     | NotifyFilters.DirectoryName;

            dataWatcher.Renamed += Change;
            dataWatcher.Created += Change;
            dataWatcher.Deleted += Change;
            dataWatcher.Changed += Change;
            dataWatcher.EnableRaisingEvents = true;
            timer.Elapsed += ArchiveTheChange;
            timer.Start();
        }

        public static void StopObserv()
        {
            dataWatcher.EnableRaisingEvents = false;
            timer.Stop();
            timer.Elapsed -= ArchiveTheChange;
        }

        public static void BackUpTo(string time)
        {
            var requestedTime = ConvertToDateTime(time);
            
            // Получаем список доступных бэкапов.
            var namesOfBackUps = Directory.GetDirectories(@$"{targetFolderPath}\Archive");
            namesOfBackUps = namesOfBackUps.Select(x => Path.GetFileName(x)).ToArray();
            var timesOfBackUps = ConvertToDateTime(namesOfBackUps);

            // Ищем в списке целевой.
            DateTime targetBackUpTime = DateTime.MinValue;
            foreach (var timeOfBackUp in timesOfBackUps)
            {
                if (requestedTime > timeOfBackUp)
                {
                    targetBackUpTime = timeOfBackUp;
                }
            }
            // Если он есть. :)
            if (targetBackUpTime == DateTime.MinValue)
            {
                Console.WriteLine($"Folder has not backup in {time}");
                return;
            }
            string targetBackUpFolderPath = $@"{targetFolderPath}\Archive\{targetBackUpTime.ToString(folderNamingPattern)}";
            var backUpFiles = Directory.GetFiles(targetBackUpFolderPath);

            // Откатываем целевую папку до бэкапа.
            CleanObservableFolder();
            string createdFile;
            foreach (var file in backUpFiles)
            {
                var name = Path.GetFileName(file);
                createdFile = Path.Combine(targetFolderPath, name);
                File.Copy(file, createdFile);
            }
        }


        private static void ArchiveTheChange(object sender, ElapsedEventArgs e)
        {
            if (isChanged == true)
            {
                var dateTimeOfChange = DateTime.Now.ToString(folderNamingPattern);

                string newArchiveFolderName = @$"{targetFolderPath}\Archive\{dateTimeOfChange}";
                Directory.CreateDirectory(newArchiveFolderName);

                var files = Directory.GetFiles(targetFolderPath);

                string createdFile;
                foreach (var file in files)
                {
                    string name = Path.GetFileName(file);
                    createdFile = Path.Combine(newArchiveFolderName, name);
                    File.Copy(file, createdFile);
                }

                Console.WriteLine($"Back up for {dateTimeOfChange} was saved.");
            }
            isChanged = false;
        }

        private static void Change(object sender, FileSystemEventArgs e)
        {
            isChanged = true;
        }

        private static void CleanObservableFolder()
        {
            var files = Directory.GetFiles(dataWatcher.Path);
            foreach (var file in files)
            {
                File.Delete(file);
            }
        }

        private static DateTime ConvertToDateTime(string str)
        {
            var temp = new string(str);
            temp = temp.Replace('-', ' ');
            temp = temp.Replace('_', ' ');
            temp = temp.Replace('.', ':');
            return DateTime.Parse(temp);
        }

        private static DateTime[] ConvertToDateTime(string[] str)
        {
            var temp = new DateTime[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                temp[i] = ConvertToDateTime(str[i]);
            }
            return temp;
        }
    }
}
