
# Strategy design pattern

- According to the Gang of Four Definitions, Strategy is a behavioral design pattern that lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable.
  
- The Strategy Design Pattern is a behavioral design pattern that defines a family of algorithms, encapsulates each one, and makes them interchangeable. It allows the algorithm to vary independently from clients that use it.
  
## Understanding Stratery Design Pattern with an Example in C#:

 - **Create an interface with IPaymentStrategy**

   ![image](https://github.com/jil1710/readmedemo/assets/125335932/e009f264-d300-4345-9dad-9168bd492652)

 - **Create PaymentType Enum**

   ![image](https://github.com/jil1710/readmedemo/assets/125335932/7167ac29-5c7d-4e74-bc24-1fb74155f414)

 - **CreditCardPaymentStrategy Concrete Strategy class implements the IPaymentStrategy Interface and provides implementations for the Pay Method.**

   ![image](https://github.com/jil1710/readmedemo/assets/125335932/4bd8217c-e4a8-4375-bbe0-9b1611d2ed92)

 - **CashCardPaymentStrategy Concrete Strategy class implements the IPaymentStrategy Interface and provides implementations for the Pay Method.**

   ![image](https://github.com/jil1710/readmedemo/assets/125335932/e0ff612b-661f-4804-976f-6ee5afd3bab7)

 - **Create PaymentContext class that contains a property that holds the reference of a Strategy object. The client will set this property at run-time according to the payment option the client selected**

   ![image](https://github.com/jil1710/readmedemo/assets/125335932/25e70432-aaf8-410b-9f70-274e45bb902a)

 - **Client code**

   ![image](https://github.com/jil1710/readmedemo/assets/125335932/ab0d0cd9-bfe3-4a84-941b-86d7a3f73321)








