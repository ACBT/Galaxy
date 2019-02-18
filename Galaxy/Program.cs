using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SFML.Graphics;
using SFML.Window;

namespace Galaxy
{
    class Program
    {
        //public static RenderWindow window;
        //public static Game Game { get; private set; }
        
        
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //window = new RenderWindow(new VideoMode(800, 600), "Galaxy");
            //window.SetVerticalSyncEnabled(true);
            //window.Closed += Window_Closed;
            //window.Resized += Window_Resized;
            //Resources.Loadfield();
            //Game = new Game();


            //while (window.IsOpen)
            //{
            //    window.DispatchEvents();
            //    Game.Update();
            //    window.Clear(Color.Black);
            //    Game.Draw();
            //    window.Display();
            //}


        }

        //private static void Window_Resized(object sender, SizeEventArgs e)
        //{
        //    window.SetView(new SFML.Graphics.View(new FloatRect(0, 0, e.Width, e.Height)));


        //}

        //private static void Window_Closed(object sender, EventArgs e)
        //{
        //    window.Close();
        //}
    }
}
