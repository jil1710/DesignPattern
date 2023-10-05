using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Service
{
    public class DrawGreenCircle : IDrawService
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine($"Drawing Circle [ Color: Green, Radius: {radius}, X : {x}, Y : {y} ]");
        }
    }
}
