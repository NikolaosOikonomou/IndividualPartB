using IndividualPartB.Menu;
using IndividualPartB.Menu.MenuServices;
using IndividualPartB.Repositories.CourseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IndividualPartB.Enums.Enum;

namespace IndividualPartB
{
    class Program
    {
        static void Main(string[] args)
        {

             PrimaryMenu.Start();

            //using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            //{
            //    var assignmnets = db.Assignments.ToList();
            //    var students = db.Students.ToList();
            //    var course = db.Courses.ToList();
            //    foreach (var stu in students)
            //    {
            //        foreach (var cou in stu.Courses)
            //        {
            //            foreach (var ass in cou.Assignments)
            //            {
            //                stu.Assignments.Add(ass);
            //            }
            //        }
            //    }
            //    db.SaveChanges();
            //}


        }

    }
}
