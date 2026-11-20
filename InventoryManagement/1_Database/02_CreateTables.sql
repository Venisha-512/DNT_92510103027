USE InventoryDB;
GO

DROP TABLE IF EXISTS dbo.Products;
GO

CREATE TABLE dbo.Products
(
    ProductId    INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Products PRIMARY KEY,
    ProductName  NVARCHAR(100)     NOT NULL,
    Category     NVARCHAR(50)      NOT NULL,
    Price        DECIMAL(18,2)     NOT NULL CONSTRAINT CK_Products_Price CHECK (Price > 0),
    Quantity     INT               NOT NULL CONSTRAINT CK_Products_Quantity CHECK (Quantity >= 0),
    Supplier     NVARCHAR(100)     NOT NULL
);
GO

INSERT INTO dbo.Products (ProductName, Category, Price, Quantity, Supplier) VALUES
(N'Wireless Mouse',      N'Electronics', 599.00,  45,  N'Tech World'),
(N'Mechanical Keyboard', N'Electronics', 2499.00, 12,  N'Computer Hub'),
(N'A4 Paper Ream',       N'Stationery',  285.50,  120, N'ABC Stationers'),
(N'Office Chair',        N'Furniture',   5499.00, 4,   N'Comfort Furniture'),
(N'USB-C Cable',         N'Accessories', 199.00,  60,  N'Digital Store');
GO

SELECT * FROM dbo.Products;
GO
