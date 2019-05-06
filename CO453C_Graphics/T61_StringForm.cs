using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453C_Graphics
{
    public partial class T61_StringForm : Form
    {
        public T61_StringForm()
        {
            InitializeComponent();
        }

        private void DrawString(object sender, PaintEventArgs e)
        {
            int x = 50;
            int y = 20;
            Graphics g = e.Graphics;

            Font myFont = new Font("Arial", 20);
            g.DrawString("Derek is texting a Windows Form", myFont, Brushes.Blue, x, y);
        }
    }
}
