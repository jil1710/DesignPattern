using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
    public class Ball 
    {
        private string color;
        private string imgUrl;
        public int cordX { get; set; }
        public int cordY { get; set; }
        public int radius { get; set; }

        public Ball(string color, string imgUrl)
        {
            this.color = color;
            this.imgUrl = imgUrl;   
        }


        public void draw()
        {
            Console.WriteLine($"Color -> {color} -> Url -> {imgUrl} -> Radius -> {radius}");
        }

    }
}
