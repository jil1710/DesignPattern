
# Interpreter design pattern

- Interpreter pattern provides a way to evaluate language grammar or expression. This type of pattern comes under behavioral pattern. This pattern involves implementing an expression interface which tells to interpret a particular context. This pattern is used in SQL parsing, symbol processing engine etc.

- Let us understand the Interpreter Design Pattern with an example. Please have a look at the following image. On the left-hand side, you can see the Context. The Context is nothing but the value that we want to interpret. Here, the context value is the current date. On the right-hand side, you can see the Date expression, or you can say the grammar. We have different types of date expressions, such as (MM-DD-YYYY, DD-MM-YYYY, YYYY-MM-DD, and DD-YYYY).

  ![image](https://github.com/jil1710/readmedemo/assets/125335932/0e0875c0-0667-4a1d-af3f-f60a9fac0799)

- Suppose you want the date in MM-DD-YYYY format; then, you must pass the Context value and the Date Expression you want (i.e., MM-DD-YYYY) to the interpreter. What the interpreter will do is it will convert the context value into the date expression format you passed to it. So, the interpreter contains the logic or grammar to convert the context object into a specific readable format.

## Let's implement the interpreter pattern with real example:

  - **Query Language for Filtering a Collection of Products**

      Interpreting a domain-specific query language for filtering a collection of products. Suppose we have an e-commerce platform and want to provide users with a way to filter products using a custom query language. Our DSL might be:

      **Our query is like :** `"brand:Nike; color:blue; minprice:100; maxprice:300"` - This would filter products of the Nike brand that are blue and priced between 100 and 300.


  - **Create Product Model**

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/0e399fc2-4341-4132-9c85-23192b824f0f)

  - **Create Product filter interface for interpreter**

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/d30987d3-9f7b-4188-91df-c29c3f26356b)

  - **Create Filters like filter base on price, base on brand, base on color or combination of all compound filter**

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/399c6384-09b2-45f7-a4d8-eebc0cf1e1ff)

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/aaf3b1d4-f8a5-4f29-b605-44263c8e0196)

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/5ad1423c-dd2b-472f-b2c6-2ee47f2b3e69)

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/7905ca88-280d-4ff5-9058-f4d26080e741)

  - **Create interpreter or parser that can parse our query or base on our query filter the product**

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/3cd94515-b331-4ac4-bbbe-dbbb2be012b2)

  - **Client write the query and interpreter parse the query and produce the result.**

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/4122e5f6-a34c-4a9a-91a1-904173c4a990)








