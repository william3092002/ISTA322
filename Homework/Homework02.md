# File: ASP.NET Homework 2
# Name: William Chan
# Date: 12 August, 2020

1. What is the difference between Visual Studio and Visual Studio Code?
	* Visual studio code is a light weight version of the visual studio 
2. What is LocalDB?
	* LocalDB is a developer oriented, on-demand managed instance of the SQL Server engine that can be turned on automatically when needed and turned off when not in use. It requires no configuration to run and allows for quick access to a database engine without the overhead of managing and installing a full SQL Server instance. LocalDB utilizes the minimal amount of files needed to achieve all of this. Having the database access stay local greatly reduces the complexity for developing and testing applications with a SQL Server backend.
3. What do these commands do?
dotnet new globaljson --sdk-version 3.1.101 --output FirstProject
dotnet new mvc --no-https --output FirstProject --framework netcoreapp3.1
	* The first command creates a folder named FirstProject and adds to it a file named global.json, which specifies the version
of .NET Core that the project will use; this ensures you get the expected results when following the examples. The second command
creates a new ASP.NET Core project. The .NET Core SDK includes a range of templates for starting new projects, and the mvc
template is one of the options available for ASP.NET Core applications. This project template creates a project that is configured for
the MVC Framework, which is one of the application types supported by ASP.NET Core. 
4. What command do you use to build an ASP.NET project from the command line? What command
do you use to run the project?
	* dotnet new mvc --no-https --output FirstProject --framework netcoreapp3.1
	* start FirstProject.csproj
5. What is the purpose of an endpoint?
	* When a user sends a HTTP request to the webserver, the enpoint handle incomming request. the
request will be processed by the Index method defined by the HomeController class.  
6. What is a controller?
	* is a C# class that is derived from the
Microsoft.AspNetCore.Mvc.Controller class, the built-in controller base class.
	* controller is peice that sits in the middle that coordinates everything.

7. Where are actions defined?
	* each public defined by controller is an action. 
	* controller. the HTTP request will be processed by the Index action defined by the Home controller.
8. What is the purpose of the routing system?
	* selecting the endpoint that will handle an HTTP request. A route is a rule that is
used to decide how a request is handled.
9. Assume that your ASP.NET application runs in a browser with a URL like http://localhost:5000.
List the three default routes configured by the ASP.NET Core routing system.
	* /
	* /Home		//this is the name of the controller
	* /Home/Index 	//this is the name of the controller/action-method
10. What does the ViewResult object instruct ASP.NET Core to do?
	* to render a view
	* a view is a user interface, what the user sees.
11. How does ASP.NET Core know what View is to be called from an action method?
	* methodName.cshtml, it looks for the view that ahs the same name of the method
12. What is the job of an action method?
	* it calls a view
13. What is a view model?
	* 