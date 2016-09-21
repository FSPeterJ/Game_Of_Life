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
using System.IO;

namespace Game_Of_Life
{
    public partial class BaseForm : Form
    {
        
        Options dlg_Options = new Options();
        SeedDialogue dlg_Seed = new SeedDialogue();

        Color ColorLiveCell = Color.Yellow;
        Color ColorGrid = Color.Yellow;
        Color ColorGrid10x = Color.Yellow;
        Color ColorBack = Color.Yellow;

        Grid MainGrid;
        //DO NOT USE THESE DIRECTLY
        bool gridstate = true;
        bool hudstate = true;
        bool neighborsstate = true;
        // - - - 

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
            //Time
            time.Enabled = false;
            time.Tick += Timer_Tick;


            //Settings Load
            TimerMS = Properties.Settings.Default.TimerMS;

            MainGrid = new Grid();
            ResizeGrid(Properties.Settings.Default.Width, Properties.Settings.Default.Height);

            ColorBack = Properties.Settings.Default.ColorBack;
            ColorGrid = Properties.Settings.Default.ColorGrid;
            ColorGrid10x = Properties.Settings.Default.ColorGrid10x;
            ColorLiveCell = Properties.Settings.Default.ColorCell;

            //BorderType = Properties.Settings.Default.BorderType;
            GridEnabled = Properties.Settings.Default.GridEnabled;
            NeighborsEnabled = Properties.Settings.Default.NeighborsEnabled;
            HUDEnabled = Properties.Settings.Default.HUDEnabled;
            Seed = Properties.Settings.Default.Seed;
            GridWidth = Properties.Settings.Default.Width;
            MainGrid.BorderType = Properties.Settings.Default.BorderType;
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






        public bool HUDEnabled
        {
            get
            {
                return hudstate;
            }
            set
            {
                hudstate = value;
                if (value)
                {
                    headsUpVisibleToolStripMenuItem.Checked = true;
                    headsUpVisibleToolStripMenuItem1.Checked = true;
                }
                else
                {

                    headsUpVisibleToolStripMenuItem.Checked = false;
                    headsUpVisibleToolStripMenuItem1.Checked = false;
                }
                graphicsPanel1.Invalidate();
            }
        }
        public bool GridEnabled
        {
            get
            {
                return gridstate;
            }
            set
            {
                gridstate = value;
                if (value)
                {
                    gridVisibleToolStripMenuItem.Checked = true;
                    gridVisibleToolStripMenuItem1.Checked = true;
                }
                else
                {

                    gridVisibleToolStripMenuItem.Checked = false;
                    gridVisibleToolStripMenuItem1.Checked = false;
                }
                graphicsPanel1.Invalidate();
            }
        }
        public bool NeighborsEnabled
        {
            get
            {
                return neighborsstate;
            }
            set
            {
                neighborsstate = value;
                if (value)
                {

                    neighborCountVisibleToolStripMenuItem.Checked = true;
                    neighborCountVisibleToolStripMenuItem1.Checked = true;
                }
                else
                {

                    neighborCountVisibleToolStripMenuItem.Checked = false;
                    neighborCountVisibleToolStripMenuItem1.Checked = false;
                }
                graphicsPanel1.Invalidate();
            }
        }

        int TimerMS
        {

            get
            {
                return time.Interval;
            }
            set
            {
                time.Interval = value;
                
            }
        }

        int Seed
        {
            get
            {
                return MainGrid.CurrentSeed;
            }
            set
            {
                if(value == -1)
                {
                    MainGrid.NewSeed();
                }
                else
                {
                    MainGrid.CurrentSeed = value;
                }

                tsl_CurrentSeed.Text = "Current Seed: " + MainGrid.CurrentSeed;
            }
        }


        private void ResizeGrid(int width, int height)
        {
            GridHeight = height;
            GridWidth = width;
            MainGrid.NewGrid();
        }

        int GridHeight
        {
            get
            {
                return MainGrid.Height;
            }
            set
            {
                MainGrid.Height = value;
            }
        }

