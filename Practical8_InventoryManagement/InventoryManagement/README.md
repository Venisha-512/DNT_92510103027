# Experiment 8 – Inventory Management Module (ADO.NET & CRUD Operations)

**Course:** 01CE1523 - .NET Technologies  
**Student:** Venisha Makadia (92510103027)  
**Department:** Computer Engineering, Marwadi University  

## Features
- SQL Server database setup scripts (`1_Database/`)
- Parameterized ADO.NET CRUD operations using `Microsoft.Data.SqlClient`
- Search by product name, category, or supplier
- Live stock count and total stock value dashboard

## How to Run
1. Execute `1_Database/01_CreateDatabase.sql` and `1_Database/02_CreateTables.sql` in SQL Server / LocalDB.
2. Verify the connection string in `appsettings.json` (see `2_Connection/ConnectionStrings.txt` for alternatives).
3. Run:
   ```bash
   dotnet restore
   dotnet run
   ```
