using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace StartWithRegedit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            try
            {
                //Get or create registry key with name "MyNewItem"
                var testKey = Registry.CurrentUser.CreateSubKey("MyNewItem");
                //Get registry key with name "MyNewItem" as read-only
                RegistryKey key = Registry.CurrentUser.OpenSubKey("MyNewItem");
                //Set value to registry key
                testKey?.SetValue("MySubKeyValue", "SubKeyValue");
                //Get or create registry key
                var subKey = testKey?.CreateSubKey("SubItem");
                //Set value to registry key
                subKey?.SetValue("SubitemValueName", "This is value");
                //Close registry key
                subKey?.Close();
                //Close registry key
                testKey?.Close();
                Console.WriteLine("Are you want to delete created subItem (y/n)? ");
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                Console.WriteLine();
                if (pressedKey.Key == ConsoleKey.Y)
                {
                    //Delete sub item key from MyNewItem item
                    Registry.CurrentUser.CreateSubKey("MyNewItem")?.DeleteSubKey("SubItem");
                    Console.WriteLine("Sub item deleted");
                }
                else if (pressedKey.Key == ConsoleKey.N)
                {
                    Console.WriteLine("Sub item not deleted");
                }
                else
                {
                    Console.WriteLine("You pressed wrong button and sub item will not be deleted!");
                }
                Console.WriteLine("All OK");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
           
            Console.ReadLine();
        }
    }
}
