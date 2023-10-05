namespace FlyWeightPattern
{
    internal class Program
    {
        private static string[] colour = new string[] { "Red", "Green", "Blue" };

        private static Dictionary<string, string> urlMap = new Dictionary<string, string>();

        static Program()
        {
            urlMap.Add("Red", "Red.jpg");
            urlMap.Add("Green", "Green.jpg");
            urlMap.Add("Blue", "Blue.jpg");
        }

        private static string GetColour()
        {
            return colour[new Random().Next(0, 3)];
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                string color = GetColour();
                string url = urlMap[color];

                Ball ball = BallFactory.GetBall(color, url);
                ball.cordX = i;
                ball.cordY = i + 2;
                ball.radius = i + 2;
                ball.draw();
            }
        }
    }
}