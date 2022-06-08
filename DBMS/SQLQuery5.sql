create database SampleDB1;
use SampleDB1;

create table EmployeeDetails(id int identity(1,1), fname varchar(100), lname varchar(100), salary int, primary key(id));

select * from EmployeeDetails;
