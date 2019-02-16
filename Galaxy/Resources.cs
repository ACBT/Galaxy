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
        public const string FONTS_DIR = @"..\Resources\Fonts\";
        public static Texture pl_texture;
        public static Texture en_texture;
        public static Texture bl_texture;
        public static Font font;

        public static void Loadfield()
        {
            pl_texture = new Texture(SPRITES_DIR + "spaceship.png");
            en_texture = new Texture(SPRITES_DIR + "vrag1.png");
            bl_texture = new Texture(SPRITES_DIR + "bullet3.png");
            font = new Font(FONTS_DIR+ "Roboto.ttf");
        }
    }
}
