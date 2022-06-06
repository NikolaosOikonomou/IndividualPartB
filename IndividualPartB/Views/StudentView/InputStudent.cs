using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Views.StudentView
{
    /// <summary>
    /// In Connection with the Course Controller to Delete(GetIdForDelete), Create(GetStudentData)
    /// and Edit(GetDataForEdit) data in Student Table.
    /// </summary>
    internal class InputStudent : IInputData
    {
        public int GetIdForDelete()
        {
            Console.WriteLine("Give  the Student's Id that you wish to Delete");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }

        public Student GetStudentData()
        {
            Console.WriteLine("Give Student's name");
            string name = Console.ReadLine();

            Console.WriteLine("Give Student's lastname");
            string lastName = Console.ReadLine();

            Console.WriteLine("Give Student's Date of birth");
            DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Give Student's Tuition Fees");
            int tuitionFee = Convert.ToInt32(Console.ReadLine());

            return new Student(name, lastName, dateOfBirth, tuitionFee);
        }

        public Student GetDataForEdit()
        {
            Console.WriteLine("Give student's id to edit it");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Change Student's firstName");
            string firstName = Console.ReadLine();

            Console.WriteLine("Change Student's LastName");
            string lastName = Console.ReadLine();

            Console.WriteLine("Change Student's Date of Birth");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Change Student's Tuition Fees");
            int tuitionFees = Convert.ToInt32(Console.ReadLine());

            return new Student() { ID = id, FirstName = firstName, LastName = lastName, DateOfBirth = date, TuitionFees = tuitionFees };
        }
    }
}
