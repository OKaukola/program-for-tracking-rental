using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Data.OleDb;

namespace Vuokranseuranta
{
    public partial class Seuranta : Form
    {
        string polku = Environment.CurrentDirectory;
        /*
        public Seuranta()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();
        }

        public void SplashStart()
        {
            Application.Run(new Etu());
        }
        */
        private void Seuranta_Load(object sender, EventArgs e)
        {               
            StreamReader sr = new StreamReader(polku + @"\Data\companies.txt", Encoding.UTF8);
            
            string rivi;
            while ((rivi = sr.ReadLine()) != null)
            {
                string company = rivi;
                cbYhtiot.Items.Add(company);
            }
            sr.Close();
        }

        private void asuntoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsLisaaminen lisaaminen = new AsLisaaminen();
            DialogResult result = lisaaminen.ShowDialog();
            if (result == DialogResult.OK)
            {                
                cbYhtiot.Items.Clear();
                string rivi;
                StreamReader sr = new StreamReader(polku + @"\Data\companies.txt", Encoding.UTF8);
                while ((rivi = sr.ReadLine()) != null)
                {
                    string company = rivi;
                    cbYhtiot.Items.Add(company);
                }
                sr.Close();
            }
        }
        private void btnMuuta_Click(object sender, EventArgs e)
        {
            int i = 0;
            int index;

            ListViewItem item = listViewVuokrat.SelectedItems[i];
            index = listViewVuokrat.FocusedItem.Index;

            if (listViewVuokrat.SelectedItems.Count > 0)
            {
                Vuokra au = new Vuokra(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text, item.SubItems[5].Text);

                LisaaMuokkaa lisaa = new LisaaMuokkaa(au);

                DialogResult result = lisaa.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var item2 = new ListViewItem(new[] { au.Kuukausi, au.Vuokrasumma, au.Vuokrapvm, au.Vastike, au.Vastikepvm, au.Muistiinp});
                    listViewVuokrat.Items.RemoveAt(index);
                    listViewVuokrat.Items.Insert(index, item2);                                    
                }
            }
            else 
            { 
                MessageBox.Show("Valiste muokattava kuukausi"); 
            }
        }

        private void btnAvaa_Click(object sender, EventArgs e)
        {        
            if (cbYhtiot.SelectedItem == null)
            {
                MessageBox.Show("Valitse asunto!");
            }
            else if (cbVuosi.SelectedItem == null)
            {
                MessageBox.Show("Valitse vuosi!");
            }
            else
            {
                listViewVuokrat.Items.Clear();

                string path1 = polku + @"\Data\Companies\";
                string path2 = cbYhtiot.Text;
                string path3 = cbVuosi.Text + ".txt";

                string pathString = Path.Combine(path1, path2, path3);

                StreamReader sr = new StreamReader(pathString, Encoding.UTF8);
                
                string rivi;
                while ((rivi = sr.ReadLine()) != null)
                {
                    string[] palaset = rivi.Split('&');

                    Vuokra au = new Vuokra(palaset[0], palaset[1], palaset[2], palaset[3], palaset[4], palaset[5]);

                    ListViewItem itm = new ListViewItem(palaset);
                    listViewVuokrat.Items.Add(itm);
                }
                sr.Close();

                labelVuosi.Text = cbVuosi.Text;
                labelYhtio.Text = cbYhtiot.Text;
            }
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            string path1 = polku + @"\Data\Companies\";
            string path2 = cbYhtiot.Text;
            string path3 = cbVuosi.Text + ".txt";

            string pathString = Path.Combine(path1, path2, path3);
            
            StreamWriter sw = new StreamWriter(pathString);

            foreach (ListViewItem item in listViewVuokrat.Items)
            {
                sw.WriteLine("{0}&{1}&{2}&{3}&{4}&{5}&",item.SubItems[0].Text,item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text, item.SubItems[5].Text);
            }

            MessageBox.Show("Muutokset tallennettu!");

            sw.Close();
        }

        private void ohjeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ohje ohje = new Ohje();
            ohje.ShowDialog();
        }

        private void tietoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VUOSE Vuokranseuranta v. 1.0\n\nTekijät Olli Kaukola");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RentLayout lisaaminen = new RentLayout();
            DialogResult result = lisaaminen.ShowDialog();
        }

    }
}
