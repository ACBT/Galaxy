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
        public static Texture pl_texture;
        public static Texture en_texture;
        

        public static void Loadfield()
        {
            pl_texture = new Texture(SPRITES_DIR + "spaceship.png");
            en_texture = new Texture(SPRITES_DIR + "vrag1.png");
        }
    }
}
