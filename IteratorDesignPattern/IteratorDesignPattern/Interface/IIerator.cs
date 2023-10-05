using IteratorDesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern.Interface
{
    interface IIterator
    {
        Employee First();
        Employee Next();
        bool IsCompleted { get; }
    }
}
