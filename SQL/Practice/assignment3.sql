--Show the most recent five orders that were purchased from account numbers that have spent more than $70,000 with AdventureWorks.

SELECT top 5 SUM(SOH.TotalDue) AS 'Total_Money_Spent',SOH.AccountNumber,SOH.DueDate,soh.AccountNumber
FROM Sales.SalesOrderHeader SOH
GROUP BY SOH.AccountNumber,SOH.DueDate,soh.AccountNumber
HAVING SUM(SOH.TotalDue) > 70000
ORDER BY SOH.DueDate desc

