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
        Color penColor = Color.Black;
        Color brushColor = Color.Blue;

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
            Bitmap bm = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(bm);

            g.FillEllipse(myBrush, 100, 100, 20, 20);
            this.BackgroundImage = bm;
        }
    }
}
