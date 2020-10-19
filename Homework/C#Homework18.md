# File: C# Homework 18
# Name: William Chan
# Date: 8 September, 2020

1. You are building a help ticket system. You want to ensure that the older the ticket, the sooner it will
be handled by the team. For example, a ticket submitted a week ago has a higher priority than a
ticked just submitted. What kind of data structure would you use, and why?
	- Queue
	- First in first out
2. You are building a tracking system for seasonal agricultural farm labor. Te labor requirements vary
widely, depending on the season. Your requirement is that the newest hires are terminated first, and
that our more experienced hires are kept longer. What kind of data structure would you use, and why?
	- Stack
	- Last in first out
3. You are building a transaction database. Your requirement is that the database adds data very quickly,
and that deletions, updates, and searches happen infrequently. In other words, data is typically added
in the order in which the transaction occurs. What kind of data structure would you use, and why?
	- List
4. You are building an analytical database. Your requirement is that the database handle queries very
quickly, but that the data never changes, i.e., there are no inserts, deletions, or updates. What kind
of data structure would you use, and why?
	- Dictionary
	- allows you to retrieve the value that is associated with a specified key quickly.
5. You are building a personnel directory, where searched are performed by last name, first name, middle
name. What kind of data structure would you use, and why?
	- Sorted Dictionary
6. You are building a username/password database. Your requirement is that updates happen frequently
(when users change their passwords) and that searches (to authenticate users) happenb extremely
quickly. What kind of data structure would you use, and why?
	- Dictionary
	- key value set for username and password
7. What is a lambda expression? Give an example. Why would we use a lambda expression?
	- A lambda expression is an expression that returns a method.	
	- Person match = personnel.Find(p => p.ID == 3);
	- make your code more refined and readable.
8. What is the difference between lambda expressions and anonymous methods? What are the advantages
of each?
	- for anonymous method your replace the method name with method body. 