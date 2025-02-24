create table Products (ProductId int identity(1,1), ProductName varchar(255),Price bigint, Quantity int)
insert into Products(ProductName,Price,Quantity)Values
('Smartphone', 699, 50),
('Laptop', 1199, 30),
('Wireless Mouse', 25, 150),
('Bluetooth Speaker', 89, 75),
('LED Monitor', 179, 40);
select * from Products
drop table Products
create table Sales (SaleId int identity(1,1),ProductID int, SalesQty int)
insert into Sales(ProductID,SalesQty)values
(1,10),
(1,20),
(1,30);
select * from Sales
