using IndividualPartB.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Views.TrainerView
{
    /// <summary>
    /// In Connection with the Assignment Controller to Delete(GetIdForDelete), Create(GetTrainerData)
    /// and Edit(GetDataForEdit) data in Trainer Table.
    /// </summary>
    internal class InputTrainer : IInputData
    {
        public int GetIdForDelete()
        {
            Console.WriteLine("Give  the Trainer's Id that you wish to Delete");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }

        public Trainer GetTrainerData()
        {
            string firstName;
            string lastName;
            string subject;
            

            Console.WriteLine("Give Trainer's name");
            do
            {
                firstName = Console.ReadLine();
            } while (!Validation.ProperNameInput(firstName));

            Console.WriteLine("Give Trainer's lastname");
            do
            {
                lastName = Console.ReadLine();
            } while (!Validation.ProperNameInput(lastName));

            Console.WriteLine("Give Trainer's Subject\t( C# , Java , Python , Fortant)");
            do
            {
                subject = Console.ReadLine();
            } while (!Validation.ProperCourseInput(subject));



            return new Trainer(firstName, lastName, subject);
        }

        public Trainer GetDataForEdit()
        {
            string firstName;
            string lastName;
            string subject;

            Console.WriteLine("Give Trainer's id to edit it");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Change Trainer's firstName");
            do
            {
                firstName = Console.ReadLine();
            } while (!Validation.ProperNameInput(firstName));

            Console.WriteLine("Change Trainer's LastName");
            do
            {
                lastName = Console.ReadLine();
            } while (!Validation.ProperNameInput(lastName));

            Console.WriteLine("Change Trainer's Subject\t( C# , Java , Python , Fortant)");
            do
            {
                subject = Console.ReadLine();
            } while (!Validation.ProperCourseInput(subject));

            return new Trainer() { ID = id, FirstName = firstName, LastsName = lastName, Subject = subject };
        }
    }
}
