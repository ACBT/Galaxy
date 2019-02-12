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

        public World()
        {
            pl = new Player();
            en = new Enemy();
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            target.Draw(pl);
        }
    }
}
