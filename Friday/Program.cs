using System;
using System.IO;

namespace Friday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            string FridayPath = @"C:\Users\opilane\Friday\sampleDirectories.txt";
            string SamplesPath = @"C:\Users\opilane\Samples";

            string[] allDirectories = Directory.GetDirectories(SamplesPath);

            string[] NestedDirectories = Directory.GetDirectories(SamplesPath, "*", SearchOption.AllDirectories);
            ReadArray(NestedDirectories);

            File.WriteAllLines(FridayPath, NestedDirectories);


            

        }
        public static void ReadArray(string[] array)
        {
            foreach(string line in array)
            {
                Console.WriteLine(line);
            }
        }
    }
}
