using System;
using System.IO;
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
        private bool drawing;
        private delegate Figure Instantiate();
        Instantiate instantiateFigure;
        public MainForm()
        {
            InitializeComponent();
            FiguresProperties.Canvas = this.CreateGraphics();
            drawing = false;
            instantiateFigure = null;
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            instantiateFigure = null;
            if (serializeDialog.ShowDialog() == DialogResult.Cancel) return;
            using (StreamWriter streamWriter = new StreamWriter(serializeDialog.FileName, false))
            {
                foreach (var figure in Storage.AllFigures)
                {
                    streamWriter.WriteLine(figure.Serialize());
                }
            }            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            instantiateFigure = null;
            if (deserializeDialog.ShowDialog() == DialogResult.Cancel) return;
            Storage.Clear();
            using (StreamReader streamReader = new StreamReader(deserializeDialog.FileName))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] temp = line.Split(',');
                    Type figureType = Type.GetType(temp[0], true);
                    Figure figure = figureType.GetConstructor(new Type[0]).Invoke(new Object[0]) as Figure;
                    figure.Deserialize(temp);
                    Storage.AllFigures.Add(figure);
                }
            }
            DrawingUtils.Redraw();
        }
        private void addNewFigureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addDllDialog.ShowDialog() == DialogResult.Cancel) return;
            Assembly asm = Assembly.LoadFrom(addDllDialog.FileName);
            var interfaceType = typeof(IFigureFactory); 
            Type[] types = asm.GetTypes().Where(t => t != interfaceType && interfaceType.IsAssignableFrom(t)).ToArray();
            foreach (var type in types)
            {
                IFigureFactory factory = (IFigureFactory)Activator.CreateInstance(type);
                ToolStripButton btn = new ToolStripButton
                {
                    AutoSize = false,
                    Size = new Size(39, 40),
                    Text = factory.Name,
                    DisplayStyle = ToolStripItemDisplayStyle.Image,
                    Image = Properties.Resources.pen,
                    ImageTransparentColor = Color.Magenta
                };
                btn.Click += (object send, EventArgs args) => instantiateFigure = delegate ()
                {
                    Figure fig = factory.Instantiate();
                    fig.Canvas = FiguresProperties.Canvas;
                    fig.DrawingPen = new Pen(new SolidBrush(FiguresProperties.CurrBrushColor));
                    return fig;
                };
                toolStrip1.Items.Add(btn);
            }
        }

        private void ptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var button = sender as ToolStripMenuItem;
            if (button != null)
                FiguresProperties.CurrPen.Width = button.Text[0] - '0';
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (penColorDialog.ShowDialog() == DialogResult.Cancel) return;
            FiguresProperties.CurrPen.Color = penColorDialog.Color;
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (penColorDialog.ShowDialog() == DialogResult.Cancel) return;
            FiguresProperties.CurrBrushColor = penColorDialog.Color;
        }
        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (!drawing)
            {
                if (instantiateFigure == null) return;
                currFigure = instantiateFigure();
                drawing = true;
            }
            if (e.Button == MouseButtons.Left)
            {
                currFigure.Points.Add(e.Location);    
            }
            else if (e.Button == MouseButtons.Right)
            {                
                if (currFigure.Points.Count < 2)
                {
                    currFigure.Points.Add(e.Location);
                }
                Storage.AllFigures.Add(currFigure);
                Storage.AddAction(new FigureCreate { Figure = currFigure });
                DrawingUtils.Redraw();
                currFigure = null;
                drawing = false;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                DrawingUtils.Redraw();
                currFigure.Draw(e.Location);
            }
        }

        private void undo_Click(object sender, EventArgs e)
        {
            instantiateFigure = null;
            Storage.Undo();
            DrawingUtils.Redraw();
        }

        private void redo_Click(object sender, EventArgs e)
        {
            instantiateFigure = null;
            Storage.Redo();
            DrawingUtils.Redraw();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            var obj = (NumericUpDown)sender;
            FiguresProperties.Angles = (int)obj.Value;
        }

        private void Line_Click(object sender, EventArgs e)
        {
            IFigureFactory factory = new LineFactory();
            instantiateFigure = () => factory.Instantiate();
        }

        private void PolyLine_Click(object sender, EventArgs e)
        {
            IFigureFactory factory = new PolyLineFactory();
            instantiateFigure = () => factory.Instantiate();
        }

        private void Rectan_Click(object sender, EventArgs e)
        {
            IFigureFactory factory = new RectanFactory();
            instantiateFigure = () => factory.Instantiate();
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            IFigureFactory factory = new EllipseFactory();
            instantiateFigure = () => factory.Instantiate();
        }

        private void manualPol_Click(object sender, EventArgs e)
        {
            IFigureFactory factory = new ManualPolygonFactory();
            instantiateFigure = () => factory.Instantiate();
        }

        private void ManualPolygon_Click(object sender, EventArgs e)
        {
            IFigureFactory factory = new PolygonFactory();
            instantiateFigure = () => factory.Instantiate();
        }

    }
}
