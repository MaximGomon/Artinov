using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            DisplayMenu();
            bool isExit = false;
            while (!isExit)
            {
                Console.Write($"{Directory.GetCurrentDirectory()}>");
                string command = Console.ReadLine().Trim().ToLower();
                //DirectoryInfo
                //FileInfo
                List<string> splitedCommand = command.Split(' ').ToList();
                
                switch (splitedCommand.First())
                {
                    case "cd..":
                        if (splitedCommand.Count != 1)
                        {
                            DisplayError("You entered wrong parameters for command");
                        }
                        else
                        {
                            InvokeMoveToUpDirectory();
                        }
                        break;
                    case "cd":
                        if (splitedCommand.Count != 2)
                        {
                            DisplayError("You entered wrong parameters for command");
                        }
                        else
                        {
                            InvokeMoveToDirectory(splitedCommand[1]);
                        }
                        break;
                    case "dir":
                        InvokeDir();
                        break;
                    case "help":
                        DisplayMenu();
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    case "exit":
                        isExit = true;
                        break;
                    default:
                        DisplayError("You entered wrong command");
                        break;
                }
                //Ctrl+R+M - Extract method
                //Ctrl+R+R - rename
                //Alt+Enter - call action menu
            }
        }

        private static void InvokeDir()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            List<string> dirList = new List<string>();
            Console.ForegroundColor = ConsoleColor.Green;
            dirList.Add("Folders:");
            GetShortNameFromFullPath(dirList, Directory.GetDirectories(currentDirectory));
            dirList.Add("");
            dirList.Add("Files:");
            GetShortNameFromFullPath(dirList, Directory.GetFiles(currentDirectory), true);

            Console.WriteLine();
            foreach (var item in dirList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        private static void GetShortNameFromFullPath(List<string> dirList, string[] pathElements, bool isFile = false)
        {
            foreach (var item in pathElements)
            {
                string name = String.Empty;
                if (isFile)
                {
                    FileInfo info = new FileInfo(item);
                    name = $"{info.Name} {info.CreationTime.ToString("yyyy-MM-dd hh:mm:sss zzz")}";
                }
                else
                {
                    name = item.Substring(item.LastIndexOf('\\') + 1);
                }
                dirList.Add(name);

            }
        }

        private static void InvokeMoveToDirectory(string directoryName)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string newDirectory = currentDirectory + '\\' + directoryName;
            if (Directory.Exists(newDirectory))
            {
                Directory.SetCurrentDirectory(newDirectory);
            }
            else
            {
                DisplayError($"Directory {directoryName} doesn`t exists");
            }
        }

        private static void InvokeMoveToUpDirectory()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            int indexOfLastFolder = currentDirectory.LastIndexOf('\\');
            string newDirectory = currentDirectory.Substring(0, indexOfLastFolder);
            Directory.SetCurrentDirectory(newDirectory);
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("\'cd <directory name>\' change directory");
            Console.WriteLine("\'cd..\' change directory to up");
            Console.WriteLine("\'dir\' display content of current directory");
            Console.WriteLine("\'exit\' close program");
            Console.WriteLine("\'help\' show info about commands");
            Console.WriteLine("\'clear\' clear console");

            Console.WriteLine(new String('-', 25));
            Console.WriteLine();
        }

        private static void DisplayError(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
