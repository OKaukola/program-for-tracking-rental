using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Globalization;
using System.Resources;


namespace Vuokranseuranta
{
    public partial class RentLayout : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Projects\program-for-tracking-rental\Vuokranseuranta\vuose_db.mdf;Integrated Security=True;Connect Timeout=30");
        private List<string> vuokrat = new List<string>();
        public string language = Properties.Settings.Default.Language;
        SqlCommand command;
        SqlDataReader dataReader;
        String sql = "";
        string cid, aid;

        public RentLayout()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();

            con.Open();

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

        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(LoadingLayout));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        private void RentLayout_Load(object sender, EventArgs e)
        {

        }

        public void SplashStart()
        {
            Application.Run(new LoadingLayout());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            con.Open();

            sql = "Select Cid from Condominium where name = '" + comboBox1.SelectedItem + "'";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cid = dataReader.GetValue(0).ToString();
            }
            dataReader.Close();
            command.Dispose();
            con.Close();

            if (cid != null)
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
            if (comboBox2.SelectedItem != null)
            {
                con.Open();

                sql = "Select Aid from Apartment where apartNro = '" + comboBox2.SelectedItem + "' AND cid = '" + cid + "'";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    aid = dataReader.GetValue(0).ToString();
                }
                dataReader.Close();
                command.Dispose();
                con.Close();

                if (rentRB.Checked)
                {
                    if (aid != null)
                    {
                        mainListView.Clear();
                        con.Open();
                        sql = "SELECT year, january, february, march, april, may, june, july, august, september, october, november, december FROM Rent re JOIN Apartment ap ON re.Aid = ap.Aid WHERE re.Aid = " + aid;

                        command = new SqlCommand(sql, con);
                        dataReader = command.ExecuteReader();

                        // Set to details view.
                        mainListView.View = View.Details;
                        // Add a column with width 20 and left alignment.
                        mainListView.Columns.Add("Vuosi", 50, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Tammikuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Helmikuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Maaliskuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Huhtikuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Toukokuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Kesäkuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Heinäkuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Elokuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Syyskuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Lokakuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Marraskuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Joulukuu", 80, HorizontalAlignment.Left);

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

                            mainListView.Items.Add(i);

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
                if (mcRB.Checked)
                {
                    if (aid != null)
                    {
                        mainListView.Clear();
                        con.Open();
                        sql = "SELECT year, january, february, march, april, may, june, july, august, september, october, november, december FROM MaintenanceCharge mc JOIN Apartment ap ON mc.Aid = ap.Aid WHERE mc.Aid = " + aid;

                        command = new SqlCommand(sql, con);
                        dataReader = command.ExecuteReader();

                        // Set to details view.
                        mainListView.View = View.Details;
                        // Add a column with width 20 and left alignment.
                        mainListView.Columns.Add("Vuosi", 50, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Tammikuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Helmikuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Maaliskuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Huhtikuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Toukokuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Kesäkuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Heinäkuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Elokuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Syyskuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Lokakuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Marraskuu", 80, HorizontalAlignment.Left);
                        mainListView.Columns.Add("Joulukuu", 80, HorizontalAlignment.Left);

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

                            mainListView.Items.Add(i);
                        }

                        dataReader.Close();
                        command.Dispose();
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Valitse yhtiö ja asunto");
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
            RectangleF destinationRect = new RectangleF(25, 20, .07f * width, .07f * height);
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
            HelpLayout ohje = new HelpLayout();
            DialogResult result = ohje.ShowDialog();
        }

        private void tietojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutLayout about = new AboutLayout();
            DialogResult result = about.ShowDialog();
            /*
            string message = "You did not enter a server name. Cancel this operation?";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                // Closes the parent form.

                this.Close();

            }*/
        }

        private void lisääUusiRiviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aid != null)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                string currentYear = DateTime.Today.Year.ToString();
                con.Open();
                sql = "INSERT INTO Rent (year,Aid) VALUES(" + currentYear + "," + aid + ")";

                command = new SqlCommand(sql, con);
                adapter.InsertCommand = new SqlCommand(sql, con);
                adapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();
                con.Close();
            }
            else
            {
                MessageBox.Show("Hae huoneisto");
            }
        }

        private void suomiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            language = "fi-FI";
            finnishMenuItem.Checked = true;
            englishMenuItem.Checked = false;

            Properties.Settings.Default.Language = "fi-FI";
            Properties.Settings.Default.Save();

            Application.Restart();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            language = "en-US";
            englishMenuItem.Checked = true;
            finnishMenuItem.Checked = false;

            Properties.Settings.Default.Language = "en-US";
            Properties.Settings.Default.Save();

            Application.Restart();
        }

        private void suljeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tenantButton_Click(object sender, EventArgs e)
        {
            if (aid != null)
            {
                Tenant ten = new Tenant();
                con.Open();

                sql = "SELECT Aid,tenant,tenTel FROM Apartment WHERE apartNro = '" + comboBox2.SelectedItem + "' AND cid = '" + cid + "'";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ten.Aid = Int32.Parse(dataReader.GetValue(0).ToString());
                    ten.Name = dataReader.GetValue(1).ToString();
                    ten.Phone = dataReader.GetValue(2).ToString();
                    ten.Cid = Int32.Parse(cid);
                }
                dataReader.Close();
                command.Dispose();
                con.Close();

                TenantLayout tenant = new TenantLayout(ten);
                DialogResult result = tenant.ShowDialog();
            }
            else
            {
                MessageBox.Show("Valitse huoneisto");
            }
        }

        private void kuluvaVuosiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentYear = DateTime.Today.Year.ToString();
            con.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql = "";
            mainListView.Clear();

            sql = "SELECT ap.apartNro, co.name, january, february, march, april, may, june, july, august, september, october, november, december FROM Rent re JOIN Apartment ap ON re.Aid=ap.Aid JOIN Condominium co ON ap.Cid = co.Cid  WHERE re.year = " + currentYear;

            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();

            // Set to details view.
            mainListView.View = View.Details;
            // Add a column with width 20 and left alignment.
            mainListView.Columns.Add("Huoneisto", 130, HorizontalAlignment.Left);
            mainListView.Columns.Add("Tammikuu", 80, HorizontalAlignment.Left);
            mainListView.Columns.Add("Helmikuu", 80, HorizontalAlignment.Left);
            mainListView.Columns.Add("Maaliskuu", 80, HorizontalAlignment.Left);
            mainListView.Columns.Add("Huhtikuu", 80, HorizontalAlignment.Left);
            mainListView.Columns.Add("Toukokuu", 80, HorizontalAlignment.Left);
            mainListView.Columns.Add("Kesäkuu", 80, HorizontalAlignment.Left);
            mainListView.Columns.Add("Heinäkuu", 80, HorizontalAlignment.Left);
            mainListView.Columns.Add("Elokuu", 80, HorizontalAlignment.Left);
            mainListView.Columns.Add("Syyskuu", 80, HorizontalAlignment.Left);
            mainListView.Columns.Add("Lokakuu", 80, HorizontalAlignment.Left);
            mainListView.Columns.Add("Marraskuu", 80, HorizontalAlignment.Left);
            mainListView.Columns.Add("Joulukuu", 80, HorizontalAlignment.Left);

            while (dataReader.Read())
            {
                string apart = dataReader.GetValue(1).ToString() + " " + dataReader.GetValue(0).ToString();
                ListViewItem i = new ListViewItem(apart);
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
                i.SubItems.Add(dataReader.GetValue(13).ToString());

                mainListView.Items.Add(i);

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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int index;

            if (mainListView.SelectedItems.Count > 0)
            {
                ListViewItem item = mainListView.SelectedItems[i];
                index = mainListView.FocusedItem.Index;

                string pvm = "12.01.2018";
                DateTime parsedDate = DateTime.Parse(pvm);

                string kuukausi = "Tammikuu";

                Vuokra au = new Vuokra(kuukausi, item.SubItems[1].Text, parsedDate);

                EditLayout editLayout = new EditLayout(au);
                DialogResult result = editLayout.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var item2 = new ListViewItem(new[] { au.Kuukausi });//, au.Vuokrasumma, au.Vuokrapvm, au.Vastike, au.Vastikepvm, au.Muistiinp });
                    mainListView.Items.RemoveAt(index);
                    mainListView.Items.Insert(index, item2);
                }
            }
            else
            {
                MessageBox.Show("Valiste muokattava kuukausi");
            }
        }
    }
}
