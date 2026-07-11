# Module 5 - Lab 1: Understanding ORM with a Retail Inventory System

## Objective
The objective of this lab is to understand Object Relational Mapping (ORM) using Entity Framework Core and learn how it maps C# classes to SQL Server database tables.

## Scenario
A retail inventory management system is developed to manage products, categories, and stock information using Entity Framework Core with SQL Server.

## Technologies Used
- C#
- .NET 8 Console Application
- Entity Framework Core
- SQL Server
- Visual Studio 2026

## Packages Installed
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Design
- dotnet-ef

## Project Structure

```
RetailInventory
│
├── Data
│   └── AppDbContext.cs
│
├── Models
│   ├── Product.cs
│   └── Category.cs
│
├── Migrations
│
├── Program.cs
└── RetailInventory.csproj
```

## Features Implemented
- Created Product entity.
- Created Category entity.
- Configured AppDbContext.
- Connected Entity Framework Core with SQL Server.
- Created initial migration.
- Generated SQL Server database using Entity Framework Core.

## Commands Executed

```bash
dotnet new console -n RetailInventory

dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet tool install --global dotnet-ef

dotnet ef migrations add InitialCreate

dotnet ef database update
```

## Outcome
Successfully understood the fundamentals of Object Relational Mapping (ORM) using Entity Framework Core, created entity models, configured DbContext, generated migrations, and created the SQL Server database.

## Author
**Bhavana**
