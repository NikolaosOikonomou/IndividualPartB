using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Enums
{
    internal class Enum

    {

        /// <summary>
        /// All the Enums for PrimaryMenu
        /// </summary>
        public enum Choice
        {
            Exit,
            Student,
            Trainer,
            Coarse,
            Assignment,
            Query
        }

        /// <summary>
        /// All the enums for the SecondaryMenu 
        /// </summary>

        public enum StudentChoice
        {

            ReadingStudents = 1,
            CreateStudent,
            EditStudent,
            DeleteStudent,
            Back
        }

        public enum TrainerChoice
        {

            ReadingTrainer = 1,
            CreateTrainer,
            EditTrainer,
            DeleteTrainer,
            Back
        }

        public enum CourseChoice
        {

            ReadingCourse = 1,
            CreateCourse,
            EditCourse,
            DeleteCourse,
            Back
        }

        public enum AssignmentChoice
        {

            ReadingAssignment = 1,
            CreateAssignment,
            EditAssignment,
            DeleteAssignment,
            Back
        }

        public enum QueryChoice
        {
            StudentPerCourse = 1,
            TrainerPerCourse,
            AssignmentsPerStudentsPerCourse,
            Back = 5
        }

        public enum TrainerSubject
        {
            C = 1,
            Java,
            Python,
            Fortrant

        }

    }
}
