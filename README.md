# Project Name

## Description

Briefly describe your project, its purpose, and key features.

## Prerequisites


- [.NET SDK 7.0](https://dotnet.microsoft.com/download)
- [PostgreSQL](https://www.postgresql.org/download/)


## Getting Started

1. **Clone the repository:**

    ```bash
    git clone https://github.com/your-username/your-project.git
    ```

2. **Navigate to the project folder:**

    ```bash
    cd your-project
    ```
3. **Write Terminal this key words :**
    ```bash
    dotnet build
    dotnet restore
    ```  
4. **Database Setup:**

    - Create a PostgreSQL database for the project.

    - Update the `appsettings.json` file with your database connection string:

        ```json
        {
    "ConnectionStrings": {
        "DefaultConnectionString": "User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=MediatorAPI_Auth"
    }
          // other settings...
        }
        ```

5. **Run Migrations:**

    ```Package Manager Console Host Version 6.8.0.131

    update-database
    ```

6. **Run the Application:**

    ```bash
    dotnet run
    ```
    
7.**Default **

    The application will be accessible at `http://localhost:7285` (or `https://localhost:7285` for HTTPS).

## Contributing

If you would like to contribute to the project, please follow the [contribution guidelines](CONTRIBUTING.md).

## License

This project is licensed under the [MIT License](LICENSE).

## Acknowledgments

Mention any libraries, tools, or people you want to give credit to.
