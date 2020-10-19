# File: C# Homework 15
# Name: William Chan
# Date: 20 August, 2020

1. What is the difference between a property and a field?
	* A property requires implementation and a field doesn't. 
2. What is the difference between a property and a method?
	* A method has parameters and properties don't.
3. What is your understanding of encapsulation?
	* Ensure the information is contained in the object. 
	* Encapulate all required elements in one capsul for easy access. 
4. Some languages are case insensitive, that is, an ‘a” and an “A” are considered to be the same letter.
C# is case sensitive. What implications does this have regarding the naming of variables, methods,
and other identifiers? Do you think that the difference in case in the initial character of two different
identifiers is sufficient to distinguish them¿
	* the identifiers with the same letters but different case induces human error. 
	* in a perfect world yes. Not in the real world. 
5. Give an example that is not in the book of an instance where you might want to use a read-only
property. Give an example not in the book of an instance where you might want to use s write-only
property.
	* you might want to use a read only property to display the price of your commodities.
	* password
6. Can you think of a reason why you might ever want to make getters and setters private? Give an
example. Also, make a case why getters and setters should never be private.
	* when you only want to restrict accessbility to the property partially.
	* If you want private properties, you mind as well utilize fields. 
7. What are restrictions on the use of properties?
	* no ref or out
	* contain only one get and set accessor. No methods, fields or properties. 
	* no parameters for your get and set. 
	* can't declare properties with const key word. 
8. What is an object initializer? What is the syntax for an object initializer?
	* When you create an instance of a class, you can initialize it by specifying the names and values for
any public properties that have set accessors. 
