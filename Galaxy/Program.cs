using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;

namespace Galaxy
{
    class Program
    {
        static RenderWindow window;
        static void Main(string[] args)
        {
            window = new RenderWindow(new SFML.Window.VideoMode(800,600),"Galaxy");
            window.SetVerticalSyncEnabled(true);
            window.Closed += Window_Closed;

            while (window.IsOpen)
            {
                window.DispatchEvents();

                window.Clear(Color.Black);
                window.Display();
            }


        }

        private static void Window_Closed(object sender, EventArgs e)
        {
            window.Close();
        }
    }
}
