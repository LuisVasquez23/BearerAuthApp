# BearerAuthApp - Bearer Auth Web API

## Overview

This project is a RESTful API built with .NET Core 8, utilizing Entity Framework Core with SQLite. This API provides a Auth App using Bearer.

## Features

- **SQLite Database**: Lightweight and easy-to-configure database for quick development and testing.
- **Entity Framework Core**: Simplifies data access with a robust ORM framework.


## Setup and Running

1. **Clone the repository**:
    ```bash
    git clone https://github.com/LuisVasquez23/BearerAuthApp.git
    cd BearerAuthApp
    ```

2. **Install dependencies**:
    ```bash
    dotnet restore
    ```

3. **Configure the database**:
    Update the connection string in `appsettings.json` if necessary:
    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Data Source=BeareAuthApp.db"
      },
      "Logging": {
        "LogLevel": {
          "Default": "Information",
          "Microsoft.AspNetCore": "Warning"
        }
      },
      "AllowedHosts": "*"
    }
    ```

4. **Apply migrations and create the database**:
    ```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update
    ```

5. **Run the application**:
    ```bash
    dotnet run
    ```

6. **Explore the API**:
    The API can be tested using tools like Postman or through the built-in Swagger UI available at `https://localhost:[PORT]/swagger/index`.

## Contribution

Contributions are welcome! Please open an issue or submit a pull request for any changes or improvements.
