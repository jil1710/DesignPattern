using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Service
{
    public interface IDrawService
    {
        void DrawCircle(int radius, int x, int y);
    }
}
