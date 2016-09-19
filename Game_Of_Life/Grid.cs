using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Game_Of_Life
{

    enum RandomTypes
    {
        Time,
        Seed,
        NewSeed
    }
    class Grid
    {
        public int CurrentSeed
        {
            get
            {
                return currentseed;
            }
            set
            {
                currentseed = value;
                rnds = new Random(CurrentSeed);
            }
        }

        int currentseed = 0;

        int width = 1;
        int height = 1;

        Random rnd = new Random();
        Random rnds = new Random();

        GridSquare[,] GridSquares = new GridSquare[1,1];
        GridSquare[,] ShadowGridSquares = new GridSquare[1, 1];

        OpenFileDialog ofd = new OpenFileDialog();



        public class GridSquare
        {
            bool alive = false;
            int liveneighbors = 0;
            int age = 0;
            int generationsactive = 0;

            public GridSquare()
            {

            }

            public bool IsAlive
            {
                get { return alive; }
                set { alive = value; }
            }

            protected internal void CheckGenerations()
            {
                if (IsAlive)
                {
                    generationsactive++;
                    age++;
                }
            }

            public int LiveNeighbors
            {
                get { return liveneighbors; }
                set { liveneighbors = value; }
            }

            public void Reset()
            {
                alive = false;
                LiveNeighbors = 0;
                age = 0;
                generationsactive = 0;
            }

            public void ToggleState()
            {
                alive = !alive;
                age = 0;
            }

            public bool WillLive
            {
                get
                {
                    switch (LiveNeighbors)
                    {
                        case 2:
                            if (IsAlive)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        case 3:

                            return true;

                        default:
                            return false;
                    }
                }

            }

        }

        public Grid()
        {
            NewGrid(Width, Height);
        }

        private Grid(int x, int y)
        {
            Width = x;
            Height = y;
            NewGrid(Width, Height);
        }
        public GridSquare this[int x, int y]
        {
            get
            {
                return GridSquares[x, y];
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public void Reset()
        {
            for (int y = 0; y < GridSquares.GetLength(1); y++)
            {
                for (int x = 0; x < GridSquares.GetLength(0); x++)
                {
                    GridSquares[x, y].Reset();
                }
            }

        }

        public void NewSeed(int seed = 0)
        {
            if (seed == 0)
            {

                CurrentSeed = rnd.Next();
            }
            else
            {
                CurrentSeed = seed;
            }
        }

        public void NewGrid()
        {
            GridSquare[,] temp = new GridSquare[Width, Height];
            ShadowGridSquares = new GridSquare[Width, Height];
            for (int y = 0; y < temp.GetLength(1); y++)
            {
                for (int x = 0; x < temp.GetLength(0); x++)
                {
                    if (x < GridSquares.GetLength(0) && y < GridSquares.GetLength(1) && GridSquares != null && GridSquares[x, y] != null)
                    {
                        temp[x, y] = GridSquares[x, y];
                        ShadowGridSquares[x, y] = GridSquares[x, y];
                    }
                    else
                    {
                        temp[x, y] = new GridSquare();
                        ShadowGridSquares[x, y] = new GridSquare();
                    }

                }
            }

            GridSquares = temp;

        }

        private void NewGrid(int width, int height)
        {
            Width = width;
            Height = height;
            NewGrid();
        }


        public void Randomize()
        {
            for (int y = 0; y < GridSquares.GetLength(1); y++)
            {
                for (int x = 0; x < GridSquares.GetLength(0); x++)
                {
                    GridSquares[x, y].IsAlive = (rnds.Next() % 3 == 0);
                }
            }
        }


        public int ProcessNeighbor(int x, int y)
        {
            int count = 0;
            for (int sy = y - 1; sy < y + 2; sy++)
            {
                for (int sx = x - 1; sx < x + 2; sx++)
                {

                    if (sx > -1 && sy > -1 && sx < GridSquares.GetLength(0) && sy < GridSquares.GetLength(1))
                    {
                        if (GridSquares[sx, sy].IsAlive && !(sx == x && sy == y))
                        {
                            count++;
                        }

                    }

                }
            }
            GridSquares[x, y].LiveNeighbors = count;
            return count;
        }

        public void NewGridFromList(List<string> lines)
        {
            //Generate new grid
            NewGrid(lines[0].Length, lines.Count);

            //Processes Lines
            int Linecount = lines.Count;
            char[,] Arr2d = new char[lines[0].Length, Linecount];
            for (int i = 0; i < Linecount; i++)
            {

                for (int c = 0; c < lines[i].Length; c++)
                {

                    if (lines[i][c] == 'O')
                    {
                        GridSquares[c, i].IsAlive = true;

                    }
                }
            }
        }

        public void CalculateNext()
        {
            for (int y = 0; y < GridSquares.GetLength(1); y++)
            {
                for (int x = 0; x < GridSquares.GetLength(0); x++)
                {
                    ProcessNeighbor(x, y);
                    ShadowGridSquares[x, y].IsAlive = GridSquares[x, y].WillLive;
                }
            }
            for (int y = 0; y < GridSquares.GetLength(1); y++)
            {
                for (int x = 0; x < GridSquares.GetLength(0); x++)
                {
                    GridSquares[x, y].IsAlive = ShadowGridSquares[x, y].IsAlive;

                    GridSquares[x, y].CheckGenerations();

                }
            }


        }

        internal void Load()
        {

            ofd.Filter = "cell files (*.cell)|*.cell|All files (*.*)|*.*";
            ofd.FilterIndex = 0;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                List<string> lines = new List<string>();

                try
                {
                    StreamReader reader;
                    using (reader = new StreamReader(ofd.FileName))
                    {
                        string line;

                        for (int i = 0; !reader.EndOfStream; i++)
                        {
                            line = reader.ReadLine();
                            if (line[0] != '!')
                            {
                                lines.Add(line);
                            }
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                int Linecount = lines.Count;
                if (Linecount > 0)
                {

                    NewGridFromList(lines);
                }
            }
        }

        internal void Save()
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "cell files (*.cell)|*.cell|All files (*.*)|*.*";
            sfd.FilterIndex = 0;

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    StreamWriter writer;
                    using (writer = new StreamWriter(sfd.FileName))
                    {
                        for (int y = 0; y < GridSquares.GetLength(1); y++)
                        {
                            string line = "";
                            for (int x = 0; x < GridSquares.GetLength(0); x++)
                            {
                                if (GridSquares[x, y].IsAlive)
                                {
                                    line += 'O';
                                }
                                else
                                {
                                    line += '.';
                                }
                            }
                            
                        writer.WriteLine(line);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not write file to disk. Original error: " + ex.Message);
                }
            }
        }
    }
}

