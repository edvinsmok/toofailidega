using System;
using System.IO;

namespace Ül4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a car brand from: BMW, Toyota or Tesla");
            string usercar = Console.ReadLine();
            string rootpath = @"C:\Users\opilane\samples\Sample";
            string fullfilepath = $@"{rootpath}\{usercar}.txt";
            bool exists = File.Exists(fullfilepath);

            if (exists)
            {
                string[] datafromfile = File.ReadAllLines(fullfilepath);
                if (usercar == "BMW" || usercar == "Tesla" || usercar == "Toyota")
                {
                    foreach (string line in datafromfile)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine($"{usercar} doesnt exist :(");
                }
            }
            else
            {
                Console.WriteLine($"{usercar} doesnt exist.");
            }
        }
    }
}