        int GridWidth
        {
            get
            {
                return MainGrid.Width;
            }
            set
            {
                dlg_Options.GridWidth = value;
                MainGrid.Width = value;
            }
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics
            width = graphicsPanel1.Width / (float)MainGrid.Width;
            height = graphicsPanel1.Height / (float)MainGrid.Height;

            Pen linePen = new Pen(ColorGrid);
            Pen lineSectorPen = new Pen(ColorGrid10x, 3);
            Brush liveCellBrsh = new SolidBrush(ColorLiveCell);
            StringFormat drawFormat = new StringFormat();
            int countCells = 0;



            RectangleF rect = RectangleF.Empty;
            rect.Width = width;
            rect.Height = height;

            Font font = new Font("Arial", 10f);
            Font Hudfont = new Font("Arial", 10f);
            Brush Livebrush = new SolidBrush(Color.Green);
            Brush Diebrush = new SolidBrush(Color.DarkRed);

            Brush txtBrush = Livebrush;
            Brush hudBrush = new SolidBrush(Color.Red);

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
                    if (MainGrid[x, y].IsAlive)
                    {
                        e.Graphics.FillRectangle(liveCellBrsh, rect);
                        countCells++;
                    }

                    if (GridEnabled)
                    {
                        if (y == 0 && x % 10 == 0)
                        {
                            e.Graphics.DrawLine(lineSectorPen, rect.X, 0, rect.X, graphicsPanel1.Height);
                        }
                        if (x == 0 && y % 10 == 0)
                        {
                            e.Graphics.DrawLine(lineSectorPen, 0, rect.Y, graphicsPanel1.Width, rect.Y);
                        }
                        e.Graphics.DrawRectangle(linePen, rect.X, rect.Y, rect.Width, rect.Height);

                    }

                    if (NeighborsEnabled)
                    {

                        int LiveFriends = MainGrid.ProcessNeighbor(x, y);

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

            if (hudstate)
            {
                string tmp = "Generations : " + generation;
                e.Graphics.DrawString(tmp, Hudfont, hudBrush, 5, graphicsPanel1.Height - 80);
                tmp = "Cell Count : " + countCells;
                e.Graphics.DrawString(tmp, Hudfont, hudBrush, 5, graphicsPanel1.Height - 60);
                tmp = "Boundary Type : " + (MainGrid.BorderType == 1 ? "Wrap" : "Finite" );
                e.Graphics.DrawString(tmp, Hudfont, hudBrush, 5, graphicsPanel1.Height - 40);
                tmp = "Generations : {Width=" + MainGrid.Width +", Height=" + MainGrid.Height + "}";
                e.Graphics.DrawString(tmp, Hudfont, hudBrush, 5, graphicsPanel1.Height - 20);
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


        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            // dlg.Color = ;
            dlg.ShowDialog();

            if (DialogResult.OK == dlg.ShowDialog())
            {
                

            }
        }



        //This method came from MSDN
        //Modified to use floats & acount for height of area and default that dumb option, might get rid of it;

        //https://msdn.microsoft.com/en-us/library/bb986765.aspx
        public Font GetAdjustedFont(Graphics GraphicRef, string GraphicString, Font OriginalFont, float ContainerWidth, float ContainerHeight, int MaxFontSize, int MinFontSize, bool SmallestOnFail = true)
        {
            MinFontSize = (MinFontSize < 1) ? 1 : MinFontSize;
            Font TestFont =  new Font(OriginalFont.Name, MinFontSize, OriginalFont.Style);

            // MS: We utilize MeasureString which we get via a control instance           
            for (int AdjustedSize = MaxFontSize; AdjustedSize >= MinFontSize; AdjustedSize--)
            {
                //I don't like the idea that Font is immutable - Why is it like that?
                TestFont = new Font(OriginalFont.Name, AdjustedSize, OriginalFont.Style);
                // MS: Test the string with the new size
                SizeF AdjustedSizeNew = GraphicRef.MeasureString(GraphicString, TestFont);
                //add height test
                if (ContainerWidth > AdjustedSizeNew.Width && ContainerHeight > AdjustedSizeNew.Height)
                {
                    // MS: Good font, return it
                    break;
                }
            }
                
            return TestFont;

        }

        private void fromCurrentTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seed = -1;
            MainGrid.Randomize();
            graphicsPanel1.Invalidate();
        }

        private void fromCurrentSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainGrid.Randomize();
        }


        private void gridVisibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridEnabled = !GridEnabled;
        }

        private void neighborCountVisibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NeighborsEnabled = !NeighborsEnabled;
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainGrid.Load();
            graphicsPanel1.Invalidate();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Pause();
            MainGrid.Save();
        }

        private void fromNewSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dlg_Seed.Seed = Seed;
            dlg_Seed.ShowDialog();

            if(dlg_Seed.DialogResult == DialogResult.OK)
            {
                Seed = dlg_Seed.Seed;
            }
        }

        private void SetOptions()
        {
            dlg_Options.TimerMS = TimerMS;
            dlg_Options.GridHeight = GridHeight;
            dlg_Options.GridWidth = GridWidth;
            dlg_Options.LiveCellColor = ColorLiveCell;
            dlg_Options.GridColor = ColorGrid;
            dlg_Options.BackColor = graphicsPanel1.BackColor;
            dlg_Options.Grid10Color = ColorGrid10x;
            dlg_Options.BorderType = MainGrid.BorderType;


        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SetOptions();
            dlg_Options.ShowDialog();

            if (DialogResult.OK == dlg_Options.DialogResult)
            {
                TimerMS = dlg_Options.TimerMS;
                ResizeGrid(dlg_Options.GridWidth, dlg_Options.GridHeight);
                graphicsPanel1.BackColor = dlg_Options.BackColor;
                ColorLiveCell = dlg_Options.LiveCellColor;
                ColorGrid = dlg_Options.GridColor;
                ColorGrid10x = dlg_Options.Grid10Color;
                MainGrid.BorderType = dlg_Options.BorderType;
            }
            graphicsPanel1.Invalidate();


            
        }


        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainGrid.Import();
            graphicsPanel1.Invalidate();
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.BorderType = MainGrid.BorderType;
            Properties.Settings.Default.ColorBack = ColorBack;
            Properties.Settings.Default.ColorCell = ColorLiveCell;
            Properties.Settings.Default.ColorGrid = ColorGrid;
            Properties.Settings.Default.ColorGrid10x = ColorGrid10x;
            Properties.Settings.Default.GridEnabled = GridEnabled;
            Properties.Settings.Default.HUDEnabled = HUDEnabled;
            Properties.Settings.Default.Height = GridHeight;
            Properties.Settings.Default.NeighborsEnabled = NeighborsEnabled;
            Properties.Settings.Default.Seed = Seed;
            Properties.Settings.Default.TimerMS = TimerMS;
            Properties.Settings.Default.Width = GridWidth;
        }

        private void headsUpVisibleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HUDEnabled = !HUDEnabled;
        }
    }
}
