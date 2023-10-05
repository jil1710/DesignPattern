
# Abstract Design Pattern

- According to the Gang of Four Definition, The Abstract Factory Design Pattern provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes.
  
- In simple words, we can say that the Abstract Factory is a super factory that creates other factories. This Abstract Factory is also called the Factory of Factories. That means the Abstract Factory design pattern provides an interface for creating families of related or dependent products but leaves the actual object creation to the concrete factory classes.
  
## Let's take an example

- We must use the following components to Implement the Abstract Factory Design Pattern in C#.

    - **Abstract Product:** These are going to be interfaces for creating abstract products. Here, we need to define the Operations a Product should have.
    - **Concrete Product:** These are the classes that implement the Abstract Product interface.
    - **Abstract Factory:** This will be an interface for operations that will create Abstract Product objects.
    - **Concrete Factory:** These classes implement the Abstract Factory interface and provide implementations for the interface methods. We can use these concrete classes to create concrete product objects.
    - **Client:** This class will use our Abstract Factory and Abstract Product interfaces to create a family of products.

    - ![image](https://github.com/jil1710/readmedemo/assets/125335932/4c47903f-6c1c-4d96-89b2-de28e883453d)

 ## When to use Abstract Factory Design Pattern Real-Time Applications in C#?

   - **System Needs to Be Independent of How Its Objects Are Created, Composed, and Represented:** When isolating your application’s concrete classes, Abstract Factory can access specific families of objects without directly instantiating them.
   - **System Should Be Configured with One of the Multiple Families of Products:** If your software needs to support multiple sets or families of products (like UI controls for different operating systems or communication interfaces for different protocols), an      Abstract Factory can help configure the application with the right family.
   - **Products in a Family Need to Be Used Together:** If mixing products from different families (like using a macOS button with a Windows window) doesn’t make sense, an Abstract Factory ensures the client uses products from the same family.
   - **Adding New Families of Products:** If there’s a requirement in the future to add new families of products without modifying existing code, the Abstract Factory pattern supports this scenario by allowing you to create new concrete factories for the new products.
 
## Let's implement the abstract factory :

  - Let’s consider a scenario where customer or user want to get the loan from bank. The Abstract Factory pattern can help create families of related objects to to get the bank factory and loan factory, considering operations like loan calulation. Let us see how we can implement the above example using the Abstract Factory Design Pattern in C#:

    ```csharp
      public interface IBank
      {
          string GetBankName();
      }
  
      public class SBI : IBank
      {
          private readonly string bankname;
  
          public SBI()
          {
              this.bankname = "SBI Bank";
          }
          public string GetBankName()
          {
              return bankname;
          }
      }
  
      // Concrete Products for PayPal
      public class HomeLoan : Loan
      {
  
          public override void GetInterestRate(double rate)
          {
              this.rate = rate;
          }
      }
  
       public abstract class Loan
      {
          protected double rate;
          public abstract void GetInterestRate(double rate);
          public void CalculateLoanPayment(double loanamount, int years)
          {
              double EMI;
              int n;
  
              n = years * 12;
              rate = rate / 1200;
              EMI = ((rate * Math.Pow((1 + rate), n)) / ((Math.Pow((1 + rate), n)) - 1)) * loanamount;
  
              Console.WriteLine($"your monthly EMI is {EMI} for the amount {loanamount} you have borrowed");
          }
      }
  
      // Abstract Factory
      public abstract class Abstract_Factory
      {
          public abstract IBank GetBank(String bank);
          public abstract Loan GetLoan(String loan);
      }
  
      // Concrete Factories
      public class BankFactory : Abstract_Factory
      {
          public override IBank GetBank(String bank)
          {
              if (bank == null)
              {
                  return null;
              }
              if (bank.Equals("HDFC"))
              {
                  return new HDFC();
              }
              else if (bank.Equals("ICICI"))
              {
                  return new ICICI();
              }
              else if (bank.Equals("SBI"))
              {
                  return new SBI();
              }
              return null;
          }
          public override Loan GetLoan(String loan)
          {
              return null;
          }
      }
  
      public class LoanFactory : Abstract_Factory
      {
          public override IBank GetBank(String bank)
          {
              return null;
          }
  
          public override Loan GetLoan(String loan)
          {
              if (loan == null)
              {
                  return null;
              }
              if (loan.Equals("Home"))
              {
                  return new HomeLoan();
              }
              else if (loan.Equals("Business"))
              {
                  return new BusinessLoan();
              }
              else if (loan.Equals("Education"))
              {
                  return new EducationLoan();
              }
              return null;
          }
      }
  
      // Client Code
     public static class FactoryCreator
    {
        public static Abstract_Factory GetFactory(string choice)
        {
            if (choice.Equals("Bank"))
            {
                return new BankFactory();
            }
            else if (choice.Equals("Loan"))
            {
                return new LoanFactory();
            }
            return null;
        }
    }
      
      // Testing the Abstract Factory Design Pattern
      public class Program
      {
          static void Main(string[] args)
      {
          Console.WriteLine("Enter the name of Bank from where you want to take loan amount: Type from this [ HDFC, SBI, ICICI ] ");
          string br = Console.ReadLine()!;

          Console.WriteLine("\n");
          Console.WriteLine("Enter the type of loan e.g. Home loan or Business loan or Education loan : ");

          string loanName = Console.ReadLine()!;
          Abstract_Factory bankFactory = FactoryCreator.GetFactory("Bank");
          IBank b = bankFactory.GetBank(br);

          Console.WriteLine("\n");
          Console.WriteLine("Enter the interest rate for " + b.GetBankName() + ": ");

          double rate = Double.Parse(Console.ReadLine()!);
          Console.WriteLine("\n");
          Console.WriteLine("Enter the loan amount you want to take: ");

          double loanAmount = Double.Parse(Console.ReadLine()!);
          Console.WriteLine("\n");
          Console.WriteLine("Enter the number of years to pay your entire loan amount: ");
          int years = int.Parse(Console.ReadLine()!);

          Console.WriteLine("\n");
          Console.WriteLine("you are taking the loan from " + b.GetBankName());

          Abstract_Factory loanFactory = FactoryCreator.GetFactory("Loan");
          Loan l = loanFactory.GetLoan(loanName);
          l.GetInterestRate(rate);
          l.CalculateLoanPayment(loanAmount, years);

          Console.ReadKey();
      }
      }

    ```


    






    

  



