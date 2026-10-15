# TaskManager.Api

A task management REST API built with C# and ASP.NET Core.

## About the Project

This project is being developed as a learning and portfolio project to practice backend development, REST APIs, and database integration.

## Technologies

- C#
- ASP.NET Core Web API
- Entity Framework Core
- MySQL
- Swagger / OpenAPI
- Git and GitHub

## Current Features

- Retrieve all tasks
- Retrieve a task by ID
- Create a task
- Update a task
- Delete a task

## Project Structure

- `Controllers` — handles HTTP requests and responses.
- `Models` — contains data models.
- `Services` — contains task-related logic.
- `Data` — contains the Entity Framework Core database context.

## Project Status

Work in progress. MySQL and Entity Framework Core configuration has been added. Integration of the API's CRUD operations with the database is the next development step.

## Running Locally

1. Install the .NET SDK compatible with the project.
2. Install and start MySQL.
3. Configure the `DefaultConnection` connection string using .NET User Secrets.
4. Run the project from Visual Studio.
5. Open the Swagger UI URL shown when the application starts.

## Notes

This is a work in progress. Features and documentation will be updated as development continues.
