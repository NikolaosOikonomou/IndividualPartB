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
        public void Creating()
        {
            AssignmentRepository rep = new AssignmentRepository();
            InputAssignment input = new InputAssignment();

            var assignment = input.GetAssignmentData();
            rep.Add(assignment);
        }

        public void Deleting()
        {
            AssignmentRepository rep = new AssignmentRepository();
            InputAssignment input = new InputAssignment();

            int id = input.GetIdForDelete();
            rep.Delete(id);
        }

        public void Editing()
        {
            AssignmentRepository rep = new AssignmentRepository();
            InputAssignment input = new InputAssignment();

            var assignment = input.GetDataForEdit();
            rep.Update(assignment);
        }

        public void Reading()
        {
            AssignmentRepository rep = new AssignmentRepository();
            PrintAssignment printAssignment = new PrintAssignment();

            var assignment = rep.GetALL();
            printAssignment.PrintAssignments(assignment);
        }
    }
}
