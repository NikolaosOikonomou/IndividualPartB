using IndividualPartB.Repositories.CourseRepository;
using IndividualPartB.Repositories.StudentRepository;
using IndividualPartB.Views.CourseView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Menu.MenuServices
{
    /// <summary>
    /// The Class Where the Repository, Input and Print services are compine to produce
    /// the results for The Course Entity
    /// Furthermore includes the 3 methods to produce: 1. Student Per Course, 2. Trainer Per Course
    /// and 3. Assignment Per Student Per Course  Queries.
    /// </summary>
    internal class CourseController : IController 
    {
        private CourseRepository Rep = new CourseRepository();

        private InputCourse Input = new InputCourse();

        private PrintCourse Print = new PrintCourse();


        public void Creating()
        {
            try
            {
                Rep.Add(Input.GetCourseData());
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Editing()
        {
            try
            {
                Rep.Update(Input.GetDataForEdit());
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
                Print.PrintCourses(Rep.GetALL());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void StudentPerCourse()
        {
            try
            {
                Print.StudentsPer(Rep.StudentPerCourse());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void TrainerPerCourse()
        {
            try
            {
                Print.TrainersPer(Rep.TrainerPerCourse());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void AssignmentPerStudentPerCourse()
        {
            try
            {
                Print.AssignmentPerStudentPer(Rep.AssignmentPerStudentPerCourse());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
