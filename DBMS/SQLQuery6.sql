create database SampleDB3;
use SampleDB3;

create table Employee(ID int identity(1,1), FirstName varchar(50), LastName varchar(50), Gender varchar (50), primary key(ID));

select *from Employee;

insert into Employee values('Pragati', 'Tanpure', 'Female');
insert into Employee values('Atul', 'Kale', 'Male');
insert into Employee values('Mayuri', 'Munde', 'Female');
insert into Employee values('Meghna', 'Patil', 'Female');
insert into Employee values('Vinay', 'Rane', 'Male');