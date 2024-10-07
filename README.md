**Overview**
This Employee Management System is a full-stack web application developed using ASP.NET Core Web API for the backend and React for the frontend.
The system allows users to perform CRUD (Create, Read, Update, Delete) operations on employee records with token-based authentication using JWT (JSON Web Token).

Technologies Used:

Backend: ASP.NET Core Web API

Frontend: React

Database: SQL Server

Authentication: JWT


**Application Architecture**
Backend (ASP.NET Core Web API):
Controllers:

LoginController: Handles user authentication and JWT token generation.

EmployeesController: Manages CRUD operations for employee data.

Services:

JWT Token Generation.

Database interaction.

Frontend (React):
Components:

EmployeeForm.js: A form to add and update employee details.

EmployeeList.js: A list view to display all employees, with options to edit or delete them.

App.js: Main component that handles state management and coordination between EmployeeForm and EmployeeList.

API Calls:Defined in api.js, handling API requests for employee CRUD operations.
