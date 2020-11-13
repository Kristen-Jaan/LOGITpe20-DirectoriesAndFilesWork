using System;
using System.IO;

namespace FridayFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            string FridayPath = @"C:\Users\opilane\Friday\samplesFiles.txt";
            string SamplesPath = @"C:\Users\opilane\Samples";

            string[] files = Directory.GetFiles(SamplesPath, "*.*", SearchOption.AllDirectories);
            ReadArray(files);
            File.WriteAllLines(FridayPath, files);
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
