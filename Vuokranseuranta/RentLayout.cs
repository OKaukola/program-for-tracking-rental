using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Vuokranseuranta
{
    public partial class RentLayout : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Projects\program-for-tracking-rental\Vuokranseuranta\vuose_db.mdf;Integrated Security=True;Connect Timeout=30");
        private List<string> vuokrat = new List<string>();
        //private string vuokrat;

        public RentLayout()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();

            con.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql = "";

            sql = "Select name from Condominium";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                comboBox1.Items.Add(dataReader.GetValue(0).ToString());
            }
            dataReader.Close();
            command.Dispose();
            con.Close();
        }

        public void SplashStart()
        {
            Application.Run(new Etu());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cid = "";
            comboBox2.Items.Clear();
            con.Open();
            SqlCommand command, command2;
            SqlDataReader dataReader, dr;
            String sql, sql2 = "";

            sql2 = "Select Cid from Condominium where name = '" + comboBox1.SelectedItem + "'";
            command2 = new SqlCommand(sql2, con);
            dr = command2.ExecuteReader();
            while (dr.Read())
            {
                cid = dr.GetValue(0).ToString();
            }
            dr.Close();
            command2.Dispose();
            con.Close();
            
            if (cid != "")
            {
                con.Open();
                sql = "SELECT apartNro FROM Apartment ap JOIN Condominium con ON con.cid = ap.Cid WHERE ap.Cid = " + cid;
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBox2.Items.Add(dataReader.GetValue(0).ToString());
                }

                dataReader.Close();
                command.Dispose();
                con.Close();
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aid = "";
            con.Open();
            SqlCommand command, command2;
            SqlDataReader dataReader, dr;
            String sql, sql2 = "";

            sql2 = "Select Aid from Apartment where apartNro = '" + comboBox2.SelectedItem + "'";
            command2 = new SqlCommand(sql2, con);
            dr = command2.ExecuteReader();
            while (dr.Read())
            {
                aid = dr.GetValue(0).ToString();
            }
            dr.Close();
            command2.Dispose();
            con.Close();

            if (checkBox1.Checked)
            {
                if (aid != "")
                {
                    listView1.Clear();
                    con.Open();
                    sql = "SELECT year, january, february, march, april, may, june, july, august, september, october, november, december FROM Rent re JOIN Apartment ap ON re.Aid = ap.Aid WHERE re.Aid = " + aid;

                    command = new SqlCommand(sql, con);
                    dataReader = command.ExecuteReader();

                    // Set to details view.
                    listView1.View = View.Details;
                    // Add a column with width 20 and left alignment.
                    listView1.Columns.Add("Vuosi", 50, HorizontalAlignment.Left);
                    listView1.Columns.Add("Tammikuu", 80, HorizontalAlignment.Left);
                    listView1.Columns.Add("Helmikuu", 80, HorizontalAlignment.Left);
                    listView1.Columns.Add("Maaliskuu", 80, HorizontalAlignment.Left);
                    listView1.Columns.Add("Huhtikuu", 80, HorizontalAlignment.Left);
                    listView1.Columns.Add("Toukokuu", 80, HorizontalAlignment.Left);
                    listView1.Columns.Add("Kesäkuu", 80, HorizontalAlignment.Left);
                    listView1.Columns.Add("Heinäkuu", 80, HorizontalAlignment.Left);
                    listView1.Columns.Add("Elokuu", 80, HorizontalAlignment.Left);
                    listView1.Columns.Add("Syyskuu", 80, HorizontalAlignment.Left);
                    listView1.Columns.Add("Lokakuu", 80, HorizontalAlignment.Left);
                    listView1.Columns.Add("Marraskuu", 80, HorizontalAlignment.Left);
                    listView1.Columns.Add("Joulukuu", 80, HorizontalAlignment.Left);

                    while (dataReader.Read())
                    {
                        ListViewItem i = new ListViewItem(dataReader.GetValue(0).ToString());
                        i.SubItems.Add(dataReader.GetValue(1).ToString());
                        i.SubItems.Add(dataReader.GetValue(2).ToString());
                        i.SubItems.Add(dataReader.GetValue(3).ToString());
                        i.SubItems.Add(dataReader.GetValue(4).ToString());
                        i.SubItems.Add(dataReader.GetValue(5).ToString());
                        i.SubItems.Add(dataReader.GetValue(6).ToString());
                        i.SubItems.Add(dataReader.GetValue(7).ToString());
                        i.SubItems.Add(dataReader.GetValue(8).ToString());
                        i.SubItems.Add(dataReader.GetValue(9).ToString());
                        i.SubItems.Add(dataReader.GetValue(10).ToString());
                        i.SubItems.Add(dataReader.GetValue(11).ToString());
                        i.SubItems.Add(dataReader.GetValue(12).ToString());

                        listView1.Items.Add(i);

                        vuokrat.Add(dataReader.GetValue(1).ToString());
                        vuokrat.Add(dataReader.GetValue(2).ToString());
                        vuokrat.Add(dataReader.GetValue(3).ToString());
                        vuokrat.Add(dataReader.GetValue(4).ToString());
                        vuokrat.Add(dataReader.GetValue(5).ToString());
                        vuokrat.Add(dataReader.GetValue(6).ToString());
                        vuokrat.Add(dataReader.GetValue(7).ToString());
                        vuokrat.Add(dataReader.GetValue(8).ToString());
                        vuokrat.Add(dataReader.GetValue(9).ToString());
                        vuokrat.Add(dataReader.GetValue(10).ToString());
                        vuokrat.Add(dataReader.GetValue(11).ToString());
                        vuokrat.Add(dataReader.GetValue(12).ToString());
                        vuokrat.Add("---------------------------------------------------------------------------------");
                    }

                    dataReader.Close();
                    command.Dispose();
                    con.Close();
                }
            }
            if (checkBox2.Checked)
            {
                if (aid != "")
                {
                    listView1.Clear();
                    con.Open();
                    sql = "SELECT year, january, february, march, april, may, june, july, august, september, october, november, december FROM MaintenanceCharge mc JOIN Apartment ap ON mc.Aid = ap.Aid WHERE mc.Aid = " + aid;

                    command = new SqlCommand(sql, con);
                    dataReader = command.ExecuteReader();

                    // Set to details view.
                    listView1.View = View.Details;
                    // Add a column with width 20 and left alignment.
                    listView1.Columns.Add("Vuosi", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("Tammikuu", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("Helmikuu", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("Maaliskuu", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("Huhtikuu", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("Toukokuu", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("Kesäkuu", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("Heinäkuu", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("Elokuu", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("Syyskuu", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("Lokakuu", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("Marraskuu", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("Joulukuu", 100, HorizontalAlignment.Left);

                    while (dataReader.Read())
                    {
                        ListViewItem i = new ListViewItem(dataReader.GetValue(0).ToString());
                        i.SubItems.Add(dataReader.GetValue(1).ToString());
                        i.SubItems.Add(dataReader.GetValue(2).ToString());
                        i.SubItems.Add(dataReader.GetValue(3).ToString());
                        i.SubItems.Add(dataReader.GetValue(4).ToString());
                        i.SubItems.Add(dataReader.GetValue(5).ToString());
                        i.SubItems.Add(dataReader.GetValue(6).ToString());
                        i.SubItems.Add(dataReader.GetValue(7).ToString());
                        i.SubItems.Add(dataReader.GetValue(8).ToString());
                        i.SubItems.Add(dataReader.GetValue(9).ToString());
                        i.SubItems.Add(dataReader.GetValue(10).ToString());
                        i.SubItems.Add(dataReader.GetValue(11).ToString());
                        i.SubItems.Add(dataReader.GetValue(12).ToString());

                        listView1.Items.Add(i);
                    }

                    dataReader.Close();
                    command.Dispose();
                    con.Close();
                }
            }
            
         
        }

        private void asuntoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApartLayout lisaaminen = new ApartLayout();
            DialogResult result = lisaaminen.ShowDialog();
        }

        private void taloyhtiöToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CondominiumLayout talo = new CondominiumLayout();
            DialogResult result = talo.ShowDialog();
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void esikatseleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int test = 120;
            Bitmap bmp = Properties.Resources.vuose_logo;
            Image newImage = bmp;
            int width = newImage.Width;
            int height = newImage.Height;
            RectangleF destinationRect = new RectangleF(25,20, .07f * width, .07f * height);
            RectangleF sourceRect = new RectangleF(0, 0, 1f * width, 1f * height);

            e.Graphics.DrawImage(newImage, destinationRect, sourceRect, GraphicsUnit.Pixel);
            e.Graphics.DrawString("Vuose Raportti", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, 40));
            e.Graphics.DrawString(DateTime.Now.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 40));
            e.Graphics.DrawString("Vuokrat:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 100));
            foreach (string item in vuokrat)
            {
                e.Graphics.DrawString(item, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, test));
                test = test + 20;
            }
            
        }

        private void ohjeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ohje ohje = new Ohje();
            DialogResult result = ohje.ShowDialog();
        }

        private void tietojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "You did not enter a server name. Cancel this operation?";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                // Closes the parent form.

                this.Close();

            }
        }

    }
}
