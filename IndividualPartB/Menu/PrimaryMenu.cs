using IndividualPartB.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IndividualPartB.Enums.Enum;



namespace IndividualPartB.Menu
{
    internal class PrimaryMenu
    {
        /// <summary>
        /// The 5 Option in the Primary menu
        /// </summary>
        public static void Start()
        {
            bool isActive = true;
            while (isActive)
            {

                Console.WriteLine("1 - For Students");
                Console.WriteLine("2 - For Trainers");
                Console.WriteLine("3 - For Courses");
                Console.WriteLine("4 - For Assignments");
                Console.WriteLine("5 - For the Project Queries!");
                Console.WriteLine("0 - Exit");
                Console.Write("Choose:");

                Console.ForegroundColor = ConsoleColor.Green;
                
                int input = Validation.Integer(Console.ReadLine()); 
                Console.ResetColor();
                Console.Clear();
                Choice choice = (Choice)input;

                switch (choice)
                {
                    case Choice.Student: SecondaryMenu.StudentService(); break;
                    case Choice.Trainer: SecondaryMenu.TrainerService(); break;
                    case Choice.Coarse: SecondaryMenu.CoarseService(); break;
                    case Choice.Assignment: SecondaryMenu.AssignmentService(); break;
                    case Choice.Query: SecondaryMenu.ProjectQueries(); break;
                    case Choice.Exit: isActive = false; break;
                    default: Validation.Error(); break;
                }
            }
        }
        

    }
}
