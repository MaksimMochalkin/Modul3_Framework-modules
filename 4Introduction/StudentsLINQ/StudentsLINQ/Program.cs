using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StudentsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"‪C:\Users\User\source\repos\Modul3_Framework-modules\4Introduction\StudentsLINQ\StudentsLINQ\bin\Debug\netcoreapp3.1\Students.bin";
            var studentsStorage = new StudentStorage();
            var extension = new LINQExtension();

            var grade = extension.ExtractFromTheEvaluationFile(studentsStorage, path, 3);
            foreach (var g in grade)
            {
                Console.WriteLine($"{g}\t");
            }

            var take = extension.TakeRows(studentsStorage, path, 5);
            foreach (var t in take)
            {
                Console.WriteLine($"{t}\t");
            }

            var skip = extension.SkipRows(studentsStorage, path, 5);
            foreach (var s in skip)
            {
                Console.WriteLine($"{s}\t");
            }

            var ascending = extension.OrderByAscending(studentsStorage, path);
            foreach (var a in ascending)
            {
                Console.WriteLine($"{a}\t");
            }
            var descending = extension.OrderByDescending(studentsStorage, path);
            foreach(var d in descending)
            {
                Console.WriteLine($"{d}\t");
            }

            Console.ReadLine();

        }


    }
}
