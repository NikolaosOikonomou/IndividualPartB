using IndividualPartB.Repositories.StudentRepository;
using IndividualPartB.Views.StudentView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Menu.MenuServices
{
    /// <summary>
    /// The Class Where the Repository, Input and Print services are compine to produce
    /// the results for The Student Entity
    /// </summary>
    internal class StudentController : IController
    {
        private StudentRepository Rep = new StudentRepository();

        private InputStudent Input = new InputStudent();

        private PrintStudent Print = new PrintStudent();

        public void Creating()
        {
            try
            {
                Rep.Add(Input.GetStudentData());
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
                Print.PrintStudents(Rep.GetALL());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
