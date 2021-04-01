using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperPaint.Figures;
using SuperPaint.Utils;
using System.Reflection;
using SuperPaint.Actions;

namespace SuperPaint
{
    public partial class MainForm : Form
    {
        private Figure currFigure;
        public MainForm()
        {
            InitializeComponent();
            FiguresProperties.Canvas = this.CreateGraphics();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serializeDialog.ShowDialog() == DialogResult.Cancel) return;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deserializeDialog.ShowDialog() == DialogResult.Cancel) return;
        }

        private void ptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var button = sender as ToolStripMenuItem;
            if (button != null)
                MessageBox.Show(button.Text);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (penColorDialog.ShowDialog() == DialogResult.Cancel) return;
            FiguresProperties.CurrPen.Color = penColorDialog.Color;
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (penColorDialog.ShowDialog() == DialogResult.Cancel) return;
            FiguresProperties.CurrBrush = new SolidBrush(penColorDialog.Color);
        }

        private void Figure_Click(object sender, EventArgs e)
        {
            var button = sender as ToolStripButton;
            if (button != null)
            {
                string name = button.Name;
                if (!Storage.Constructors.ContainsKey(name))
                {
                    Type figureType = Type.GetType("SuperPaint.Figures." + button.Name, true);
                    Storage.Constructors.Add(name, figureType.GetConstructor(new Type[0]));
                }
                currFigure = Storage.Constructors[name].Invoke(new Object[0]) as Figure;
            }                
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currFigure.Points.Add(e.Location);
            }
            else if (e.Button == MouseButtons.Right)
            {                
                if (currFigure.Points.Count >= 2)
                {
                    Storage.AllFigures.Add(currFigure);
                    Storage.AddAction(new FigureCreate { Figure = currFigure });
                }
                currFigure = null;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
