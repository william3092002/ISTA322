# File: C# Homework 17
# Name: William Chan
# Date: 26 August, 2020

1. What is a type parameter?
	* a type parameter is a placeholder for a specific type that a client specifies when they create an instance of the generic type. 
	* a type that you specialize a method to when you instantiate a method
2. What does a type parameter do?
	* allows me to specify the type when I'm creating an instance of a generic type 
	* it specializes the type for the method 
3. How many type parameters can a generic class have?
	* multiple
4. What is the difference between a generic class and a generalized class?
	* generalized class has only one implementation, its methods take object parameters and return object types.
	* generic class has type parameter.	Many implementation, each implementation is specific to that particular type. 
5. What is a constraint? How do you specify a constraint?
	* a constraint is a limitation you implement on the type parameters.
	* where T : InterfaceName
6. What is a generic method? How do you define a generic method?
	* Generic method allows you to specify different types of the parameter and the return types with each instance. 
	* By using the parameter type syntax for the parameter and return type.
7. What do we mean when we say that a generic type interface is invariant?
	* You cannot assign an IWrapper<A> object to a
reference of type IWrapper<B>, even if type A is derived from type B.
8. What do we mean when we say that a generic type interface is covariant?
	* If the methods in a generic interface can return strings, they can also
return objects. (All strings are objects.)
9. Does covariance work with value types? Does it work with reference types?
	* no
	* yes
10. What do we mean when we cay that a generic type interface is contravariant?
	* If the methods in a generic interface can take object parameters,
they can take string parameters. (If you can perform an operation by using an object, you can
perform the same operation by using a string because all strings are objects.)