create database new
use new
create table StdDetls(ID int identity(1,1) primary Key,Name varchar(100),Mark int,Age int)
insert into StdDetls(Name,Mark,Age)values
('pran',10,24),
('habeeb',20,23),
('anwar',30,34),
('ameen',40,22);
select * from StdDetls

create procedure getdatas 
@names varchar(255)
as 
begin
select * from StdDetls where Name=@names
end
getdatas 'pran'

CREATE PROCEDURE GetNames
AS
BEGIN
    SELECT Name FROM StdDetls;
END;

exec GetNames

alter procedure Getage
@age int
as
begin
select Name,Age from StdDetls where Age = @age
end
Getage 34

select MAX(Mark) from  StdDetls

SELECT *
FROM StdDetls
WHERE Mark = (SELECT MAX(Mark) FROM StdDetls);















