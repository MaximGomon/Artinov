using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace StartWithReflection
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //GetInfoAboutCurrentAssembly();
            GetInfoAboutAssembly(@"D:\Work\Artinov\StartWithReflection\StartWithReflection\bin\Debug\StartWithReflection.exe");
            Console.ReadLine();
        }

        private static void GetInfoAboutAssembly(string assenblyPath)
        {
            Console.Clear();
            //load assebly by assenblyPath
            Assembly someAssembly = Assembly.LoadFile(assenblyPath);
            //Get info about all DefinedTypes in assembly
            foreach (var definedType in someAssembly.DefinedTypes)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(definedType.Name);
                Console.ForegroundColor = ConsoleColor.Yellow;
                var item = someAssembly.CreateInstance(definedType.FullName);
                Console.WriteLine("Properties:");
                Console.WriteLine(new string('-', 30));
                Console.ForegroundColor = ConsoleColor.Cyan;

                //get all properties of type
                foreach (var propertyInfo in definedType.DeclaredProperties)
                {
                    //create object array for property parameters
                    object[] array = new object[1];
                    //if type of current property is int => write int to object array
                    if (propertyInfo.PropertyType == typeof (int))
                    {
                        array[0] = 1;
                    }
                    //if type of current property is string => write string to object array
                    else if (propertyInfo.PropertyType == typeof(string))
                    {
                        array[0] = "Some text";
                    }
                    //invoke property setter
                    propertyInfo.SetMethod.Invoke(item, array);
                    string propertyDescription = String.Empty;
                    propertyDescription += propertyInfo.PropertyType.Name;
                    propertyDescription += " " + propertyInfo.Name + " {";
                    if (propertyInfo.GetMethod != null)
                    {
                        propertyDescription += "get;";
                    }
                    if (propertyInfo.SetMethod != null)
                    {
                        propertyDescription += "set;";
                    }
                    propertyDescription += "}";
                    Console.WriteLine(propertyDescription);
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Fields:");
                Console.WriteLine(new string('-', 30));
                Console.ForegroundColor = ConsoleColor.Cyan;

                //get all properties of type
                foreach (var propertyInfo in definedType.DeclaredFields)
                {
                    string fieldDescription = String.Empty;
                    fieldDescription += propertyInfo.FieldType.Name + " " + propertyInfo.Name;
                    Console.WriteLine(fieldDescription);
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Methods:");
                Console.WriteLine(new string('-', 30));
                Console.ForegroundColor = ConsoleColor.Cyan;

                List<MethodInfo> methods = definedType.DeclaredMethods
                    .Where(x => !x.IsSpecialName).ToList();
                if (methods.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Type {definedType.FullName} haven`t any methods");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    //Get all methods of current type
                    foreach (var methodInfo in methods)
                    {
                        Console.WriteLine(CreateMethodDeclarationString(methodInfo));
                        if (methodInfo.ReturnType != typeof (void))
                        {
                            //invoke not void method
                            Console.WriteLine(methodInfo.Invoke(item, null));
                        }
                        else
                        {
                            //invoke void method
                            methodInfo.Invoke(item, null);
                        }
                    }
                }
            }
        }

        private static void GetInfoAboutCurrentAssembly(bool isClearScreen = false)
        {
            //Get assembly that currently running
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            //display full name of current assembly
            Console.WriteLine(currentAssembly.FullName);
            //get entry point of current (*.exe) assembly
            MethodInfo mainInfo = currentAssembly.EntryPoint;
            //display method name of entry point 
            Console.WriteLine(mainInfo.Name);
            //display return type name of entry point method
            Console.WriteLine(mainInfo.ReturnType.Name);

            var methodDeclaration = CreateMethodDeclarationString(mainInfo);
            if(isClearScreen)
                Console.Clear();
            //display constructed method declaration
            Console.WriteLine(methodDeclaration);
        }

        private static string CreateMethodDeclarationString(MethodInfo mainInfo)
        {
            string methodDeclaration = String.Empty;
            //check if "mainInfo" method is "private"
            if (mainInfo.IsPrivate)
            {
                methodDeclaration += "private ";
            }
            else if (mainInfo.IsFamily)
            {
                methodDeclaration += "protected ";
            }
            else if(mainInfo.IsPublic)
            {
                methodDeclaration += "public ";
            }
            //check if "mainInfo" method is "static"
            if (mainInfo.IsStatic)
            {
                methodDeclaration += "static ";
            }
            methodDeclaration += mainInfo.ReturnType.Name.ToLower();
            //get real name of "mainInfo" method
            methodDeclaration += " " + mainInfo.Name + "(";
            //get all parameters of "mainInfo" method
            foreach (var parameterInfo in mainInfo.GetParameters())
            {
                //get parameter type name
                methodDeclaration += parameterInfo.ParameterType.Name + " ";
                //get parameer name
                methodDeclaration += parameterInfo.Name;
            }
            methodDeclaration += ")";
            return methodDeclaration;
        }
    }
}
