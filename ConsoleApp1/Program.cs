using System;
using System.IO;

namespace FileCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\Sample";
            string userfile = Console.ReadLine();
            string fullfilepath = $@"{rootDirectory}\{userfile}.txt";

            bool directoryexists = Directory.Exists(rootDirectory);
            bool fileexists = File.Exists(fullfilepath);

            if (directoryexists && fileexists)
            {
                Console.WriteLine($"{userfile} aready exists in {rootDirectory}.");
            }

            else if (!directoryexists)
            {
                Console.WriteLine($"{rootDirectory} does not exist.");
                Directory.CreateDirectory(rootDirectory);
                Console.WriteLine($"{rootDirectory} has been created.");
                File.Create(fullfilepath);
                Console.WriteLine($"{userfile}.txt has been created in {rootDirectory}.");
            }

            else
            {
                File.Create(fullfilepath);
                Console.WriteLine($"{userfile}.txt has been created in {rootDirectory}.");

            }



        }
    }
}
