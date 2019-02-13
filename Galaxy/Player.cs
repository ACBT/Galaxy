using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using Galaxy;
using SFML.System;

namespace Galaxy
{
    class Player : Transformable, Drawable
    {
        private float x;
        private float y;
        private int r;
        private Color color1;
        private Color color2;
        RectangleShape rectangleShape;
        Sprite sp;

        public Player()
        {
           
            x = Program.window.Size.X / 2 - 70;
            y = Program.window.Size.Y / 2 + 100;
            r = 5;
            //Resources.Loadfield();
            rectangleShape = new RectangleShape(new Vector2f(100, 100));
            rectangleShape.Texture = Resources.pl_texture;
            rectangleShape.Position = new SFML.System.Vector2f(x, y);
            sp = new Sprite();
            sp.Texture = Resources.pl_texture;
            //rectangleShape.TextureRect = new IntRect(0, 0, 100, 100);
            //color1 = Color.Blue;
        }

        //Обновление информации о игроке
        public void update()
        {

        }

        //public void draw(Texture t)
        //{

        //}


        public void Draw(RenderTarget target, RenderStates states)
        { 
            states.Transform *= Transform;
            target.Draw(rectangleShape,states);
        }
    }
}
