using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections;
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
        //Bullet [] bullets = new Bullet[10];
        //ArrayList bullets = new ArrayList(Bullet);
        List<Bullet> bullets;
        //Bullet bullet = new Bullet();
        bool a = true;

        public Game()
        {
            world = new World();
            player = new Player();
            bullets = new List<Bullet>();

            //for (int i = 0; i < 9; i++)
            //{
            //    bullets.Add(new Bullet());
            //}

            //for (int i = 0; i < 9; i++)
            //    bullets[i] = new Bullet();
        }
        public void Update()
        {
            player.Update();
            foreach (Bullet bullet in bullets)
            {
                
                bullet.Update();
                
            }
        }

        public void Draw()
        {
            Program.window.Draw(world);
            Program.window.Draw(player);
            bool isShoot = Keyboard.IsKeyPressed(Keyboard.Key.Space);


            //for (int i = 0; i < bullets.Count; i++)
            //{
            //    bullets[i].Update();
            //    Program.window.Draw(bullets[i]);
            //}
            if (isShoot)
            {
                bullets.Add(new Bullet());
                
            }
            foreach (Bullet bullet in bullets)
            {
                Program.window.Draw(bullet);
            }
            //bullets[1].Update();
            //Program.window.Draw(bullets[1]);

            //if (isShoot)
            //{
            //    if (a)
            //    {
            //        bullet = new Bullet();
            //    }
            //    a = false;
            //    bullet.Update();
            //    Program.window.Draw(bullet);
            //}



        }

        
    }
}
