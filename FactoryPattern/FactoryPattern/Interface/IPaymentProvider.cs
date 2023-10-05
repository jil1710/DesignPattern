using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Interface
{
    public interface IPaymentProvider
    {
        void ProcessPayment(decimal money);
    }
}
