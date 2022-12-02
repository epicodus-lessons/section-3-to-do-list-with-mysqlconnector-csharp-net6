## What Is This?
 
This is an example repo corresponding to multiple lessons within the LearnHowToProgram.com walkthrough on creating a To Do List application in [Section 3: Database Basics](https://www.learnhowtoprogram.com/c-and-net/database-basics).
 
This project corresponds to the classwork and lessons that describe how to connect an ASP.NET Core MVC project to a MySQL database using [the MySqlConnector package](https://mysqlconnector.net/). Here are the lessons in the series:

- [Introduction to MySQL Workbench: Creating a Database](https://www.learnhowtoprogram.com/c-and-net/database-basics/introduction-to-mysql-workbench-creating-a-database)
- [Connecting a Database to an ASP.NET Core App with MySqlConnector](https://www.learnhowtoprogram.com/c-and-net/database-basics/connecting-a-database-to-an-asp-net-core-app-with-mysqlconnector) 
- [Retrieving Objects From the Database](https://www.learnhowtoprogram.com/c-and-net/database-basics/retrieving-objects-from-the-database)
- [Testing Database Backed Applications](https://www.learnhowtoprogram.com/c-and-net/database-basics/testing-database-backed-applications)
- [Creating a Test Database: Exporting and Importing Databases with MySQL Workbench](https://www.learnhowtoprogram.com/c-and-net/database-basics/creating-a-test-database-exporting-and-importing-databases-with-mysql-workbench)
- [Using the Test Database](https://www.learnhowtoprogram.com/c-and-net/database-basics/using-the-test-database)
- [Deleting Objects in the Database](https://www.learnhowtoprogram.com/c-and-net/database-basics/deleting-objects-in-the-database)
- [Testing for an Empty Database](https://www.learnhowtoprogram.com/c-and-net/database-basics/testing-for-an-empty-database)
- [Overriding Equals and GetHashCode](https://www.learnhowtoprogram.com/c-and-net/database-basics/overriding-equals-and-gethashcode)
- [Saving Objects in the Database](https://www.learnhowtoprogram.com/c-and-net/database-basics/saving-objects-in-the-database)
- [Finding Objects in the Database](https://www.learnhowtoprogram.com/c-and-net/database-basics/finding-objects-in-the-database)
 
## How To Run This Project

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c).

### Set up the Databases

Follow the instructions in the LearnHowToProgram.com lesson ["Introduction to MySQL Workbench: Creating a Database"](https://www.learnhowtoprogram.com/c-and-net/database-basics/introduction-to-mysql-workbench-creating-a-database) to create a `to_do_list_with_mysqlconnector` database with an `items` table.

Next, follow the instructions in the LearnHowToProgram.com lesson ["Creating a Test Database: Exporting and Importing Databases with MySQL Workbench"](https://www.learnhowtoprogram.com/c-and-net/database-basics/creating-a-test-database-exporting-and-importing-databases-with-mysql-workbench) to create a `to_do_list_with_mysqlconnector_test` database with an `items` table.

### Set Up and Run Project

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "ToDoList".
3. Within the production directory "ToDoList", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. For the LearnHowToProgram.com lessons, we always assume the `uid` is `root` and the `pwd` is `epicodus`.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list_with_mysqlconnector;uid=root;pwd=epicodus;",
      "TestConnection": "Server=localhost;Port=3306;database=to_do_list_with_mysqlconnector_test;uid=root;pwd=epicodus;"
  }
}
```

5. Within the production directory "ToDoList", run `dotnet watch run` in the command line to start the project in development mode with a watcher.
4. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate).
