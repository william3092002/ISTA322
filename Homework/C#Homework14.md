# File: C# Homework 14
# Name: William Chan
# Date: 17 August, 2020

1. What is the difference between a managed resource and an unmanaged resource?
	* The term "unmanaged resource" is usually used to describe something not directly under the control of the garbage collector. For example, if you open a connection to a database server this will use resources on the server (for maintaining the connection) and possibly other non-.net resources on the client machine, if the provider isn't written entirely in managed code.
2. When is memory for an object (reference type) allocated? When is the memory deallocated?
	* When the instanace is intantiated. 
	* when there is no longer a reference pointing to the object. 
3. What is a destructor?
	* A destructor is a special method, a little like a constructor, except that the CLR calls it after the
 reference to an object has disappeared. 
4. What is the difference in syntax between a constructor and a destructor?
	* ~ + constructor.
5. Give some examples of scarce resources. Why would you want to manage scarce resources?
	* memory, database connections and file handels. 
	* They're too valuable to lie around waiting for an arbitrary length of time until the garbage collector actually release them. 
6. What is exception-safe disposal?
	* One way to ensure that a disposal method (such as Close) is always called, regardless of whether there is
an exception
7. How do you think that the using statement works for resource management? Give an informal, English
language, explanation of how it works.
	* works like the opening and closeing brackets on Stack. 
8. What ill effects could result from attempting to dispose of a resource more than once?
	* It depends on what's the content of your dispose method.
9. We will look at threads later in the term. For now, what is your understanding of how threads interact
with resource management? A good guess is a siufficient answer to this question.
	* all threads comes to a halt when resource is being freed from the garbage collector.
10. Why does the book recommend not attempting to force the garbage collector? Are their any exceptions
to this recommendation?
	* The GC.Collect method starts the garbage collector, but the
 process runs asynchronously—the GC.Collect method does not wait for garbage collection
to be complete before it returns, so you still don’t know whether your objects have been
destroyed. Let the CLR decide when it is best to collect garbage.
	* when managing scarce resource?