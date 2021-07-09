--Write a Procedure supplying name information from the Person.Person table and accepting a filter for the first name. Alter the above Store Procedure to supply Default Values if user does not enter any value.( Use AdventureWorks)


CREATE procedure AddName
  @name varchar(50) 
as
if @name is null begin;
  set @name='someone'
end;
SELECT FirstName,MiddleName,LastName
FROM Person.Person
WHERE FirstName=@Name;


ALTER procedure AddName
  @name varchar(50) 
as
if @name is null begin;
  set @name='syed'
end;
SELECT FirstName,MiddleName,LastName
FROM Person.Person
WHERE FirstName=@Name;


EXEC AddName null