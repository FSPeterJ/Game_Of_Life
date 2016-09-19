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
        int seed = 0;
        Random rnd = new Random();

        public int Seed
        {
            get
            {
                return seed;
            }
            set
            {
                nud_Seed.Value = value;
                seed = value;
            }
        }

        public SeedDialogue()
        {
            InitializeComponent();
        }

        private void SeedDialogue_Load(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Randomize_Click(object sender, EventArgs e)
        {
            Seed = rnd.Next();
        }
    }
}
