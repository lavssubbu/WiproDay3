--Aggregate functions - count,sum,avg,min,max
select count(*) as "No:ofEmployees" from employee;
select min(salary) as "MinimumSalary" from employee;
select max(salary) as "MaximumSalary" from employee;
select sum(salary) as "TotalSum" from employee;
select avg(salary) as "AverageSalary" from employee;


--Groupby
select city,count(*) from employee group by city
--having - filters the result of group by clause
select deptid,count(*) from employee group by deptid having count(*)>2

select deptid,city,count(*) from employee group by deptid,city having count(*)>1

--Function
--System Functions
--Date function
select getdate() as TodaysDate
select SYSDATETIME() as Currentdate

alter table employee add joiningdate date

select * from employee where year(joiningdate)>2020 
select * from employee where month(joiningdate)=09

select * from employee where joiningdate >= DateAdd(Day,-30,GetDate())

select Empname,DateDiff(year,joiningdate,getdate()) as Experienceinyears
from employee 

insert into EMployee(empid,empname,deptid,joiningdate) values
(19,'Neha',1,'2023-07-25')

insert into EMployee(empid,empname,deptid,joiningdate) values
(20,'Mahim',3,getdate())

--math functions
select rand() as Randomnumber

select cast(rand() * 50 as int) as RandomInteger

select 10 % 3 as Modfunction
--even employees
select * from employee where empid %2 = 0

--user defined function
--Scalar Valued function - returns single value
create function GetCountEmployee()
returns int
as
begin
   declare @noofempl int;--scalar variable
   select @noofempl=count(*) from employee;
   return @noofempl;
end;

--use function - depends on select in order to call it
select dbo.GetCountEmployee()

alter function GetCountEmployee(@city varchar(20))
returns int
as
begin
   declare @noofempl int;--scalar variable
   select @noofempl=count(*) from employee where city=@city;
   return @noofempl;
end;

select dbo.GetCountEmployee('pune')


--Table valued function
create or alter function 
GetEmployeeSal(@minsalary decimal(8,2),@maxsalary decimal(8,2))
returns table
as
return 
(  
   select * from Employee where salary between @minsalary and @maxsalary
) 

select * from dbo.GetEmployeeSal(55000,70000)

create or alter function eastorwest(@logitude int)
returns char(4) 
as
begin
   declare @res char(4)
   set @res='Same'
   if(@logitude > 0.0)
     set @res='East'
   else
	  set @res='West'
	return @res
end

select dbo.eastorwest(-12)


--Stored Procedure - query to be executed repeatedly - put the query in sp
create or alter procedure sp_emp
as 
begin
  select * from employee;
end

sp_emp

create or alter procedure sp_emp(@minsal decimal(8,2),@maxsal decimal(8,2))
as 
begin
  select * from dbo.GetEmployeeSal(@minsal,@maxsal);
end

sp_emp 60000,80000

--Joins 
create table Student(Regno int not null,stname varchar(35),dept varchar(20),city varchar(25));

create table Fees(Regno int not null,dept varchar(20),FeesPaid decimal(10,2),Paidon date)

select * from student;
select * from Fees

--Inner Join - Common REcords
select S.Regno,S.stname,S.dept,F.FeesPaid,F.Paidon 
from Student S inner join Fees F
on S.Regno = F.Regno

select S.Regno,S.stname,S.dept,F.FeesPaid,F.Paidon 
from Student S,Fees F
where S.Regno = F.Regno

--OuterJoins - Find the unmatching records
--Left Outer -
select S.Regno,S.stname,S.dept,F.FeesPaid,F.Paidon 
from Student S left outer join Fees F
on S.Regno = F.Regno

select e.empid,e.empname,d.deptname from employee e left join department d
on e.deptid = d.did

--Right outer join
select S.Regno,S.stname,S.dept,F.Regno,F.dept,F.FeesPaid,F.Paidon 
from Student S right outer join Fees F
on S.Regno = F.Regno

--Cross Join
select S.Regno,S.stname,S.dept,F.Regno,F.dept,F.FeesPaid,F.Paidon 
from Student S cross join Fees F

--Self join - Join with same table - alias name
alter table Employee add Managerid int

select distinct e.empid,e.empname from employee e join employee e2
on e.empid=e2.managerid

select e.empid,e.empname,e2.empname from employee e join employee e2
on e.empid=e2.managerid
