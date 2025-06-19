# ConsoleToAPI

This is my dedicated project for daily learning of **ASP.NET Core Web API**.

Each day, I add new concepts, controllers, models, and features to explore and understand how ASP.NET Core Web API works from the ground up.

---

## 📌 Project Purpose

To document and practice building real-world REST APIs using:
- ASP.NET Core (.NET 8)
- Visual Studio / VS Code
- SQL Server (optional)
- Entity Framework Core (in progress)

---

## 📅 Daily Progress Log

| Date       | Description                                                  |
|------------|--------------------------------------------------------------|
| 2025-06-08 | Project initialized, created solution structure              |
| 2025-06-09 | Added `EmployeeController`, implemented basic GET/POST       |
| 2025-06-10 | Added `AnimalController`, tested routes with Postman         |
| 2025-06-11 | Configured DB context, added EF Core models                  |
| 2025-06-12 | Created and applied initial migrations                       |
| 2025-06-13 | Integrated Repository pattern, created `IEmployeeRepo`       |
| 2025-06-14 | Connected API to stored procedure for student insert         |
| 2025-06-15 | Added method to fetch student scores using stored procedure  |
| 2025-06-16 | Wrote queries to get highest scoring subjects per student    |
| 2025-06-17 | Added average score by teacher query + flag-based SP logic   |
| 2025-06-18 | Created a a procedure TopStudentsPerTeacher to return top 3 students (by average marks) for each teacher and integerated it with the API controller|


---

## 🛠️ How to Run


cd ConsoleToAPI
dotnet run
