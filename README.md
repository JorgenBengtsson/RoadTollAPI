# RoadTollAPI
This project is an example of a super simple Web API Project using Entity Framework and code-first.
 
 
It's an API to keep track of Cars, their owners, and how many times a car has passed a toll station. There is support for invoice handling as well.

## Base Project
The base project is empty except a Home controller with a welcome message. The necessary NuGet packages for Entity Framework is added.

## Commits

###### Add DBContext, Owner, and Controller
Adds the DbContext with a "hard-coded" connectionstring :thumbsdown:. There is a initial entity for Owner and controller to handle input and output for the Owner.
The controller is super simple, directly creating and using the DbContext :thumbsdown:. It shows the basic implementations of functions that is expected from an API.
In order to create the database, don't forget
```
PM> update-database -verbose
```
