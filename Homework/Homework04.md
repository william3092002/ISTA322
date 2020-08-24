# File: ASP.NET Homework 4
# Name: William Chan
# Date: 19 August, 2020

1. What are the .NET SDK command line tools used for? Is their use required? Why or why not?
	* SDK includes a set of command-line tools for creating, managing, building, and running projects.
	* if using visual studio code then it is required.
2. What kind of applications do the following templates create? Run these commands and read the
documentation. A brief summary of each template is sufficient.
dotnet new console --help
	* you can create console application with template using this command. 
dotnet new mvc --help
	* You can create an ASP.NET Core application teamplate with example ASP.NET Core MVC Views and Controllers.
dotnet new web --help
	* you can create an empty project template for creating an ASP.NET Core application. This template has no content in it. 
3. What, specifically, do the following commands do?
dotnet new globaljson --sdk-version 3.1.101 --output MySolution/MyProject
	* create a folder with globaljson file that will define the version of SDK you are using. Which is .NET Core SDK 3.1.101
dotnet new web --no-https --output MySolution/MyProject --framework netcoreapp3.1
	* craete a the project using the web template. this template creates a project with the minimum content required for ASP.NET Core development. It's a project with no HTTPS support.
dotnet new sln -o MySolution
	* creates a new solution name MySolution.
dotnet sln MySolution add MySolution/MyProject
	* add MySolution to MyProject folder
4. What is the purpose of the global.json file?
	* The global.json file allows you to define which .NET Core SDK version is used when you run .NET Core CLI commands. 
5. What does the method app.UseStaticFiles() do?
	* UseStaticFiles() method adds StaticFiles middleware into the request pipeline.
6. What do the following two commands do?
dotnet build
	* The dotnet build command builds the project and its dependencies into a set of binaries.
dotnet run
	* runs the project.
7. (not in book) You cah manage pacakges using the NuGet package manager and the command line tool
dotnet add package. What are packages and what are they used for.
	* Put simply, a NuGet package is a single ZIP file with the .nupkg extension that contains compiled code (DLLs), other files related to that code, and a descriptive manifest that includes information like the package's version number.
8. What are tool packages and what are they used for?
	* Tool packages install commands that can be used from the command line to perform operations on .NET Core projects. One
common example is the Entity Framework Core tools package that installs commands that are used to manage databases in ASP.
9. What are tool packages and what are they used for?
10. What are client side packages and what are they used for?
	* Client-side packages contain content that is delivered to the client, such as images, CSS stylesheets, JavaScript files, and static
HTML. Client-side packages are added to ASP.NET Core using the Library Manager (LibMan) tool.
11. List two ways that a developer can debug code.
	* debugger and console.writeLine