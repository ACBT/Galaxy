using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using Galaxy;

namespace Galaxy
{
    class Player : Transformable, Drawable
    {
        private double x;
        private double y;
        private int r;
        private Color color1;
        private Color color2;
        RectangleShape rectangleShape;

        public Player()
        {
            rectangleShape = new RectangleShape(new SFML.System.Vector2f(50, 50));
            rectangleShape.Texture = Resources.field;
            rectangleShape.TextureRect = new IntRect(0, 0, 50, 50);
            x = Program.window.Size.X / 2;
            y = Program.window.Size.Y / 2;
            r = 5;
            color1 = Color.Blue;
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
            target.Draw(rectangleShape);
        }
    }
}
