
# Factory Design Pattern

- According to Gang of Four (GoF), the Factory Design Pattern states that A factory is an object used for creating other objects. In technical terms, we can say that a factory is a class with a method. That method will create and return different objects based on the received input parameter.
  
- In the Factory Design pattern, we create an object without exposing the Object Creation and Initialization logic to the client, and the client will refer to the newly created object using a common interface. The basic principle behind the Factory Design Pattern is that, at run time, we get an object of a similar type based on the parameter we pass. So, the client will get the appropriate object and consume the object without knowing how the object is created and initialized. 

## When to use the Factory Design Pattern in Real-Time Applications?

  - The Object needs to be extended to the subclasses.
  - Classes don’t know what exact sub-classes it has to create.
  - The Product implementation is going to change over time, and the Client remains unchanged.

## Real-Time Example to Understand Factory Design Pattern

  - Let us understand the Factory Design Pattern with one Real-Time Example. We are going to develop an application for showing Payment Processing.

  - So we have different payment provider such as Strip, RazorPay, Paypal etcc.. and client want to use these payment provider for example if client want to use Strip then PaymentProviderFactory will gave the object of Strip and then it will process the payment.Let's implement this so get an better idea..


  - PaymentProviders ( Strip, RazorPay, Paypal )

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/61b084e6-3017-447e-b17a-7e8b7c29a87f)

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/e376ff4c-9cb0-4e9a-b21d-3af0b3713f59)

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/3342822c-c69f-4e73-be24-0ec2b33e31a9)

  - We have PaymentProviderFactory that will return the regitered factory else return exception

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/2b633eaf-97a2-4cf2-897a-429801f3127b)


 - Click here to see the example : [Factory Pattern](https://github.com/jil1710/DesignPattern/tree/master/FactoryPattern)

