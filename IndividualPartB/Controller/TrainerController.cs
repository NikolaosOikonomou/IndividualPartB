using IndividualPartB.Repositories.TrainerRepository;
using IndividualPartB.Views.TrainerView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Menu.MenuServices
{
    /// <summary>
    /// The Class Where the Repository, Input and Print services are compine to produce
    /// the results for The Trainer Entity
    /// </summary>
    internal class TrainerController : IController
    {
        private TrainerRepository Rep = new TrainerRepository();

        private InputTrainer Input = new InputTrainer();

        private PrintTrainer Print = new PrintTrainer();


        public void Creating()
        {
            try
            {
                Rep.Add(Input.GetTrainerData());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Deleting()
        {
            try
            {
                Rep.Delete(Input.GetIdForDelete());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Editing()
        {
            try
            {
                Rep.Add(Input.GetDataForEdit());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Reading()
        {
            try
            {
                Print.PrintTrainers(Rep.GetALL());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
