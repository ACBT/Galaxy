using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Galaxy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("XMLFile1.xml");
            foreach (XmlNode node in doc.DocumentElement)
            {
                string date = node.Attributes[0].Value;
                int flags = int.Parse(node["flags"].InnerText);
                int bomb = int.Parse(node["bomb"].InnerText);
                dataGridView1.Rows.Add(date, flags.ToString(), bomb.ToString());
            }
        }
    }
}
