USE SampleDB2



ALTER TABLE employee add Name varchar(10)



select * from employee
select * from department
create proc AddEmployee(@Id int,@Name varchar(200),@DepartmentId int)
As 
Begin
insert into employee values(@Id,@Name,@DepartmentId);
END


exec dbo.AddEmployee 'Priyanka','IT'


create table employee (id int IDENTITY(1,1),name varchar(200),departmentid int)
create table department(id int IDENTITY(1,2),department varchar(20))

create proc getStudents as begin 
select * from employee emp FULL OUTER JOIN department dep on emp.departmentid=dep.id;
end 

exec getStudents