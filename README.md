# AnyDataBaseFluent

![NuGet Version](https://img.shields.io/nuget/v/BinaryCoffee.AnyDataBaseFluent?style=flat-square)
![Build Status](https://github.com/stescobedo92/AnyDataBaseFluent/actions/workflows/dotnet.yml/badge.svg)
![License](https://img.shields.io/github/license/stescobedo92/AnyDataBaseFluent?style=flat-square)

**AnyDataBaseFluent** is a versatile and intuitive C# library designed to fluently create database schemas for a variety of database management systems. It simplifies the process of generating SQL scripts using a readable and expressive fluent interface.

## ?? Supported Databases

The library currently supports the creation of schema scripts for the following databases:

- **Microsoft SQL Server**
- **MySQL**
- **PostgreSQL**
- **Oracle**
- **SQLite**
- **Firebird**
- **Microsoft Access**

## ?? Installation

You can install `AnyDataBaseFluent` via the NuGet Package Manager console:

```bash
Install-Package BinaryCoffee.AnyDataBaseFluent
```

Or via the .NET CLI:

```bash
dotnet add package BinaryCoffee.AnyDataBaseFluent
```

## ?? Usage

Below is an example of how to use `AnyDataBaseFluent` to define a database schema with tables, columns, and constraints, and then generate the corresponding SQL script.

### C# Fluent Definitions

```csharp
using AnyDataBaseFluent;
using AnyDataBaseFluent.EnumTypes;
using System.Data;

// Initialize the database writer (e.g., StringWriter or StreamWriter)
using var writer = new StreamWriter("script.sql");

DatabaseFactory.Create(DatabaseType.SQLSERVER)
    .WithName("AnyBusiness")
    .UsingSchema("Test")
    .HasTable(table => table
        .WithName("Companies")
        .HasColumn(column => column
            .WithName("Id")
            .OfType(SqlDbType.Int)
            .IsAutoIncrementing()
            .HasConstraint(c => c.OfType(ConstraintType.NotNull))
            .HasConstraint(c => c.OfType(ConstraintType.PrimaryKey).WithName("PK_Companies_Id"))
        )
        .HasColumn(column => column
            .WithName("Name")
            .OfType(SqlDbType.NVarChar, 100)
            .HasConstraint(c => c.OfType(ConstraintType.NotNull))
        )
    )
    .HasTable(table => table
        .WithName("Employees")
        .HasColumn(column => column
            .WithName("Id")
            .OfType(SqlDbType.Int)
            .IsAutoIncrementing()
            .HasConstraint(c => c.OfType(ConstraintType.NotNull))
            .HasConstraint(c => c.OfType(ConstraintType.PrimaryKey).WithName("PK_Employees_Id"))
        )
        .HasColumn(column => column
            .WithName("CompanyId")
            .OfType(SqlDbType.Int)
            .HasConstraint(c => c.OfType(ConstraintType.NotNull))
            .HasConstraint(c => c
                .WithName("FK_Employees_CompanyId")
                .OfType(ConstraintType.ForeignKey)
                .HasReferenceTo("Companies", "Id")
            )
        )
        .HasColumn(column => column
            .WithName("Name")
            .OfType(SqlDbType.NVarChar, 50)
            .HasConstraint(c => c.OfType(ConstraintType.NotNull))
        )
        .HasColumn(column => column
            .WithName("Bio")
            .OfType(SqlDbType.NVarChar, ColumnSize.Max)
        )
    )
    .Write(writer);
```

### Generated SQL Output

The code above creates a script similar to:

```sql
USE [AnyBusiness]

CREATE TABLE [Test].[Companies]
(
    [Id] INT IDENTITY NOT NULL CONSTRAINT [PK_Companies_Id] PRIMARY KEY,
    [Name] NVARCHAR ( 100 ) NOT NULL,
)

CREATE TABLE [Test].[Employees]
(
    [Id] INT IDENTITY NOT NULL CONSTRAINT [PK_Employees_Id] PRIMARY KEY,
    [CompanyId] INT NOT NULL CONSTRAINT [FK_Employees_CompanyId] FOREIGN KEY REFERENCES [Companies] ( [Id] ),
    [Name] NVARCHAR ( 50 ) NOT NULL,
    [Bio] NVARCHAR ( MAX ),
)
```

## ?? Contributing

Contributions are welcome! If you find a bug or want to add a feature (like support for a new database), please feel free to submit a pull request or open an issue.

## ?? License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---
*Copyright © Sergio Triana Escobedo*
