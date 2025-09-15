# OhMyTasks - Task Management System

This project is an AI-enhanced version of the original [OhMyTasks](https://github.com/medhatelmasry/OhMyTasks.git) repository by Medhat Elmasry. All modifications and enhancements were generated through interaction with GitHub Copilot.

## Project Overview

The project consists of two implementations of a task management system:
1. A Console Application
2. An ASP.NET MVC Web Application with SQL Server persistence

### Features

- Create new tasks
- List all tasks
- Mark tasks as complete/incomplete
- Delete tasks
- Persistent storage (MVC version)
- Clean, responsive UI (MVC version)

## Technical Implementation

### Console Application
- Simple in-memory task management
- Command-line interface
- Basic CRUD operations

### MVC Application
- ASP.NET Core MVC architecture
- Entity Framework Core for data persistence
- SQL Server database integration
- Bootstrap-based responsive UI
- Full CRUD operations with user feedback

## Setup Instructions

### Prerequisites
- .NET 9.0 SDK
- SQL Server (or SQL Server in Docker)
- Visual Studio 2025 or VS Code

### Database Configuration
The application uses SQL Server for data persistence. You'll need to update the connection string in `appsettings.Development.json` according to your SQL Server instance configuration.

Note: For security reasons, never commit sensitive database credentials to source control. Consider using user secrets or environment variables for production deployments.

### Running the Applications

#### Console Application
1. Navigate to the TasksManagerConsole directory
2. Run `dotnet run`

#### MVC Application
1. Navigate to the TasksManagerMVC directory
2. Run the database migrations:
   ```bash
   dotnet ef database update
   ```
3. Start the application:
   ```bash
   dotnet run
   ```
4. Access the application at `http://localhost:5044`

## AI-Generated Enhancements

The following enhancements were added to the original project through GitHub Copilot:

1. Added complete MVC implementation including:
   - Entity Framework Core integration
   - SQL Server database support
   - Full CRUD operations
   - Responsive Bootstrap UI
   - User feedback messages

2. Enhanced the navigation system:
   - Streamlined menu structure
   - Improved task management interface
   - Added confirmation dialogs for deletions

3. Added database persistence:
   - Entity Framework Core migrations
   - SQL Server integration
   - Proper data model with validations

4. Improved user experience:
   - Success/error feedback messages
   - Confirmation dialogs
   - Responsive design
   - Intuitive navigation

## Acknowledgments

- Original project by [Medhat Elmasry](https://github.com/medhatelmasry/OhMyTasks.git)
- All enhancements were generated through GitHub Copilot interaction
- Built with ASP.NET Core and Entity Framework Core

## Technical Notes

- Target Framework: .NET 9.0
- Database: SQL Server
- ORM: Entity Framework Core 9.0.9
- UI Framework: Bootstrap 5
- Authentication: Not implemented (could be added as future enhancement)