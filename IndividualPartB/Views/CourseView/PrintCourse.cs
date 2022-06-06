using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Views.CourseView
{
    /// <summary>
    /// The Print Services to produce information in the console for the Course Entity.
    /// Also 3 more methods for the Project Queries. 
    /// </summary>
    internal class PrintCourse : IPrintData
    {
        public void Print(IEntity entity)
        {
            var course = entity as Course;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"ID",-5}{"Title",-15}{"Stream",-15}{"Type",-15}{"StartDate",-25}{"EndDate"} ");
            Console.ResetColor();
            Console.WriteLine($"{course.ID,-5}{course.Title,-15}{course.Stream,-15}{course.Type,-15}{course.StartDate,-25}{course.EndDate}");
        }

        /// <summary>
        /// Print Service to print All the Courses
        /// </summary>
        /// <param name="courses"></param>
        public void PrintCourses(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"ID",-5}{"Title",-15}{"Stream",-15}{"Type",-15}{"StartDate",-25}{"EndDate"} \n");
            Console.ResetColor();
            foreach (Course course in courses)
            {
                Console.WriteLine($"{course.ID,-5}{course.Title,-15}{course.Stream,-15}{course.Type,-15}{course.StartDate,-25}{course.EndDate}");
            }
        }

        /// <summary>
        /// Print Service for Student per Course Query!
        /// </summary>
        /// <param name="courses"></param>
        public void StudentsPerCourse(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"Tittle",-10}{"Stream",-12}{"Type"}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine($"\n{course.Title,-10} {course.Stream,-10} {course.Type}:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\t\t\t\t\t{"FName:",-10}{"LName:"}\n");
                Console.ResetColor();
                foreach (var student in course.Students)
                {
                    Console.WriteLine($"\t\t\t\t\t{student.FirstName,-10} {student.LastName}");
                }
            }
        }

        /// <summary>
        /// Print Service for the Trainers per Course Query!
        /// </summary>
        /// <param name="courses"></param>
        public void TrainersPerCourse(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"Tittle",-10}{"Stream",-12}{"Type"}");
            Console.ResetColor();
            foreach (var course in courses)
            {

                Console.WriteLine($"\n{course.Title,-10} {course.Stream,-10} {course.Type}:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\t\t\t\t\t{"FName:",-10}{"LName:"}");
                Console.ResetColor();
                foreach (var trainer in course.Trainers)
                {

                    Console.WriteLine($"\t\t\t\t\t{trainer.FirstName,-10} {trainer.LastsName}");
                }
            }
        }

        /// <summary>
        /// Print Service for the Assignment per Studnet Per course Query!
        /// </summary>
        /// <param name="courses"></param>
        public void AssignmentPerStudentPerCourse(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"Tittle",-10}{"Stream",-12}{"Type"}");
            Console.ResetColor();
            foreach (var course in courses)
            {

                Console.WriteLine($"\n{course.Title,-10} {course.Stream,-10} {course.Type}:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\t\t\t\t\t{"FName:",-10}{"LName:"}");
                Console.ResetColor();
                foreach (var student in course.Students)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\n\t\t\t\t\t{student.FirstName,-10} {student.LastName}");
                    Console.ResetColor();
                    foreach (var assignment in course.Assignments)
                    {
                        Console.WriteLine($"\t\t\t\t\t{assignment.Title}");
                    }
                }

            }
        }
    }
}
