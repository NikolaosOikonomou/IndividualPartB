CREATE DATABASE Individual_Part_B

use Individual_Part_B

CREATE TABLE [Student] --1  OK
(
 [ID]          int   identity(1,1),
 [FirstName]   varchar(50) NOT NULL ,
 [LastName]    varchar(50) NOT NULL ,
 [DateOfBirth] Datetime,
 [TuitionFees] int,


  CONSTRAINT PK_StudentID PRIMARY KEY (ID) 
);


CREATE TABLE [Course]-- 2  OK
(	
	[ID]        int identity (100,1),
	[Title]     nvarchar(50) NOT NULL,
	[Stream]    nvarchar(50),
	[Type]      nvarchar (20) NOT NULL CHECK ([Type] IN('Full-Time', 'Part-Time')) DEFAULT 'Full-Time',
	[StartDate] DateTime,
	[EndDate]   DateTime,

	CONSTRAINT PK_CourseName PRIMARY KEY (ID)
);

CREATE TABLE [Trainer] --3  OK
(
	[ID]		 int     identity(1000,1),
	[FirstName]  varchar(50)  NOT NULL,
	[LastsName]  varchar(50)  NOT NULL,
	[Subject]    varchar(50),
	--[CourseID]   int,

	CONSTRAINT PK_TrainerID  PRIMARY KEY (ID),
	--CONSTRAINT FK_TrainerCourseID FOREIGN KEY (CourseID) REFERENCES Course(ID)
);

CREATE TABLE [Assignment] --4  OK
(
	[ID]          int identity(1000,1),
	[Title]       nvarchar(50) NOT NULL,
	[Description] nvarchar(255),	
	[SubDateTime] DateTime,
	[OralMark]    int,
	[TotalMark]   int,
	[CourseID]    int,

	CONSTRAINT PK_CourseName_AssgnmTittle PRIMARY KEY (ID),
	CONSTRAINT FK_Assgnm_CourseName       FOREIGN KEY (CourseID)       REFERENCES Course(ID),
	
);

CREATE TABLE [StudentPerCourse] -- 5  OK
(
	[StudentID]	int	  NOT NULL,
	[CourseID]	int   NOT NULL,

	CONSTRAINT PK_StudentPerCourse      PRIMARY KEY (StudentID,CourseID),
	CONSTRAINT  FK_StuPer_StudentID   FOREIGN KEY (StudentID)   REFERENCES Student(ID),
	CONSTRAINT  FK_StuPer_CourseName  FOREIGN KEY (CourseID)  REFERENCES Course(ID),
);


CREATE TABLE [TrainerPerCourse] --6  OK
(
	[TrainerID] int	NOT NULL,
	[CourseID]  int	NOT NULL,

	CONSTRAINT PK_TrainerPerCourse      PRIMARY KEY (TrainerID,CourseID),
	CONSTRAINT FK_Trainer_ID			FOREIGN KEY (TrainerID)	    REFERENCES Trainer(ID),
	CONSTRAINT FK_TrainerCourseName		FOREIGN KEY (CourseID)	REFERENCES Course(ID),

);

CREATE TABLE [AssignmentPerStudent] -- 7  OK
(
	[StudentID]	int	  NOT NULL,
	[AssignmentID]	int   NOT NULL,

	CONSTRAINT PK_StudentPerAssignment           PRIMARY KEY (StudentID,AssignmentID),
	CONSTRAINT  FK_StuPer_StudentID_Assignment   FOREIGN KEY (StudentID)   REFERENCES Student(ID),
	CONSTRAINT  FK_StuPer_AssignmentTable        FOREIGN KEY (AssignmentID)  REFERENCES Assignment(ID),
);

CREATE TABLE [AssignmentPerCoursePerStudent] -- 8  OK
(
	[AssignmentID]  int  NOT NULL,
	[CourseID]	    int  NOT NULL,
	[StudentID]	    int	 NOT NULL,

	CONSTRAINT PK_CourseID_AssgnmIDPerStudent PRIMARY KEY (AssignmentID,CourseID,StudentID),
	CONSTRAINT FK_StudentsPerCourseTable      FOREIGN KEY (CourseID, StudentID)       REFERENCES StudentPerCourse(StudentID,CourseID),
	CONSTRAINT FK_AssignmentTable_ID			FOREIGN KEY (AssignmentID)	          REFERENCES Assignment(ID)
	
)
