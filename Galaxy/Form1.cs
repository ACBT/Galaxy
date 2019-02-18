using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galaxy
{
    public partial class Form1 : Form
    {
        public static RenderWindow window;
        private static Game Game;
        public static bool PlayGame = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gamestart();
        }
        static void gamestart()
        {

            window = new RenderWindow(new VideoMode(800, 600), "Galaxy");
            window.SetVerticalSyncEnabled(true);
            window.Closed += Window_Closed;
            window.Resized += Window_Resized;
            Resources.Loadfield();
            Game = new Game();


            while (window.IsOpen  && PlayGame)
            {
                window.DispatchEvents();
                Game.Update();
                window.Clear(SFML.Graphics.Color.Black);
                Game.Draw();
                window.Display();
            }


        }

        private static void Window_Resized(object sender, SizeEventArgs e)
        {
            window.SetView(new SFML.Graphics.View(new FloatRect(0, 0, e.Width, e.Height)));


        }

        private static void Window_Closed(object sender, EventArgs e)
        {
            window.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
