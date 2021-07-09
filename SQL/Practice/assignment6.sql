--Write a trigger for the Product table to ensure the list price can never be raised more than 15 Percent in a single change. Modify the above trigger to execute its check code only if the ListPrice column is   updated (Use AdventureWorks Database).

CREATE TRIGGER priceLimitChange
ON Production.Product
FOR UPDATE
AS
IF EXISTS(
SELECT * FROM inserted newVal
join
deleted oldVal
ON newVal.ProductID=oldVal.ProductID
WHERE newVal.ListPrice > (oldVal.ListPrice * 1.15)
)
BEGIN
RAISERROR('THE INCREASE VALUE CAN NOT BE GREATER THEN 15 %',16,1)
ROLLBACK TRANSACTION
END
GO

