# Proxy Design Pattern

- According to the Gang of four definitions, Proxy Design Pattern provides a surrogate or wrappers (act on behalf of another) or placeholder for another object to control access to it.

- The Proxy Design Pattern allows us to create a class that represents the functionality of other classes. The proxy could interface with anything such as a network connection, a large object in memory, a file, or some other resources that are expensive or impossible to duplicate.
    
- Proxy pattern does – “Controls and manage access to the object they are protecting“.
  
## Why do we need Proxy Design Pattern in C#?

- **Improve Performance using Proxy Server:**

  The Proxy Servers can drastically improve the performance of the application. This is because it saves the results of a request for a certain period of time. For example, let’s say we have two users called X and Y and they want to access a particular resource through the Proxy Server. First, user X requests for a particular resource (let’s say a list of employees), and the Proxy Server gets the data from the real server, and before sending the data to the client, it caches that resource (list of employees) for a certain amount of time. Later, user Y also requests for the same resource, then the Proxy Server instead of forwarding that request to the Real Server (which is a time-consuming operation), can simply return the data from the Cache which will ultimately improve the performance of the application.

- Filter Requests using Proxy Server:
  
  The Proxy Servers can also be used to filter incoming requests. For example, a company might use a Proxy Server to prevent its employees from accessing a specific set of websites such as Facebook, Twitter, etc.

  ![image](https://github.com/jil1710/readmedemo/assets/125335932/59817e65-e410-4574-bd44-af10b468750c)

## Let's implement an example of Filtering request and restricts few site access:

- Interface of Internet
  
  ![image](https://github.com/jil1710/readmedemo/assets/125335932/c75a52eb-e207-4dab-a7d5-6af4789be211)

- Real Internet Provider

  ![image](https://github.com/jil1710/readmedemo/assets/125335932/e0e04292-7d36-401b-b58f-f31aa061a368)

- Proxy Internet Provider that helps to restricts few site access.

  ![image](https://github.com/jil1710/readmedemo/assets/125335932/9625ae27-6db9-4b13-a155-ae37ba2ea93f)

- Client request for accessing web server all the request is pass through proxy internet provider

  ![image](https://github.com/jil1710/readmedemo/assets/125335932/bd659927-7ac0-4467-a761-0fabd65e4a98)

  ![image](https://github.com/jil1710/readmedemo/assets/125335932/2b673883-400a-4551-b1e1-5a677dea20ed)