using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace villamos116
{
    public struct villamos
    {
        public string vonal;
        public List<megallo> megallok;
        public int ido;
    }

    public struct megallo
    {
        public string nev;
        public int ido;
    }
    public partial class Form1 : Form
    {
        Dictionary<string,villamos> stat= new Dictionary<string,villamos>();
        villamos v = new villamos();
        megallo m = new megallo();
        List<villamos> lista = new List<villamos>();
        string filenev = "./villamosjaratok.txt";
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = filenev;
        }

        private void buttonFileOlvas_Click(object sender, EventArgs e)
        {
            filenev = textBox1.Text;
            FilebolBeolvas();
        }

        void FilebolBeolvas()
        {
            string [] file = File.ReadAllLines(filenev);

            foreach (string sor in file)
            {
                string[] t = sor.Split(';');
                string vonal = t[0];
                string megallo = t[1];
                int ido = int.Parse(t[2]);
                villamos vili = new villamos
                {
                    vonal = vonal,
                    megallok = new List<megallo>(),
                    ido = 0
                };
                megallo villamosmegallo = new megallo
                {
                    nev = megallo,
                    ido = ido,
                };
                vili.megallok.Add(villamosmegallo);
                if (stat.ContainsKey(vonal))
                {
                    stat[vonal].megallok.Add(villamosmegallo);
                }
                else
                {
                    stat.Add(vonal, vili);
                }
            }
        }

        private void buttonVonal_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string vonalszam in stat.Keys)
            {
                int time = 0;
                foreach (megallo megallo in stat[vonalszam].megallok)
                {
                    time += megallo.ido;
                }
                listBox1.Items.Add(vonalszam + ". jarat " + time + " perc");
            }
        }

        private void buttonGyors_Click(object sender, EventArgs e)
        {
            int maxp = int.MaxValue;
            string maxvonal = "";
            listBox1.Items.Clear();
            foreach (string vonalszam in stat.Keys)
            {
                int time = 0;
                foreach (megallo megallo in stat[vonalszam].megallok)
                {
                    time += megallo.ido;
                }

                if (time < maxp)
                {
                    maxp = time;
                    maxvonal = vonalszam;
                }
            }
            listBox1.Items.Add("Leggyorsabb vonal: " + maxvonal + " : " + maxp + " perc");
        }

        private void buttonLassu_Click(object sender, EventArgs e)
        {
            int minp = int.MinValue;
            string minvonal = "";
            listBox1.Items.Clear();
            foreach (string vonalszam in stat.Keys)
            {
                int time = 0;
                foreach (megallo megallo in stat[vonalszam].megallok)
                {
                    time += megallo.ido;
                }

                if (time > minp)
                {
                    minp = time;
                    minvonal = vonalszam;
                }
                
            }
            listBox1.Items.Add("Leglassabb vonal: " + minvonal + " : " + minp + " perc");
        }

        private void buttonMegallo_Click(object sender, EventArgs e)
        {
            int time = 0;
            listBox1.Items.Clear();
            foreach (string vonalszam in stat.Keys)
            {
                listBox1.Items.Add(vonalszam + ". vonal: ");
                foreach (megallo megallo in stat[vonalszam].megallok)
                {
                    listBox1.Items.Add(megallo.nev + " - " + time);
                    time += megallo.ido;
                }
                    time = 0;
            }   
        }
    }
}
