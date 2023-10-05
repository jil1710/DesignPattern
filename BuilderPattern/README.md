
# Builder Design Pattern

- Builder pattern builds a complex object using simple objects and using a step by step approach. This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.
  
- So, the Builder Design Pattern is about separating the construction process from its representation. When the construction process of your object is very complex, only you need to use the Builder Design Pattern.

## Example to Understand Builder Design Pattern:

  - Let us understand the Builder Design Pattern in C# with one Real-Time Example. Suppose we want to develop an application for displaying the reports. The reports we need to display either in Excel or in PDF format. That means we have two types of representation of the reports.

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/21397d1f-8eac-4c72-946f-24ee422724ac)

  - As you can see in the above image, we generate the report in Excel or PDF formats. The construction process involves several steps, such as Creating a new report and setting the report type, header, content, and footer. If you look at the final output, we have one PDF representation and one Excel representation. Please look at the following diagram to understand the construction process and its representation. As you can see, the construction process is the same, but we are getting two types of reports with the same construction process.

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/cd367cd7-e4f0-43c6-a6b5-e13f67650ef5)


- Click here to see the example of builder Pattern : [Builder Pattern](https://github.com/jil1710/DesignPattern/tree/master/BuilderPattern)

