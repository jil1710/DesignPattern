using BridgeDesignPattern.Service;

namespace BridgeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape redCircle = new Circle(30, 200, 340, new DrawRedCircle());
            Shape greenCircle = new Circle(100, 100, 10, new DrawGreenCircle());

            redCircle.Draw();
            greenCircle.Draw();
        }
    }
}