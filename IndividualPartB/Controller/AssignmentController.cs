using IndividualPartB.Repositories.AssignmentRepository;
using IndividualPartB.Views.AssignmentView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Menu.MenuServices
{
    /// <summary>
    /// The Class Where the Repository, Input and Print services are compine to produce
    /// the results for The Assignment Entity
    /// </summary>
    internal class AssignmentController : IController
    {
        private  AssignmentRepository Rep = new AssignmentRepository();
        private  InputAssignment Input = new InputAssignment();
        private  PrintAssignment Print = new PrintAssignment();

        public void Creating()
        {
            try
            {
                Rep.Add(Input.GetAssignmentData());
            }
            catch (Exception ex)
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
                Rep.Update(Input.GetAssignmentData());
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
                Print.PrintAssignments(Rep.GetALL());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
