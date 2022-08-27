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
    public partial class Odev_2708v2 : Form
    {
        public Odev_2708v2()
        {
            InitializeComponent();
        }

        private void Odev_2708v2_Load(object sender, EventArgs e)
        {
            gb_urunEkle.Visible = true;
            gb_urunEklendi.Visible = false;
            lbl_beden.Visible = lbl_ayakNo.Visible = cb_bedenGomlek.Visible = cb_ayakNo.Visible = cb_bedenPantolon.Visible = lbl_boy.Visible = cb_boy.Visible = false;

        }

        private void cb_urun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_urun.SelectedIndex == 0)
            {
                lbl_beden.Visible = true;
                cb_bedenGomlek.Visible = true;
                cb_bedenPantolon.Visible = false;
                lbl_ayakNo.Visible = false;
                cb_ayakNo.Visible = false;
                lbl_boy.Visible = false;
                cb_boy.Visible = false;
            }
            if (cb_urun.SelectedIndex == 1)
            {
                lbl_beden.Visible = true;
                cb_bedenPantolon.Visible = true;
                lbl_boy.Visible = true;
                cb_boy.Visible = true;
                cb_bedenGomlek.Visible = false;
                lbl_ayakNo.Visible = false;
                cb_ayakNo.Visible = false;
            }
            if (cb_urun.SelectedIndex == 2)
            {
                lbl_ayakNo.Visible = true;
                cb_ayakNo.Visible = true;
                lbl_beden.Visible = false;
                cb_bedenPantolon.Visible = false;
                cb_bedenGomlek.Visible = false;
                lbl_boy.Visible = false;
                cb_boy.Visible = false;
            }
        }

        private void btn_urunEkle_Click(object sender, EventArgs e)
        {
            gb_urunEkle.Visible = false;
            gb_urunEklendi.Visible = true;
            lbl_ayakNoBilgisi.Visible = lbl_ayakNoEklendi.Visible = lbl_boyuBilgisi.Visible = lbl_boyEklendi.Visible = lbl_bedenEklendi.Visible = lbl_bedenBilgisi.Visible = false;
            if (cb_urun.SelectedIndex == 0)
            {
                lbl_urunEklendi.Text = cb_urun.SelectedItem.ToString();
                lbl_bedenBilgisi.Visible = lbl_bedenEklendi.Visible= true;
                lbl_bedenEklendi.Text = cb_bedenGomlek.SelectedItem.ToString();
            }
            if (cb_urun.SelectedIndex == 1)
            {
                lbl_urunEklendi.Text = cb_urun.SelectedItem.ToString();
                lbl_bedenBilgisi.Visible = lbl_bedenEklendi.Visible = true;
                lbl_bedenEklendi.Text = cb_bedenPantolon.SelectedItem.ToString();
                lbl_boyuBilgisi.Visible = lbl_boyEklendi.Visible = true;
                lbl_boyEklendi.Text = cb_boy.SelectedItem.ToString();
            }
            if (cb_urun.SelectedIndex == 2)
            {
                lbl_urunEklendi.Text = cb_urun.SelectedItem.ToString();
                lbl_ayakNoBilgisi.Visible = lbl_ayakNoEklendi.Visible = true;
                lbl_ayakNoEklendi.Text = cb_ayakNo.SelectedItem.ToString();
            }
        }

        private void btn_yeniUrunEkle_Click(object sender, EventArgs e)
        {
            gb_urunEkle.Visible = true;
            gb_urunEklendi.Visible = false;
            cb_urun.ResetText();
            cb_bedenGomlek.ResetText();
            cb_bedenPantolon.ResetText();
            cb_ayakNo.ResetText();
            cb_boy.ResetText();
        }
    }
}
