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
    public partial class Options : Form
    {

        public Options()
        {
            InitializeComponent();
        }


        public int TimerMS
        {
            get
            {
                return (int)nud_TimerMS.Value;
            }
            set
            {
                nud_TimerMS.Value = value;
            }
        }

        public int GridWidth
        {
            get
            {
                return (int)nud_Width.Value;
            }
            set
            {
                nud_Width.Value = value;
            }
        }

        public int GridHeight
        {
            get
            {
                return (int)nud_Height.Value;
            }
            set
            {
                nud_Height.Value = value;
            }
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

        }
    }
}
