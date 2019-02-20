namespace Vuokranseuranta
{
    partial class Seuranta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seuranta));
            this.cbYhtiot = new System.Windows.Forms.ComboBox();
            this.cbVuosi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lisääToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asuntoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ohjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ohjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tietoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewVuokrat = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelVuosi = new System.Windows.Forms.Label();
            this.btnMuuta = new System.Windows.Forms.Button();
            this.labelYhtio = new System.Windows.Forms.Label();
            this.btnAvaa = new System.Windows.Forms.Button();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbYhtiot
            // 
            this.cbYhtiot.FormattingEnabled = true;
            this.cbYhtiot.Location = new System.Drawing.Point(170, 40);
            this.cbYhtiot.Name = "cbYhtiot";
            this.cbYhtiot.Size = new System.Drawing.Size(220, 21);
            this.cbYhtiot.TabIndex = 1;
            // 
            // cbVuosi
            // 
            this.cbVuosi.FormattingEnabled = true;
            this.cbVuosi.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cbVuosi.Location = new System.Drawing.Point(170, 84);
            this.cbVuosi.Name = "cbVuosi";
            this.cbVuosi.Size = new System.Drawing.Size(220, 21);
            this.cbVuosi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asunto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vuosi";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 474);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(655, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lisääToolStripMenuItem,
            this.ohjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lisääToolStripMenuItem
            // 
            this.lisääToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asuntoToolStripMenuItem});
            this.lisääToolStripMenuItem.Name = "lisääToolStripMenuItem";
            this.lisääToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.lisääToolStripMenuItem.Text = "Lisää";
            // 
            // asuntoToolStripMenuItem
            // 
            this.asuntoToolStripMenuItem.Name = "asuntoToolStripMenuItem";
            this.asuntoToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.asuntoToolStripMenuItem.Text = "Asunto";
            this.asuntoToolStripMenuItem.Click += new System.EventHandler(this.asuntoToolStripMenuItem_Click);
            // 
            // ohjeToolStripMenuItem
            // 
            this.ohjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ohjeToolStripMenuItem1,
            this.tietoaToolStripMenuItem});
            this.ohjeToolStripMenuItem.Name = "ohjeToolStripMenuItem";
            this.ohjeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ohjeToolStripMenuItem.Text = "Ohje";
            // 
            // ohjeToolStripMenuItem1
            // 
            this.ohjeToolStripMenuItem1.Name = "ohjeToolStripMenuItem1";
            this.ohjeToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.ohjeToolStripMenuItem1.Text = "Ohje";
            this.ohjeToolStripMenuItem1.Click += new System.EventHandler(this.ohjeToolStripMenuItem1_Click);
            // 
            // tietoaToolStripMenuItem
            // 
            this.tietoaToolStripMenuItem.Name = "tietoaToolStripMenuItem";
            this.tietoaToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.tietoaToolStripMenuItem.Text = "Tietoa";
            this.tietoaToolStripMenuItem.Click += new System.EventHandler(this.tietoaToolStripMenuItem_Click);
            // 
            // listViewVuokrat
            // 
            this.listViewVuokrat.BackColor = System.Drawing.SystemColors.Window;
            this.listViewVuokrat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewVuokrat.GridLines = true;
            this.listViewVuokrat.Location = new System.Drawing.Point(44, 195);
            this.listViewVuokrat.Name = "listViewVuokrat";
            this.listViewVuokrat.Size = new System.Drawing.Size(550, 232);
            this.listViewVuokrat.TabIndex = 0;
            this.listViewVuokrat.UseCompatibleStateImageBehavior = false;
            this.listViewVuokrat.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kuukausi";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Vuokra";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Maksu pvm";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Vastikkeet";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Maksu pvm";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Muistiinpanot";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 156;
            // 
            // labelVuosi
            // 
            this.labelVuosi.AutoSize = true;
            this.labelVuosi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVuosi.Location = new System.Drawing.Point(432, 156);
            this.labelVuosi.Name = "labelVuosi";
            this.labelVuosi.Size = new System.Drawing.Size(0, 25);
            this.labelVuosi.TabIndex = 0;
            // 
            // btnMuuta
            // 
            this.btnMuuta.Location = new System.Drawing.Point(44, 433);
            this.btnMuuta.Name = "btnMuuta";
            this.btnMuuta.Size = new System.Drawing.Size(123, 23);
            this.btnMuuta.TabIndex = 4;
            this.btnMuuta.Text = "Lisää / muokkaa ";
            this.btnMuuta.UseVisualStyleBackColor = true;
            this.btnMuuta.Click += new System.EventHandler(this.btnMuuta_Click);
            // 
            // labelYhtio
            // 
            this.labelYhtio.AutoSize = true;
            this.labelYhtio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYhtio.Location = new System.Drawing.Point(39, 156);
            this.labelYhtio.Name = "labelYhtio";
            this.labelYhtio.Size = new System.Drawing.Size(0, 25);
            this.labelYhtio.TabIndex = 0;
            // 
            // btnAvaa
            // 
            this.btnAvaa.Location = new System.Drawing.Point(44, 120);
            this.btnAvaa.Name = "btnAvaa";
            this.btnAvaa.Size = new System.Drawing.Size(123, 23);
            this.btnAvaa.TabIndex = 3;
            this.btnAvaa.Text = "Avaa";
            this.btnAvaa.UseVisualStyleBackColor = true;
            this.btnAvaa.Click += new System.EventHandler(this.btnAvaa_Click);
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(173, 433);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(123, 23);
            this.btnTallenna.TabIndex = 7;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Seuranta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTallenna);
            this.Controls.Add(this.btnAvaa);
            this.Controls.Add(this.labelYhtio);
            this.Controls.Add(this.btnMuuta);
            this.Controls.Add(this.labelVuosi);
            this.Controls.Add(this.listViewVuokrat);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVuosi);
            this.Controls.Add(this.cbYhtiot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(671, 535);
            this.Name = "Seuranta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seuranta";
            this.Load += new System.EventHandler(this.Seuranta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbYhtiot;
        private System.Windows.Forms.ComboBox cbVuosi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lisääToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asuntoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ohjeToolStripMenuItem;
        private System.Windows.Forms.ListView listViewVuokrat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label labelVuosi;
        private System.Windows.Forms.Button btnMuuta;
        private System.Windows.Forms.Label labelYhtio;
        private System.Windows.Forms.Button btnAvaa;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.ToolStripMenuItem ohjeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tietoaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}