/****** Student Per Course ******/
select Course.ID,Course.Title,Student.FirstName,Student.LastName
from StudentPerCourse inner join Student on StudentPerCourse.StudentID=Student.ID 
                                    inner join Course on StudentPerCourse.CourseID=Course.ID
group by Course.ID,Course.Title,Student.FirstName,Student.LastName