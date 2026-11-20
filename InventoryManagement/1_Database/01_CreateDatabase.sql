USE master;
GO

IF DB_ID(N'InventoryDB') IS NULL
BEGIN
    CREATE DATABASE InventoryDB;
    PRINT 'Database InventoryDB created.';
END
ELSE
    PRINT 'Database InventoryDB already exists.';
GO

USE InventoryDB;
GO
