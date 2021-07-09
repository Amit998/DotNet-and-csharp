--Write separate queries using a join, a subquery, a CTE, and then an EXISTS to list all AdventureWorks customers who have not placed an order.

--using join

SELECT *
FROM Sales.Customer c
LEFT OUTER JOIN Sales.SalesOrderHeader s ON c.CustomerID = s.CustomerID
WHERE s.PurchaseOrderNumber IS NULL;

--using subquery

SELECT * FROM Sales.Customer c
WHERE c.CustomerID in(
SELECT s.CustomerID
FROM Sales.SalesOrderHeader s
WHERE s.PurchaseOrderNumber IS NULL
)



--using CTE

WITH s AS
(
	SELECT *
	FROM Sales.SalesOrderHeader
)
SELECT * FROM Sales.Customer c
LEFT OUTER JOIN s ON c.CustomerID=s.CustomerID
WHERE s.PurchaseOrderNumber IS NULL order by c.CustomerID;

--using exists

SELECT *
FROM Sales.Customer c
where EXISTS(
SELECT * FROM Sales.SalesOrderHeader s
WHERE c.CustomerID=s.CustomerID AND s.PurchaseOrderNumber IS NULL);

