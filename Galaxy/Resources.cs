using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy
{
    class Resources
    {
        public const string SPRITES_DIR = @"..\Resources\Sprites\";
        public static Texture field;

        public static void Loadfield()
        {
            field = new Texture(SPRITES_DIR + "spaceship.png");
        }
    }
}
