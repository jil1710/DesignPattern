
# Chain design pattern

- According to the Gang of Four Definitions, the Chain of Responsibility Design Pattern states that Avoid coupling the sender of a request to its receiver by giving more than one receiver object a chance to handle the request. Chain the receiving objects and pass the request along until an object handles it.
  
- In simple words, we can say that the chain of responsibility design pattern creates a chain of receiver objects for a given request. In this design pattern, normally, each receiver contains a reference to another receiver. If one receiver cannot handle the request, it passes the same request to the next receiver, and so on. One receiver handles the request in the chain, or one or more receivers handle the request.
  
## Real-Time Example to Understand Chain of Responsibility Design Pattern:

- Let us understand the Chain of Responsibility Design Pattern with one Real-Time Example. Please have a look at the following image. As shown in the image below, we have an ATM machine and four handlers. The TwoThousandhandler will give 2000 rupees. Similarly, the FiveHundredHandler will give 500 hundred rupees and the same for 200 and 100 handlers.

  ![image](https://github.com/jil1710/readmedemo/assets/125335932/768063d1-4e8a-4832-88ee-5c81d51ebfd2)

- Now, Anurag wants to withdraw 4600 rupees from the ATM machine. So, what the ATM machine will do is send the request to the first handler, i.e., the TwoThousandHandler, and the TwoThousandHandler will check the amount and give two 2000 rupees notes, and then the remaining amount is 600 rupees. So, the TwoThousandHandler will send the request to the FiveHundredHandler. Then, the FiveHundredHandler will check the remaining amount and give one 500 rupee note, and the remaining amount is 100 rupees. So, the FiveHundredHandler will forward the request to the next handler, i.e., TwoHundredHandler, and the TwoHundredHandler will check the remaining amount, which is 100. So, it can’t handle the request and simply forwards it to the next handler, HundredHandler. The HundredHandler checks the remaining amount, which is 100, and will give one 100 rupees note. This way, it will handle the request and provide Anurag with 4600 (2 * 2000, 1*500, and 1*100). This is one of the best examples of one or more receivers in the chain handling the request.

  
## Let us implement the above-discussed example step by step using the Chain of Responsibility Design Pattern in C#.

 - **Step 1:** Creating Abstract Handler

   ![image](https://github.com/jil1710/readmedemo/assets/125335932/91166c8c-f835-416c-91c8-84489b6a9b08)


 - **Step 2:** Creating Concrete Handlers

     Here, we will create four handlers (TwoThousandHandler, FiveHundredHandler, TwoHundredHandler, and HundredHandler) to handle the respective currency. Create a class file named TwoThousandHandler.cs and copy and paste the following code. This class inherits from the Handler abstract class and implements the abstract DispatchNote method. 

   ![image](https://github.com/jil1710/readmedemo/assets/125335932/409552ea-4be4-4a91-961f-856f9f4a4083)

   ![image](https://github.com/jil1710/readmedemo/assets/125335932/fec63065-314c-4c47-8a83-5c3e08a9da64)

   ![image](https://github.com/jil1710/readmedemo/assets/125335932/bca0cf75-f78a-4f9b-9c03-3c9971c77782)

- **Step 3 :** Chaining the Handlers

    In our example, ATMMachine has managed the sequence in which all the handlers will be chained together. This class is used for internal processing and holding request details. The client is going to use this class. So, create a class file named ATMMachine.cs and copy and paste the following code. In the following code, we are creating four instance variables of our four concrete handlers, and through the constructor, we prepare the sequence of the chain of handlers. We also provide one method (i.e., Withdraw()), which the client will consume.

  ![image](https://github.com/jil1710/readmedemo/assets/125335932/36d3b330-94de-4b3a-af09-dbfbc8544109)


 - The Main method of the Program class is going to be the Client. So, modify the Main method of the Program class as shown below. As you can see, here we are creating an instance of ATM class and calling the Withdraw method by passing the amount.

   ![image](https://github.com/jil1710/readmedemo/assets/125335932/ce8a7d4f-cb48-47c6-9303-4cf73a23ec59)

   ![image](https://github.com/jil1710/readmedemo/assets/125335932/f39eb67e-1d8a-406f-9839-a4174d41dd87)













