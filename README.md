
# What is this project about?

This backend project uses the.NET 6 Web API to show how to develop a multi-container backend application while adhering to clean architecture principles like controller, services, and repository organization. To push to Docker with a SQLite database, the solution uses Dockerfile.

# What does the Solution offer?

The most fundamental building pieces an API has to have are taken into consideration when creating the Solution in order to provide a scalable and nearly ideal API component. The following are fully implemented as part of the solution:

- [x] Clean Architecture with separated layers for Api, Core, domain, Infrastructure and Application
- [x] UnitOfWork with Generic Repository
- [x] Entity Framework Core migrations with SQLite
- [x] Complete CRUD for an Entity following Clean Architecture
- [x] Fluent Validation of input inside the Command classes
- [x] Preconfigured Swagger UI
- [x] Ready to use Docker configuration with Dockerfiles 
- [x] JWT Token API for Generation and Configured JWT Validation
- [x] Roles based Authorization with predefined Roles for passwordchange, and we can also add Authorization for other but idid not add line of code for all. 
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
* SQLite, becuase easy to test at any localhost. Database is autogenerate no need to configure.
* SwaggerUI
* AutoMapper
* NUnit3TestAdapter
* Dockerfile

# How do I get started with Docker Compose?

To get started, follow the below steps:

1. Install .NET 6 SDK
3. Install Docker Desktop (for Windows) / Docker (for Linux/Mac)
4. Clone the Solution into your Local Directory
5. On the Repository root you can find the dockerfile
6. Run the below command to build and run the solution in Docker (requires a working Docker installation)
## Build and run docker image
```
> docker build -t dockeryourusername/repositoryname:tagname .
> docker run dockeryourusername/repositoryname:tagname .
```
## example build docker image
```
  > docker build -t tsedeke2018/dotnet_full_satck_integrify:first .
```
## example run docker image
```
> docker run tsedeke2018/dotnet_full_satck_integrify:first .
```
7. Once the containers start successfully navigate to your localhost http://localhost in Postman.

# I'm not into Docker. How do I get started?

You can also just run the solution without Docker by following the steps below:

1. Install .NET 6 SDK
2. Clone the Solution into your Local Directory
3. Navigate to the Api directory (./Api) and run the below command to get the Api running:

```
> dotnet run --project ./Api
```
4. Open a browser with SwaggerUI ,or automatically navigate to http://localhost or You can use tetsing tools like Postman and you're all set!
5. Start with signup user using either SwaggerUI or Postman
6. Then login to the user account.
7. You will receive the created token value after logging in. Take a copy of this token, go to the SwaggerUI Authorize button, and enter bearer and pest after the term bearer has been separated by a space. Using POSTMAN, pick Accept and Authorization from the key column, select JSON/Application from the value column accept key Accept, and Pest Token to the Authorization Row under the Value Column. After that, you may use this little project to test and have fun. Below is a table with a list of the end points and examples. 
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
  ### Example for create/update new todo list                                                        
```
  {
    "name": "Wine",
    "description": "Unix Platform",
    "status": 1
  }
```
## Available api endpoints for custom user

| Web Method | API Endpoint URL              | Description                | Example                                                              
| :----------| ------------------------------|----------------------------|----------------------------------------------------------------------
| GET        | /api/v1/CurrentUser           | Check current user         | http://localhost:5055/api/V1/CurrentUser                                      
| POST       | /api/v1/signin                | login to authorize the user| http://localhost:5055/api/V1/signin
| POST       | /api/v1/signup                | Create new user            | http://localhost:5055/api/V1/signup
| PUT        | /api/v1/changePassword        | Change password            | http://localhost:5055/api/V1/signup                                                         
 ### Example for create new user                                                        
```
  {
    "firstName": "Tsedeke",
    "lastName": "Habe",
    "userName": "tshabe",
    "email": "tsedeke@uef.fi",
    "password": "1234@parul"
  }
```
 ### Example for signin user                                                        
```
  {
    "email": "tsedeke@uef.fi",
    "password": "1234@parul"
  }
```
 ### Example for change password                                                        
```
  {
    "currentPassword": "string",
    "newPassword": "string",
    "newPasswordConfirmation": "string"
  }
```
Read more: [Dockerizing a Full Stack Application with Docker Compose](https://referbruv.com/blog/posts/dockerizing-multiple-services-integrating-angular-with-aspnetcore-api-via-docker-compose)

# Issues or Ideas?

If you face any issues or would like to drop a suggestion, ![raise an issue](https://github.com/referbruv/ContainerNinja.CleanArchitecture/issues/new/choose)

# License

The project is completely open source.

# Show your Support 

I really hope this solution helps integrify academy get started on building awesome things with ASP.NET Core (.NET 6) Web API for trainee job in full stack developer. 

Found this solution helpful and useful? You can do these to help this reach greater audience.So Leave a star on this repository :star:

