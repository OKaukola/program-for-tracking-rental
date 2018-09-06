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
    public partial class LisaaMuokkaa : Form
    {
        public Vuokra rent { get; set; }

        public LisaaMuokkaa(Vuokra au)
        {
            InitializeComponent();
            this.rent = au;
        }

        private void LisaaMuokkaa_Load(object sender, EventArgs e)
        {
            tbKuukausi.Text = rent.Kuukausi;
            tbVuokra.Text = rent.Vuokrasumma;
            tbVuokrapvm.Text = rent.Vuokrapvm;
            tbVastike.Text = rent.Vastike;
            tbVastikepvm.Text = rent.Vastikepvm;
            tbMuistiin.Text = rent.Muistiinp;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            rent.Kuukausi = tbKuukausi.Text;
            rent.Vuokrasumma = tbVuokra.Text;
            rent.Vuokrapvm = tbVuokrapvm.Text;
            rent.Vastike = tbVastike.Text;
            rent.Vastikepvm = tbVastikepvm.Text;
            rent.Muistiinp = tbMuistiin.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnPeruuta_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }     
    }
}
