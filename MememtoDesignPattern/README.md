
# Mememto design pattern

- The Memento Design Pattern in C# restores an object to its Previous State. You must use the Memento Design Pattern to perform undo or rollback operations in your application. That means the Memento Design Pattern captures an object’s internal state to be restored to that state later. It is especially useful when implementing undo functionality in an application.

## Understanding Memento Design Pattern with an Example in C#:

- Let us understand the Memento Design Pattern in C# with an example. Please have a look at the following image. As shown in the below image, on the left-hand side, we have an employee with `Id =101, Name =John, Salary = 2Lakhs, Designation = Software Engineer, Address = London`, and many more attributes. Later, we changed some of the properties, i.e., Salary to 3Lakhs and designation to Senior Software Engineer; we also changed some other employee attributes, shown on the right-hand side of the image below. That means we change the object state from State 1 to State 2.

  ![image](https://github.com/jil1710/readmedemo/assets/125335932/5eb3a8be-873c-46e5-b635-dc22eb8c544a)

- After some time, let’s undo or roll back the employee information to its previous state, i.e., State 1. If this is your requirement, you must use the Memento Design Pattern and roll back the employee information to its previous state.


## Real-Time Example of Memento Design Pattern in C#: Banking System

- Consider a scenario where a customer uses online banking to make various transactions. To enhance the user experience, the bank wants to provide a feature that allows users to undo their recent transactions. Let us see how we can implement the above example using the Memento Design Pattern in C#:

    - **Create Transaction State class that can hold the latest transaction

      ![image](https://github.com/jil1710/readmedemo/assets/125335932/d2dc6b4e-d82a-4dcf-ba30-66efe6cfa370)

    - **Create Bank Account for performing operation such as deposite, withdraw, Undo transaction etc..**
 
      ![image](https://github.com/jil1710/readmedemo/assets/125335932/478f78a7-a4b6-4ebb-9934-3b0d6de58dff)

    - **Create Bank History class for managing history of transaction**
 
      ![image](https://github.com/jil1710/readmedemo/assets/125335932/83dcff38-992f-4b94-8fe6-96e8f0b6103c)

    - **Let's managing history**

      ![image](https://github.com/jil1710/readmedemo/assets/125335932/f292c664-9893-4d2e-9e3f-b34df0e8e62c)














