using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DllImportExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            try
            {
                Console.WriteLine($"Version of Windows is: {GetWindowsVersion()}");
                Console.Write("Please enter disk letter: ");
                string diskLetter = Console.ReadLine().Trim();
                Console.WriteLine(GetDriveType(diskLetter + ":\\"));
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error when try to import Dll Method. {ex.Message}");
            }

            Console.ReadLine();
        }

        [DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi, EntryPoint = "GetVersion", SetLastError = true)]
        static extern IntPtr GetWindowsVersion();

        [DllImport("kernel32.dll")]
        static extern DriveType GetDriveType([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName);
    }
}
