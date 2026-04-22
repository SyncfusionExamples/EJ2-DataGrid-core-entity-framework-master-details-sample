# ASP.NET CORE DataGrid - Entity Framework Master Details

## Repository Description

This repository contains an ASP.NET Core sample that demonstrates how to create a master-details grid using Entity Framework and perform advanced grid operations such as filtering, pagination, sorting, and complete CRUD (Create, Read, Update, Delete) functionality using Syncfusion ASP.NET Core DataGrid.

## Project Overview

This sample explains how to implement the master-details grid pattern with ASP.NET Core and Entity Framework. The application showcases best practices for building hierarchical data representations with interactive grid features. Users can expand master rows to view detailed information, manage data through editing and deletion operations, and navigate efficiently using pagination and filtering capabilities. This approach is ideal for applications that need to display complex relational data in an intuitive and user-friendly manner.

## Key Features

- Master-Details Grid layout with expandable rows
- Complete CRUD operations (Create, Read, Update, Delete)
- Advanced filtering capabilities
- Pagination support for efficient data handling
- Multi-column sorting in ascending and descending order
- Entity Framework Core integration for data access
- Responsive design across different devices

## Prerequisites

- Visual Studio 2022
- ASP.NET Core compatible .NET SDK

## Running the Application

Follow the steps below to clone the repository, restore dependencies, and run the application:

1. Clone the repository and navigate to the project directory:

   ```bash
   git clone https://github.com/SyncfusionExamples/EJ2-DataGrid-core-entity-framework-master-details-sample.git
   cd EJ2-DataGrid-core-entity-framework-master-details-sample
   ```

2. Restore the required NuGet packages:

   ```bash
   dotnet restore
   ```

3. Run the application:

   ```bash
   dotnet run
   ```

Once the application starts, launch the displayed application URL in a browser. The master-details grid will load with all CRUD operations, filtering, sorting, and pagination features fully functional.

## Usage Notes

You can customize the DataGrid behavior, appearance, and data bindings in the controller and view files. Modify the Entity Framework model to match your database schema and update the grid configuration as per your requirements.

## Additional Resources

- [Example of Master/Detail in Javascript Data Grid Control](https://ej2.syncfusion.com/demos/grid/master-detail/)
- [Syncfusion ASP.NET Core Grid Documentation](https://ej2.syncfusion.com/aspnetcore/documentation/grid)
- [Syncfusion ASP.NET Core Demos](https://ej2.syncfusion.com/aspnetcore/grid/gridoverview)
- [Entity Framework Core Documentation](https://learn.microsoft.com/en-us/ef/core/)
