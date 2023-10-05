
# Decorator Design Pattern

- Decorator pattern allows a user to add new functionality to an existing object without altering its structure. This type of design pattern comes under structural pattern as this pattern acts as a wrapper to existing class.

- This pattern creates a decorator class which wraps the original class and provides additional functionality keeping class methods signature intact.

## Understand Decorator Design Pattern:

  - We're going to create a Shape interface and concrete classes implementing the Shape interface. We will then create an abstract decorator class ShapeDecorator implementing the Shape interface and having Shape object as its instance variable.

  - RedShapeDecorator is concrete class implementing ShapeDecorator.

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/9330d2fb-5a6c-4452-8c29-11fb558bf8a5)

  - Create an interface.

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/1780e8b4-fe27-4831-a2f0-a9821dfe8ca6)

  - Create concrete classes implementing the same interface.

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/e78b7a16-f461-4bd0-bf54-5ae02966b7ce)

  - Create abstract decorator class implementing the Shape interface.

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/c3084856-a3b5-4d42-98cc-1c26bdaf25af)

  - Create concrete decorator class extending the ShapeDecorator class.

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/5fd28710-4681-4f25-b62d-c5588be977ae)

  - Use RedshapeDecorator to decorate the circle object
    
    ![image](https://github.com/jil1710/readmedemo/assets/125335932/4bc00e32-53f3-404f-a9b3-3e8881d2ab7e)


 - Click here to see the example : [Decorator Pattern](https://github.com/jil1710/DesignPattern/tree/master/DecoratorDesignPattern)

