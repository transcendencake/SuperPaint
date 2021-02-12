using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperPaint
{
    public partial class MainForm : Form
    {
        private Graphics graphics;
        public MainForm()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
        }

        private void DrawingTest()
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            graphics.DrawLine(pen, 10, 0, 100, 100);
            graphics.DrawEllipse(pen, new Rectangle(10, 100, 150, 100));
            graphics.DrawRectangle(pen, new Rectangle(10, 220, 150, 100));
            graphics.DrawLines(pen, new Point[] { new Point(10, 350), new Point(100, 450), new Point(10, 550) });
            graphics.DrawPolygon(pen, new PointF[] { new PointF(200,50), new PointF(200, 150), new PointF(300, 150),
                new PointF(250, 100), new PointF(300, 100) , new PointF(200, 50)});

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            DrawingTest();
        }

        //private void MainForm_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
}
