using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Repositories.TrainerRepository
{
    internal class TrainerRepository : IRepository
    {
        /// <summary>
        /// The Repository Service Actions where the app connects to the Database on behalf Trainer Entiry
        /// </summary>
        public void Add(IEntity entity)
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                var trainer = db.Trainers.Find(id);
                if (trainer != null)
                {
                    db.Entry(trainer).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception($"Student with {id} id doens't exist");
                }
            }
        }

        public IEntity Get(int id)
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                var trainer = db.Trainers.Find(id);
                if (trainer != null)
                    return trainer;
                else
                    return null;
            }
        }

        public List<Trainer> GetALL()
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                var trainer = db.Trainers;
                return db.Trainers.SqlQuery("Select * from Trainer").ToList();
            }
        }

        public void Update(IEntity entity)
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                var tempTrainer = entity as Trainer;
                var trainer = db.Trainers.Find(entity.ID);
                if (trainer != null)
                {
                    trainer.FirstName = tempTrainer.FirstName;
                    trainer.LastsName = tempTrainer.LastsName;
                    trainer.Subject = tempTrainer.Subject;
                }
                else
                    throw new Exception($"Trainer with id {entity.ID} doesn't exist");
            }
        }
    }
}
