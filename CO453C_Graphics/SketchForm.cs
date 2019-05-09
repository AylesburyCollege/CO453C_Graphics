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
    public partial class SketchForm : Form
    {
        Bitmap backImage;

        Color penColor = Color.Black;
        Color brushColor = Color.Blue;

        int x = 100;
        int y = 100;
        int move = 10;

        Brush myBrush;

        Pen myPen;

        public SketchForm()
        {
            InitializeComponent();

            myPen = new Pen(Brushes.Black);
            myBrush = new SolidBrush(brushColor);
        }

        private void SketchForm_Load(object sender, EventArgs e)
        {
            backImage = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(backImage);

            g.Clear(Color.Yellow);
            g.FillEllipse(myBrush, x, y, 20, 20);
            this.BackgroundImage = backImage;
        }

        private void SketchForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char key = (char)e.KeyChar;
            //keyLabel.Text = "Key = " + key;
        }

        private void SketchForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Right)
            {
                x += move;
            }
            else if (e.KeyData == Keys.Left)
            {
                x -= move;
            }
            else if (e.KeyData == Keys.Up)
            {
                y -= move;
            }
            else if (e.KeyData == Keys.Down)
            {
                y += move;
            }
            else if(e.KeyData == Keys.C)
            {
                Graphics g = Graphics.FromImage(backImage);
                g.Clear(Color.Yellow);
            }
            else if (e.KeyData == Keys.Escape)
            {
                EndSketching();
            }

            Refresh();
        }

        private void EndSketching()
        {
            if(MessageBox.Show("Do you want to finish?", "Message",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                Close();
        }

        private void SketchForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Graphics.FromImage(backImage);
            g.FillEllipse(myBrush, x, y, 20, 20);
        }
    }
}
