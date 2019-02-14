using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.Window;
using Galaxy;
using SFML.System;
using System.Threading;

namespace Galaxy
{
    class Bullet : Transformable, Drawable
    {
        public const float BULLET_SPEED = 7f;
        RectangleShape bulletShape;
        Vector2f bulletPos;
        Vector2f startPos;
        Player pl = new Player();
        

        public Bullet()
        {
            bulletShape = new RectangleShape(new Vector2f(10, 10));
            bulletShape.Texture = Resources.bl_texture;
            bulletShape.Position = new Vector2f(Player.movement.X + 375, Player.movement.Y + 400);
           
        }
        public void Update()
        {
            
            UpdatePhysic();
            Position = bulletPos;
        }

        private void UpdatePhysic()
        {
            bulletPos.Y -= BULLET_SPEED;
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            states.Transform *= Transform;
            target.Draw(bulletShape, states);
        }
    }
}
