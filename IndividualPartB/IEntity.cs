using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB
{
    /// <summary>
    /// Inherited by Student, Trainer, Course and Assignment Entities to make IRepository Interface
    /// more Flecsible.
    /// </summary>
    public interface IEntity
    {
         int ID { get; set; }
    }
}
