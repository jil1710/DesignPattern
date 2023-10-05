using IteratorDesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern.Interface
{
    public class Iterator : IIterator
    {
        private MarshalCollection collection;

        private int current = 0;

        private readonly int step = 1;

        public Iterator(MarshalCollection collection)
        {
            this.collection = collection;
        }

        public bool IsCompleted { get { return current >= collection.Count; } }

        public Employee First()
        {
            current = 0;
            return collection.GetEmployee(current);
        }

        public Employee Next()
        {
            current += step;
            if (!IsCompleted)
            {
                return collection.GetEmployee(current);
            }
            else
            {
                return null;
            }
        }
    }
}
