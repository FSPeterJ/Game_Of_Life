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
    public partial class SeedDialogue : Form
    {
        int cSeed = 0;
        Random rnd = new Random();
        public SeedDialogue(int seed = 0)
        {
            Seed = seed;
            InitializeComponent();
        }

        public int Seed {
            get
            {
                return cSeed;
            }

            set
            {
                cSeed = value;
            }
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Random_Click(object sender, EventArgs e)
        {
            Seed = rnd.Next();
            nud_Seed.Value = Seed;
        }
    }
}
