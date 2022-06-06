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
        public void Creating()
        {
            TrainerRepository rep = new TrainerRepository();
            InputTrainer input = new InputTrainer();

            var trainer = input.GetTrainerData();
            rep.Add(trainer);
        }

        public void Deleting()
        {
            TrainerRepository rep = new TrainerRepository();
            InputTrainer input = new InputTrainer();

            int id = input.GetIdForDelete();
            rep.Delete(id);
        }

        public void Editing()
        {
            TrainerRepository rep = new TrainerRepository();
            InputTrainer input = new InputTrainer();

            var trainer = input.GetDataForEdit();
            rep.Add(trainer);
        }

        public void Reading()
        {
            TrainerRepository rep = new TrainerRepository();
            PrintTrainer printTrainer = new PrintTrainer();

            var trainers = rep.GetALL();
            printTrainer.PrintTrainers(trainers);
        }
    }
}
