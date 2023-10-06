
# Observer Design Pattern

- According to GoF, the Observer design Pattern Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
    
- The Observer Design Pattern defines a one-to-many dependency between objects so that when one object’s state changes, all its dependents are notified and updated automatically. The Other names of this pattern are Producer/Consumer and Publish/Subscribe.

## How Does the Observer Design Pattern Work?

- The observer design pattern has two main components. They are as follows

    - **Subject:** They are also called Publishers. When a change occurs to a subject, it should notify all its Subscribers/Observers.
    - **Observers:** They are also called subscribers. They listen to the changes in the subjects.

## Real-Time Example to Understand Observer Design Pattern:

  - Let us understand the Observer Design Pattern with one Real-Time Example. Please have a look at the following diagram. Here, we are taking the example of the Amazon ECommerce Application.

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/7272138b-4512-4773-bd85-661ff6de3c97)

  - As you can see in the above image, three users come to the Amazon site to buy a Mobile Phone. Unfortunately, at that time, the Mobile phone was out of stock, i.e., the mobile is in the Out Of Stock state. But the above three users want to buy that particular mobile phone. The Amazon website has an option called Notify Me when the product is unavailable in stock. The above three users click the Notify Me button so that the Amazon site will notify them when the product is available.

  - After a few days, the Product is available, so the status of the Product is changed from Out Of Stock to Available. So, Amazon will notify all users registered with that particular product that the product is available. As we already discussed, the Observer Design Pattern has two main components, i.e., the Subject and the Observer. In our examples, the Mobile is the Subject, and three users (i.e., User1, User2, and User3) are the Observers. For a better understanding, please have a look at the following image.
  
  ![image](https://github.com/jil1710/readmedemo/assets/125335932/95a3b1c2-8f52-4254-8181-c67c39144db7)

 - As per the Observer Design Pattern, the Observers must be registered with the Subject. In our case, the three users are registered to the notification option of the Subject. When the state changes, i.e., Out of Stock to Available, the Subject will notify all subscribers.


 - Click here to see the implementation of above example : [Observer Pattern](https://github.com/jil1710/DesignPattern/tree/master/ObserverPattern)
