--1.	Display the number of records in the [SalesPerson] table. (Schema(s) involved: Sales)

select * from HumanResources.Department;

--2.	Select both the FirstName and LastName of records from the Person table where the FirstName begins with the letter ‘B’. (Schema(s) involved: Person)

SELECT FirstName,LastName FROM Person.Person WHERE FirstName like 'B%';

--3.	Select a list of FirstName and LastName for employees where Title is one of Design Engineer, Tool Designer or Marketing Assistant. (Schema(s) involved: HumanResources, Person)

SELECT 
Person.Person.FirstName,
Person.Person.LastName,
HumanResources.Employee.JobTitle
From Person.Person
INNER JOIN HumanResources.Employee
ON 
Person.BusinessEntityID = HumanResources.Employee.BusinessEntityID
WHERE
HumanResources.Employee.JobTitle='Design Engineer' 
or
HumanResources.Employee.JobTitle='Marketing Assistant'
or
HumanResources.Employee.JobTitle='Tool Designer';

--4.	Display the Name and Color of the Product with the maximum weight. (Schema(s) involved: Production)

SELECT TOP 1
Name,
Color,
Weight 
From Production.Product 
Where
Weight is not null and Color is not null 
ORDER BY Weight DESC;

--5.	Display Description and MaxQty fields from the SpecialOffer table. Some of the MaxQty values are NULL, in this case display the value 0.00 instead. (Schema(s) involved: Sales)

SELECT 
ISNULL(MaxQty,0.00) AS QTY,
Description
FROM 
Sales.SpecialOffer;


--6.	Display the overall Average of the [CurrencyRate].[AverageRate] values for the exchange rate ‘USD’ to ‘GBP’ for the year 2005 i.e. FromCurrencyCode = ‘USD’ and ToCurrencyCode = ‘GBP’. Note: The field [CurrencyRate].[AverageRate] is defined as 'Average exchange rate for the day.' (Schema(s) involved: Sales)

SELECT 
CurrencyRateDate,
FromCurrencyCode,
ToCurrencyCode,
AverageRate
FROM 
Sales.CurrencyRate
WHERE 
datepart(year,CurrencyRateDate)=2005
and
FromCurrencyCode='USD'
and
ToCurrencyCode='GBP';

--7.	Display the FirstName and LastName of records from the Person table where FirstName contains the letters ‘ss’. Display an additional column with sequential numbers for each row returned beginning at integer 1. (Schema(s) involved: Person)

SELECT
ROW_NUMBER()
OVER
(
ORDER BY FirstName ASC
)row_num,
FirstName,LastName
FROM Person.Person
WHERE FirstName
like '%ss%';

--8.	Sales people receive various commission rates that belong to 1 of 4 bands. (Schema(s) involved: Sales)
--CommissionPct	 Commission Band
--	0.00			Band 0
--	Up To 1%		Band 1
--	Up To 1.5%		Band 2
--	Greater 1.5%	Band 3
--Display the [SalesPersonID] with an additional column entitled ‘Commission Band’ indicating the appropriate band as above

SELECT 
BusinessEntityID  as SalesPersonID,
CommissionPct,
'Commission Band'=
CASE WHEN CommissionPct = 0.00 THEN 'Brand 0'
when CommissionPct > 0 and CommissionPct <= 0.01 then 'band 1'
when CommissionPct > 0.01 and CommissionPct <= 0.015 then 'band 2'
when CommissionPct < 0.15  then 'band 3'
END
FROM Sales.SalesPerson
ORDER BY CommissionPct;


--9.	Display the managerial hierarchy from Ruth Ellerbrock (person type – EM) up to CEO Ken Sanchez. Hint: use [uspGetEmployeeManagers] (Schema(s) involved: [Person], [HumanResources]) 

SELECT
Person.Person.BusinessEntityID,
Person.Person.FirstName,
Person.Person.LastName,
Person.Person.PersonType,
HumanResources.EmployeePayHistory.Rate,
HumanResources.Employee.OrganizationLevel,
HumanResources.Employee.JobTitle
FROM
HumanResources.Employee INNER JOIN 
HumanResources.EmployeePayHistory
ON
HumanResources.Employee.BusinessEntityID=HumanResources.EmployeePayHistory.BusinessEntityID
INNER JOIN
Person.Person
ON
HumanResources.Employee.BusinessEntityID=Person.Person.BusinessEntityID
WHERE
Person.Person.PersonType ='EM' and
Person.Person.BusinessEntityID < 49
order by Person.Person.BusinessEntityID asc;


--10.	Display the ProductId of the product with the largest stock level. Hint: Use the Scalar-valued function [dbo]. [UfnGetStock]. (Schema(s) involved: Production)

SELECT TOP 1
ProductID,
SUM(PI.Quantity) as 'Total qty' 
FROM 
Production.ProductInventory PI
group by ProductID
order by SUM(PI.Quantity) desc;



