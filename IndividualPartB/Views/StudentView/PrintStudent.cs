using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Views.StudentView
{
    /// <summary>
    /// The Print Services to produce information in the Console for the Student Entity.
    /// </summary>
    internal class PrintStudent : IPrintData
    {
        public void Print(IEntity entity)
        {
            var student = entity as Student;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"ID",-5}{"Firstname",-15}{"Lastname",-15}{"DateOfBirth",-15}{"TuitionFees"} \n ");
            Console.ResetColor();
            Console.WriteLine($"{student.ID,-5}{student.FirstName,-15}{student.LastName,-15}{student.DateOfBirth,-15}{student.TuitionFees}");
        }

        public void PrintStudents(List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"ID",-5}{"Firstname",-15}{"Lastname",-15}{"DateOfBirth",-25}{"TuitionFees"} \n");
            Console.ResetColor();
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.ID,-5}{student.FirstName,-15}{student.LastName,-15}{student.DateOfBirth,-25}{student.TuitionFees}");
            }
        }


    }
}
