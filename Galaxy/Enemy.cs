using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy
{
    class Enemy
    {
        private double x;
        private double y;
        private int r;
        private Color color1;
        private Color color2;
        Random rn = new Random();

        public Enemy()
        {
            x = rn.Next(0,Convert.ToInt32(Program.window.Size.X));
            y = rn.Next(0, 100);
            r = 5;
            color1 = Color.Red;
        }
    }
}
