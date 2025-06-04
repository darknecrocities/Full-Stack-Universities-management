
🎓 Student Manager Web App

A full-stack Student Manager system with **Angular Frontend** and **ASP.NET Core C# Backend** using **SQL Server** and **ADO.NET** for database operations.

📚 Table of Contents
- 🧰 Tech Stack
- 📦 Project Structure
- 🚀 Getting Started
  - Backend (C# API)
  - Frontend (Angular)
- 📝 Features
- 🔧 Future Improvements

🧰 Tech Stack

| Layer      | Technology          |
|------------|---------------------|
| Frontend   | Angular             |
| Backend    | ASP.NET Core (C#)   |
| Database   | SQL Server          |
| DB Access  | ADO.NET             |
| Styling    | CSS with Gradients |
| Runtime    | Node.js, .NET 6+    |

📦 Project Structure

/StudentManagerApp
├── StudentManagerAPI/         # C# ASP.NET Core Web API (Backend)
│   ├── Controllers/
│   ├── Models/
│   └── appsettings.json       # DB connection string
│
└── student-manager-angular/   # Angular project (Frontend)
    ├── src/
    └── angular.json

🚀 Getting Started

🛠 Prerequisites
- Node.js
- Angular CLI
- .NET 6+ SDK
- SQL Server

🔙 Backend (C# API)

1. Navigate to backend folder
   cd StudentManagerAPI

2. Set your connection string
   Open appsettings.json and modify:
   "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_SERVER;Database=StudentDB;Trusted_Connection=True;"
   }

3. Run the project
   dotnet build
   dotnet run

4. API Endpoints:
   - GET /api/students – fetch all students
   - POST /api/students – add a student
   - PUT /api/students/{id} – update student
   - DELETE /api/students/{id} – delete student

🔜 Frontend (Angular)

1. Navigate to frontend folder
   cd student-manager-angular

2. Install dependencies
   npm install

3. Start Angular server
   ng serve

4. Access App
   Visit: http://localhost:4200

📝 Features

- ✅ Add, view, update, and delete students (CRUD)
- ✅ Colorful and responsive form design
- ✅ Angular connects to real C# backend
- ✅ SQL Server via ADO.NET
- ✅ Easy to scale into a production-ready system

🔧 Future Improvements

- 🔐 JWT Authentication and role-based access
- 🎨 UI enhancements (pagination, validation, alerts)
- 🧱 Entity Framework version
- 🐳 Dockerized deployment

✨ Credits
Created by Rhonzkiee
Email: parejasarronkian@gmail.com
