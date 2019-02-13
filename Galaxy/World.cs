using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy
{
    class World : Transformable, Drawable
    {
        Player pl;
        Enemy en;
        EnemyArray ena;

        public World()
        {
            pl = new Player();
            en = new Enemy();
            ena = new EnemyArray();
        }

        
        

        public void Draw(RenderTarget target, RenderStates states)
        {
            
            states.Transform *= Transform;
            target.Draw(pl,states);
            target.Draw(ena, states);
        }
    }
}
