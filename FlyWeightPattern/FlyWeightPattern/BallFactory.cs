using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
    public class BallFactory
    {
        private static Dictionary<string, Ball> ballDic = new Dictionary<string, Ball>();
        
        public static Ball GetBall(string color,string url)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(color);
            sb.Append(url);

            string cacheKey = sb.ToString();
            Ball ball;
            ballDic.TryGetValue(cacheKey, out ball);

            if(ball== null)
            {
                ball = new Ball(color, url);
                ballDic.TryAdd(cacheKey, ball);
                Console.WriteLine($"\nCreating Circle of color : {color}\n");
            }
            return ball;
        }
    }
}
