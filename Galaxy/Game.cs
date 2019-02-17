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
        Text text1 = new Text();
        Text text2 = new Text();
        public int points;
        public int kills;
        public int hit;
        public int lvl;
        public int count_enemy;
        bool bul = false;
        bool bul2 = false;
        bool bul3 = true;


        public Game()
        {
            points = 0;
            kills = 0;
            hit = 0;
            lvl = 1;
            world = new World();
            player = new Player();
            bullets = new List<Bullet>();
            enemies = new List<Enemy>();
            text.Font = Resources.font;
            text.DisplayedString = "Уничтожено: " + points.ToString();
            text.CharacterSize = 14;
            text.Color = Color.White;
            text.Position = new Vector2f(0, 10);


            text1.Font = Resources.font;
            text1.DisplayedString = "Выстрелов: " + hit.ToString();
            text1.CharacterSize = 14;
            text1.Color = Color.White;
            text1.Position = new Vector2f(0, 30);

            text2.Font = Resources.font;
            text2.DisplayedString = "Уровень: " + lvl.ToString();
            text2.CharacterSize = 14;
            text2.Color = Color.White;
            text2.Position = new Vector2f(0, 50);

            SetLevel();

        }

        private void SetLevel()
        {
            switch (lvl)
            {
                case 1:
                    for (int i = 0; i < 15; i++)
                        enemies.Add(new Enemy(TypeEnemy.HITHER));
                    count_enemy = enemies.Count;
                    foreach (Enemy enemy in enemies)
                        enemy.Position = new Vector2f(rn.Next(150, 700), rn.Next(0, Convert.ToInt32(Form1.window.Size.Y) - 300));
                    break;
                case 2:
                    for (int i = 0; i < 2; i++)
                        enemies.Add(new Enemy(TypeEnemy.DISTANT));
                    foreach (Enemy enemy in enemies)
                        enemy.Position = new Vector2f(rn.Next(150, 700), rn.Next(0, Convert.ToInt32(Form1.window.Size.Y) - 300));
                    break;
                case 3:
                    for (int i = 0; i < 3; i++)
                        enemies.Add(new Enemy(TypeEnemy.DISTANT));
                    foreach (Enemy enemy in enemies)
                        enemy.Position = new Vector2f(rn.Next(150, 700), rn.Next(0, Convert.ToInt32(Form1.window.Size.Y) - 300));
                    break;
            }
           
        }

        public void CheckLevel()
        {
            switch (points)
            {
                case 15:
                    if (bul3)
                    {
                        lvl++;
                        SetLevel();
                    }
                    bul3 = false;
                    break;
                case 17:
                    if (bul3 == false)
                    {
                        lvl++;
                        SetLevel();
                    }
                    bul3 = true;
                    break;
            }
        }

        public void Update()
        {
            //text.DisplayedString = "Уничтожено: " + enemies[0].Position.Y.ToString();
            text.DisplayedString = "Уничтожено: " + points.ToString();
            text1.DisplayedString = "Выстрелов: " + hit.ToString();
            player.Update();

            CheckLevel();
            text2.DisplayedString = "Уровень: " + lvl.ToString();




            foreach (Enemy enemy in enemies.ToArray())
            {
                enemy.Update(enemy.GetTypeEnemy());
                foreach (Bullet bullet in bullets.ToArray())
                {
                    switch (lvl)
                    {
                        case 1:
                            if (enemy.Position.X - 10 < bullet.Position.X * 1000 + 350 && enemy.Position.X + 10 > bullet.Position.X * 1000 + 350 && (enemy.Position.Y * 1.5 < -bullet.Position.Y) && (enemy.Position.Y * 1.5 - 20 < -bullet.Position.Y))
                            {
                 
                                enemies.Remove(enemy);
                                bullets.Remove(bullet);
                                points++;
                                break;
                            }
                            break;
                        case 2:

                            if (enemy.Position.X - 10 < bullet.Position.X * 1000 + 350 && enemy.Position.X + 10 > bullet.Position.X * 1000 + 350 && (enemy.Position.Y * 1.5 < -bullet.Position.Y) && (enemy.Position.Y * 1.5 - 70 < -bullet.Position.Y))
                            {
                                
                                enemies.Remove(enemy);
                                bullets.Remove(bullet);
                                points++;
                                break;
                            }
                            break;
                        case 3:

                            if (enemy.Position.X - 10 < bullet.Position.X * 1000 + 350 && enemy.Position.X + 10 > bullet.Position.X * 1000 + 350 && (enemy.Position.Y * 1.5 < -bullet.Position.Y) && (enemy.Position.Y * 1.5 - 70 < -bullet.Position.Y))
                            {

                                enemies.Remove(enemy);
                                bullets.Remove(bullet);
                                points++;
                                break;
                            }
                            break;
                    }

                }
            }
                
            foreach (Bullet bullet in bullets.ToArray())
            {
                if (bullet.Position.Y < -600)
                    bullets.Remove(bullet);
                bullet.Update();
            }
        }
       

       

        public void Draw()
        {
            Form1.window.Draw(world);
            Form1.window.Draw(player);
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
                        hit++;

                    }

                }
            }

            foreach (Bullet bullet in bullets)
                Form1.window.Draw(bullet);

            foreach (Enemy enemy in enemies)
                Form1.window.Draw(enemy);



            Form1.window.Draw(text);
            Form1.window.Draw(text1);
            Form1.window.Draw(text2);
            if(Form1.PlayGame == false)
                Form1.window.Draw(Enemy.text3);

        }
    }
}