using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy
{
    class EnemyArray : Transformable, Drawable
    {
        public const int ENEMYS_COUNT = 10;
        Enemy[] enemies;
        Random random;

        public EnemyArray()
        {
            enemies = new Enemy[ENEMYS_COUNT];

            for (int i = 0; i < ENEMYS_COUNT; i++)
                SetPosition(i);
        }

        public void SetPosition(int i)
        {
            random = new Random();
            //enemies = new Enemy ;
            //enemies[i].Position = new SFML.System.Vector2f(random.Next(0,Convert.ToInt32(Program.window.Size.X)), random.Next(0,Convert.ToInt32(Program.window.Size.Y)));
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            states.Transform *= Transform;
            for (int i = 0; i < enemies.Length; i++)
            {
                target.Draw(enemies[i], states);
            }
            
        }
    }
}
