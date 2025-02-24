create database MyLibrary;
use MyLibrary;
create table Books (
BookId int Identity(1,1) primary key,
Title varchar(250) not null,
Author varchar(255)not null,
);
Insert into Books(Title,Author) values('To Kill a Mockingbird', 'Harper Lee'),
('The Great Gatsby', 'F. Scott Fitzgerald'),
('Pride and Prejudice', 'Jane Austen');
select *from Books;