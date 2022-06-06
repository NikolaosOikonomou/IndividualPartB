using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Views.AssignmentView
{
    /// <summary>
    /// The Print Services to produce information in the console for the Assignment Entity
    /// </summary>
    internal class PrintAssignment : IPrintData
    {
        public void Print(IEntity entity)
        {
            var assignment = entity as Assignment;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"ID",-15}{"Title",-15}{"Description",-15}{"SubDateTime",-15}{"OralMark",-15}{"TotalMark",-15}{"CourseID"} \n");
            Console.ResetColor();
            Console.WriteLine($"{assignment.ID,-15}{assignment.Title,-15}{assignment.Description,-15}{assignment.SubDateTime,-15}{assignment.OralMark,-15}{assignment.TotalMark,-15}{assignment.CourseID}");
        }

        public void PrintAssignments(List<Assignment> assignments)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"ID",-15}{"Title",-25}{"Description",-15}{"SubDateTime",-15}{"OralMark",-15}{"TotalMark",-15}{"CourseID"} \n");
            Console.ResetColor();
            foreach (Assignment assignment in assignments)
            {
                Console.WriteLine($"{assignment.ID,-15}{assignment.Title,-25}{assignment.Description,-15}{assignment.SubDateTime,-15}{assignment.OralMark,-15}{assignment.TotalMark,-15}{assignment.CourseID}");
            }
        }
    }
}
