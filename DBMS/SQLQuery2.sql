
--full outer join
--left outer join
--right outer join

select * from EmployeeDetails

select * from department

select * from EmployeeDetails emp FULL OUTER JOIN department dep on emp.departmentis=dep.id;

select * from EmployeeDetails emp LEFT OUTER JOIN department dep on emp.departmentis=dep.id;

select * from EmployeeDetails emp RIGHT OUTER JOIN department dep on emp.departmentis=dep.id;

/*student table
-id
-roll no
-first name
-last name
-gender
-classid

student class
-id
-classname

select rollNo,full name,gender,classname*/

create table student(id int, roll_no int, FName varchar(100), LName varchar(100), gender varchar(100), classid int)

select *from student

insert into student values(1, 101, 'Pragati', 'Tanpure', 'Female', 500);
insert into student values(2, 102, 'Priya', 'aaa', 'Female', 700);
insert into student values(3, 103, 'Mayuri', 'bbb', 'Female', 800);
insert into student values(4, 104, 'Megha', 'ccc', 'Female', 400);

create table student_class(id int, classname varchar(100))
insert into student_class values(1,'7th class');
insert into student_class values(2,'5th class');
insert into student_class values(3,'8th class');
insert into student_class values(4,'4th class');

delete from student
delete from student_class

select *from student
select *from student_class

/*select roll_no, CONCAT(FName,' ',LName) as FullName, gender, classid, classname from student as stud inner join student_class as sc on stud.classid=sc.id;*/
OR

select s.roll_no, CONCAT(s.FName,' ',s.LName) as FullName, s.gender, sc.classname from student s inner join student_class sc on s.id=sc.id;

/*
create function <function-name>(<parameters>) returns data-type as
begin
//body
end
*/

create function GetFullName(@ID int) returns varchar(100) as
begin
return (select CONCAT(FName,' ',LName) as FullName from student where id=@ID);
end

select *from student
select dbo.GetFullName(3);


/*create a fuction which fetch the Employee name @ id from Employee table*/

Create function GetEmpID(@ID int) returns varchar(100) AS
BEGIN
return (select CONCAT(name,id) as EmpID from EmployeeDetails where id=@ID);
END

Drop function GetEmpID;

select *from EmployeeDetails
select dbo.GetEmpID(1);

/*Create a function

1==>EMP1
2==>EMP2
3==>EMP3
*/

Create function GetEmpID1(@ID int) returns varchar(10) AS
BEGIN
return
(select CONCAT ('Emp',id) as EMPID from EmployeeDetails where id=@ID);

END

Drop function GetEmpID;

select *from EmployeeDetails
select dbo.GetEmpID1(1);


/*create a function to manupulate date of table employeedetails*/

select * from EmployeeDetails
create proc AddEmployee(@Id int,@Name varchar(200),@DepartmentIs int)
As 
Begin

insert into EmployeeDetails values(@Id,@Name,@departmentIs);
END


exec dbo.AddEmployee 5,'xys',1
