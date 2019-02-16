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
        public const float BULLET_SPEED = 5.5f;
        RectangleShape bulletShape;
        Vector2f bulletPos;
        public float pX;
        Thread bulletThread;
        

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

        private void UpdateShoot()
        {
           
        }

        private void UpdatePhysic()
        {
            bulletPos.Y -= BULLET_SPEED;
            bulletPos.X = Player.movement.X/1000;
            //bulletPos.X += Position.X;
            //pX = Position.X;
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            states.Transform *= Transform;
            target.Draw(bulletShape, states);
        }
    }
}
