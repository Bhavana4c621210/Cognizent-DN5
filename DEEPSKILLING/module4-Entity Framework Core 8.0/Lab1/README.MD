# Lab 1 - Understanding ORM with EF Core 8.0

## Objective
To understand Object Relational Mapping (ORM) and learn how Entity Framework Core 8.0 maps C# classes to SQL Server database tables.

## Scenario
A retail store requires an inventory management system to manage products, categories, and stock levels using a SQL Server database.

## Tools & Technologies
- Visual Studio 2022
- C#
- .NET 8 Console Application
- Entity Framework Core 8.0
- SQL Server
- SQL Server Management Studio (SSMS)

## EF Core Packages Installed
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Design

## Project Structure
```
RetailInventory
│
├── Models
│   ├── Category.cs
│   └── Product.cs
│
├── AppDbContext.cs
├── Program.cs
└── RetailInventory.csproj
```

## Concepts Learned
- Introduction to Object Relational Mapping (ORM)
- Mapping C# classes to SQL Server tables
- Benefits of ORM
- Difference between EF Core and Entity Framework
- Features of Entity Framework Core 8.0
- Creating a .NET Console Application
- Installing Entity Framework Core packages
- Creating entity models
- Configuring DbContext
- Connecting the application to SQL Server

## Outcome
Successfully created a .NET 8 Console Application, installed Entity Framework Core packages, created entity models (Category and Product), configured the DbContext, and prepared the project for database migrations.

## Author
Bhavana Parupalli
