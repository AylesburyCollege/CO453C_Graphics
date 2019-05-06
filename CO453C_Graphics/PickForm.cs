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
    public partial class PickForm : Form
    {
        private static Random generator = new Random();

        private Pen myPen;
        private int x, y;
        private char choice;

        public PickForm()
        {
            InitializeComponent();
        }

        private void PickForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            choice = (char)e.KeyChar;
            Refresh();
        }

        private void PickForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            myPen = new Pen(CreateColor(), 4);

            x = generator.Next(this.Width - 100);
            y = generator.Next(this.Height - 100);

            switch (choice)
            {
                case 'r': case 'R': DrawRectangle(g); break;

                default:
                    break;
            }
        }

        public static Color CreateColor()
        {
            int red = generator.Next(256);
            int green = generator.Next(256);
            int blue = generator.Next(256);

            int rgb = ((red * 256 * 256) + (green * 256) + blue);

            return Color.FromArgb(rgb);
        }

        private void DrawRectangle(Graphics g)
        {
            g.DrawRectangle(myPen, x, y, 100, 100);
        }
    }
}
