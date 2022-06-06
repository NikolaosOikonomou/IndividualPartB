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
            Console.WriteLine("Give Trainer's name");
            string name = Console.ReadLine();
            Console.WriteLine("Give Trainer's lastname");
            string lastName = Console.ReadLine();
            Console.WriteLine("Give Trainer's Subject");
            string subject = Console.ReadLine();


            return new Trainer(name, lastName, subject);
        }

        public Trainer GetDataForEdit()
        {
            Console.WriteLine("Give Trainer's id to edit it");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Change Trainer's firstName");
            string firstName = Console.ReadLine();

            Console.WriteLine("Change Trainer's LastName");
            string lastName = Console.ReadLine();

            Console.WriteLine("Change Trainer's Subject");
            string subject = Console.ReadLine();

            return new Trainer() { ID = id, FirstName = firstName, LastsName = lastName, Subject = subject };
        }
    }
}
