# TaskManager.Api

A task management REST API built with C# and ASP.NET Core.

> **Project status: In Progress**  
> This is an active learning and portfolio project. Core CRUD endpoints are implemented, and database integration is currently in progress.

## Technologies

- C#
- ASP.NET Core Web API
- Entity Framework Core
- MySQL
- Swagger / OpenAPI
- Git and GitHub

## Implemented Features

- [x] Retrieve all tasks
- [x] Retrieve a task by ID
- [x] Create a task
- [x] Update an existing task
- [x] Delete a task
- [x] Separate HTTP handling from task-related logic using a service
- [x] Configure Swagger for API testing
- [x] Add an initial Entity Framework Core and MySQL configuration

## Work in Progress

- [ ] Connect CRUD operations to MySQL through Entity Framework Core
- [ ] Replace in-memory task storage with database persistence
- [ ] Configure and verify database schema management
- [ ] Add input validation and consistent error handling
- [ ] Add automated tests

## Project Structure

- `Controllers` — handles HTTP requests and responses.
- `Models` — defines task data.
- `Services` — contains task-related logic.
- `Data` — contains the Entity Framework Core database context.

## Running Locally

1. Install the .NET SDK compatible with the project.
2. Install and start MySQL.
3. Configure the `DefaultConnection` connection string using .NET User Secrets.
4. Run the project in Visual Studio.
5. Open the Swagger UI URL shown when the application starts.

**Note:** Database integration is still in progress. The current task storage is in memory, so task changes are not preserved after the application restarts.

## Future Improvements

- Complete MySQL integration
- Add automated tests
- Improve validation and error handling
- Add authentication and authorization
- Improve API documentation

## Purpose

This project is being developed to practice backend development with C#, ASP.NET Core, REST APIs, and relational databases. The README will be updated as new features are implemented.
