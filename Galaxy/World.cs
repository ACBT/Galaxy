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
           
            en = new Enemy(TypeEnemy.HITHER);
            ena = new EnemyArray();
        }

        public void Update()
        {
            
        }
        

        public void Draw(RenderTarget target, RenderStates states)
        {

            states.Transform *= Transform;
            //target.Draw(pl,states);
            target.Draw(ena, states);
        }
    }
}
