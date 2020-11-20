using System;
using System.Configuration;
using System.IO;
using static StreamsDemo.StreamsExtension;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = ConfigurationManager.AppSettings["sourcePath"];

            var destination = ConfigurationManager.AppSettings["destinationPath"];

            string sourcePath = @"C:\Users\User\Desktop\Test.txt";
            string destinationPath = @"C:\Users\User\Desktop\Test2.txt";

            Console.WriteLine($"ByteCopy() done. Total bytes: {ByByteCopy(sourcePath, destinationPath)}");

            Console.WriteLine($"InMemoryByteCopy() done. Total bytes: {InMemoryByByteCopy(sourcePath, destinationPath)}");

            Console.WriteLine($"ByBlockCopy() done. Total bytes: {ByBlockCopy(sourcePath, destinationPath)}");

            Console.WriteLine($"ByLineCopy() done. Total strings: {ByLineCopy(sourcePath, destinationPath)}");

            Console.WriteLine(IsContentEquals(sourcePath, destinationPath));



            //etc
        }
    }
}
