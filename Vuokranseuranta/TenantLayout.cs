using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vuokranseuranta
{
    public partial class TenantLayout : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Projects\program-for-tracking-rental\Vuokranseuranta\vuose_db.mdf;Integrated Security=True;Connect Timeout=30");
        public Tenant te { get; set; }

        public TenantLayout(Tenant ten)
        {
            InitializeComponent();
            this.te = ten;
            textBox1.Text = te.Name;
            textBox2.Text = te.Phone;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "UPDATE Apartment set tenant='" + textBox1.Text + "',tenTel='" + textBox2.Text + "' WHERE Aid =" + te.Aid;
            command = new SqlCommand(sql, con);
            adapter.UpdateCommand = new SqlCommand(sql, con);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Dispose();
            con.Close();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
