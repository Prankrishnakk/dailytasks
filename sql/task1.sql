create database task1
use task1;
create table books(
BookID int identity(1,1) primary key,
Title varchar(100) not null,
Author varchar(100) not null,
PublishYear int not null,
);
insert into books(Title,Author,PublishYear) Values('To Kill a Mockingbird','Harper Lee', 1960),
    ('The Great Gatsby', 'F. Scott Fitzgerald', 1925),
    ('Pride and Prejudice', 'Jane Austen', 1813),
    ('Moby-Dick', 'Herman Melville', 1851),
    ('War and Peace', 'Leo Tolstoy', 1869),
    ('1984', 'George Orwell', 1949),
    ('Animal Farm', 'George Orwell', 1945),
    ('Sense and Sensibility', 'Jane Austen', 1811);
	
SELECT * FROM books WHERE PublishYear = 1949; 
select distinct  Author from books;

	