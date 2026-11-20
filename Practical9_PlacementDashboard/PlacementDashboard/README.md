# Experiment 9 – Placement Dashboard & Printable Report

**Course:** 01CE1523 - .NET Technologies  
**Student:** Venisha Makadia (92510103027)  
**Department:** Computer Engineering, Marwadi University  

## Features
- SQL Server relational schema (`Student`, `Company`, `Placement`) with sample data (`1_Database/`)
- Summary KPI cards (Total Students, Students Placed, Companies, Average Package LPA)
- Status-based filtering (`All`, `Placed`, `In Process`, `Not Placed`)
- Company-wise placement summary table
- Printable HTML-to-PDF report view (`/Placement/Report`) as a modern alternative to Crystal Reports

## How to Run
1. Execute `1_Database/01_CreateDatabase.sql` and `1_Database/02_CreateTablesAndSampleData.sql` in SQL Server / LocalDB.
2. Verify the connection string in `appsettings.json` (see `2_Connection/ConnectionStrings.txt`).
3. Run:
   ```bash
   dotnet restore
   dotnet run
   ```
