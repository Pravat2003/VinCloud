use Tech

Use Tech
--CREATE TABLE Student
--(StudentId   INT
-- PRIMARY KEY IDENTITY(5001, 1), 
-- Name        VARCHAR(300), 
-- StudyIn     VARCHAR(100), 
-- Age         INT, 
-- Address     VARCHAR(500), 
-- CreatedDate DATETIME DEFAULT GETDATE()
--);


--CREATE TABLE Teacher
--(TeacherId   INT
-- PRIMARY KEY IDENTITY(8001, 1), 
-- Name        VARCHAR(300), 
-- Subject     VARCHAR(500), 
-- Expreance   VARCHAR(300), 
-- CreatedDate DATETIME DEFAULT GETDATE()
--);


CREATE TABLE Course
(CourseId   INT
 PRIMARY KEY IDENTITY(2001, 1), 
 CourseName VARCHAR(300), 
 IsActive   BIT DEFAULT 1,
 CreatedDate DATETIME DEFAULT GETDATE()
);

--INSERT Course(CourseName)
--SELECT 'JAVA'

--select * from Course


--select * from Course
--select * from Teacher


--alter table Course add TeacherId INT

--ALTER TABLE Course
--ADD FOREIGN KEY (TeacherId) REFERENCES Teacher(TeacherId);