using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    static class ConsoleIO
    {
        public static void WriteLine(string s)
        {
            Console.WriteLine(s);
        }
        public static void WriteLine(object o)
        {
            Console.WriteLine(o);
        }

        public static void Write(string s)
        {
            Console.Write(s);
        }

        public static void Write(object o)
        {
            Console.Write(o);
        }

        public static void WriteCollection(params string[] collection)
        {
            WriteCollection((IEnumerable<string>)collection);
        }

        public static void WriteCollection(params object[] collection)
        {
            WriteCollection((IEnumerable<object>)collection);
        }

        public static void WriteCollection(IEnumerable<string> collection)
        {
            WriteCollection(collection, Environment.NewLine);
        }

        public static void WriteCollection(IEnumerable<string> collection, string delimiter)
        {
            WriteLine(string.Join(delimiter, collection));
        }

        public static void WriteCollection(IEnumerable<object> collection)
        {
            WriteCollection(collection.Select(o => o.ToString()));
        }

        public static void WriteCollection(IEnumerable<object> collection, string delimiter)
        {
            WriteCollection(collection.Select(o => o.ToString()), delimiter);
        }

        public static string GetString()
        {
            return Console.ReadLine();
        }

        public static void Clear()
        {
            Console.Clear();
        }

        public static void WaitForKeyPress()
        {
            Console.ReadKey(true);
        }

        public static int GetInt(string message = null)
        {
            int returnValue;

            {
                bool isNumber;
                do
                {
                    if (message != null)
                    {
                        Clear();

                        Write(message + ": ");
                    }

                    var valueEntered = GetString();

                    isNumber = int.TryParse(valueEntered, out returnValue);
                } while (!isNumber);
            }

            return returnValue;
        }

        public static bool YesNo(string question)
        {
            ConsoleKeyInfo keyInfo;

            {
                do
                {
                    Console.WriteLine(question + " (y/n): ");

                    keyInfo = Console.ReadKey(true);

                } while (keyInfo.Key != ConsoleKey.Y && keyInfo.Key != ConsoleKey.N);
            }

            WriteLine(keyInfo.KeyChar);

            return keyInfo.Key == ConsoleKey.Y;
        }

        public static bool? YesNoCancel(string question)
        {
            ConsoleKeyInfo keyInfo;

            {
                do
                {
                    Console.WriteLine(question + " (y/n/escape): ");

                    keyInfo = Console.ReadKey(true);

                } while (keyInfo.Key != ConsoleKey.Y && keyInfo.Key != ConsoleKey.N &&
                         keyInfo.Key != ConsoleKey.Escape);
            }

            if (keyInfo.Key == ConsoleKey.Escape)
            {
                WriteLine("Cancelled");
                return null;
            }

            WriteLine(keyInfo.KeyChar);

            return keyInfo.Key == ConsoleKey.Y;
        }
    }
}
