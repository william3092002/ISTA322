# File: ASP.NET Homework 3
# Name: William Chan
# Date: 19 August, 2020


1. What is the most important part of an ASP.NET Core 3 application?
	* The data model. 
2. What is the domain model?
	* contains the C# objects (known as domain objects) that make up the universe of the application and the methods
that manipulate them.
	* domain model is data that application uses.
3. Where are the model classes in an ASP.NET Core 3 application placed?
	*  in a folder named Models, which was added to the project by the template.
4. How many action methods can a controller class define?
	* as many as required.
5. What is a tag helper?
	* A Tag Helper Component is a Tag Helper that allows you to conditionally modify or add HTML elements from server-side code. 
	* a piece of C# code looks like Html.
6. What does the asp-action attribute do?
	* The asp-action attribute is an instruction to add an href attribute to the a element that contains a URL for an action method. 
	* looks like a piece of html but it's actually tie to a C# code when it executes.
7. What is the difference between HTTP GET and HTTP POST? This is an important question, and you
should understand the difference.
	* A GET request is what a browser issues normally each time
someone clicks a link. This version of the action will be responsible for displaying the initial blank form when
someone first visits /Home/RsvpForm.
	
	* By default, forms rendered using Html.BeginForm() are
submitted by the browser as a POST request. This version of the action will be responsible for receiving
submitted data and deciding what to do with it.
8. What is model binding?
	* it allows action method to be invoked by HTTP POST request.
	* Model Binding allows the program code access to the form values passed by user to the web server.
9. Why should we validate user data? How do we validate user data?
	* Without validation, users could enter nonsense data or even submit an empty form.
	* Client side and server sider.
	* In an ASP.NET Core application, validation rules are defined by applying attributes to model classes, which means the same
validation rules can be applied in any form that uses that class. ASP.NET Core relies on attributes from the System.ComponentModel.
DataAnnotations namespace.
10. What, specifically, is the ModelState.IsValid property?
	* The outcome of the model binding.
	* it's valid if all the validation is passed.
11. What does the asp-validation-summary do?
	*  it displays a list of validation errors when the view is rendered.
12. Static content consists of content such as images, script files, style files, etc. In an ASP.NET Core
application, what is the name of the folder that cotains static content?
	* wwwroot folder
13. What is Bootstrap? Who developed Bootstrap? Is Bootstrap a proprietary package? If not, what is
it?
	* CSS Framework for developing responsive and mobile-first websites.
	* Developed by twitter.
	* becomes a open-source project.
	
