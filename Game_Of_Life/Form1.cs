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

        int xwidth = 30;
        int xheight = 30;

        bool[,] universe = new bool[30, 30];
        bool[,] scratchpad = new bool[30, 30];



        float width = 0;
        float height = 0;

        Timer time = new Timer();

        int generation = 0;



        public BaseForm()
        {
            InitializeComponent();
            //TTime
            time.Enabled = false;
            time.Interval = 20;
            time.Tick += Timer_Tick;
        }
        
        /// <summary>
        /// Operations to complete every tick;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            mutate();
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

            Pen linePen = new Pen(Color.DarkRed);
            Pen lineSectorPen = new Pen(Color.DarkGray, 3);
            Brush liveCellBrsh = new SolidBrush(Color.Red);

            int countCells = 0;

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
                        countCells++;
                    }

                    e.Graphics.DrawRectangle(linePen, rect.X, rect.Y, rect.Width, rect.Height);
                }
            }
            tsl_Cells.Text = "Cells: " + countCells;
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
            New();
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void New()
        {
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                }
            }
            generation = 0;
            graphicsPanel1.Invalidate();
        }

        private void mutate()
        {
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    int count = 0;
                    for (int sy = y-1; sy < y+2; sy++)
                    {
                        for (int sx = x-1; sx < x+2; sx++)
                        {
                            
                            if( sx > -1 && sy > -1 && sx < universe.GetLength(0) && sy < universe.GetLength(1))
                            {
                                if (universe[sx, sy] && !(sx == x && sy == y))
                                {
                                    count++;
                                }
                                
                            }

                        }
                    }
                    switch (count)
                    { 
                        case 2:
                            if (universe[x, y])
                            {
                                scratchpad[x, y] = true;
                            }
                            else
                            {
                                scratchpad[x, y] = false;
                            }
                                break;
                        case 3:

                                scratchpad[x, y] = true;

                            break;
                        default:
                            scratchpad[x, y] = false;
                            break;
                    }
                    
                }
            }
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = scratchpad[x, y];
                }
            }


                    graphicsPanel1.Invalidate();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            New();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            time.Enabled = true;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            time.Enabled = false;
        }

    }
}
