using System;
using System.IO;
using System.Threading;

namespace epam_xt
{
    class FileManager
    {
        FileSystemWatcher watcher;
        private string _allFiles = @"E:\FileStorage";
        private string _logsPath = @"E:\Logs\Logs.txt";
        private string _backupsPath = @"E:\Backups";
        public bool observer = true;
        static object locker = new object();

        public FileManager()
        {
            watcher = new FileSystemWatcher(_allFiles);
            CreateDirectory();
            SelectMode();


            if (observer) 
            {
                watcher.Created += Watcher_Created;
                watcher.Changed += Watcher_Changed;
                watcher.Renamed += Watcher_Renamed;
                watcher.Deleted += Watcher_Deleted;
                watcher.Error += Watcher_Error;
                watcher.Filter = "*.txt";
                watcher.IncludeSubdirectories = true;
            }

            else
            {
                Recovery();
            }
        }

        enum Mode : Int32
        {
            ObserverMode = 1,
            RecoveryMode = 2
        }

        private void SelectMode()
        {
            Console.WriteLine("Select file manager mode:"
                + Environment.NewLine + "1: Observer mode" 
                + Environment.NewLine + "2: Recovery mode");

            Mode mode;
            string input = Console.ReadLine();
            bool check = Enum.TryParse<Mode>(input, out mode);

            if (!check)
            {
                Console.WriteLine("{0} is not a valid mode", input);
            }

            switch (mode)
            {
                case Mode.ObserverMode:
                    Console.WriteLine("You have entered the observer mode.");
                    break;

                case Mode.RecoveryMode:
                    observer = false;
                    Console.WriteLine("You have entered the recovery mode.");
                    break;

                default:
                    break;
            }
        }

        internal void Start()
        {
            watcher.EnableRaisingEvents = true;

            while (observer) { Thread.Sleep(1000); }
        }

        private void Event(string fileEvent, string filePath)
        {
            lock (locker)
            {
                using (StreamWriter writer = new StreamWriter(_logsPath, true))
                {
                    writer.WriteLine(String.Format("{0} file {1} was {2}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"), filePath, fileEvent));
                    writer.Flush();
                }
            }
        }

        private void CopyDirectory(string sourceDirectory, string newDirectory)
        {
            Directory.CreateDirectory(newDirectory);

            foreach (string fileName in Directory.GetFiles(sourceDirectory))
            {
                string newPath = newDirectory + @"\" + Path.GetFileName(fileName);
                File.Copy(fileName, newPath, true);
            }

            foreach (string fileName in Directory.GetDirectories(sourceDirectory))
            {
                CopyDirectory(fileName, newDirectory + @"\" + Path.GetFileName(fileName));
            }
        }

        private void CreateDirectory()
        {
            var currentTime = DateTime.Now.ToString("yyyy.MM.dd_HH-mm-ss");

            var directory = Path.Combine(_backupsPath + currentTime);

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            CopyDirectory(_allFiles, directory);
        }

        private void Recovery()
        {
            //var dataTemplate = "YYYY.MM.DD_HH-MM-SS";

            Console.Write("Enter date for recovery: ");

            var recoveryDate = Console.ReadLine();

            foreach (var file in Directory.GetFiles(_allFiles))
            {
                if (File.Exists(file) & !File.Exists(_backupsPath + recoveryDate))
                {
                    File.Delete(file);
                }
            }

            CopyDirectory(_backupsPath + recoveryDate, _allFiles);
            Console.WriteLine("Recovery was successful");

            Thread.Sleep(2000);
        }

        #region EVENTS

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File: {0} {1}", e.FullPath, e.ChangeType.ToString());

            string fileEvent = "changed";
            string filePath = e.FullPath;

            Event(fileEvent, filePath);
            CopyDirectory(_allFiles, _backupsPath);
        }

        private void Watcher_Error(object sender, ErrorEventArgs e) => GetExceptionType(e.GetException());

        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File {0} has been deleted", e.FullPath);

            string fileEvent = "deleted";
            string filePath = e.FullPath;

            Event(fileEvent, filePath);
            CreateDirectory();
        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("Renamed file from {0} to {1}", e.OldFullPath, e.FullPath);

            string fileEvent = "renamed to " + e.FullPath;
            string filePath = e.OldFullPath;

            Event(fileEvent, filePath);
            CreateDirectory();
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File {0} was created", e.FullPath);

            string fileEvent = "created";
            string filePath = e.FullPath;

            Event(fileEvent, filePath);
            CreateDirectory();
        }

        private void GetExceptionType(Exception ex)
        {
            if(ex != null)
            {
                Console.WriteLine(String.Format("Exception Message: {0}"), ex.Message);

                GetExceptionType(ex.InnerException);
            }
        }

        #endregion
    }
}
