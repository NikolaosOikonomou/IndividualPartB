/****** Students with more than one Course ******/
select StudentPerCourse.StudentID ,Student.FirstName,Student.LastName,COUNT (*) as NumberOfCourses
from StudentPerCourse inner join Student on StudentPerCourse.StudentID=Student.ID
group by StudentPerCourse.StudentID,Student.FirstName,Student.LastName
having COUNT (*)>1
