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
            player = new Player();
        }
        public void Update()
        {
            player.Update();
        }

        public void Draw()
        {
            Program.window.Draw(world);
            Program.window.Draw(player);
        }

        
    }
}
