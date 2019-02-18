using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy
{
    enum TypeEnemy { HITHER, DISTANT, BOSS };
    class Enemy : Transformable, Drawable, IDisposable
    {
        public const float ENEMY_SPEED = 2f;
        private float x;
        private float y;
        private int r;
        private Color color1;
        private Color color2;
        public static Text text3 = new Text();
        public static RectangleShape rectangleShape;
        Vector2f enemyPos;
        Random rn = new Random();
        int hp;

        TypeEnemy type = TypeEnemy.HITHER;
        //private object random;

        public void Update( TypeEnemy type)
        {
            switch (type)
            {
                case TypeEnemy.HITHER:
                    break;
                case TypeEnemy.DISTANT:
                    if (Position.Y >= 550)
                    {
                        text3.Font = Resources.font;
                        text3.DisplayedString = "Поражение";
                        text3.CharacterSize = 34;
                        text3.Color = Color.White;
                        text3.Position = new Vector2f(Form1.window.Size.X / 2 - 50, Form1.window.Size.Y / 2);
                        Form1.PlayGame = false;
                        Game.xmldocwrie();


                    }

                    UpdPhysic();
                    Position = new Vector2f(Position.X, enemyPos.Y);
                    break;
            }
            
        }

        public TypeEnemy GetTypeEnemy()
        {
            return this.type;
        }

        private void UpdPhysic()
        {
            enemyPos.Y += ENEMY_SPEED;
          
        }

        public Enemy(TypeEnemy type)
        {
            this.type = type;
            x = rn.Next(0,Convert.ToInt32(Form1.window.Size.X));
            y = rn.Next(0, 100);
            r = 5;
            //Resources.Loadfield();
            
            //color1 = Color.Red;

            switch (type)
            {
                case TypeEnemy.HITHER:
                    rectangleShape = new RectangleShape(new SFML.System.Vector2f(50, 50));
                    rectangleShape.Texture = Resources.en_texture;
                    hp = 2;
                    break;
                case TypeEnemy.DISTANT:
                    rectangleShape = new RectangleShape(new SFML.System.Vector2f(50, 50));
                    rectangleShape.Texture = Resources.en1_texture;
                    hp = 2;
                    break;
            }
        }

        public bool Remove()
        {
            if (hp <= 0)
                return true;
            return false;
        }

        public void Hit()
        {
            hp--;
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            states.Transform *= Transform;
            target.Draw(rectangleShape, states);
            
        }
    }
}
