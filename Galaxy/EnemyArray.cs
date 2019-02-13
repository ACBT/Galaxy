using SFML.Graphics;
using SFML.System;
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
        Random random = new Random();

        public EnemyArray()
        {
            enemies = new Enemy[ENEMYS_COUNT];

            for (int i = 0; i < ENEMYS_COUNT; i++)
                SetPosition(TypeEnemy.HITHER,i);
        }

        public void SetPosition(TypeEnemy type ,int i)
        {
            
            enemies[i] = new Enemy(type);
            enemies[i].Position = new Vector2f(random.Next(0, Convert.ToInt32(Program.window.Size.X)/2), random.Next(0, Convert.ToInt32(Program.window.Size.Y) - 400));
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
