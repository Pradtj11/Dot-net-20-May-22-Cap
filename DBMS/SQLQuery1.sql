Create database SampleDB2;
Drop database SampleDB2;

--create table
/*
create table <TABLE NAMR>(<columns> data type)
*/
Create table sample(id int, name varchar(200));

select * from sample

insert into sample values(1, 'Pragati');
insert into sample values(2, 'Pragati1');
insert into sample values(3, 'Pragati2');
insert into sample values(4, 'Pragati3');

delete from sample

Create table Employee(Employee_Name varchar(200), Employee_id int, Gender varchar(20), salary int);
select *from Employee

insert into Employee values('Pragati', 101, 'Female', 3000);
insert into Employee values('Atul', 102, 'Male', 5000);
insert into Employee values('Priya', 103, 'Female', 8000);
insert into Employee values('Mayuri', 104, 'Female', 2000);

update Employee set Employee_Name='Snehal' where Employee_id=103;
select *from Employee

select *from Employee where Gender='Female'
delete from Employee


alter table sample add company varchar(100);
alter table sample Drop column salary;

create table student (FirstName varchar(100), LastName varchar(100), id int, Gender varchar(100));
select * from student

insert into student values('Pragati', 'Tanpure', 101, 'Female');
insert into student values('abc', 'xyz', 102, 'Female');
insert into student values('mno', 'pqr', 103, 'Male');
insert into student values('bbb', 'zzz', 104, 'Male');

delete from student
select *from student;
select * from student where Gender='Female';

select * from student where Gender='Male';

select * from student order by id desc
select * from student order by id asc

select * from student where id=101;
select * from student where id=103;
select * from student where id=104;

select * from student where id in (101,103,104);
select * from student where id not in (101,103,104);

select max(id) from student
select min(id) from student
select AVG(id) from student
select count(*) from student

select *from student where FirstName like 'P%' --name starts with P

select *from student where FirstName like 'a%'

select CONCAT(FirstName,' ',LastName) as FullName  from student

select *from student where id between 101 and 103

/*concate two tables*/
create table EmployeeDetails(id int, name varchar(100), departmentis int);
create table department(id int, department varchar(20));

insert into EmployeeDetails values(1,'Pragati', 1);
insert into EmployeeDetails values(2,'priya', 2);
insert into EmployeeDetails values(3,'vaishnavi', 3);
insert into EmployeeDetails values(4,'srushti', 1);
insert into EmployeeDetails values(5,'payal', 1);

insert into department values(1, 'IT');
insert into department values(1, 'Sales');
insert into department values(1, 'Admin');

delete from 
select *from EmployeeDetails
select *from department

select emp.name, dep.department from EmployeeDetails as emp inner join department as dep on emp.departmentis=dep.id;

select emp.name, dep.department from EmployeeDetails as emp left join department as dep on emp.departmentis=dep.id;

select emp.name, dep.department from EmployeeDetails as emp right join department as dep on emp.departmentis=dep.id;

select * from EmployeeDetails as emp inner join department as dep on emp.departmentis=dep.id;

