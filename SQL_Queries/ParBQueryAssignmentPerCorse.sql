/****** Assignment Per Course ******/
select Course.ID as CourseID,Course.Title as CourseTittle, Assignment.ID as AssignmentId,Assignment.Title as AssignmentTittle
from Course inner join Assignment on Course.ID=Assignment.CourseID