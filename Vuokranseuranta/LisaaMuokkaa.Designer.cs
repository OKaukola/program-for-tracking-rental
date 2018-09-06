namespace Vuokranseuranta
{
    partial class LisaaMuokkaa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LisaaMuokkaa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVuokra = new System.Windows.Forms.TextBox();
            this.tbVastike = new System.Windows.Forms.TextBox();
            this.tbMuistiin = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbKuukausi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVuokrapvm = new System.Windows.Forms.TextBox();
            this.tbVastikepvm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vuokra summa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maksu pvm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vastike summa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Masku pvm";
            // 
            // tbVuokra
            // 
            this.tbVuokra.Location = new System.Drawing.Point(122, 60);
            this.tbVuokra.Name = "tbVuokra";
            this.tbVuokra.Size = new System.Drawing.Size(208, 20);
            this.tbVuokra.TabIndex = 1;
            // 
            // tbVastike
            // 
            this.tbVastike.Location = new System.Drawing.Point(122, 112);
            this.tbVastike.Name = "tbVastike";
            this.tbVastike.Size = new System.Drawing.Size(208, 20);
            this.tbVastike.TabIndex = 3;
            // 
            // tbMuistiin
            // 
            this.tbMuistiin.Location = new System.Drawing.Point(122, 165);
            this.tbMuistiin.Name = "tbMuistiin";
            this.tbMuistiin.Size = new System.Drawing.Size(208, 96);
            this.tbMuistiin.TabIndex = 5;
            this.tbMuistiin.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Muistiinpanot";
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.Location = new System.Drawing.Point(198, 280);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(123, 23);
            this.btnPeruuta.TabIndex = 7;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            this.btnPeruuta.Click += new System.EventHandler(this.btnPeruuta_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(47, 280);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(123, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbKuukausi
            // 
            this.tbKuukausi.Enabled = false;
            this.tbKuukausi.Location = new System.Drawing.Point(122, 34);
            this.tbKuukausi.Name = "tbKuukausi";
            this.tbKuukausi.ReadOnly = true;
            this.tbKuukausi.Size = new System.Drawing.Size(208, 20);
            this.tbKuukausi.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kuukausi";
            // 
            // tbVuokrapvm
            // 
            this.tbVuokrapvm.Location = new System.Drawing.Point(122, 86);
            this.tbVuokrapvm.Name = "tbVuokrapvm";
            this.tbVuokrapvm.Size = new System.Drawing.Size(208, 20);
            this.tbVuokrapvm.TabIndex = 2;
            // 
            // tbVastikepvm
            // 
            this.tbVastikepvm.Location = new System.Drawing.Point(122, 139);
            this.tbVastikepvm.Name = "tbVastikepvm";
            this.tbVastikepvm.Size = new System.Drawing.Size(208, 20);
            this.tbVastikepvm.TabIndex = 4;
            // 
            // LisaaMuokkaa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 337);
            this.Controls.Add(this.tbVastikepvm);
            this.Controls.Add(this.tbVuokrapvm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbKuukausi);
            this.Controls.Add(this.btnPeruuta);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMuistiin);
            this.Controls.Add(this.tbVastike);
            this.Controls.Add(this.tbVuokra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(384, 376);
            this.MinimumSize = new System.Drawing.Size(384, 376);
            this.Name = "LisaaMuokkaa";
            this.Text = "Lisää ja muokkaa";
            this.Load += new System.EventHandler(this.LisaaMuokkaa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVuokra;
        private System.Windows.Forms.TextBox tbVastike;
        private System.Windows.Forms.RichTextBox tbMuistiin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPeruuta;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbKuukausi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVuokrapvm;
        private System.Windows.Forms.TextBox tbVastikepvm;
    }
}