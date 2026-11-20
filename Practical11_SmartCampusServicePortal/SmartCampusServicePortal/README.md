# Experiment 11 – Smart Campus Service Portal (MVC + SQLite + REST API)

**Course:** 01CE1523 - .NET Technologies  
**Student:** Venisha Makadia (92510103027)  
**Department:** Computer Engineering, Marwadi University  

## Features
- ASP.NET Core MVC Dashboard with live request counters (`Total`, `Pending`, `Completed`)
- Entity Framework Core + SQLite (`campus.db`) with automatic database creation and seed data
- Create, list, update status (`Pending`, `In Progress`, `Completed`), and delete campus service requests
- Integrated REST API endpoints at `/api/requests` (`GET`, `GET /{id}`, `POST`)

## How to Run
```bash
dotnet restore
dotnet run
```
- Web UI: `https://localhost:7148`
- REST API JSON: `https://localhost:7148/api/requests`
