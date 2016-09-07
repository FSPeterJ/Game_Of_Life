using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Of_Life
{
    public partial class BaseForm : Form
    {
        Color RectBKColor = Color.Yellow;


        Grid MainGrid = new Grid(30, 30);

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



            RectangleF rect = RectangleF.Empty;
            rect.Width = width;
            rect.Height = height;

            Font font = new Font("Arial", 10f);
            Brush Livebrush = new SolidBrush(Color.Green);
            Brush Diebrush = new SolidBrush(Color.DarkRed);

            Brush txtBrush = Livebrush;

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            font = GetAdjustedFont(e.Graphics, "8", font, width, height, 72, 0);

            for (int y = 0; y < MainGrid.Height; y++)
            {
                for (int x = 0; x < MainGrid.Width; x++)
                {

                    //Rectangle
                    rect.X = (x * width);
                    rect.Y = (y * height);

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
                        int LiveFriends = MainGrid.ProcessNeighbor(x,y);

                        if (LiveFriends > 0)
                        {
                            if (MainGrid[x, y].WillLive)
                            {
                                txtBrush = Livebrush;
                            }
                            else
                            {
                                txtBrush = Diebrush;
                            }
                            e.Graphics.DrawString(LiveFriends.ToString(), font, txtBrush, rect, stringFormat);

                        }




                    }

                }
            }
            tsl_Cells.Text = "Cells: " + countCells;
            linePen.Dispose();
            liveCellBrsh.Dispose();
        }

        private void Play()
        {
            time.Enabled = true;

            tsb_Play.Enabled = false;

            tsb_Next.Enabled = false;

            tsb_Stop.Enabled = true;
            startToolStripMenuItem.Enabled = false;
            nextToolStripMenuItem.Enabled = false;
            pauseToolStripMenuItem.Enabled = true;
        }

        private void Pause()
        {
            time.Enabled = false;

            tsb_Play.Enabled = true;
            tsb_Next.Enabled = true;
            tsb_Stop.Enabled = false;

            startToolStripMenuItem.Enabled = true;
            nextToolStripMenuItem.Enabled = true;
            pauseToolStripMenuItem.Enabled = false;
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
            Pause();
            generation = 0;
            lbl_Generation.Text = "Generation: " + generation;
            graphicsPanel1.Invalidate();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Pause();
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
                //MainGrid[x, y].LiveNeighbors(x, y);
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

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            // dlg.Color = ;
            dlg.ShowDialog();

            if (DialogResult.OK == dlg.ShowDialog())
            {


            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options dlg = new Options();

            dlg.ShowDialog();
        }


        //This method came from MSDN
        //Modified to use floats & acount for height of area;

        //https://msdn.microsoft.com/en-us/library/bb986765.aspx
        public Font GetAdjustedFont(Graphics GraphicRef, string GraphicString, Font OriginalFont, float ContainerWidth, float ContainerHeight, int MaxFontSize, int MinFontSize, bool SmallestOnFail = true)
        {
            // We utilize MeasureString which we get via a control instance           
            for (int AdjustedSize = MaxFontSize; AdjustedSize >= MinFontSize; AdjustedSize--)
            {
                Font TestFont = new Font(OriginalFont.Name, AdjustedSize, OriginalFont.Style);

                // Test the string with the new size
                SizeF AdjustedSizeNew = GraphicRef.MeasureString(GraphicString, TestFont);


                // Added check for height
                if (ContainerWidth > AdjustedSizeNew.Width && ContainerHeight > AdjustedSizeNew.Height)
                {
                    // Good font, return it
                    return TestFont;
                }
            }

            // If you get here there was no fontsize that worked
            // return MinimumSize or Original?
            if (SmallestOnFail)
            {
                return new Font(OriginalFont.Name, MinFontSize, OriginalFont.Style);
            }
            else
            {
                return OriginalFont;
            }
        }

        private void fromCurrentTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainGrid.Randomize();
        }
    }
}
