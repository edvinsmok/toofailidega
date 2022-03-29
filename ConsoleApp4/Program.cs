using System;
using System.IO;

namespace Chuckjokegenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Facts So Interesting You'll Say, OMG!");
            Console.WriteLine("Choose a joke from 1-25!");
            int usernumber = Convert.ToInt32(Console.ReadLine());

            GetJokes(usernumber);
        }
        private static void GetJokes(int Jokesnumber)
        {
            string filepath = @"C:\Users\opilane\samples\FunFacts.txt";
            string[] jokesaboutChuck = File.ReadAllLines(filepath);

            if (Jokesnumber > jokesaboutChuck.Length)
            {
                Jokesnumber = jokesaboutChuck.Length;
            }

            for (int i = 0; i < Jokesnumber; i++)
            {
                Console.WriteLine(jokesaboutChuck[i]);
            }

        }
    }
}
