# Repository Design Pattern

- The Repository Design Pattern Mediates between the domain and the data mapping layers using a collection-like interface for accessing the domain objects.

- In other words, we can say that a Repository Design Pattern acts as a middleman or middle layer between the rest of the application and the data access logic. That means a repository pattern isolates all the data access codes from the rest of the application. The advantage of doing so is that, if you need to do any changes then you need to do it in one place. Another benefit is that testing your controllers becomes easy because the testing framework need not run against the actual database access code.
    
  ![image](https://github.com/jil1710/readmedemo/assets/125335932/1163ccb8-94fb-4b26-af60-bcff70022b70)

- As you can see in the above diagram, now the Employee controller won’t talk with the Entity Framework data context class directly. Also, now there are no queries or any other data access code written in the action methods of the Employee Controller. All these operations (i.e. CRUD operations) are wrapped by the Employee Repository. The Employee Repository uses the Entity Framework data context class to perform the CRUD operations. As you can see, now the Employee repository has methods such as GetAll(), GetByID(), Insert(), Update(), and Delete(). These methods are going to perform the Typical CRUD operations against the underlying database. The Employee controller uses those methods to perform the required database operations.

  
## Why do we need the Repository Design Pattern in C#?

- As we already discussed, nowadays, most data-driven applications need to access the data residing in one or more other data sources. Most of the time data sources will be a database. Again, these data-driven applications need to have a good and secure strategy for data access to perform the CRUD operations against the underlying database. One of the most important aspects of this strategy is the separation between the actual database, queries, and other data access logic from the rest of the application. In our example, we need to separate the data access logic from the Employee Controller. The Repository Design Pattern is one of the most popular design patterns to achieve such separation between the actual database, queries, and other data access logic from the rest of the application.

## Advantages of Repository Design Pattern

- Testing controllers becomes easy because the testing framework need not run against the actual database access code.
- Repository Design Pattern separates the actual database, queries and other data access logic from the rest of the application.
- Business logic can access the data object without having knowledge of the underlying data access architecture.
- Business logic is not aware of whether the application is using LINQ to SQL or ADO.NET. In the future, underlying data sources or architecture can be changed without affecting the business logic.
- Caching strategy for the data source can be centralized.
- Centralizing the data access logic, so code maintainability is easier.

## How to Implement Repository Design Pattern in C#

- Instead of accessing database or performing database operation directly through the controller we seperate an make repository that decouple the database logic. Create User repository

  ![image](https://github.com/jil1710/readmedemo/assets/125335932/3c7b59e9-65e8-44fa-a964-46368e4da19b)

  ![image](https://github.com/jil1710/readmedemo/assets/125335932/b370148f-2ee9-45f5-88a4-e6c0515a4cbe)

- Now register that repository as a service dependency injection ( AddSingleton, AddTransient, AddScoped )

  ![image](https://github.com/jil1710/readmedemo/assets/125335932/807783b4-bdec-4038-af6a-22915b26c769)

- Now use it in appropriate controller according to your need, first inject the service into controller then you are ready to use it.

  ![image](https://github.com/jil1710/readmedemo/assets/125335932/a4559966-fc2e-49f0-a01e-5dfb90f195ac)