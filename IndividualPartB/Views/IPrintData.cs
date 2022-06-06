using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Views
{
    /// <summary>
    /// Inherited by All Entities Print Services in Views Folder.
    /// </summary>
    internal interface IPrintData
    {
        void Print(IEntity entity);

    }
}
