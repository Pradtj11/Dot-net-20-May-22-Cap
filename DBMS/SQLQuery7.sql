create database SampleDB4;
use SampleDB4;

create table Student(ID int identity(1,1), Name varchar(50), primary key(ID));
select *from Student;

insert into Student values('Pragati');
insert into Student values('Atul');
insert into Student values('Megha');
insert into Student values('Mayuri');
insert into Student values('Akash');


create table Course(ID int identity(1,1), CourseID int, CourseName varchar(50), primary key(ID));

select *from Course;

insert into Course values(101, '.Net');
insert into Course values(102, 'Java');
insert into Course values(103, 'Python');
insert into Course values(104, 'PHP');
insert into Course values(101, '.Net');

delete from Course;

select *from Student;
select *from Course;
select * from Student s FULL OUTER JOIN Course c on s.ID=c.ID;

select * from Student s LEFT OUTER JOIN Course c on s.ID=c.ID;

select * from Student s RIGHT OUTER JOIN Course c on s.ID=c.ID;


select Name, c.CourseId, c.CourseName from student s inner join Course c on s.id=c.id;
