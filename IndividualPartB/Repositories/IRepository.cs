using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Repositories
{
    interface IRepository
    {
        IEntity Get(int id);

        void Add(IEntity entity);

        void Update(IEntity entity);

        void Delete(int id);

    }
}
