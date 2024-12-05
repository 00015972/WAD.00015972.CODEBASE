# This application was developed for Web Application module, as coursework portfolio project @ WIUT by student ID: 00015972

# Key Store Application API

I divided 15972 by 20 and got remainder 12. My topic is 12th (Key Store Application).

It is a simple RESTful API for managing key-value pairs in a key store using ASP.NET Core Web API (version 6.0). The project demonstrates the use of the **Repository Pattern** for better code organization and maintainability.

---

## Project Description

The **Key Store Application** provides an API to manage key-value pairs. Each key includes information such as its name, description, and value. The project focuses on implementing CRUD (Create, Read, Update, Delete) operations and ensures clean architecture by applying the Repository Pattern.

---

## Features

1. CRUD operations for managing keys.
2. Repository Pattern for abstracting database interactions.
3. SQL Server integration with Entity Framework Core for data persistence.
4. API documentation using Swagger.

---

## Prerequisites

Before running the application, ensure the following tools and software are installed:
- **.NET SDK** (version 6.0 or later)
- **NuGet Packages**
-   Microsoft.EntityFrameworkCore (6.0.36)
-   Microsoft.EntityFrameworkCore.SqlServer (6.0.36)
-   Microsoft.EntityFrameworkCore.Tools (6.0.36)
-   Swashbuckle.AspNetCore (6.9.0)
-   
- **SQL Server** (Server Name: `localhost\SQLEXPRESS`)

---

## Setup Instructions

### 1. Clone the Repository
Clone the project repository to your local machine:
```bash
git clone https://github.com/00015972/WAD.00015972.CODEBASE.git
cd Back_End_00015972
```

#Important Note

Some folders (bin, obj, .vs) could not be committed to the GitHub as Visual Studio showed error and restrictions to these folders


