
# Bridge Design Pattern

- As per the Gang of Four definitions, the Bridge Design Pattern “Decouples an abstraction from its implementation so that the two can vary independently“.
  
- In the Bridge Design Pattern, there are 2 parts. The first part is the Abstraction and the second part is the Implementation. The Bridge Design Pattern allows both Abstraction and Implementation to be developed independently and the client code can only access the Abstraction part without being concerned about the Implementation part.

## When do we need to use Bridge Design Pattern in C# Real-Time Applications?

  - We want to hide the implementation details from the client.
  - We want the selection or switching of the implementation to be at runtime rather than design time.
  - We want both the abstraction and implementation classes to be extensible by the subclasses.
  - We want to avoid a tight coupling binding between an abstraction and its implementation. 
  - The changes in the implementation of an abstraction should have no impact on clients.

## Let's implement the Bridge Pattern

- We have a DrawAPI interface which is acting as a bridge implementer and concrete classes RedCircle, GreenCircle implementing the DrawAPI interface. Shape is an abstract class and will use object of DrawAPI. BridgePatternDemo, our demo class will use Shape class to draw different colored circle.
  
  ![image](https://github.com/jil1710/readmedemo/assets/125335932/6922dfc5-6f41-4aa4-a150-3c2a6d8a2d93)

- Create bridge implementer interface.

  ![image](https://github.com/jil1710/readmedemo/assets/125335932/f8683345-bd44-4cb5-9a22-0776106e308d)

- Create concrete bridge implementer classes implementing the IDrawService interface.

  ![image](https://github.com/jil1710/readmedemo/assets/125335932/df57bff7-09c4-41a2-80a9-ee5b9e818aec)

  ![image](https://github.com/jil1710/readmedemo/assets/125335932/0ab37195-2aa8-433f-b012-c6f0e7c6c427)

- Create an abstract class Shape using the IDrawService interface.

  ![image](https://github.com/jil1710/readmedemo/assets/125335932/2fe54a67-6b33-4369-910e-76af57cbd0a8)

- Create concrete class implementing the Shape interface.

  ![image](https://github.com/jil1710/readmedemo/assets/125335932/5235563a-cb95-4c75-9345-bfb79501f68a)

- Use the Shape and IDrawService classes to draw different colored circles.

  ![image](https://github.com/jil1710/readmedemo/assets/125335932/f293dcd3-c015-4f4a-b87e-1646bd258cf2)





