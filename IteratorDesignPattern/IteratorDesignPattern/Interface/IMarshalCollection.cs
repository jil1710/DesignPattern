using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern.Interface
{
    public interface IMarshalCollection
    {
        Iterator CreateIterator();
    }
}
