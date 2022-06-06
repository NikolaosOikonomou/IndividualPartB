using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Repositories.StudentRepository
{
    public class StudentRepository : IRepository
    {
        /// <summary>
        /// The Repository Service Actions where the app connects to the Database on behalf Student Entiry
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
                var student = db.Students.Find(id);
                if (student != null)
                {
                    db.Entry(student).State = EntityState.Deleted;
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
                var student = db.Students.Find(id);
                if (student != null)
                    return student;
                else
                    throw new Exception($"Student with {student.ID} doesnt exist");
            }

        }


        public List<Student> GetALL()
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                var students = db.Students;
                return db.Students.SqlQuery("Select * from Student").ToList();
            }
        }

        public void Update(IEntity entity)
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                var tempEntity = entity as Student;
                var student = db.Students.Find(tempEntity.ID);
                if (student != null)
                {
                    student.FirstName = tempEntity.FirstName;
                    student.LastName = tempEntity.LastName;
                    student.DateOfBirth = tempEntity.DateOfBirth;
                    student.TuitionFees = tempEntity.TuitionFees;
                    db.Entry(student).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception($"Student with {entity.ID} doesnt exist");
                }
            }
        }
    }
}
