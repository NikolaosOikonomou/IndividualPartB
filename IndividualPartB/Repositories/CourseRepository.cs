using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using IndividualPartB.Views.CourseView;

namespace IndividualPartB.Repositories.CourseRepository
{
    /// <summary>
    /// The Repository Service Actions where the app connects to the Database on behalf Course Entiry
    /// </summary>
    internal class CourseRepository : IRepository
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
                var course = db.Courses.Find(id);
                if (course != null)
                {
                    db.Entry(course).State = EntityState.Deleted;
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
                var course = db.Students.Find(id);
                if (course != null)
                    return course;
                else
                    throw new Exception($"Student with {id} id doens't exist");
            }

        }

        public List<Course> GetALL()
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {

                var course = db.Courses;
                return db.Courses.SqlQuery("Select * from Course").ToList();
            }
        }

        public void Update(IEntity entity)
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                var tempCourse = entity as Course;
                var course = db.Courses.Find(tempCourse.ID);
                if (course != null)
                {
                    course.Title = tempCourse.Title;
                    course.Stream = tempCourse.Stream;
                    course.Type = tempCourse.Type;
                    course.StartDate = tempCourse.StartDate;
                    course.EndDate = tempCourse.EndDate;
                    db.Entry(course).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                    throw new Exception($"Trainer with id {entity.ID} doesn't exist");
            }
        }


        /// <summary>
        /// Gets the List for the Student per Course Query
        /// </summary>
        /// <returns></returns>
        public List<Course> StudentPerCourse()
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                var course = db.Courses.Include(x => x.Students).ToList(); //Eager Loading!!
                PrintCourse print = new PrintCourse();

                return course;
            }
        }

        /// <summary>
        /// Gets the List for the Trainer per Course Query
        /// </summary>
        /// <returns></returns>
        public List<Course> TrainerPerCourse()
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                var course = db.Courses.Include(x => x.Trainers).ToList();
                PrintCourse print = new PrintCourse();

                return course;
            }
        }


        /// <summary>
        /// GEts the list for the Assignment per Student per Course Query
        /// </summary>
        /// <returns></returns>
        public List<Course> AssignmentPerStudentPerCourse()
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                var course = db.Courses.Include(x => x.Assignments).Include(s => s.Students).ToList();
                PrintCourse print = new PrintCourse();

                return course;
            }
        }
    }
}
