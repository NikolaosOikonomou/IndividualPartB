using IndividualPartB.Validations;
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
            int id;
            int totalMark;
            int oralMark;

            Console.WriteLine("Give Assignment Tittle");
            string tittle = Console.ReadLine();
            Console.WriteLine("Give Assignment Discription");
            string disc = Console.ReadLine();
            Console.WriteLine("Give Assignment submition date");
            DateTime startingDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give the Assignment's Oral Mark");
            do
            {
                oralMark = Validation.Integer(Console.ReadLine());
            } while (!Validation.RangeCheck(oralMark, 1, 20));
            

            Console.WriteLine("Give the Assignment's Total Mark");
            do
            {
                totalMark = Validation.Integer(Console.ReadLine());
            } while (!Validation.RangeCheck(totalMark, 1, 80));
             

            Console.WriteLine("Give the Course ID of the Assignment (100-123)");
            do
            {
                id = Validation.Integer(Console.ReadLine());
            } while (!Validation.RangeCheck(id, 100, 123));
            


            return new Assignment(tittle, disc, startingDate, oralMark, totalMark, id);
        }

        public Assignment GetDataForEdit()
        {
            int courseID;
            int oralMark;
            int totalMark;

            Console.WriteLine("Give Course's ID wich you wish to edit");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give Course Tittle");
            string tittle = Console.ReadLine();
            Console.WriteLine("Dessscribe the Assignment");
            string disc = Console.ReadLine();

            Console.WriteLine("Give the Assignment's Oral Mark");
            do
            {
                oralMark = Validation.Integer(Console.ReadLine());
            } while (!Validation.RangeCheck(oralMark, 1, 20));

            Console.WriteLine("Give the Assignment's Total Mark");
            do
            {
                totalMark = Validation.Integer(Console.ReadLine());
            } while (!Validation.RangeCheck(totalMark, 1, 80));

            Console.WriteLine("Give the submition date");
            DateTime subDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Give the Course ID(100-123)");
            do
            {
                courseID = Validation.Integer(Console.ReadLine());
            } while (!Validation.RangeCheck(courseID, 100, 123));


            return new Assignment() { ID = id, Title = tittle, Description = disc, SubDateTime = subDate, OralMark = oralMark, TotalMark = totalMark, CourseID = courseID };
        }
    }
}
