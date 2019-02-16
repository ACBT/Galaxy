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
    class Player : Transformable, Drawable
    {
        public const float PLAYER_FLIGHT_SPEED = 5f;
        public const float PLAYER_FLIGHT_ACCELERATION = 0.2f;
        public Vector2f startPosition;
        private float x;
        private float y;
        public static float pX;
        public static float pY;
        private int r;
        private Color color1;
        private Color color2;
        public static RectangleShape rectangleShape;
        Sprite sp;
        Vector2f velocity;
        public static Vector2f movement;
        public static Vector2f pos;

        public Player()
        {
           
            x = Program.window.Size.X / 2 - 70;
            y = Program.window.Size.Y / 2 + 100;
            r = 5;
            //Resources.Loadfield();
            rectangleShape = new RectangleShape(new Vector2f(100, 100));
            rectangleShape.Texture = Resources.pl_texture;
            rectangleShape.Origin = new Vector2f(0, 0);
            rectangleShape.Position = new Vector2f(x, y);
            pos = Position;
            sp = new Sprite();
            sp.Texture = Resources.pl_texture;
            pX = Position.X;
            pY = movement.Y;
            //rectangleShape.TextureRect = new IntRect(0, 0, 100, 100);
            //color1 = Color.Blue;
        }

        public void Spawn()
        {
            Position = startPosition;
        }
        //Обновление информации о игроке
        public void Update()
        {
            //UpdatePhysics();
            UpdateMovement();
            //Position += movement + velocity;
            Position = movement;
            pos = Position;
            //pX = Position.X;
            //pY = movement.Y;
        }

        private void UpdateMovement()
        {
            bool isMoveLeft = Keyboard.IsKeyPressed(Keyboard.Key.A);
            bool isMoveRight = Keyboard.IsKeyPressed(Keyboard.Key.D);
            bool isMoveUp = Keyboard.IsKeyPressed(Keyboard.Key.W);
            bool isMoveDown= Keyboard.IsKeyPressed(Keyboard.Key.S);
            bool isShoot = Keyboard.IsKeyPressed(Keyboard.Key.Space);
            bool isMove = isMoveLeft || isMoveRight || isMoveUp || isMoveDown;

            if (isMove)
            {
                if (isMoveLeft)
                {
                    movement.X -= PLAYER_FLIGHT_SPEED;
                    if (movement.X < -(Program.window.Size.X / 2) + 50)
                        movement = new Vector2f(-Program.window.Size.X/2 + 50, movement.Y);
                }
                if (isMoveRight)
                {
                    movement.X += PLAYER_FLIGHT_SPEED;
                    if (movement.X > (Program.window.Size.X / 2) - 10)
                        movement = new Vector2f(Program.window.Size.X/2 - 10, movement.Y);
                }
                if (isMoveUp)
                {
                    movement.Y -= PLAYER_FLIGHT_SPEED;
                    if (movement.Y < -(Program.window.Size.Y / 1.5f))
                        movement = new Vector2f(movement.X, -(Program.window.Size.Y / 1.5f));
                }
                if (isMoveDown)
                {
                    movement.Y += PLAYER_FLIGHT_SPEED;
                    if (movement.Y > rectangleShape.Size.Y)
                        movement = new Vector2f(movement.X, rectangleShape.Size.Y);
                }
                //pX = Position.X;
                //pY = movement.Y;
            }
           
        }

        private void UpdatePhysics()
        {
            bool isScreen = false;
            velocity += new Vector2f(0,0.15f);
            int pX = (int)(Position.X - rectangleShape.Origin.X + rectangleShape.Size.X / 2);
            int pY = (int)(Position.Y + rectangleShape.Size.Y);
        }

        public void Draw(RenderTarget target, RenderStates states)
        { 
            states.Transform *= Transform;
            target.Draw(rectangleShape,states);
            //pX = Position.X;
            //pY = movement.Y;
        }
    }
}
