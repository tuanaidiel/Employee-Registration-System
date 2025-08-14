This project is a full-stack employee registration system built with React 19 on the frontend and ASP.NET Core 9 on the backend. The frontend, named employee-register-client, is created using Create React App, and communicates with the backend via Axios. It features a clean component-based architecture and uses modern testing libraries such as React Testing Library and Jest DOM for frontend testing. The app is optimized for modern browsers and provides a responsive user experience for registering, viewing, or managing employee data.

The backend is a .NET 9 Web API project that handles all server-side logic, database interactions, and API endpoints. It uses Entity Framework Core 9 with support for both SQL Server and PostgreSQL, providing flexibility in database choices. The project also includes OpenAPI support, which enables automatic API documentation through Swagger. CORS is enabled, allowing the React frontend to interact with the API seamlessly during development and production. Overall, this setup creates a modern, scalable foundation for employee management applications.

_________________________________________________________________________________________

# 👨‍💼 Employee Register

A fullstack application to register employees with image upload functionality, built using **React.js** for the frontend and **ASP.NET Core Web API** for the backend. SQL Server is used as the database with **Entity Framework Core** for ORM.

---

## 🚀 Features

- 📤 Upload an image in **React** and store it via **ASP.NET Core Web API**
- 🗂️ Full CRUD functionality for employee data
- 🖼️ Image preview before upload
- 🧰 SQL Server database with Entity Framework Core
- 🎯 Seamless integration between frontend and backend

---

## 🛠 Tech Stack

### Frontend
- React.js (with Hooks)
- Axios (for HTTP requests)
- Bootstrap or plain CSS (for styling)

### Backend
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server

---

## 📸 Image Upload Flow

1. User selects an image using a file input form in React.
2. A preview of the selected image is displayed instantly.
3. On form submission, the image is sent to the ASP.NET Core Web API.
4. The Web API handles and saves the image to the server and stores the path in the database.