/****** Trainer Per Course ******/
select Course.ID,Course.Title,Trainer.FirstName,Trainer.LastsName
from TrainerPerCourse inner join Trainer on TrainerPerCourse.TrainerID=Trainer.ID 
                                    inner join Course on TrainerPerCourse.CourseID=Course.ID
group by Course.ID,Course.Title,Trainer.FirstName,Trainer.LastsName