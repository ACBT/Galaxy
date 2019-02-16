using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy
{
    enum TypeEnemy { HITHER, DISTANT };
    class Enemy : Transformable, Drawable, IDisposable
    {
        private float x;
        private float y;
        private int r;
        private Color color1;
        private Color color2;
        public static RectangleShape rectangleShape;
        Random rn = new Random();
       
        TypeEnemy type = TypeEnemy.HITHER;
        //private object random;

        public void Update()
        {
            //if (Bullet.bulletPos.Y == this.rectangleShape.Position.Y)
            //{
            //    rectangleShape.Texture = null;
            //}
        }

        public Enemy(TypeEnemy type)
        {
            this.type = type;
            x = rn.Next(0,Convert.ToInt32(Program.window.Size.X));
            y = rn.Next(0, 100);
            r = 5;
            //Resources.Loadfield();
            
            //color1 = Color.Red;

            switch (type)
            {
                case TypeEnemy.HITHER:
                    rectangleShape = new RectangleShape(new SFML.System.Vector2f(50, 50));
                    //rectangleShape.Position = new Vector2f(rn.Next(0, Convert.ToInt32(Program.window.Size.X) - 50), rn.Next(0, Convert.ToInt32(Program.window.Size.Y) - 400));
                    rectangleShape.Texture = Resources.en_texture;
                    break;
            }
        }

        

        public void Draw(RenderTarget target, RenderStates states)
        {
            states.Transform *= Transform;
            target.Draw(rectangleShape, states);
        }
    }
}
