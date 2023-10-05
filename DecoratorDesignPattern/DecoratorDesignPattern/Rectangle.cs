﻿using DecoratorDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape : Rectangle");
        }
    }
}
