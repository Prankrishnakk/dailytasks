create table students(Id int primary key identity(1,1),Name varchar(200),age int)
insert into students(Name,age)values
('pran',24);
select * from students
drop  table students