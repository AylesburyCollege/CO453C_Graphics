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

        private void PaintForm(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
           
            DrawString(g);
            DrawRectangles(g);
            DrawPolygons(g);
        }

        private void DrawPolygons(Graphics g)
        {
            BackColor = Color.Yellow;
            Pen myPen = new Pen(Color.Orange, 4);
            Font myFont = new Font("Arial", 16);

            Point[] points = new Point[]
            {
                new Point(300, 400),
                new Point(400, 300),
                new Point(500, 300),
                new Point(600, 400),
                new Point(500, 500),
                new Point(400, 500),
                new Point(300, 400),
            };

            g.DrawPolygon(myPen, points);
            g.FillPolygon(Brushes.Red, points);

            g.DrawString("Derek's Hexagon", myFont, Brushes.Black, 370, 520);
        }

        private void DrawString(Graphics g)
        {
            int x = 50;
            int y = 20;

            Font myFont = new Font("Algerian", 20);

            //BackColor = Color.Coral;

            for (int count = 0; count < 6; count++)
            {
                //g.Clear(Color.Coral);
                g.DrawString("Derek is texting a Windows Form", myFont, Brushes.Blue, x, y);
                y = y + 30;
                System.Threading.Thread.Sleep(100);
            }
        }

        private void DrawRectangles(Graphics g)
        {
            int x = 90;   int y = 100;
            int w = 300;  int h = 200;

            Pen myPen = new Pen(Color.Blue, 4);

            g.DrawRectangle(myPen, x, y, w, h);
            g.FillRectangle(Brushes.Red, x, y, w, h);
            g.FillEllipse(Brushes.Yellow, x, y, w, h);

            int d = 8;
            for(int count = 0; count < 6; count++)
            {
                x = x + d; y = y + d;
                w = w - 2 * d; h = h - 2 * d;

                g.DrawRectangle(myPen, x, y, w, h);
            }
        }

        private void T61_StringForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void T61_StringForm_KeyPress(object sender, KeyPressEventArgs e)
        {


        }
    }
}
