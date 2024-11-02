# B2B SaaS Application

This project is a B2B SaaS application with a simple login screen using credentials admin/admin. Upon logging in, users will see an application layout with:
- A horizontal navbar at the top.
- A sidebar with a menu containing "Home" and "Insights".
- A content area on the right.

The application follows Preline design standards throughout the layout.

## Page Requirements

### Home Page
- Display a simple "Hello, world!" message.

### Insights Page
- Include a Preline-style table with columns:
  - Title
  - Source
  - Date
- Populate it with dummy data for now.
- Add a Create button above the table to allow users to add new insights.

## Backend Setup

### .NET 8 Project
- Create a new .NET 8 project with the solution file named `B2BApp.sln`.
- Inside this solution, create a main project called `B2BAppBackend` to handle backend logic.
- Include all necessary .csproj files, .cs files, and folder structures.
- Ensure `B2BApp.sln` is the main entry point and includes `B2BAppBackend` as a project reference.

### Semantic Kernel Integration
- Set up Semantic Kernel in `B2BAppBackend` for document embedding storage and interactions.

### Docker Stack
- Create a Docker Compose file that includes:
  - A PostgreSQL instance with initialization options for a vector table.
  - Ensure all database configurations are set up to support embedding storage.

## Project Structure and Required Files
- Confirm the .sln file (`B2BApp.sln`) is present.
- Confirm the `B2BAppBackend` project contains a structured setup with:
  - Proper folder hierarchy (e.g., Controllers, Models, Services).
  - All necessary .csproj files.
  - `Program.cs` and `Startup.cs` (or equivalent for .NET 8).

## Frontend Setup
- Use Next.js with TailwindCSS and Preline for the frontend UI.

## Setup Instructions

### Backend
1. Navigate to the `backend` directory.
2. Run `dotnet restore` to restore the .NET project dependencies.
3. Run `dotnet build` to build the .NET project.
4. Run `dotnet run` to start the backend server.

### Frontend
1. Navigate to the `frontend` directory.
2. Run `npm install` to install the frontend dependencies.
3. Run `npm run dev` to start the Next.js development server.

## Usage Instructions

### Running the Application
1. Ensure Docker is installed and running on your machine.
2. Navigate to the root directory of the project.
3. Run `docker-compose up` to start the Docker containers.
4. Open your browser and navigate to `http://localhost:3000` to access the application.
