using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Service
{
    public class DrawRedCircle : IDrawService
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine($"Drawing Circle [ Color: Red, Radius: {radius}, X : {x}, Y : {y} ]");
        }
    }
}
