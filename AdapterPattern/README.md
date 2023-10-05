
# Adapter Design Pattern

- The Adapter Design Pattern is a Structural Design Pattern that allows incompatible interfaces (objects) to work together. The Adapter Design Pattern acts as a bridge between two incompatible objects. Let’s say the first object is A and the second object is B. Object A wants to consume some of the services provided by object B as they are incompatible, so they cannot communicate directly. In this case, the Adapter will come into the picture and act as a middleman or bridge between object A and object B. Now, object A will call the Adapter, and the Adapter will do the necessary transformations or conversions, and then it will call object B.
  
- The Adapter Design Pattern in C# involves a single class called Adapter responsible for communication between two independent or incompatible interfaces. So, in simple words, we can say that the Adapter Design Pattern helps two incompatible interfaces to work together.
  
## When to use the Adapter Design Pattern in Real-Time Applications?

  - A class needs to be reused that does not have an interface that a client requires.
  - Allow a system to use classes of another system that is incompatible with it.
  - Allow communication between a new and already existing system that is independent of each other.
  - Sometimes, a toolkit or class library cannot be used because its interface is incompatible with the interface required by an application.
  
## Let's implement the abstract factory :

   - Let’s consider a scenario, In our application we are using third party tool to process the data but the data we have is XML data and third party tool only accept json data to process the data, so in this scenario we create an adapter that can transform the xml data to json data afterward we can process the data.

  - Structure for XML Data
    
      ![image](https://github.com/jil1710/readmedemo/assets/125335932/d2ee4dfd-8d0c-4ffe-b390-a2654b2fbc16)

  - Structure For JSON Data
    
      ![image](https://github.com/jil1710/readmedemo/assets/125335932/ef3d2477-c71e-4335-8da9-f4de6e1edce4)

  - XML To JSON Data Transform Adapter
    
      ![image](https://github.com/jil1710/readmedemo/assets/125335932/bddeb6ed-daf2-464f-aacc-0f2133bfb246)

  - Use The Adapter 

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/0fe2899e-3366-4fab-b7fc-373e70369ca5)


