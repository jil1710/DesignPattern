
# Iterator Design Pattern

- The Iterator Design Pattern allows sequential access to elements without exposing the inside logic. That means using the Iterator Design Pattern, we can access the elements of a collection sequentially without knowing its internal representations.
  
- Iterator pattern falls under behavioral pattern category.


## Example to Understand Iterator Design Pattern in C#:

  - Suppose we have a collection of employees. Then, we can easily iterate through the collection using either for or for each loop in C#, as shown in the below code.

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/614b03bd-6099-447f-8dcb-bc76c2e4137d)

  - Here, the for-each loop sequentially accesses the elements from the collection without exposing the internal logic, i.e., how it is accessing the elements sequentially. Again, you need to change the client code to use a different data structure. Is it not nice to provide a uniform interface for traversing different collections?

  - For example, your application may have different types of collections, such as List, Array, ArrayList, Generic Dictionary, etc. For whichever type of collection you have, you will need to traverse or iterate through the elements of the collections sequentially. The actual implementation of how to traverse different types of collections will be different, yet the client code should not be concerned about the details of the implementations. The Iterator Design Pattern helps you to hide such details and provides a generic interface for the client to traverse different types of collections, as shown in the image below.

   ![image](https://github.com/jil1710/readmedemo/assets/125335932/6a7cf407-afbe-4b87-9aa5-432456b67f36)

## Let's implement this above example :

  - **Step 1:** Create the Collection Item

      ![image](https://github.com/jil1710/readmedemo/assets/125335932/676df856-311a-4490-9328-adf80bf69ef6)

  - **Step 2:** Creating Aggregate Interface that has one method CreateIterator.

      ![image](https://github.com/jil1710/readmedemo/assets/125335932/cda5e8d9-f81a-42ac-a182-11b005eb4d50)

      ![image](https://github.com/jil1710/readmedemo/assets/125335932/f7bba401-1f41-4e36-b0b2-3247abfa4263)

  - **Step 3:** Creating Concrete Iterator. This will be a concrete class implementing the Iterator interface and providing implementations for Iterator interface methods.

      ![image](https://github.com/jil1710/readmedemo/assets/125335932/cc440d78-8322-4f1e-88e7-24f11b317cb8)

      ![image](https://github.com/jil1710/readmedemo/assets/125335932/182d2ea0-0dff-4518-baa6-06c31e849a52)

   - **Step 6:** Client Code

      ![image](https://github.com/jil1710/readmedemo/assets/125335932/9f02c153-a65b-41e9-89cc-a7ab73339581)


 - Click here to see the example : [Iterator Pattern](https://github.com/jil1710/DesignPattern/tree/master/IteratorDesignPattern)
