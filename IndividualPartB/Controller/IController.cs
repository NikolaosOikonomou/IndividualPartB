using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Menu.MenuServices
{
    /// <summary>
    /// Implement this Interface to all Entities Controller.
    /// </summary>
    internal interface IController
    {

        void Reading();

        void Creating();

        void Editing();

        void Deleting();

    }
}
