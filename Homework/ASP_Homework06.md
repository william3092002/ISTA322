# File: ASP.NET Homework 6
# Name: William Chan
# Date: 8 September, 2020

1. What is unit testing as defined by the book?
	- Unit testing is a form of testing in which individual
components are isolated from the rest of the application so their behavior can be thoroughly validated.
2. What is the convention for creating unit tests in ASP.NET Core applications?
	- For ASP.NET Core applications, you generally create a separate Visual Studio project to hold the unit tests, each of which is defined
as a method in a C# class. Using a separate project means you can deploy your application without also deploying the tests. 
3. Name three unit test project tools used for ASP.NET Core applications.
	- mstest
	- nunit
	- xunit
4. What is the convention for naming unit tests in ASP.NET Core applications?
	- ApplicationName.Tests
5. What is the convention for naming the test classes in AP.NET Core? What is the convention for
naming the methods in the test classes?
	- Conventionally, the name of the test methods describes what the test does, and the name of the class describes what is being
tested.
6. What is the purpose of the Fact attribute in Xunit? (not in book) What is the purpose of the Theory
attribute in Xunit?
	- It says that the method is a unit test.
	- The [Theory] attribute, on the other, expects one or more instances to supply the values for a Parameterized Test's method arguments.
7. Describe the different elements of the AAA testing pattern.
	- Arrange refers to setting up the conditions for the test
	- Act refers to performing the test.
	- Assert refers to verifying that the result was the one that was expected.
8. Describe the use of the methods in the Assert class. Describe the purpose, parameters, and return
value of the Assert.Equals() method.
	- used to check that the outcome of an action is the one that is expected.
	- This method asserts that the result is equal to the expected outcome. 
9. What is the key to isolating a component for testing?
	- The key to isolating components is to use C# interfaces.
10. What is a mocking package? What does it do?
	- Code that allow you to create mock objects for tests.
	- The purpose of mocking is to isolate and focus on the code being tested and not on the behavior or state of external dependencies.
11. (not in book) What is the difference between the Setup() and the SetupGet() methods of Moq?
	- Setup() can be used for mocking a method or a property. SetupGet() is specifically for mocking the getter of a property.