using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        float sekunde = 0;
        float minute = 0;
        float sati = 0;
        public Form1()
        {
            InitializeComponent();
            timer.Start();
            toolStripLabelDatum.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            sekunde = sekunde + 1f;
            if (sekunde >= 60)
            {
                sekunde = 0;
                minute++;
                if (minute >= 60)
                {
                    minute = 0;
                    sati++;
                    if (sati > 23)
                    {
                        sati = 0;
                    }
                }
            }
            toolStripLabelVrijeme.Text = sati.ToString() + ":" + minute.ToString() + ":" + sekunde.ToString();
        }

        private void rdbNiza_Click(object sender, EventArgs e)
        {
            try
            { 
                if(txtkWh.Text != "")
                {
                    txtRacun.Text = (Convert.ToInt32(float.Parse(txtkWh.Text) * 0.0395f) + Convert.ToInt32(float.Parse(txtkWh.Text) * 0.0658f) + Convert.ToInt32(float.Parse(txtkWh.Text) * 0.02f)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Unijeli ste slovo ili neki drugi znak a trebali ste broj", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rdbVisa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtkWh.Text != "")
                {
                    txtRacun.Text = (Convert.ToInt32(float.Parse(txtkWh.Text) * 0.0429f) + Convert.ToInt32(float.Parse(txtkWh.Text) * 0.0658f) + Convert.ToInt32(float.Parse(txtkWh.Text) * 0.02f)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Unijeli ste slovo ili neki drugi znak a trebali ste broj", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

    }
}
