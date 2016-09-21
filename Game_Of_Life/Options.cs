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
        ColorDialog cld = new ColorDialog();





        public Options()
        {
            InitializeComponent();
        }


        public int BorderType
        {
            get
            {
                if (rb_Finite.Checked)
                {
                    return 0;
                }
                return 1;
            }
            set
            {
                if(value == 0)
                {
                    rb_Finite.Checked = true;
                }
                else
                {
                    rb_Toroidal.Checked = true;
                }
            }
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

        public Color GridColor
        {
            get
            {
                return btn_Grid.BackColor;
            }
            set
            {
                btn_Grid.BackColor = value;
            }
        }
        public Color Grid10Color
        {
            get
            {
                return btn_Grid10.BackColor;
            }
            set
            {
                btn_Grid10.BackColor = value;
            }
        }

        public Color BackColor
        {
            get
            {
                
                return btn_Background.BackColor;
            }
            set
            {
                btn_Background.BackColor = value;
            }
        }

        public Color LiveCellColor
        {
            get
            {
            
                return btn_LiveCell.BackColor;
            }
            set
            {
                btn_LiveCell.BackColor = value;
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

        private void btn_Grid_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);

            cld.Color = btn.BackColor;
            cld.ShowDialog();
            btn.BackColor = cld.Color;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void rb_Toroidal_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
