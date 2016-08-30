using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Of_Life
{
    public partial class BaseForm : Form
    {


        bool[,] universe = new bool[5, 5];



        float width = 0;
        float height = 0;

        Timer time = new Timer();

        int generation = 0;



        public BaseForm()
        {
            InitializeComponent();
            time.Enabled = true;
            time.Interval = 20;
            time.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            generation++;

            lbl_Generation.Text = "Generation: " + generation;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphicsPanel1.Refresh();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics
            width = graphicsPanel1.Width / (float)universe.GetLength(0);
            height = graphicsPanel1.Height / (float)universe.GetLength(1);

            Pen linePen = new Pen(Color.Black);
            Pen lineSectorPen = new Pen(Color.Black, 3);
            Brush liveCellBrsh = new SolidBrush(Color.Green);


            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    //Rectangle
                    RectangleF rect = RectangleF.Empty;
                    rect.X = (x * width);
                    rect.Y = (y * height);
                    rect.Width = width;
                    rect.Height = height;

                    //Cell
                    if (universe[x, y])
                    {
                        e.Graphics.FillRectangle(liveCellBrsh, rect);
                    }

                    e.Graphics.DrawRectangle(linePen, rect.X, rect.Y, rect.Width, rect.Height);
                }
            }
            linePen.Dispose();
            liveCellBrsh.Dispose();
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = (int)(e.X / width);
                int y = (int)(e.Y / height);

                universe[x, y] = !universe[x, y];
                graphicsPanel1.Invalidate();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                }
            }
            graphicsPanel1.Invalidate();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
