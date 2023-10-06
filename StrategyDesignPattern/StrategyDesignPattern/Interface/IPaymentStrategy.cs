using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Interface
{
    public interface IPaymentStrategy
    {
        void Pay(double amount);
    }
}
