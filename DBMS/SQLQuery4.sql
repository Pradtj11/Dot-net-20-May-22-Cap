create database SampleDB;
use SampleDB;

create table tblsample(id int identity(1,1), test varchar(50), primary key(id));

select *from tblsample;
