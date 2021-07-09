--Create a function that takes as inputs a SalesOrderID, a Currency Code, and a date, and returns a table of all the SalesOrderDetail rows for that Sales Order including Quantity, ProductID, UnitPrice, and the unit price converted to the target currency based on the end of day rate for the date provided. Exchange rates can be found in the Sales.CurrencyRate table. ( Use AdventureWorks)


--fun will take SalesOrderID,Currency Code,date
-- Quantity, ProductID, UnitPrice, and the unit price converted to the target currency 

SELECT TOP(1) * FROM Production.Product;
SELECT TOP(1) * FROM Production.ProductDescription;
SELECT TOP(1) * FROM Sales.SalesOrderHeader;
SELECT TOP(1) * FROM Sales.SalesOrderDetail;
SELECT TOP(1) * FROM Sales.CurrencyRate;


CREATE FUNCTION GetProductDetailPrice
(
	@salesOrderId as nvarchar(100),
	@cc as nvarchar(100),
	@date as datetime
)
RETURNS @table table(ProductID nvarchar(100),UnitPrice MONEY,OrderQty INT,price MONEY)
AS
BEGIN
DECLARE @EndOfTheDayrate Money;
select @EndOfTheDayrate=EndOfDayRate From Sales.CurrencyRate WHERE CurrencyRateDate=@date and ToCurrencyCode=@cc;
INSERT INTO @table
SELECT 
ProductID,
UnitPrice,
OrderQty,
((UnitPrice * OrderQty) * @EndOfTheDayrate) as 'price'
FROM Sales.SalesOrderDetail
WHERE
SalesOrderID=@salesOrderId
RETURN;
END

SELECT * FROM GetProductDetailPrice('43659','ARS','2005-07-01 00:00:00.000');
