using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2708
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gb_ilce1.Visible = gb_ilce2.Visible = gb_ilce3.Visible = false;

        }

        private void cb_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_il.SelectedIndex == 0)
            {
                gb_ilce1.Visible = true;
                gb_ilce2.Visible = false;
                gb_ilce3.Visible = false;
            }
            if(cb_il.SelectedIndex == 1) 
            {
                gb_ilce1.Visible = false;
                gb_ilce2.Visible = true;
                gb_ilce3.Visible = false;
            }
            if(cb_il.SelectedIndex == 2)
            {
                gb_ilce1.Visible = false;
                gb_ilce2.Visible = false;
                gb_ilce3.Visible = true;
            }
        }
    }
}
