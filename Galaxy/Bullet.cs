using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.Window;
using Galaxy;
using SFML.System;

namespace Galaxy
{
    class Bullet : Transformable, Drawable
    {
        RectangleShape bulletShape;
        public Bullet()
        {
            bulletShape = new RectangleShape(new Vector2f(10, 30));
            bulletShape.Texture = Resources.bl_texture;
        }
        public void Update()
        {

        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            states.Transform *= Transform;
            target.Draw(bulletShape, states);
        }
    }
}
