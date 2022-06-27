use EcommerceDB;

create table TblLogin(UserID int identity(1,1), UserName nvarchar(100), UserLastName nvarchar(100), Password nvarchar(100), EmailId nvarchar(100), Gender nvarchar(100), IsAdmin int, primary key(UserId));


create table TblLogin(ID int identity(1,1), UserName nvarchar(100), Password nvarchar(100), IsAdmin int, primary key(ID));

create table TblProduct(Id int identity(1,1), ProductName nvarchar(100), ProductDescription nvarchar(100), CatID int, ProductImage nvarchar(100), ProductMrp decimal(18,2), ProductDiscount decimal(18,2), ProductFinal decimal(18,2), ProductQuantity int, primary key(ID));

select * from TblLogin;
insert into tblProduct values('Gaming Laptop','Lenovo IdeaPad Gaming 3 Ryzen 7 Octa Core 5800H','1001' 'gaming-laptop.webp', 86889.00, 7899.00, 78999.00, 80);
insert into tblProduct values('Watch','VPrime Screen Guard for CROX Noise Colour','NULL' 'watch.webp', 1000.00, 10.00, 100.00, 20);
insert into tblProduct values('Watch','VPrime Screen Guard for CROX Noise Colour','NULL' 'watch.jpg', 1000.00, 10.00, 100.00, 20);
insert into tblProduct values('Watch','VPrime Screen Guard for CROX Noise Colour','NULL' 'watch.jpg', 1000.00, 10.00, 100.00, 20);

delete from tblProduct;
select * from tblProduct;
select * from TblLogin;
delete from TblLogin;




