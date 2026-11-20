USE InventoryDB;
GO

PRINT 'CREATE - add a product';
INSERT INTO dbo.Products (ProductName, Category, Price, Quantity, Supplier)
VALUES (N'Laptop Stand', N'Accessories', 1299.00, 20, N'Digital Store');

PRINT 'READ - all products';
SELECT ProductId, ProductName, Category, Price, Quantity, Supplier
FROM   dbo.Products
ORDER  BY ProductId DESC;

PRINT 'READ - one product by id';
SELECT ProductId, ProductName, Category, Price, Quantity, Supplier
FROM   dbo.Products
WHERE  ProductId = 1;

PRINT 'READ - search by name, category or supplier';
SELECT ProductId, ProductName, Category, Price, Quantity, Supplier
FROM   dbo.Products
WHERE  ProductName LIKE '%mouse%'
   OR  Category    LIKE '%mouse%'
   OR  Supplier    LIKE '%mouse%';

PRINT 'UPDATE - edit a product';
UPDATE dbo.Products
SET    ProductName = N'Wireless Mouse Pro', Price = 899.00, Quantity = 30
WHERE  ProductId = 1;

PRINT 'DELETE - remove a product';
DELETE FROM dbo.Products
WHERE  ProductId = 6;

PRINT 'REPORT - low stock';
SELECT * FROM dbo.Products WHERE Quantity < 10;

PRINT 'REPORT - per category summary';
SELECT Category, COUNT(*) AS Items, SUM(Quantity) AS TotalUnits,
       SUM(Price * Quantity) AS StockValue
FROM   dbo.Products
GROUP  BY Category;
GO
