create database grtlearndb

select name from master.sys.databases

use grtlearndb

create schema wipro
--DDL - Create,ALter,Truncate and Drop,Rename 
create table wipro.Employee(Empid int,Empname varchar(25),city varchar(20))

create table Employee(Empid int,Empname varchar(25),city varchar(20));
--Alter - Add - New Column
Alter table Employee add dept varchar(10),
                         salary decimal(8,2);
-- Modify existing column - Alter column
Alter table Employee alter column Empid  varchar(3);
--Modified the data type
Alter table Employee alter column Empid  int
--Modified the size of existing data type
Alter table Employee alter column Empname varchar(40)

--make id as not null using alter command
Alter table Employee alter column Empid int not null;

--Read the records
select * from Employee
--truncated - all records gets removed
truncate table Employee 

--drop - entire table gets deleted
drop table Employee

select * from wipro.Empl
--no keyword for rename, we use stored procedure sp_rename
exec sp_rename 'wipro.Empl','Employee'
--DML - Insert,Update,Delete
insert into Employee values(11,'Zara','Pune','Coding',50000)

insert into Employee(Empid,Empname,city) values(12,'Zahir','Pune')

insert into Employee values(13,'Zara','Pune','Coding',50000),
               (14,'Sameera','Chennai','HR',90000),
			   (15,'Punit','Bangalore','Developer',60000),
			   (16,'Shreya','Pune','HR',80000)

update Employee set salary=salary+1000 where dept='coding' or dept='developer'

delete from Employee where empid=14

--DQL - Select
select * from EMployee

select Empname,Dept from Employee where Dept = 'Coding'

--Operators - And,Or,IN,Between,Like
select * from Employee

select * from Employee where salary>55000 and dept='coding'
select * from Employee where salary>55000 or dept='coding'

select * from EMployee where dept in('Coding','hr')
--% any number of characters , _ denotes one character
select * from Employee where empname like '%a' --last character is a
select * from Employee where empname like '%i_'
--like operator with list of characters
select * from Employee where empname like '%[ya]' --last character shall be either y or a
select * from Employee where empname like '[sz]%'

select * from Employee where empname like '[s-z]%' 
select * from Employee where empname like '[^s-z]%' 

select * from Employee where empname not like '%a'


create table Product(Prodid int not null,proName varchar(30),price decimal(10,2),Qty int)

select proname,price,qty,price * qty as TotalPrice from Product

alter table Product add discount varchar(6)

select * from Product where discount like '10!%' escape '!'

