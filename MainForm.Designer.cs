
namespace SuperPaint
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewFigureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ptToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ptToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.penColorDialog = new System.Windows.Forms.ColorDialog();
            this.deserializeDialog = new System.Windows.Forms.OpenFileDialog();
            this.serializeDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.undo = new System.Windows.Forms.ToolStripButton();
            this.redo = new System.Windows.Forms.ToolStripButton();
            this.Line = new System.Windows.Forms.ToolStripButton();
            this.PolyLine = new System.Windows.Forms.ToolStripButton();
            this.Rectan = new System.Windows.Forms.ToolStripButton();
            this.Ellipse = new System.Windows.Forms.ToolStripButton();
            this.ManualPolygon = new System.Windows.Forms.ToolStripButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.manualPol = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.penToolStripMenuItem,
            this.brushToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.addNewFigureToolStripMenuItem});
            this.menuToolStripMenuItem.Image = global::SuperPaint.Properties.Resources.file;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::SuperPaint.Properties.Resources.save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::SuperPaint.Properties.Resources.open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // addNewFigureToolStripMenuItem
            // 
            this.addNewFigureToolStripMenuItem.Image = global::SuperPaint.Properties.Resources.addFigure;
            this.addNewFigureToolStripMenuItem.Name = "addNewFigureToolStripMenuItem";
            this.addNewFigureToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addNewFigureToolStripMenuItem.Text = "Add new figure";
            // 
            // penToolStripMenuItem
            // 
            this.penToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.widthToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.penToolStripMenuItem.Image = global::SuperPaint.Properties.Resources.pen;
            this.penToolStripMenuItem.Name = "penToolStripMenuItem";
            this.penToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.penToolStripMenuItem.Text = "Pen";
            // 
            // widthToolStripMenuItem
            // 
            this.widthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ptToolStripMenuItem,
            this.ptToolStripMenuItem1,
            this.ptToolStripMenuItem2,
            this.ptToolStripMenuItem3});
            this.widthToolStripMenuItem.Image = global::SuperPaint.Properties.Resources.wigth;
            this.widthToolStripMenuItem.Name = "widthToolStripMenuItem";
            this.widthToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.widthToolStripMenuItem.Text = "Width";
            // 
            // ptToolStripMenuItem
            // 
            this.ptToolStripMenuItem.Name = "ptToolStripMenuItem";
            this.ptToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.ptToolStripMenuItem.Text = "1 pt";
            this.ptToolStripMenuItem.Click += new System.EventHandler(this.ptToolStripMenuItem_Click);
            // 
            // ptToolStripMenuItem1
            // 
            this.ptToolStripMenuItem1.Name = "ptToolStripMenuItem1";
            this.ptToolStripMenuItem1.Size = new System.Drawing.Size(94, 22);
            this.ptToolStripMenuItem1.Text = "2 pt";
            this.ptToolStripMenuItem1.Click += new System.EventHandler(this.ptToolStripMenuItem_Click);
            // 
            // ptToolStripMenuItem2
            // 
            this.ptToolStripMenuItem2.Name = "ptToolStripMenuItem2";
            this.ptToolStripMenuItem2.Size = new System.Drawing.Size(94, 22);
            this.ptToolStripMenuItem2.Text = "3 pt";
            this.ptToolStripMenuItem2.Click += new System.EventHandler(this.ptToolStripMenuItem_Click);
            // 
            // ptToolStripMenuItem3
            // 
            this.ptToolStripMenuItem3.Name = "ptToolStripMenuItem3";
            this.ptToolStripMenuItem3.Size = new System.Drawing.Size(94, 22);
            this.ptToolStripMenuItem3.Text = "4 pt";
            this.ptToolStripMenuItem3.Click += new System.EventHandler(this.ptToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Image = global::SuperPaint.Properties.Resources.color;
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // brushToolStripMenuItem
            // 
            this.brushToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem1});
            this.brushToolStripMenuItem.Image = global::SuperPaint.Properties.Resources.brush;
            this.brushToolStripMenuItem.Name = "brushToolStripMenuItem";
            this.brushToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.brushToolStripMenuItem.Text = "Brush";
            // 
            // colorToolStripMenuItem1
            // 
            this.colorToolStripMenuItem1.Image = global::SuperPaint.Properties.Resources.color;
            this.colorToolStripMenuItem1.Name = "colorToolStripMenuItem1";
            this.colorToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem1.Text = "Color";
            this.colorToolStripMenuItem1.Click += new System.EventHandler(this.colorToolStripMenuItem1_Click);
            // 
            // penColorDialog
            // 
            this.penColorDialog.AnyColor = true;
            // 
            // deserializeDialog
            // 
            this.deserializeDialog.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undo,
            this.redo,
            this.Line,
            this.PolyLine,
            this.Rectan,
            this.Ellipse,
            this.manualPol,
            this.ManualPolygon});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 427);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // undo
            // 
            this.undo.AutoSize = false;
            this.undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.undo.Image = global::SuperPaint.Properties.Resources.undo;
            this.undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(39, 40);
            this.undo.Text = "undo";
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // redo
            // 
            this.redo.AutoSize = false;
            this.redo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redo.Image = global::SuperPaint.Properties.Resources.redo;
            this.redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(37, 40);
            this.redo.Text = "redo";
            this.redo.Click += new System.EventHandler(this.redo_Click);
            // 
            // Line
            // 
            this.Line.AutoSize = false;
            this.Line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Line.Image = global::SuperPaint.Properties.Resources.line;
            this.Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(39, 40);
            this.Line.Text = "line";
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // PolyLine
            // 
            this.PolyLine.AutoSize = false;
            this.PolyLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PolyLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PolyLine.Image = global::SuperPaint.Properties.Resources.polygonLine;
            this.PolyLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PolyLine.Name = "PolyLine";
            this.PolyLine.Size = new System.Drawing.Size(39, 40);
            this.PolyLine.Text = "polygon line";
            this.PolyLine.Click += new System.EventHandler(this.PolyLine_Click);
            // 
            // Rectan
            // 
            this.Rectan.AutoSize = false;
            this.Rectan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rectan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Rectan.Image = global::SuperPaint.Properties.Resources.rectangle;
            this.Rectan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rectan.Name = "Rectan";
            this.Rectan.Size = new System.Drawing.Size(39, 40);
            this.Rectan.Text = "rectangle";
            this.Rectan.Click += new System.EventHandler(this.Rectan_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.AutoSize = false;
            this.Ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Ellipse.Image = global::SuperPaint.Properties.Resources.ellipse;
            this.Ellipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(39, 40);
            this.Ellipse.Text = "ellipse";
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // ManualPolygon
            // 
            this.ManualPolygon.AutoSize = false;
            this.ManualPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManualPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ManualPolygon.Image = global::SuperPaint.Properties.Resources.polygon;
            this.ManualPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ManualPolygon.Name = "ManualPolygon";
            this.ManualPolygon.Size = new System.Drawing.Size(39, 40);
            this.ManualPolygon.Text = "polygon";
            this.ManualPolygon.Click += new System.EventHandler(this.ManualPolygon_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(0, 375);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // manualPol
            // 
            this.manualPol.AutoSize = false;
            this.manualPol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.manualPol.Image = global::SuperPaint.Properties.Resources.polygonLine;
            this.manualPol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.manualPol.Name = "manualPol";
            this.manualPol.Size = new System.Drawing.Size(37, 40);
            this.manualPol.Text = "manual polygon";
            this.manualPol.Click += new System.EventHandler(this.manualPol_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 451);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ptToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ptToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ptToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog penColorDialog;
        private System.Windows.Forms.ToolStripMenuItem brushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewFigureToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog deserializeDialog;
        private System.Windows.Forms.SaveFileDialog serializeDialog;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton undo;
        private System.Windows.Forms.ToolStripButton redo;
        private System.Windows.Forms.ToolStripButton Line;
        private System.Windows.Forms.ToolStripButton PolyLine;
        private System.Windows.Forms.ToolStripButton Rectan;
        private System.Windows.Forms.ToolStripButton Ellipse;
        private System.Windows.Forms.ToolStripButton ManualPolygon;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ToolStripButton manualPol;
    }
}

