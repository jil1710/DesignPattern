# Singleton Design Pattern

- The Singleton pattern is a design pattern that restricts the instantiation of a class to one object and provides a way to access its object. This is useful when exactly one object is needed to coordinate actions across the system. That means we need to use the Singleton Design Pattern in C# to ensure that only one instance of a particular class will be created and provide simple global access to that instance for the entire application.

  ![image](https://github.com/jil1710/readmedemo/assets/125335932/e6e53a07-4712-4c56-a545-a523c97bd8a0)

- As you can see in the above diagram, different clients (Client A, Client B, and Client C) are trying to get the singleton instance. Once the client gets the singleton instance, they can invoke the methods (Method 1, Method 2, and Method n) using the same instance.
  
 
## Implementation Guidelines of Singleton Design Pattern in C#:

- We need to declare a constructor that should be private and parameterless. This is required because it will restrict the class from being instantiated from outside the class. It only instantiates from within the class.
- The class should be declared sealed, ensuring it cannot be inherited. This is going to be useful when you are dealing with the nested class.
- We must create a private static variable referencing the class’s singleton instance.
- We also need to create a public static property/method that will return the singleton instance of the class. This method or property first checks whether an instance of the singleton class is created. If the singleton instance is created, it returns that instance; otherwise, it will create an instance and then return it.
  
## Example of Singleton Design Pattern using C#

- **No Thread-Safe Singleton Design Pattern Implementation in C#**

  - Singleton class without thread safe

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/9f54c172-2fbe-4f77-9d2b-b824504936fa)

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/2bac14d9-6778-49a9-8adc-037f248a98b5)

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/ceb3030c-1aa0-4f77-b028-1c855581f884)

    As you can see if we run in parallel environment or in muthithreading environment then it will create multiple object of singleton class so above singleton class is not thread safe.

- **Thread-Safe Singleton Design Pattern Implementation in C#**

  - Singleton class with thread safe
 
    ![image](https://github.com/jil1710/readmedemo/assets/125335932/b247348f-a70d-465c-8fa7-7bd2ff5e09e5)

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/cd9dcec4-b7b9-4a26-94be-c79a3d362b93)

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/aad64b34-d651-4708-9fed-6e76970c0234)


    As you can see if we run in parallel environment or in muthithreading environment then it will create not multiple object of singleton class so above singleton class ss now thread safe.


