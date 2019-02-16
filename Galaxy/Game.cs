using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Galaxy
{
    class Game 
    {
        World world;
        Player player;
        List<Bullet> bullets;
        List<Enemy> enemies;
        Thread bulletThread;
        Random rn = new Random();
        Text text = new Text();
        public int points = 0000;
        bool bul = false;
        bool bul2 = false;
      

        public Game()
        {
            world = new World();
            player = new Player();
            bullets = new List<Bullet>();
            enemies = new List<Enemy>();
            
            for (int i = 0; i < 5; i++)
                enemies.Add(new Enemy(TypeEnemy.HITHER));
            foreach (Enemy enemy in enemies)
            {
                //enemy.Origin = new Vector2f(player.Position.X, 100);
                //enemy.Position = new Vector2f(player.Position.X + 175*2,100);
                enemy.Position = new Vector2f(rn.Next(350  ,700), rn.Next(0, Convert.ToInt32(Program.window.Size.Y) - 400));
                
            }
               
            //bulletThread = new Thread(UpdBullet);
            //bulletThread.Start();
        }
        public void Update()
        {
            
         
            text.Font = Resources.font;
            text.DisplayedString = points.ToString();
            text.CharacterSize = 24;
            text.Color = Color.White;
            text.Position = new Vector2f(160, 10);
            player.Update();
            //bulletThread = new Thread(UpdBullet);
            //bulletThread.Start();

            //if (enemies.Count > 0)
            //    for (int i = 0; i < enemies.Count; i++)
            //        for (int j = 0; j < bullets.Count; j++)
            //            if (enemies[i].Position.X - 10 < bullets[j].Position.X * 1000 + 350 && enemies[i].Position.X + 10 < bullets[j].Position.X * 1000 + 350)
            //                enemies.Remove(enemies[i]);

            foreach (Enemy enemy in enemies.ToArray())
                foreach (Bullet bullet in bullets.ToArray())
                    if (enemy.Position.X - 10 < bullet.Position.X * 1000 + 350 && enemy.Position.X + 10 < bullet.Position.X * 1000 + 350)
                        enemies.Remove(enemy);
            foreach (Bullet bullet in bullets)
                bullet.Update();

            foreach (Enemy enemy in enemies)
                enemy.Update();


                
                         
                            
           
                    //text.DisplayedString = (bullet.Position.X*1000 + 350).ToString();
            //if (enemy.Position.X  - 30 < bullet.Position.X)
            //{
            //    enemies.Remove(enemy);
            //    text.DisplayedString = (bullet.Position).ToString();
            //}

            //text.DisplayedString = (bullet.Position.X*1000).ToString();
            //if (((enemy.Position.X - bullet.Position.X) * (enemy.Position.X - bullet.Position.X) + (enemy.Position.Y - bullet.Position.Y) * (enemy.Position.Y - bullet.Position.Y)) < 10)
            //if ( bullet.Position.Y == 0)
            //{
            //    enemies.Remove(enemy);
            //    bullets.Remove(bullet);
            //    break;
            //}

            //enemies[1].Position = new Vector2f(100, 200);
            UpdBullet();
            //text.DisplayedString += "     " + enemies[0].Position.X.ToString();

        }
        public void kill()
        {
            //enemies.Remove();
        }

        public void UpdBullet()
        {
            //Thread.Sleep(100);
            foreach (Bullet bullet in bullets)
                bullet.Update();
        }

        public void Draw()
        {
            Program.window.Draw(world);
            Program.window.Draw(player);
            bool isShoot = Keyboard.IsKeyPressed(Keyboard.Key.Space);
           
            if (isShoot)
            {               
                bul = !bul;
                if (bul)
                {
                    bul2 = !bul2;
                    if (bul2)
                    {
                        bullets.Add(new Bullet());
                        

                    }
                        
                }                   
            }

            foreach (Bullet bullet in bullets)
                Program.window.Draw(bullet);

            foreach (Enemy enemy in enemies)
                Program.window.Draw(enemy);



            Program.window.Draw(text);


            //foreach (Bullet bullet in bullets)
            //    Program.window.Draw(bullet);
        }   
    }
}
