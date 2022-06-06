using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Repositories.AssignmentRepository
{
    /// <summary>
    /// The Repository Service Actions where the app connects to the Database on behalf Assignment Entiry
    /// </summary>
    internal class AssignmentRepository : IRepository
    {
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
                var assignment = db.Assignments.Find(id);
                if (assignment != null)
                {
                    db.Entry(assignment).State = EntityState.Deleted;
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
                var assignment = db.Students.Find(id);
                if (assignment != null)
                    return assignment;
                else
                    return null;
            }

        }

        public List<Assignment> GetALL()
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                var assignment = db.Assignments;
                return db.Assignments.SqlQuery("Select * from Assignment").ToList();
            }
        }

        public void Update(IEntity entity)
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                var tempAssignment = entity as Assignment;
                var assignment = db.Assignments.Find(tempAssignment.ID);
                if (assignment != null)
                {
                    assignment.Title = tempAssignment.Title;
                    assignment.Description = tempAssignment.Description;
                    assignment.SubDateTime = tempAssignment.SubDateTime;
                    assignment.OralMark = tempAssignment.OralMark;
                    assignment.TotalMark = tempAssignment.TotalMark;
                    assignment.CourseID = tempAssignment.CourseID;
                    db.Entry(assignment).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                    throw new Exception($"Trainer with id {entity.ID} doesn't exist");
            }
        }
    }
}
