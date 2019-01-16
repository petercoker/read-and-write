using System;
using System.IO;

namespace ReadAndWriteDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteForFile();
            ReadForFile();
        }

        public static void WriteForFile()
        {
            StreamWriter writer = new StreamWriter(@"C: \Users\sonol\Downloads\ReadAndWriteDemo\ReadWrite\Demo.txt");
            writer.WriteLine("Hello world");
            writer.Close();
        }

        public static void ReadForFile()
        {
            StreamReader reader = new StreamReader(@"C: \Users\sonol\Downloads\ReadAndWriteDemo\ReadWrite\Demo.txt");
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
        }
    }
}
