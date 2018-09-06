using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vuokranseuranta
{
    public partial class AsLisaaminen : Form
    {
        public AsLisaaminen()
        {
            InitializeComponent();
        }

        string polku = Environment.CurrentDirectory;

        static void CopyDirectory(DirectoryInfo source, DirectoryInfo destination)
        {
            if (!destination.Exists)
            {
                destination.Create();
            }

            // Copy all files.
            FileInfo[] files = source.GetFiles();
            foreach (FileInfo file in files)
            {
                file.CopyTo(Path.Combine(destination.FullName,
                    file.Name));
            }

            // Process subdirectories.
            DirectoryInfo[] dirs = source.GetDirectories();
            foreach (DirectoryInfo dir in dirs)
            {
                // Get destination directory.
                string destinationDir = Path.Combine(destination.FullName, dir.Name);

                // Call CopyDirectory() recursively.
                CopyDirectory(dir, new DirectoryInfo(destinationDir));
            }
        }

        private void btnPeruuta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string folder = tbYhtio.Text + " " + tbNro.Text;

            string folderName = polku + @"\Data\Companies\";
            string pathString = Path.Combine(folderName, folder);
            string sourcePath = polku + @"\Data\Companies\BasicInformation\";      

            string yhtio, nro, kokon;

            yhtio = tbYhtio.Text;
            nro = tbNro.Text;
            kokon = yhtio + " " + nro;

            List<string> tmp = new List<string>();

            StreamReader sr = new StreamReader(polku + @"\Data\companies.txt", Encoding.UTF8);
            string rivi;
            
            while ((rivi = sr.ReadLine()) != null)
            {
                string company = rivi;
                tmp.Add(company);                
            }
            sr.Close();

            tmp.Add(kokon);

            StreamWriter sw = new StreamWriter(polku + @"\Data\companies.txt");
            foreach (var item in tmp)
            {
                sw.WriteLine(item.ToString());                
            }            
            sw.Close();       

            DirectoryInfo src = new DirectoryInfo(sourcePath);
            DirectoryInfo dest = new DirectoryInfo(pathString);
            CopyDirectory(src, dest);
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
