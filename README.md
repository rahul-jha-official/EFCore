# Entity Framework Core
-	Entity Framework Core is the new version of Entity Framework after EF 6.x.
-	Entity Framework (EF) Core is a lightweight, extensible, open source and cross-platform version of the popular Entity Framework data access technology.
-	EF Core can serve as an object-relational mapper (O/RM), which:

	-	Enables .NET developers to work with a database using .NET objects.
	-	Eliminates the need for most of the data-access code that typically needs to be written.
-	You can write your queries using LINQ as compared to SQL.

# Advantages of Entity Framework
-	Generate models based from database and vice versa.
-	Saves time from repetitive tasks.
-	More secure.
-	Cross platform.
-	No need to manage mapping manually.
-	No need for stored procedure, but you can still use if needed.

# ORM - Object Relational Mapping
ORM is a technique that lets you query and manipulate data from a database using an Object Oriented Paradigm.

-	Object: It is class that we have in our programming language.
-	Relational: This is Relational Databse Manager System like MS-SQL, MySQL etc.
-	Mapping: This is the part which bridges between Objects and tables.

Comparision
Without ORM

	var list = new List<Book>();
	var sql = "SELECT * FROM Books WHERE author = 'James'";
	var data = query(sql);
	while (row = data.Next())
	{
		//fetching row and creating book object
		list.Add(book);
	}

With ORM

	var list = Book.Where(e => e.author == "James");

# Advantages of ORM
-	You get to write in the language you are already using anyway.
-	It abstract away the database system so that switching database is not that difficult.
-	Many of the queries you write will perform better than if you wrote them yourself.
-	Saves you time as compared to writing SQL and Wrappers.
-	It can generate databse from models.
