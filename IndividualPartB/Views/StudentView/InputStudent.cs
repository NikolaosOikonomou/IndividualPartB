using IndividualPartB.Validations;
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
            string name;
            string lastName;
            int tuitionFee;

            Console.WriteLine("Give Student's name");
            do
            {
                name = Console.ReadLine();
            } while (!Validation.ProperNameInput(name));

            Console.WriteLine("Give Student's lastname");
            do
            {
                lastName = Console.ReadLine();
            } while (!Validation.ProperNameInput(lastName));

            Console.WriteLine("Give Student's Date of birth (yyyy-mm-dd)");
            DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Give Student's Tuition Fees");
            do
            {
                tuitionFee = Validation.Integer(Console.ReadLine());
            } while (!Validation.RangeCheck(tuitionFee,1500,2500));


            return new Student(name, lastName, dateOfBirth, tuitionFee);
        }


        public Student GetDataForEdit()
        {
            string firstName;
            string lastName;
            int tuitionFees;

            Console.WriteLine("Give student's id to edit it");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Change Student's firstName");
            do
            {
                firstName = Console.ReadLine();
            } while (!Validation.ProperNameInput(firstName));

            Console.WriteLine("Change Student's LastName");
            do
            {
                lastName = Console.ReadLine();
            } while (!Validation.ProperNameInput(lastName));

            Console.WriteLine("Change Student's Date of Birth");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Change Student's Tuition Fees");
            do
            {
                tuitionFees = Validation.Integer(Console.ReadLine());
            } while (!Validation.RangeCheck(tuitionFees, 1500, 2500));


            return new Student() { ID = id, FirstName = firstName, LastName = lastName, DateOfBirth = date, TuitionFees = tuitionFees };
        }
    }
}
