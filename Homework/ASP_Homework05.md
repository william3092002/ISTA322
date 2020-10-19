# File: ASP.NET Homework 5
# Name: William Chan
# Date: 26 August, 2020

1. What is the purpose of the null conditional operator? Does it apply to value types or reference types?
Why or why not?
	* The null conditional operator allows for null values to be detected more elegantly.
	* Reference type
	* Value type can only assigned to null when it is made to nullable type
2. What is the null coalescing operator? What does it do?
	* null coalescing operator ensures that I don’t include null values in the results displayed in the browser
	* It will return the value of its left-hand operand if it is not null.
3. How is the null conditional operator different from a nullable type? What is the purpose of nullable
types?
	* nullable types have the ? keyword after the type, while null conditional operator
4. When you create an automatic property and initialize the property with a value, can the value be
changed later? Can another value be assigned to the property? Can the value be changed in the
constructor?
	* yes the value can be changed later
	* yes, another value can be assigned to the property
	* yes, the value can be changed in the constructor.
5. What is an object initializer and what is it for? What is an collection initializer and what is it for?
	* object initializer allows me to create an object and specify its property values in a single step
	* collection initializer allows the creation of a collection and its contents to be specified in a single
step. 
6. What does the is keyword do?
	* The is keyword is used to perform a type test
7. How are extension methods defined?
	* with "this" key word in the beginning of the parameter. 
	* Extension methods are defined in static classes within the same namespace as the class the extension methods applies to. 
8. What is implicit typing or type inference? How do you implement it?
	* allows you to define a local variable without explicitly specifying the variable type
	* use var key word
9. What is a default implementation of an interface? What is the purpose of a default implementation
of an interface?
	*  the ability to define default implementations for properties and methods defined by interfaces, 
	 allowing new features to be added to an interface without locate and update all the classes that implement it
	* makes it possible to update interfaces without breaking the existing implementations of them
10. What are asynchronous methods? Why should we use them? How are they used?
	* Asynchronous methods perform work in the background and notify you when they are complete
	* async and await
11. When you use the await keyword, do you have to use the async keyword? Why or why not?
	* yes, 
12. (not in book) What is the yield keyword used for? How do you use it?
	* When you use the yield contextual keyword in a statement, you indicate that the method, operator, or get accessor in which it appears is an iterator. 
13. What is the effect of using the nameof() expression?