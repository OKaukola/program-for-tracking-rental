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
    public partial class CondominiumLayout : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Projects\program-for-tracking-rental\Vuokranseuranta\vuose_db.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand command;
        SqlDataReader dataReader;
        String sql = "";
        int cid;

        public CondominiumLayout()
        {
            InitializeComponent();

            con.Open();

            sql = "SELECT COUNT(cid) from Condominium";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                cid = Convert.ToInt16(dataReader.GetValue(0)) + 1;
            }
            dataReader.Close();
            command.Dispose();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Haluatko varmasti lisätä taloyhtiön?";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                con.Open();

                sql = "INSERT INTO Condominium (Cid,name,address,city,postalcode) VALUES (@a1,@a2,@a3,@a4,@a5)";
                command = new SqlCommand(sql, con);
                command.Parameters.Add("a1", cid);
                command.Parameters.Add("a2", textBox1.Text);
                command.Parameters.Add("a3", textBox2.Text);
                command.Parameters.Add("a4", textBox3.Text);
                command.Parameters.Add("a5", textBox4.Text);

                command.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
