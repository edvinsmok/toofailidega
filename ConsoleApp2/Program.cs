using System;
using System.Collections.Generic;
using System.IO;

namespace Ylesanne3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ToyotaData = @"C:\Users\opilane\samples\Sample\Toyota.txt";
            string BMWData = @"C:\Users\opilane\samples\Sample\Bmw.txt";
            string CarsData = @"C:\Users\opilane\samples\Cars.txt";
            string TeslaData = @"C:\Users\opilane\samples\Sample\Tesla.txt";

            List<string> toyota = new List<string>();
            List<string> bmw = new List<string>();
            List<string> tesla = new List<string>();

            string[] sourceData = File.ReadAllLines(CarsData);

            foreach (string element in sourceData)
            {
                if (element.Contains("Tesla"))
                {
                    tesla.Add(element);

                }
                if (element.Contains("Toyota"))
                {
                    toyota.Add(element);

                }
                if (element.Contains("BMW"))
                {
                    bmw.Add(element);

                }
                File.WriteAllLines(ToyotaData, toyota);
                File.WriteAllLines(BMWData, bmw);
                File.WriteAllLines(TeslaData, tesla);

            }




        }



    }
}
