# Tools
- EF Power tools: Generate code first classes in visual studio
- Entity Framework Profiler

# EF Query generation
- Demonstrate power of the Linq to Enitities LinqProvider
	- Show Matt Warren's blog / Profile
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

#Testing Entity Framework Using NugetPackages by Rowan Miller

- See test project
SEE - TODO : COMPLETE

# TODO!!!
- Use EF Profiler in Talk
- Modifying Transaction block around Select Queries using extension methods
- Download the EF6 code base and run various unit tests
	- Demonstrate basic select

- Focus on Linq, change tracking, DbMigrations, unit of work features in slide
	- features which happen to be supported in EF7
- Complete and test DBMigrator Test for generating SQL
- Provide interceptor for logging in EfTestConsole.Config file
- Complete ProductController Unit Test with MockDbSet
- Complete/FIX WebApi project with ProductRepository UnitOfWork integration
- List Performance tricks in PowerPointSlides
- Complete DB Migration for FullTextSearch
- Complete Command Interceptor for Soft Deletes
- Add Example for DB Execution strategy and logging
- Add Serilog and Seqlog packages

- Highlight Linq Provider classes and tests in EF source
- Add EF7 demo project
- Add micro ORM performance mentric tests
- Add concurrency check in BaseRepository

- Download Rowan Miller talks for Ipad


Advanced scenarios
http://www.asp.net/mvc/overview/getting-started/getting-started-with-ef-using-mvc/advanced-entity-framework-scenarios-for-an-mvc-web-application
// Talk about serialisation performance in EF vs Dapper

Getting and building the EF runtime
https://entityframework.codeplex.com/wikipage?title=Getting%20and%20Building%20EF%20Runtime

# WebApi Entity Framework Scaffolding

- TODO : Complete API with DI and Resitory UnitofWork integration

http://www.entityframeworktutorial.net/entityframework6/introduction.aspx
http://www.farreachinc.com/blog/far-reach/2014/01/09/entity-framework-part-5-ef6-new-features
http://www.farreachinc.com/blog/far-reach/2013/09/26/entity-framework-query-optimizations
https://channel9.msdn.com/Events/TechEd/NorthAmerica/2014/DEV-B417#fbid=

--
http://www.asp.net/mvc/overview/getting-started/getting-started-with-ef-using-mvc/advanced-entity-framework-scenarios-for-an-mvc-web-application



https://github.com/rowanmiller


Check Demo's out on
D:\CLOUD_STORAGE\Dropbox\JEAN\IT_DEVCODE\MS.NET\ENTITY FRAMEWORK\EFTalk\Temp