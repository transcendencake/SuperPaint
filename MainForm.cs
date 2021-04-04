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
        //private string currFigureName;
        private bool drawing;
        private delegate Figure Instantiate();
        Instantiate instantiateFigure;
        public MainForm()
        {
            InitializeComponent();
            FiguresProperties.Canvas = this.CreateGraphics();
            drawing = false;
            instantiateFigure = () => new Line();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            Type[] types = asm.GetTypes();//.Where(t => t.Name != "Figure").ToArray();
            foreach (var type in types)
            {
                ToolStripButton btn = new ToolStripButton
                {
                    AutoSize = false,
                    Size = new Size(39, 40),
                    Text = type.Name,
                    DisplayStyle = ToolStripItemDisplayStyle.Image,
                    Image = Properties.Resources.pen,
                    ImageTransparentColor = Color.Magenta
            };
                btn.Click += (object send, EventArgs args) => instantiateFigure = delegate ()
                {
                    Figure fig = (Figure)Activator.CreateInstance(type);
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

        //private void Figure_Click(object sender, EventArgs e)
        //{
        //    currFigure = null;
        //    drawing = false;
        //    var button = sender as ToolStripButton;
        //    if (button != null)
        //    {
        //        string name = button.Name;
        //        if (!Storage.Constructors.ContainsKey(name))
        //        {
        //            Type figureType = Type.GetType("SuperPaint.Figures." + button.Name, true);
        //            Storage.Constructors.Add(name, figureType.GetConstructor(new Type[0]));
        //        }
        //        currFigureName = name;
        //    }                
        //}

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (!drawing)
            {
                //if (currFigureName == null) return;
                currFigure = instantiateFigure();//Storage.Constructors[currFigureName].Invoke(new Object[0]) as Figure;
                drawing = true;
            }
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
                    DrawingUtils.Redraw();
                }
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
            Storage.Undo();
            DrawingUtils.Redraw();
        }

        private void redo_Click(object sender, EventArgs e)
        {
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
            instantiateFigure = () => new Line();
        }

        private void PolyLine_Click(object sender, EventArgs e)
        {
            instantiateFigure = () => new PolyLine();
        }

        private void Rectan_Click(object sender, EventArgs e)
        {
            instantiateFigure = () => new Rectan();
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            instantiateFigure = () => new Ellipse();
        }

        private void manualPol_Click(object sender, EventArgs e)
        {
            instantiateFigure = () => new ManualPolygon();
        }

        private void ManualPolygon_Click(object sender, EventArgs e)
        {
            instantiateFigure = () => new Polygon();
        }        
    }
}
