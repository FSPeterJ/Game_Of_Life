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
        
        Grid MainGrid = new Grid(30,30);

        bool GridEnabled = true;

        bool mouseActive = false;
        int mousegridX = -1;
        int mousegridY = -1;



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
            NextGeneration();
        }

        public void NextGeneration()
        {
            MainGrid.CalculateNext();
            graphicsPanel1.Invalidate();
            generation++;
            lbl_Generation.Text = "Generation: " + generation;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics
            width = graphicsPanel1.Width / (float)MainGrid.Width;
            height = graphicsPanel1.Height / (float)MainGrid.Height;

            Pen linePen = new Pen(Color.DarkRed);
            Pen lineSectorPen = new Pen(Color.OrangeRed, 3);
            Brush liveCellBrsh = new SolidBrush(Color.Red);
            StringFormat drawFormat = new StringFormat();
            int countCells = 0;

            for (int y = 0; y < MainGrid.Height; y++)
            {
                for (int x = 0; x < MainGrid.Width; x++)
                {

                    

                    //Rectangle
                    RectangleF rect = RectangleF.Empty;
                    rect.X = (x * width);
                    rect.Y = (y * height);
                    rect.Width = width;
                    rect.Height = height;


                    

                    //Cell
                    if (MainGrid[x, y].IsOn)
                    {
                        e.Graphics.FillRectangle(liveCellBrsh, rect);
                        countCells++;
                    }
                    if (GridEnabled)
                    {
                        e.Graphics.DrawRectangle(linePen, rect.X, rect.Y, rect.Width, rect.Height);
                        if (y == 0 && x % 10 == 0)
                        {
                            e.Graphics.DrawLine(lineSectorPen, rect.X, 0, rect.X, graphicsPanel1.Height);
                        }
                        if (x == 0 && y % 10 == 0)
                        {
                            e.Graphics.DrawLine(lineSectorPen, 0, rect.Y, graphicsPanel1.Width, rect.Y);
                        }


                    }

                    if (true)
                    {

                        //e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
                    }

                }
            }
            tsl_Cells.Text = "Cells: " + countCells;
            linePen.Dispose();
            liveCellBrsh.Dispose();
        }



        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            MainGrid.Reset();
            generation = 0;
            graphicsPanel1.Invalidate();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            time.Enabled = true;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            time.Enabled = false;
        }

        private void graphicsPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                int x = (int)(e.X / width);
                int y = (int)(e.Y / height);
                mousegridX = x;
                mousegridY = y;

                //Console.WriteLine("Click:" + x + " - " + y + " | " + mousegridX + " - " + mousegridY);

                mouseActive = true;


                MainGrid[x, y].ToggleState();
                graphicsPanel1.Invalidate();
            }


        }

        private void graphicsPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseActive = false;
            }

        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void graphicsPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (mouseActive)
            {
                int x = (int)(e.X / width);
                int y = (int)(e.Y / height);
                if ((mousegridX != x || mousegridY != y) && x < MainGrid.Width && y < MainGrid.Height && x > -1 && -1 < y)
                {
                    //Console.WriteLine("Move:" + x + " - " + y + " | " + mousegridX + " - " + mousegridY);

                    MainGrid[x, y].ToggleState();
                    mousegridX = x;
                    mousegridY = y;
                    graphicsPanel1.Invalidate();
                }

                
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox dlg = new AboutBox();
            dlg.Show();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void tsb_ToggleGrid_Click(object sender, EventArgs e)
        {
            GridEnabled = !GridEnabled;
            graphicsPanel1.Invalidate();
        }
    }
}
