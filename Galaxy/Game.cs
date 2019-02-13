using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy
{
    class Game 
    {
        World world;
        Player player;
        public Game()
        {
            world = new World();
           
        }
        public void Update()
        {

        }

        public void Draw()
        {
            Program.window.Draw(world);
        }

        
    }
}
