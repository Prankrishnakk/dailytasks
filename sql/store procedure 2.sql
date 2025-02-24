SELECT TOP (1000) [Book_Id]
      ,[Title]
      ,[Publishyear]
  FROM [review].[dbo].[Book]

create Procedure GetTitle @title varchar(250)
as
begin
select *from Book where Title = @title
end
exec GetTitle @title = 'alone'
select * from Book 
