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
            this.searchButton = new System.Windows.Forms.Button();
            this.mainListView = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lisääUusiRiviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asuntoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taloyhtiöToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finnishMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.condominiumLabel = new System.Windows.Forms.Label();
            this.apartLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mcRB = new System.Windows.Forms.RadioButton();
            this.rentRB = new System.Windows.Forms.RadioButton();
            this.tenantButton = new System.Windows.Forms.Button();
            this.hakuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kuluvaVuosiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            // 
            // searchButton
            // 
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.Name = "searchButton";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainListView
            // 
            this.mainListView.ContextMenuStrip = this.contextMenuStrip1;
            this.mainListView.FullRowSelect = true;
            resources.ApplyResources(this.mainListView, "mainListView");
            this.mainListView.MultiSelect = false;
            this.mainListView.Name = "mainListView";
            this.mainListView.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.mainListView.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lisääUusiRiviToolStripMenuItem,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // lisääUusiRiviToolStripMenuItem
            // 
            this.lisääUusiRiviToolStripMenuItem.Name = "lisääUusiRiviToolStripMenuItem";
            resources.ApplyResources(this.lisääUusiRiviToolStripMenuItem, "lisääUusiRiviToolStripMenuItem");
            this.lisääUusiRiviToolStripMenuItem.Click += new System.EventHandler(this.lisääUusiRiviToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.hakuToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printMenuItem,
            this.previewMenuItem,
            this.closeMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // printMenuItem
            // 
            this.printMenuItem.Name = "printMenuItem";
            resources.ApplyResources(this.printMenuItem, "printMenuItem");
            this.printMenuItem.Click += new System.EventHandler(this.tulostaToolStripMenuItem_Click);
            // 
            // previewMenuItem
            // 
            this.previewMenuItem.Name = "previewMenuItem";
            resources.ApplyResources(this.previewMenuItem, "previewMenuItem");
            this.previewMenuItem.Click += new System.EventHandler(this.esikatseleToolStripMenuItem_Click);
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            resources.ApplyResources(this.closeMenuItem, "closeMenuItem");
            this.closeMenuItem.Click += new System.EventHandler(this.suljeToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asuntoToolStripMenuItem,
            this.taloyhtiöToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            resources.ApplyResources(this.addToolStripMenuItem, "addToolStripMenuItem");
            // 
            // asuntoToolStripMenuItem
            // 
            this.asuntoToolStripMenuItem.Name = "asuntoToolStripMenuItem";
            resources.ApplyResources(this.asuntoToolStripMenuItem, "asuntoToolStripMenuItem");
            this.asuntoToolStripMenuItem.Click += new System.EventHandler(this.asuntoToolStripMenuItem_Click);
            // 
            // taloyhtiöToolStripMenuItem
            // 
            this.taloyhtiöToolStripMenuItem.Name = "taloyhtiöToolStripMenuItem";
            resources.ApplyResources(this.taloyhtiöToolStripMenuItem, "taloyhtiöToolStripMenuItem");
            this.taloyhtiöToolStripMenuItem.Click += new System.EventHandler(this.taloyhtiöToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finnishMenuItem,
            this.englishMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // finnishMenuItem
            // 
            this.finnishMenuItem.CheckOnClick = true;
            this.finnishMenuItem.Name = "finnishMenuItem";
            resources.ApplyResources(this.finnishMenuItem, "finnishMenuItem");
            this.finnishMenuItem.Click += new System.EventHandler(this.suomiToolStripMenuItem_Click);
            // 
            // englishMenuItem
            // 
            this.englishMenuItem.CheckOnClick = true;
            this.englishMenuItem.Name = "englishMenuItem";
            resources.ApplyResources(this.englishMenuItem, "englishMenuItem");
            this.englishMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenuItem,
            this.aboutMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Name = "helpMenuItem";
            resources.ApplyResources(this.helpMenuItem, "helpMenuItem");
            this.helpMenuItem.Click += new System.EventHandler(this.ohjeToolStripMenuItem1_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            resources.ApplyResources(this.aboutMenuItem, "aboutMenuItem");
            this.aboutMenuItem.Click += new System.EventHandler(this.tietojaToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // condominiumLabel
            // 
            resources.ApplyResources(this.condominiumLabel, "condominiumLabel");
            this.condominiumLabel.Name = "condominiumLabel";
            // 
            // apartLabel
            // 
            resources.ApplyResources(this.apartLabel, "apartLabel");
            this.apartLabel.Name = "apartLabel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mcRB);
            this.groupBox1.Controls.Add(this.rentRB);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // mcRB
            // 
            resources.ApplyResources(this.mcRB, "mcRB");
            this.mcRB.Name = "mcRB";
            this.mcRB.UseVisualStyleBackColor = true;
            // 
            // rentRB
            // 
            resources.ApplyResources(this.rentRB, "rentRB");
            this.rentRB.Checked = true;
            this.rentRB.Name = "rentRB";
            this.rentRB.TabStop = true;
            this.rentRB.UseVisualStyleBackColor = true;
            // 
            // tenantButton
            // 
            resources.ApplyResources(this.tenantButton, "tenantButton");
            this.tenantButton.Name = "tenantButton";
            this.tenantButton.UseVisualStyleBackColor = true;
            this.tenantButton.Click += new System.EventHandler(this.tenantButton_Click);
            // 
            // hakuToolStripMenuItem
            // 
            this.hakuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kuluvaVuosiMenuItem});
            this.hakuToolStripMenuItem.Name = "hakuToolStripMenuItem";
            resources.ApplyResources(this.hakuToolStripMenuItem, "hakuToolStripMenuItem");
            // 
            // kuluvaVuosiMenuItem
            // 
            this.kuluvaVuosiMenuItem.Name = "kuluvaVuosiMenuItem";
            resources.ApplyResources(this.kuluvaVuosiMenuItem, "kuluvaVuosiMenuItem");
            this.kuluvaVuosiMenuItem.Click += new System.EventHandler(this.kuluvaVuosiToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // RentLayout
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tenantButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.apartLabel);
            this.Controls.Add(this.condominiumLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mainListView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RentLayout";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RentLayout_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView mainListView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asuntoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taloyhtiöToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label condominiumLabel;
        private System.Windows.Forms.Label apartLabel;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lisääUusiRiviToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton mcRB;
        private System.Windows.Forms.RadioButton rentRB;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finnishMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
        private System.Windows.Forms.Button tenantButton;
        private System.Windows.Forms.ToolStripMenuItem hakuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kuluvaVuosiMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}