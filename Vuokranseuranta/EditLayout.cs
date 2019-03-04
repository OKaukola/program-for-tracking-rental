using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vuokranseuranta
{
    public partial class EditLayout : Form
    {
        public Vuokra rent { get; set; }

        public EditLayout(Vuokra au)
        {
            InitializeComponent();
            this.rent = au;

            textBox2.Text = rent.Kuukausi;
            textBox1.Text = rent.Vuokrasumma;
            dateTimePicker1.Value = rent.Vuokrapvm;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
