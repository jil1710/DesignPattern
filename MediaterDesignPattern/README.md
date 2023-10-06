
# Mediater design pattern

- In software development, the Mediator design pattern provides a centralized communication channel for objects that need to interact with each other. It promotes loose coupling between components by encapsulating their interactions within a mediator object.
  
- The Mediator design pattern falls under the behavioral design pattern category. It promotes the concept of “mediation” by providing a mediator object that encapsulates the communication logic between multiple objects. Instead of objects directly communicating with each other, they communicate through the mediator, reducing dependencies and promoting modularity.

## Advantages of the Mediator Design Pattern:

- **Decoupling of components:** The Mediator pattern reduces direct dependencies between components by introducing a central mediator object. Components communicate through the mediator, promoting loose coupling.
- **Simplified communication:** The Mediator pattern simplifies communication between objects by providing a centralized communication channel. It abstracts the complex communication logic and encapsulates it within the mediator.
- **Extensibility:** Adding or modifying new components becomes easier as the communication logic is concentrated within the mediator. Changes to individual components have minimal impact on other components.
- **Improved maintainability:** The Mediator pattern enhances code maintainability by centralizing the communication logic in a single class. This makes it easier to understand, modify, and debug the interactions between objects.
  
## Implementing the Mediator Design Pattern in C#:

 - Let’s demonstrate the implementation of the Mediator design pattern using C# code. We’ll create an example of an online chat application where users can send messages to each other through a mediator.

 - **Create an interface with IChatMediater**

   ![image](https://github.com/jil1710/readmedemo/assets/125335932/cef09d23-b905-4cae-b37f-b8197f370853)


 - **The ChatMediator interface defines the contract for communication between objects. It declares the `SendMessage()`, `JoinGroup()` method for sending messages and joining group.The ChatRoom class is the concrete mediator that implements the `ChatMediator` interface. It maintains a list of users and broadcasts messages to all users except the sender.**

   ![image](https://github.com/jil1710/readmedemo/assets/125335932/454b1b66-4a08-43e4-becb-f333170631a7)

 - **The User interface represents the colleague interface. It declares the `SendMessage()` and `ReceiveMessage()` methods for sending and receiving messages. The ChatUser class is a concrete colleague that implements the User interface. It communicates through the mediator by invoking the `SendMessage()` method and receives messages through the `ReceiveMessage()` method.**

   ![image](https://github.com/jil1710/readmedemo/assets/125335932/4fb20443-b50c-4908-92e7-a6be138f7da1)

   ![image](https://github.com/jil1710/readmedemo/assets/125335932/2fbb05fa-9728-4867-9a34-b1c49af6999f)


 - **Client code**

   ![image](https://github.com/jil1710/readmedemo/assets/125335932/c602ffed-7bb0-4011-b572-140af99e8434)








