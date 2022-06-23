USE [Sprint1DB]

use Sprint1DB;


create table CustomerTbl(Customer_Id int identity(1,1), Customer_Name varchar(50), Order_Id int, Order_Name varchar(50), Order_Price int, primary key(Customer_Id));

create table AdminTbl(Id int identity(1,1), Product_Code int, Product_Name varchar(50), Product_Price int, primary key(Id));

select * from AdminTbl;
select *from CustomerTbl;

create table login(ID int identity(1,1), UserName varchar(100), Password varchar(100), IsAdmin int, primary key(ID));
