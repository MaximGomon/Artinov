using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;

namespace StartFithFileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                DisplayCurrentDirectory();

                Console.Write("Please enter path to file (include extension):");
                string userPath = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("For exit press \'x\'");
                List<string> userLines = new List<string>();
                bool isFinishEnterText = false;
                while (!isFinishEnterText)
                {
                    string userText = Console.ReadLine().Trim();
                    if (userText.Length == 1 &&
                        string.Equals(userText[0].ToString(), "x",
                            StringComparison.CurrentCultureIgnoreCase))
                    {
                        isFinishEnterText = true;
                    }
                    else
                    {
                        userLines.Add(userText);
                    }
                }

                bool isFileExist = File.Exists(userPath);
                if (!isFileExist)
                {
                    DisplayError("File doesn`t exist, program will be created them!");
                }

                //File.AppendAllLines(userPath, userLines);
                CreateFile(userPath, userLines);
                //DisplaySplitPathDyStep(userPath);

                if (!isFileExist)
                {
                    Console.WriteLine();
                    string fileName = userPath.Substring(userPath.LastIndexOf('\\') + 1);
                    Console.WriteLine($"File {fileName} created!");
                }
            }
            catch (SecurityException ex)
            {
                DisplayError(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                DisplayError(ex.Message);

            }
            catch (DirectoryNotFoundException ex)
            {
                DisplayError("Some directory in path are not found or not exists!");
            }
            catch (Exception ex)
            {
               DisplayError(ex.ToString());
            }
            Console.ReadLine();
        }

        private static void CreateFile(string path, List<string> text)
        {
            string directoryPath = path.Substring(0, path.LastIndexOf('\\'));
            List<string> splitPath = directoryPath.Split('\\').ToList();
            string fullPath = String.Empty;
            

            for (int i = 0; i < splitPath.Count; i++)
            {
                fullPath += $"{splitPath[i]}";
                if (!Directory.Exists(fullPath))
                {
                    Directory.CreateDirectory(fullPath);
                }
                fullPath += '\\';
                Console.WriteLine(fullPath);
            }
           

            File.AppendAllLines($"{fullPath}{path.Substring(path.LastIndexOf('\\'))}", text);
        }

        private static string GetSimpleUserText()
        {
            Console.WriteLine("Please enter text for file:");
            string userText = Console.ReadLine();
            return userText;
        }

        private static void DisplaySplitPathDyStep(string userPath)
        {
            Console.WriteLine(new string('*', 30));
            Console.WriteLine(userPath);
            Console.WriteLine(userPath.LastIndexOf('\\'));
            Console.WriteLine(userPath[userPath.LastIndexOf('\\')]);
            Console.WriteLine(userPath[userPath.LastIndexOf('\\') + 1]);
            Console.WriteLine(userPath.Substring(userPath.LastIndexOf('\\') + 1));
            Console.WriteLine(new string('*', 30));
        }

        private static void DisplayCurrentDirectory()
        {
            string currentPath = Directory.GetCurrentDirectory();
            Console.WriteLine($"{currentPath}>");
        }

        private static void DisplayError(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
