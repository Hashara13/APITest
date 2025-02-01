
# ASP.Net API

This repository contains an ASP.NET Core Web API project for managing data.

## Description

The  API provides endpoints for performing CRUD (Create, Read, Update, Delete) operations on  records. It uses Entity Framework Core for database operations and follows RESTful API principles.

## Technologies Used

- ASP.NET Core
- Entity Framework Core
- C#

## API Endpoints

- GET /api/Employee - Retrieve all employees
- GET /api/Employee/{id} - Retrieve a specific employee by ID
- POST /api/Employee - Add a new employee
- PUT /api/Employee/{id} - Update an existing employee
- DELETE /api/Employee/{id} - Delete an employee

## Setup

1. Clone the repository:
   ```
   git clone https://github.com/Hashara13/APITest.git
   ```

2. Open the solution in Visual Studio or your preferred IDE.

3. Update the database connection string in `appsettings.json` if necessary.

4. Run the database migrations:
   ```
   dotnet ef database update
   ``

5. Build and run the project.


## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

