using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Views.AssignmentView
{
    /// <summary>
    /// In Connection with the Assignment Controller to Delete(GetIdForDelete), Create(GetAssignmentData)
    /// and Edit(GetDataForEdit) data in Assignment Table.
    /// </summary>
    internal class InputAssignment : IInputData
    {
        public int GetIdForDelete()
        {
            Console.WriteLine("Give  the Assignment's Id that you wish to Delete");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }

        public Assignment GetAssignmentData()
        {
            Console.WriteLine("Give Assignment Tittle");
            string tittle = Console.ReadLine();
            Console.WriteLine("Give Assignment Discription");
            string disc = Console.ReadLine();
            Console.WriteLine("Give Assignment submition date");
            DateTime startingDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give the Assignment's Oral Mark");
            int oralMark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the Assignment's Total Mark");
            int totalMark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the Course ID of the Assignment (100-123)");
            int id = Convert.ToInt32(Console.ReadLine());


            return new Assignment(tittle, disc, startingDate, oralMark, totalMark, id);
        }

        public Assignment GetDataForEdit()
        {
            Console.WriteLine("Give Course's ID wich you wish to edit");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give Course Tittle");
            string tittle = Console.ReadLine();
            Console.WriteLine("Dessscribe the Assignment");
            string disc = Console.ReadLine();
            Console.WriteLine("Give the Oral Mark");
            int oralMark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the Oral Mark");
            int totalMark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the submition date");
            DateTime subDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give the Course ID(100-123)");
            int courseID = Convert.ToInt32(Console.ReadLine());


            return new Assignment() { ID = id, Title = tittle, Description = disc, SubDateTime = subDate, OralMark = oralMark, TotalMark = totalMark, CourseID = courseID };
        }
    }
}
