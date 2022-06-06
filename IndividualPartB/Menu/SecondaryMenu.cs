
using IndividualPartB.Menu.MenuServices;
using IndividualPartB.Repositories.CourseRepository;
using IndividualPartB.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IndividualPartB.Enums.Enum;

namespace IndividualPartB.Menu
{
    public class SecondaryMenu
    {
        /// <summary>
        /// Secondary Menu provides All the Options for the Project's Entities
        /// </summary>
        public static void StudentService() //Student's Menu Options
        {
            StudentController menuStudentInteraction = new StudentController();
            bool isActive = true;
            while (isActive)
            {

                Console.WriteLine("1 - Reading all Students");
                Console.WriteLine("2 - Create a Student");
                Console.WriteLine("3 - Edit a Student");
                Console.WriteLine("4 - Delete a Student");
                Console.WriteLine("5 - Back");
                Console.Write("Choose:");

                Console.ForegroundColor = ConsoleColor.Green;
                string input = Console.ReadLine();
                int input1 = Validation.CharsInsteadOfNumber(input);
                Console.ResetColor();
                Console.Clear();
                StudentChoice choice = (StudentChoice)input1;

                switch (choice)
                {
                    case StudentChoice.ReadingStudents: menuStudentInteraction.Reading(); break;
                    case StudentChoice.CreateStudent: menuStudentInteraction.Creating(); break;
                    case StudentChoice.EditStudent: menuStudentInteraction.Editing(); break;
                    case StudentChoice.DeleteStudent: menuStudentInteraction.Deleting(); break;
                    case StudentChoice.Back: isActive = false; break;
                    default: Validation.Error(); break; 
                }
            }
        }

        public static void TrainerService() //Trainer's Menu Options
        {
            TrainerController menuTrainerInteraction = new TrainerController();
            bool isActive = true;
            while (isActive)
            {
                Console.WriteLine("1 - Reading all Trainers");
                Console.WriteLine("2 - Create a Trainer");
                Console.WriteLine("3 - Edit a Trainer");
                Console.WriteLine("4 - Delete a Trainer");
                Console.WriteLine("5 - Back");
                Console.Write("Choose:");

                Console.ForegroundColor = ConsoleColor.Green;
                string input = Console.ReadLine();
                int input1 = Validation.CharsInsteadOfNumber(input);
                Console.ResetColor();
                Console.Clear();
                TrainerChoice choice = (TrainerChoice)input1;

                switch (choice)
                {
                    case TrainerChoice.ReadingTrainer: menuTrainerInteraction.Reading(); break;
                    case TrainerChoice.CreateTrainer: menuTrainerInteraction.Creating(); break;
                    case TrainerChoice.EditTrainer: menuTrainerInteraction.Editing(); break;
                    case TrainerChoice.DeleteTrainer: menuTrainerInteraction.Deleting(); break;
                    case TrainerChoice.Back: isActive = false; break;
                    default: Validation.Error(); break;
                }
            }
        }

        public static void CoarseService()
        {
            CourseController menuCoarseInteraction = new CourseController();
            bool isActive = true;
            while (isActive)
            {
                Console.WriteLine("1 - Reading all Courses");
                Console.WriteLine("2 - Create a Course");
                Console.WriteLine("3 - Edit a Course");
                Console.WriteLine("4 - Delete a Course");
                Console.WriteLine("5 - Back");
                Console.Write("Choose:");

                Console.ForegroundColor = ConsoleColor.Green;
                string input = Console.ReadLine();
                int input1 = Validation.CharsInsteadOfNumber(input);
                Console.ResetColor();
                Console.Clear();
                CourseChoice choice = (CourseChoice)input1;

                switch (choice)
                {
                    case CourseChoice.ReadingCourse: menuCoarseInteraction.Reading(); break;
                    case CourseChoice.CreateCourse: menuCoarseInteraction.Creating(); break;
                    case CourseChoice.EditCourse: menuCoarseInteraction.Editing(); break;
                    case CourseChoice.DeleteCourse: menuCoarseInteraction.Deleting(); break;
                    case CourseChoice.Back: isActive = false; break;
                    default: Validation.Error(); break;
                }
            }
        }

        public static void AssignmentService() //Assignment's Menu Options
        {
            AssignmentController menuAssignmentInteraction = new AssignmentController();
            bool isActive = true;
            while (isActive)
            {
                Console.WriteLine("1 - Reading all Assignments");
                Console.WriteLine("2 - Create a Assignment");
                Console.WriteLine("3 - Edit a Assignment");
                Console.WriteLine("4 - Delete a Assignment");
                Console.WriteLine("5 - Back");
                Console.Write("Choose:");

                Console.ForegroundColor = ConsoleColor.Green;
                string input = Console.ReadLine();
                int input1 = Validation.CharsInsteadOfNumber(input);
                Console.ResetColor();
                Console.Clear();
                AssignmentChoice choice = (AssignmentChoice)input1;

                switch (choice)
                {
                    case AssignmentChoice.ReadingAssignment: menuAssignmentInteraction.Reading(); break;
                    case AssignmentChoice.CreateAssignment: menuAssignmentInteraction.Creating(); break;
                    case AssignmentChoice.EditAssignment: menuAssignmentInteraction.Editing(); break;
                    case AssignmentChoice.DeleteAssignment: menuAssignmentInteraction.Deleting(); break;
                    case AssignmentChoice.Back: isActive = false; break;
                    default: Validation.Error(); break;
                }
            }
        }

        public static void ProjectQueries() //Menu Queries options of the Project
        {
            CourseRepository rep = new CourseRepository();
            bool isActive = true;
            while (isActive)
            {
                Console.WriteLine("1 - For Student's Per Course");
                Console.WriteLine("2 - For Trainer's Per Course");
                Console.WriteLine("3 - For the Assignment Per Student Per Course");
                Console.WriteLine("5 - Back");
                Console.Write("Choose:");

                Console.ForegroundColor = ConsoleColor.Green;
                string input = Console.ReadLine();
                int input1 = Validation.CharsInsteadOfNumber(input);
                Console.ResetColor();
                Console.Clear();
                QueryChoice choice = (QueryChoice)input1;

                switch (choice)
                {
                    case QueryChoice.StudentPerCourse: rep.StudentPerCourse(); break;
                    case QueryChoice.TrainerPerCourse: rep.TrainerPerCourse(); break;
                    case QueryChoice.AssignmentsPerStudentsPerCourse: rep.AssignmentPerStudentPerCourse(); break;
                    case QueryChoice.Back: isActive = false; break;
                    default: Validation.Error(); break;
                }
            }
        }


    }
}
