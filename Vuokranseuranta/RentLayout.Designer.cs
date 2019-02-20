namespace Vuokranseuranta
{
    partial class RentLayout
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentLayout));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tulostaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esikatseleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lisääToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asuntoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taloyhtiöToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ohjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ohjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tietojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lisääUusiRiviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(117, 69);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(195, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hae";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Location = new System.Drawing.Point(60, 98);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(709, 282);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(348, 46);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Vuokrat";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(348, 70);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Vastikkeet";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(845, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.lisääToolStripMenuItem,
            this.ohjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tulostaToolStripMenuItem,
            this.esikatseleToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // tulostaToolStripMenuItem
            // 
            this.tulostaToolStripMenuItem.Name = "tulostaToolStripMenuItem";
            this.tulostaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tulostaToolStripMenuItem.Text = "Tulosta";
            this.tulostaToolStripMenuItem.Click += new System.EventHandler(this.tulostaToolStripMenuItem_Click);
            // 
            // esikatseleToolStripMenuItem
            // 
            this.esikatseleToolStripMenuItem.Name = "esikatseleToolStripMenuItem";
            this.esikatseleToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.esikatseleToolStripMenuItem.Text = "Tulostuksen esikatselu";
            this.esikatseleToolStripMenuItem.Click += new System.EventHandler(this.esikatseleToolStripMenuItem_Click);
            // 
            // lisääToolStripMenuItem
            // 
            this.lisääToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asuntoToolStripMenuItem,
            this.taloyhtiöToolStripMenuItem});
            this.lisääToolStripMenuItem.Name = "lisääToolStripMenuItem";
            this.lisääToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.lisääToolStripMenuItem.Text = "Lisää";
            // 
            // asuntoToolStripMenuItem
            // 
            this.asuntoToolStripMenuItem.Name = "asuntoToolStripMenuItem";
            this.asuntoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.asuntoToolStripMenuItem.Text = "Asunto";
            this.asuntoToolStripMenuItem.Click += new System.EventHandler(this.asuntoToolStripMenuItem_Click);
            // 
            // taloyhtiöToolStripMenuItem
            // 
            this.taloyhtiöToolStripMenuItem.Name = "taloyhtiöToolStripMenuItem";
            this.taloyhtiöToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.taloyhtiöToolStripMenuItem.Text = "Taloyhtiö";
            this.taloyhtiöToolStripMenuItem.Click += new System.EventHandler(this.taloyhtiöToolStripMenuItem_Click);
            // 
            // ohjeToolStripMenuItem
            // 
            this.ohjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ohjeToolStripMenuItem1,
            this.tietojaToolStripMenuItem});
            this.ohjeToolStripMenuItem.Name = "ohjeToolStripMenuItem";
            this.ohjeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ohjeToolStripMenuItem.Text = "Ohje";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Taloyhtiö:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Huoneisto:";
            // 
            // ohjeToolStripMenuItem1
            // 
            this.ohjeToolStripMenuItem1.Name = "ohjeToolStripMenuItem1";
            this.ohjeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ohjeToolStripMenuItem1.Text = "Ohje";
            this.ohjeToolStripMenuItem1.Click += new System.EventHandler(this.ohjeToolStripMenuItem1_Click);
            // 
            // tietojaToolStripMenuItem
            // 
            this.tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
            this.tietojaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tietojaToolStripMenuItem.Text = "Tietoja";
            this.tietojaToolStripMenuItem.Click += new System.EventHandler(this.tietojaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lisääUusiRiviToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 26);
            // 
            // lisääUusiRiviToolStripMenuItem
            // 
            this.lisääUusiRiviToolStripMenuItem.Name = "lisääUusiRiviToolStripMenuItem";
            this.lisääUusiRiviToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.lisääUusiRiviToolStripMenuItem.Text = "Lisää uusi rivi";
            // 
            // RentLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 428);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RentLayout";
            this.Text = "Vuose Vuokranseuranta";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tulostaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lisääToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asuntoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taloyhtiöToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ohjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esikatseleToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem ohjeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tietojaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lisääUusiRiviToolStripMenuItem;
    }
}