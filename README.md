# Library Project, Book Manager for a Librarian

#### Many-to-Many Relationships with C# Exercise for Epicodus 08.11.2020

### By Kate Skorija, Mariel Hamson, & Teresa Roskinski

## Description

This is an unfinished educational project for Epicodus. It was built to help librarians manage their catalog of books. We practiced many-to-many relationships with a SQL database, and experimented with adding authentication using Entity and Identity. 

## Setup/Installation Requirements

*_These instructions are specifically for MySql Workbench, but should work similarly for or any generic SQL database manager._* 

1.  Navigate to the [Library.Solution respository](https://github.com/kate-skorija/Library.Solution) or open your terminal

2. Clone this project using the GitHub button or the command:
`$ git clone https://github.com/kate-skorija/Library.Solution.git`

3. Navigate to the `Library.Solution` directory in your editor of choice, or use [Visual Studio Code](https://code.visualstudio.com/)

4. Within the project, navigate to the Library directory, and type `dotnet restore`, then `dotnet build`. 

5. After building successfully, enter `dotnet ef migrations add Initial`. If there is an `Unable to resolve project` error, ensure you are in the correct directory, Factory. A Migrations folder should automatically generate in the Factory directory.

6. After the initial migration is complete, run the command `dotnet ef database update`. This will create a `catalog` database. Refresh MySql Workbench and confirm that the new database has been created.

7. Type `dotnet run` into the terminal. Click on the provided local host link in the terminal to view the web application in your browser. 

## Known Bugs

There are no known bugs at this time.

## Support and Contact Details

If there are any issues or questions, please reach out to me through [my GitHub account](https://github.com/kate-skorija).

## Technologies Used

*  [Visual Studio Code](https://code.visualstudio.com/)
*  [Markdown](https://daringfireball.net/projects/markdown/)
*  [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
*  [.NET-Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)
*  [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
*  [Entity](https://docs.microsoft.com/en-us/ef/)

### License

*This project uses the following license: [MIT](https://opensource.org/licenses/MIT)*

Copyright (c) 2020 **_Kate Skorija_** 
