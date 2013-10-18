GENERAL PRESENTATION
=============


What ?
-----

- Microsoft 'stack' used : .NET, Visual Studio 2013RC, NuGet
- Dependency Injection Application Block (as Unity used to be known originally)
- a core container, with an easy API

=> a dependency injection container



Why ?
-----

- Dependency injection ? Is good : separates configuration from use
http://www.martinfowler.com/articles/injection.html
	- constructor
	- setter
	=> some other object is responsible for composing the application by building the complete object graph
	- That other object is the Unity container
	
http://stackoverflow.com/questions/871405/why-do-i-need-an-ioc-container-as-opposed-to-straightforward-di-code?rq=1


UNITY DETAILS
=============
	
# How ?


 	## Big picture : Register, Resolve

	
	## Register = configure the dependencies
		- in code or from a XML file
		- in main/application start/each module

		
	## Details, examples

	
	- installation : easy in Visual Studio with NuGet
	- types of injection :
		- constructor
		- ...


http://msdn.microsoft.com/en-us/library/vstudio/hh323691(v=vs.100).aspx	
	
	
UNITY VS JAVA SPRING
=========

http://stackoverflow.com/questions/411660/enterprise-library-unity-vs-other-ioc-containers
http://programmers.stackexchange.com/questions/92393/what-does-the-spring-framework-do-should-i-use-it-why-or-why-not

- Java framework for inversion of control
	- It is NOT Spring .NET, which is a port and extension (open source)
	
- container ? interception ?
- key differences :
	- Initialization
	- Object retrieval
- XML, code, or annotations 


(as a side note)
- Java framework for inversion of control... but not only
	- improves on jee











