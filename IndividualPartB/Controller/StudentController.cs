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

        public void Creating()
        {
            StudentRepository rep = new StudentRepository();
            InputStudent input = new InputStudent();

            var student = input.GetStudentData();
            rep.Add(student);
        }

        public void Deleting()
        {
            StudentRepository rep = new StudentRepository();
            InputStudent input = new InputStudent();

            int id = input.GetIdForDelete();
            rep.Delete(id);

        }

        public void Editing()
        {
            StudentRepository rep = new StudentRepository();
            InputStudent input = new InputStudent();

            var student = input.GetDataForEdit();
            rep.Update(student);
        }

        public void Reading()
        {
            StudentRepository rep = new StudentRepository();
            PrintStudent printStudent = new PrintStudent();

            var students = rep.GetALL();
            printStudent.PrintStudents(students);
        }

    }
}
