
# Facade Design Pattern

- As per the GOF definition, Facade Design Pattern states that you need to provide a unified interface to a set of interfaces in a subsystem. The Facade Design Pattern defines a higher-level interface that makes the subsystem easier to use.
  
- In simple words, we can say that the Facade Design Pattern is used to hide the complexities of a system and provides an easy-to-use interface to the client using which the client can access the system. The Facade (usually a wrapper) class sits on the top of a group of subsystems and allows them to communicate in a unified manner.

## When to use Facade Design Patterns in Real-Time Applications?

  - We want to provide a simple interface to a complex subsystem. 
  - There are many dependencies between clients and the implementation classes.

## Facade Design Pattern in C# with one Real-Time Example:

  - Let us understand the Facade Design Pattern in C# with one Real-Time Example. Please have a look at the following diagram for a better understanding. Here, we need to design an application to place an order in an E-Commerce Application.

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/8d13f937-2a24-4e3e-b18c-3873aa204b39)

  - As shown in the above image, to place an order first, the Client needs to create an object of the Product class and get the product details by calling the GetProductDetails method. Then, if everything is fine (i.e. if the Product is available in stock), then you need to make the Payment. To do this, the Client needs to create an instance of the Payment class and need to call the MakePayment method. If Payment is successful, then we need to send the Invoice to the customer, and to do so, the Client needs to create an instance of the Invoice class and call the SendInvoice method. So, in order to place the order, the Client needs to do the above-mentioned steps in a particular order.

  - The Facade Design Pattern in C# is actually an extra class (i.e., a Wrapper class or, you can say, Facade Class) that sits at the top of the above classes. Please have a look at the following diagram for a better understanding.

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/ce7b5aeb-be7c-4b7a-90d4-06beb99d145b)

  - So, here, the extra class Order is nothing but the Facade class, which will be responsible for placing the order. This class internally creates the instance of the respective classes and calls the methods in a particular order. Now, the Client will not call the respective classes and their methods to place the order; instead, the Client will call the Order Class, PlaceOrder to method to place an order. The PlaceOrder method will internally use the Product, Payment, and Invoice classes to place the order.


 - Click here to see the example : [Facade Pattern](https://github.com/jil1710/DesignPattern/tree/master/FacadeDEsignPattern)

