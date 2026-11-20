# Experiment 10 – Student Management REST API (ASP.NET Core)

**Course:** 01CE1523 - .NET Technologies  
**Student:** Venisha Makadia (92510103027)  
**Department:** Computer Engineering, Marwadi University  

## Features
- RESTful CRUD API endpoints under `/api/Students` (`GET`, `GET /{id}`, `POST`, `PUT /{id}`, `DELETE /{id}`)
- Thread-safe in-memory `StudentService` via dependency injection (`IStudentService`)
- Custom `ExceptionHandlingMiddleware` and `RequestLoggingMiddleware`
- Interactive Swagger / OpenAPI documentation (`/swagger`)

## How to Run
```bash
dotnet restore
dotnet run
```
Open `https://localhost:7168/swagger` to test all endpoints.
