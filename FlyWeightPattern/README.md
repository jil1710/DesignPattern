
# FlyWeight Design Pattern

- Flyweight pattern is primarily used to reduce the number of objects created and to decrease memory footprint and increase performance. This type of design pattern comes under structural pattern as this pattern provides ways to decrease object count thus improving the object structure of application.
  
- Flyweight pattern tries to reuse already existing similar kind objects by storing them and creates new object when no matching object is found. We will demonstrate this pattern by drawing 20 circles of different locations but we will create only 5 objects. Only 5 colors are available so color property is used to check already existing Circle objects. 

## When to use the Flyweight Design Pattern in Real-Time application?

  - **Large Numbers of Similar Objects:** You might consider using the Flyweight pattern if you have many similar objects and a high storage cost.
  - **Immutability:** Objects must be immutable for Flyweight to work correctly. This means that the shared objects cannot be modified once created, ensuring consistency and avoiding potential issues with the shared state.
  - **Granularity:** When you need finer granularity objects, Flyweight can help. This means breaking down larger objects into smaller, more manageable pieces.
  - **Memory Constraints:** If your application runs in an environment where memory is a concern, the Flyweight pattern can reduce your memory footprint.
  - **Externalized State:** If an object’s state can be externalized and a significant portion of the object’s state can be made extrinsic (shared), then the Flyweight pattern can be applied. The flyweight manages this shared state, while the unique state is managed outside of the flyweight.

## Example to Understand Flyweight Design Pattern in C#:

  - Please look at the following image to better understand the Flyweight Design Pattern. As you can see in the following image, we created and stored one circle object in the Cache. Here, the circle object we stored in the cache has no color. Suppose, let’s say, we have to create 90000 circle objects in green and 90000 circle objects in blue. Again, we must create 80000 circle objects, which are orange, and 70000 circle objects in black. If you notice, all the circle object shapes are the same, only the color changes.

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/3be14e80-78ec-474e-823f-eb82dfb387e7)

  - As per the Flyweight Design Pattern, we can improve the performance by creating the circle object only once time and reusing that circle object many times to create different types of colors. Suppose you want to create 90000 circle objects with green color, then what you can do is. Instead of creating new circle objects every time and filling them with green color, you can get the circle object from the Cache and fill it with green color. In the same way, you can create 90000 circle objects with green color. So, in this way, we can improve the application’s performance using the Flyweight Design Pattern.


 - Click here to see the example : [FlyWeight Pattern](https://github.com/jil1710/DesignPattern/tree/master/FlyWeightPattern)

 - Click here to get more detail on Fly Weight Pattern : [ Fly Weight Video ](https://www.youtube.com/watch?v=8cL9KbHS5kE&t=318s&ab_channel=sudoCODE)

