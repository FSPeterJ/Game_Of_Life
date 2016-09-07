using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Random rnd = new Random();

        GridSquare[,] GridSquares;
        GridSquare[,] ShadowGridSquares;
        public class GridSquare
        {
            bool on = false;
            int LN = 0;

            public GridSquare()
            {

            }

            public bool IsOn
            {
                get { return on; }
                set { on = value; }
            }

            public int LiveNeighbors
            {
                get { return LN; }
                set { LN = value; }
            }

            public void Reset()
            {
                on = false;
                LiveNeighbors = 0;
            }

            public void ToggleState()
            {
                on = !on;
            }

            public bool WillLive
            {
                get
                {
                    switch (LiveNeighbors)
                    {
                        case 2:
                            if (IsOn)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        case 3:

                            return true;

                            break;
                        default:
                            return false;
                            break;
                    }
                }

            }

        }


        public Grid(int x, int y)
        {
            NewGrid(x, y);
        }
        public GridSquare this[int x, int y]
        {
            get { return GridSquares[x, y]; }
            //set { GridSquares[x, y] = value; }
        }
        public int Width
        {
            get { return GridSquares.GetLength(0); }
        }

        public int Height
        {
            get { return GridSquares.GetLength(1); }
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

        public void NewGrid(int width, int height)
        {
            GridSquare[,] temp = new GridSquare[width, height];
            ShadowGridSquares = new GridSquare[width, height];
            for (int y = 0; y < temp.GetLength(1); y++)
            {
                for (int x = 0; x < temp.GetLength(0); x++)
                {
                    if (GridSquares != null && GridSquares[x, y] != null)
                    {
                        temp[x, y] = GridSquares[x, y];
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

        public void Randomize()
        {
            for (int y = 0; y < GridSquares.GetLength(1); y++)
            {
                for (int x = 0; x < GridSquares.GetLength(0); x++)
                {
                    GridSquares[x, y].IsOn = (rnd.Next() % 2 == 0);
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
                        if (GridSquares[sx, sy].IsOn && !(sx == x && sy == y))
                        {
                            count++;
                        }

                    }

                }
            }
            GridSquares[x, y].LiveNeighbors = count;
            return count;
        }
        public void CalculateNext()
        {
            for (int y = 0; y < GridSquares.GetLength(1); y++)
            {
                for (int x = 0; x < GridSquares.GetLength(0); x++)
                {
                    ProcessNeighbor(x, y);
                    ShadowGridSquares[x, y].IsOn = GridSquares[x, y].WillLive;
                }
            }
            for (int y = 0; y < GridSquares.GetLength(1); y++)
            {
                for (int x = 0; x < GridSquares.GetLength(0); x++)
                {
                    GridSquares[x, y].IsOn = ShadowGridSquares[x, y].IsOn;
                }
            }


        }
    }
}

