using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.UI.Models;

namespace cms_linq._3_LinqSorting
{
    public class Exercise
    {
        public static void Start()
        {
            //LinqOrderBy();
            //LinqOrderByDesc();
            //LinqThenBy();
            LinqReverse();
        }

        
        private static void LinqReverse()
        {
            //data stored in the local variable students will gets reverse forever , actual data will not be reversed.
            // Practically , its not possible to reverse the data on the table right, this is also something like that.

            var students = Data.FetchStudents();
            Console.WriteLine("------Before reverse on data-source-----");
            Console.WriteLine();
            foreach (var std in students)
            {
                Console.WriteLine($"{std.FirstName} {std.LastName} {std.StudentId}");
            }
            Console.WriteLine("------After reverse on data-source------");
            Console.WriteLine();
            students.Reverse();
            foreach (var std in students)
            {
                Console.WriteLine($"{std.FirstName} {std.LastName} {std.StudentId}");
            }
            Console.WriteLine("------Rechecking------");
            Console.WriteLine();
            foreach (var std in students)
            {
                Console.WriteLine($"{std.FirstName} {std.LastName} {std.StudentId}");
            }

        }

        //ThenBy() , ThenByDescending()
        private static void LinqThenBy()
        {
            var students = Data.FetchStudents().OrderBy(s => s.StudentId).ThenByDescending(s=>s.FirstName);
            foreach (var std in students)
            {
                Console.WriteLine($"{std.FirstName} {std.LastName} {std.StudentId}");
            }
        }

        private static void LinqOrderByDesc()
        {
            var students = Data.FetchStudents().OrderByDescending(s => s.StudentId);
            foreach (var std in students)
            {
                Console.WriteLine($"{std.FirstName} {std.LastName} {std.StudentId}");
            }
        }

        private static void LinqOrderBy()
        {
            var students = Data.FetchStudents().OrderBy(s => s.LastName);
            foreach (var std in students)
            {
                Console.WriteLine($"{std.FirstName} {std.LastName} {std.StudentId}");
            }
        }
    }
}
