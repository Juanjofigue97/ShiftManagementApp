# Shift Management System

## Project Overview
The Shift Management System is a web-based application designed to help businesses manage customer service shifts, allowing administrators to control services, service locations, and assign staff to shifts. The project is developed using the Clean Architecture pattern to ensure maintainability, testability, and scalability.


## Technologies
* .NET 7: Core framework for the API and backend services.
* Entity Framework Core: ORM for database interaction.
* SQL Server: Database management system.
* REST API: For handling requests and responses.
* XUnit: Unit testing framework.

## Getting Started

1. Clone the repository:

    ```bash
    git clone https://github.com/your-username/your-repo.git
    ```

2. Navigate to the project directory
    
    ```bash
    cd ShiftManagementApp\ShiftManagementApp.API 
    ```
3. Update the database
    ```bash
    dotnet ef database update 
    ```
4. Run the project:
    ```bash
    dotnet run
    ```

http://localhost:5260

## Front end

1. Navigate to the project directory
    
    ```bash
    cd ShiftManagementApp\ShiftmanagementApp.UI
    ```
2. Install Dependecies
    ```bash
    npm install
    ```

3. Run the project:
    ```bash
    npm dev run
    ```
http://localhost:5173