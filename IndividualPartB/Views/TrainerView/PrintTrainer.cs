using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Views.TrainerView
{
    /// <summary>
    /// The Print Services to produce information in the Console for the Trainer Entity.
    /// </summary>
    internal class PrintTrainer : IPrintData
    {
        public void Print(IEntity entity)
        {
            var trainer = entity as Trainer;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"ID",-5}{"Firstname",-15}{"Lastname",-15}{"Subject"} ");
            Console.ResetColor();
            Console.WriteLine($"{trainer.ID,-5}{trainer.FirstName,-15}{trainer.LastsName,-15}{trainer.Subject}");
        }

        public void PrintTrainers(List<Trainer> trainers)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"ID",-5}{"Firstname",-15}{"Lastname",-15}{"Subject"} \n");
            Console.ResetColor();
            foreach (Trainer trainer in trainers)
            {
                Console.WriteLine($"{trainer.ID,-5}{trainer.FirstName,-15}{trainer.LastsName,-15}{trainer.Subject}");
            }
        }
    }
}
