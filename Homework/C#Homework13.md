# File: C# Homework 13
# Name: William Chan
# Date: 16 August, 2020

1. What is an interface as the term is used on object-oriented programmoing?
	* The interface separates the what from the how.
2. How do you define an interface?
	* Interface is defined without implementation.
3. Can an interface have variables, fields, or properties?
	* No
4. How do you define a method in an interface?
	* You replace the implementation with a semicolon. No open bracket, block of code, and close bracket.
5. Can you instantiate an object through an interface? Why or why not?
	* yes
6. Using the new keyword, can you declare a reference to an interface?
	* yes
7. Can an object inherit from multiple interfaces? Can a class implement multiple interfaces? If so, how
can it do so?
	* yes
	* yes
8. What does it mean to explicitely implement an interface?
	* reference the method through the appropriate interface
9. What are the restrictions on interfaces?
	* no fields allowed
	* no constructors allowed
	* no destructors allowed
	* no access modifier fo methods in the interface, they're implicitly public.
	* can't nest any types.
	* an interfacec cannot inherit from a class or struct. 
10. What is the difference between an abstract class and an interface?
	* You can instantiate an object through interface but not through an abstract class.
11. What is an abstract method?
	* an abstract method is a method that has to be overide in derived classes.
12. What is an sealed class?
	* the last class that can be inhereted.
13. What is an sealed method?
	* sealed method is a method you cannot overide. 