
# What is this project about?

This project is a backend project to demonstrate building a multi-container Backend application with .NET 6 Web API following Clean Architecture like controller,services and repository structure. The solution uses Dockerfile to push to Docker with SQLite database.

# What does the Solution offer?

The Solution is built keeping in mind the most fundamental blocks an API must have in order to build a scalable and near-perfect API component. The solution offers a complete implementation of the following:

- [x] Clean Architecture with separated layers for Api, Core, domain, Infrastructure and Application
- [x] UnitOfWork with Generic Repository
- [x] Entity Framework Core migrations with SQLite
- [x] Complete CRUD for an Entity following Clean Architecture
- [x] Fluent Validation of input inside the Command classes
- [x] Preconfigured Swagger UI
- [x] Ready to use Docker configuration with Dockerfiles 
- [x] JWT Token API for Generation and Configured JWT Validation
- [x] Roles based Authorization with predefined Roles for passwordchange, and we can also add Authorization for other but idid not add line off code for all. 
- [x] Complete NUnit Test Implementation
- [x] API Versioning with separated Swagger Documentation
- [x] AutoMapper implementation for Entity-to-DTO conversion
- [x] One Command deployment in Docker with Docker Compose
- [x] ILogger logging implementation

# Technologies Used

* ASP.NET Core (.NET 6) Web API
* Entity Framework Core (EFCore 6)
* MediatR for .NET 6
* Fluent Validation for .NET 6
* SQLite
* SwaggerUI
* AutoMapper
* NUnit3TestAdapter
* Docker Compose

# How do I get started with Docker Compose?

To get started, follow the below steps:

1. Install .NET 6 SDK
2. Install the latest NodeJS 
3. Install Docker Desktop (for Windows) / Docker (for Linux/Mac)
4. Clone the Solution into your Local Directory
5. On the Repository root you can find the docker-compose.yml file
6. Run the below command to build and run the solution in Docker (requires a working Docker installation)

```
> docker-compose build --force-rm --no-cache && docker-compose up
```

7. Once the containers start successfully navigate to http://localhost

# I'm not into Docker. How do I get started?

You can also just run the solution without Docker by following the steps below:

1. Install .NET 6 SDK
2. Clone the Solution into your Local Directory
3. Navigate to the Api directory (./Api) and run the below command to get the Api running:

```
> dotnet run --project ./Api
```
4. Open a browser with SwaggerUI , automatically navigate to http://localhost or You can use tetsing tools like Postman and you're all set!
## Available api endpoints

| Web Method | API Endpoint URL              | Description               | Example                                                              
| :----------| ------------------------------|---------------------------|----------------------------------------------------------------------
| GET        | /api/v1                       | get all                   | http://localhost:5055/api/v1                                         
| GET        | /api/v1/paging                | get all with page number  | http://localhost:5055/api/v1/paging?sort=Id&desc=true&skip=2&take=10 
| Get        | /api/v1/search                | get all by search name    | http://localhost:5055/api/v1/search?sort=Id&desc=true&searchTerm=Woine
| Get        | /api/v1/getById               | get all by id             |                                                                      
| Get        | /api/v1/todos/status ={status}| get all by status (0,1,2) |                                                                            
| POST       | /api/v1/todos                 | Post new Todo (Create)    | http://localhost:5055/api/v1/todos                                    
| PUT        | /api/v1/todos/:{id}           | Update existed todo by id | http://localhost:5055/api/v1/todos:3                                 
| PUT        | /api/v1/updateStatus          | Update todo's status      | http://localhost:5055/api/v1/updateStatus?id=1&status=3              
| DELETE     | /api/v1/todos/:{id}           | Delete existed todo by id | http://localhost:5055/api/v1/todos:3                                 
 
# No Default User: Start with signup user using either SwaggerUI or Postman
| Web Method | API Endpoint URL             | Description              | Example
| :----------| -----------------------------|--------------------------|----------------------------------------
| GET        |/api/v1                       | get all                  | 
| :----------| -----------------------------|--------------------------|----------------------------------------
| GET        |/api/v1/paging                | get all with page number | 
| :----------| -----------------------------|--------------------------|----------------------------------------
| Get        |/api/v1/search                | get all by search name   |
| :----------| -----------------------------|--------------------------|----------------------------------------
| Get        |/api/v1/getById               | get all by id            |
| :----------| -----------------------------|--------------------------|----------------------------------------
| Get        |/api/v1/todos/status ={status}| get all by status (0,1,2)|
| :----------| -----------------------------|--------------------------|---------------------------------------
| POST       |/api/v1/todos                 | Post new Todo (Create)   |http://localhost:5055/api/v1/todos
| :----------| -----------------------------|--------------------------|----------------------------------------
| PUT        |api/v1/todos/:{id}            | Update existed todo by id| http://localhost:5055/api/v1/todos:3
| :----------| -----------------------------|--------------------------|----------------------------------------
| PUT        |/api/v1/updateStatus         | Update todo's status      | http://localhost:5055/api/v1/updateStatus?id=1&status=3
| :----------| -----------------------------|--------------------------|----------------------------------------
| DELETE     |api/v1/todos/:{id}            | Delete existed todo by id| http://localhost:5055/api/v1/todos:3
| :----------| -----------------------------|--------------------------|----------------------------------------
```


Read more: [Dockerizing a Full Stack Application with Docker Compose](https://referbruv.com/blog/posts/dockerizing-multiple-services-integrating-angular-with-aspnetcore-api-via-docker-compose)

# Issues or Ideas?

If you face any issues or would like to drop a suggestion, ![raise an issue](https://github.com/referbruv/ContainerNinja.CleanArchitecture/issues/new/choose)

# License

The project is completely open source.

# Show your Support 

I really hope this solution helps integrify academy get started on building awesome things with ASP.NET Core (.NET 6) Web API for trainee job in full stack developer. 

Found this solution helpful and useful? You can do these to help this reach greater audience.So Leave a star on this repository :star:

