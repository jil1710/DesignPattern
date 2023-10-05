
# CQRS Design Pattern

- The Command and Query Responsibility Segregation(CQRS) is an architectural pattern that separates the read and writes operations of a data source. Here Query refers to querying data from a source and Command refers to database command that can be either Insert/Update or Delete operations.

- In simple word, It is an architectural pattern that separates the read and writes operations of your application. Read operations are called Queries and write operations are called Commands.

    - **Queries –**  The operations that return data but don’t change the application state.

    - **Commands –** The operations that change the application state and return no data. These are the methods that have side effects within the application. 

      ![image](https://github.com/jil1710/readmedemo/assets/125335932/b674dda5-8329-463b-a39b-272c71ea645b)

## Advantages of CQRS

  - Independent scaling
  - Optimized data transfer objects
  - Provides separation of concern
  - High scalability

## Real-Time Example to Understand CQRS Design Pattern:

 - **Handler/Command Handler :** This handler handle the commande request and save it to database. It is basically used for creating or writing into DB.
   
   ![image](https://github.com/jil1710/readmedemo/assets/125335932/96da1e83-16fc-43d7-9b6f-e02ad8647d82)

 - **Handler/ Query Handler :** This handler handle the query request base on the request return the data from the database. It is basically used for reading/fetching from DB.

     ![image](https://github.com/jil1710/readmedemo/assets/125335932/b692d67f-236e-4e9f-ac54-f4ac3b6de3b7)

 - **Command Request and Query Request**

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/05c5ba98-05ce-4af6-be5a-1e4b92b5da23)

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/98ecad7b-80ad-4d3b-aa72-7a8ab659e113)



 - ** Let's Use the MediatR to pass the request and handler will handle the request base on request. If the request is query type the use query handler else use command handler for command type request.

   - Install Nuget Package
  
   ```csharp
      MediatR
   ```

   - Register the MediatR handler

     ![image](https://github.com/jil1710/readmedemo/assets/125335932/a154dcb1-0e36-422f-9678-a39d4cdf9485)

   - Use ISender interface to sent the request to appropriate handler

     ![image](https://github.com/jil1710/readmedemo/assets/125335932/c7d15078-32dd-4ea0-a774-9f9b7fad0945)


- Click here to see the example of Composite Pattern : [CQRS Pattern](https://github.com/jil1710/DesignPattern/tree/master/CQRS)

