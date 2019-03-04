using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vuokranseuranta
{
    public partial class ApartLayout : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Projects\program-for-tracking-rental\Vuokranseuranta\vuose_db.mdf;Integrated Security=True;Connect Timeout=30");
        int cid;

        public ApartLayout()
        {

            InitializeComponent();

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
                //cid = Convert.ToInt16(dataReader.GetValue(1));
            }
            dataReader.Close();
            command.Dispose();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Haluatko varmasti lisätä huoneiston?";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                con.Open();
                SqlCommand command;
                String sql = "";
                int aid = 0;

                SqlDataReader dataReader;

                sql = "SELECT COUNT(aid) FROM Apartment";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    aid = Convert.ToInt32(dataReader.GetValue(0)) + 1;
                }
                dataReader.Close();
                command.Dispose();
                con.Close();

                con.Open();
                sql = "INSERT INTO Apartment (Aid,apartNro,Cid) VALUES (@a1,@a2,@a3)";
                command = new SqlCommand(sql, con);
                command.Parameters.Add("a1", aid);
                command.Parameters.Add("a2", textBox1.Text);
                command.Parameters.Add("a3", cid);

                command.ExecuteNonQuery();
                con.Close();

                // Closes the parent form.
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql = "";
            string test = comboBox1.Text;


            sql = "Select cid from Condominium WHERE name = @a1";
            command = new SqlCommand(sql, con);
            command.Parameters.Add("a1", test);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                cid = Convert.ToInt16(dataReader.GetValue(0));
            }
            dataReader.Close();
            command.Dispose();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
