using BridgeDesignPattern.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public abstract class Shape
    {
        protected IDrawService drawservice;

        protected Shape(IDrawService drawservice)
        {
            this.drawservice = drawservice;
        }
        public abstract void Draw();
    }
}
