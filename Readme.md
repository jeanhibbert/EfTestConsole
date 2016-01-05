# Tools
- EF Power tools: Generate code first classes in visual studio
- Entity Framework Profiler

# EF Query generation
- Lazy load entities
	- Query caching vs. second level caching
- Deep load entities
- Select with projection into an anonymous type
- Select with projection into an anonymous type - Deep load by exposing referenced entity on anonymous type
- Select with projection into an anonymous type - referenced entity property identified (Deep load)

# EF Caching
- DbSet.Find looks up entity from cache by default


# EF Code first migration
- The standard command set
	- update-database - Verbose
	- add-migration [Migration Name]
	- enable-migrations -force

# Concurrent Transactions
-  http://www.asp.net/mvc/overview/getting-started/getting-started-with-ef-using-mvc/handling-concurrency-with-the-entity-framework-in-an-asp-net-mvc-application

# Setup Notes
- Creating a model from an old database
download "Entity Framework Power Tools beta 4"
- Right click on project --> EntityFramework -> re-engineer code first
	- select DB in dialogue and click generate

- Download EF6 : http://entityframework.codeplex.com/SourceControl/latest

Install-Package xunit.runner.visualstudio

- Download Adventure works DB from
http://msftdbprodsamples.codeplex.com/

# Performance Enhancement techniques
- Start up performance

- General performance of save changes


# TODO
- Use EF Profiler in Talk
- Modifying Transaction block around Select Queries using extension methods
- Download the EF6 code base and run various unit tests
	- Demonstrate basic select
