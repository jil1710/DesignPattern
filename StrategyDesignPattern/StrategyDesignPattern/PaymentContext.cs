using StrategyDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class PaymentContext
    {
  
        private IPaymentStrategy PaymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            PaymentStrategy = strategy;
        }

        public void Pay(double amount)
        {
            PaymentStrategy.Pay(amount);
        }
    }
}
