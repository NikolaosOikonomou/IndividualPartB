/****** Assignment Per Course Per Student ******/
select StudentPerCourse.StudentID,Student.FirstName,Student.LastName,StudentPerCourse.CourseID,Assignment.ID,Assignment.Title
from StudentPerCourse  inner join Assignment on StudentPerCourse.CourseID=Assignment.CourseID
                       left join Student on StudentPerCourse.StudentID=Student.ID
			
 