namespace egyszeru_tanulok
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgadatok = new System.Windows.Forms.DataGridView();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbvaros = new System.Windows.Forms.ComboBox();
            this.cxvaltozas = new System.Windows.Forms.CheckBox();
            this.txigszam = new System.Windows.Forms.TextBox();
            this.txosztaly = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txnev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtszuldatum = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txirszam = new System.Windows.Forms.TextBox();
            this.txvaros = new System.Windows.Forms.TextBox();
            this.txutca = new System.Windows.Forms.TextBox();
            this.btmod = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txuzenet = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgadatok);
            this.groupBox1.Controls.Add(this.cbvaros);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Válasszon települést!";
            // 
            // dgadatok
            // 
            this.dgadatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgadatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nev,
            this.igszam});
            this.dgadatok.Location = new System.Drawing.Point(19, 80);
            this.dgadatok.Name = "dgadatok";
            this.dgadatok.Size = new System.Drawing.Size(278, 273);
            this.dgadatok.TabIndex = 1;
            this.dgadatok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgadatok_CellClick);
            this.dgadatok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgadatok_CellContentClick);
            // 
            // nev
            // 
            this.nev.HeaderText = "Név";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            // 
            // igszam
            // 
            this.igszam.HeaderText = "Igazolvány";
            this.igszam.Name = "igszam";
            this.igszam.ReadOnly = true;
            // 
            // cbvaros
            // 
            this.cbvaros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbvaros.FormattingEnabled = true;
            this.cbvaros.Location = new System.Drawing.Point(17, 47);
            this.cbvaros.Name = "cbvaros";
            this.cbvaros.Size = new System.Drawing.Size(280, 21);
            this.cbvaros.TabIndex = 0;
            this.cbvaros.SelectedIndexChanged += new System.EventHandler(this.cbvaros_SelectedIndexChanged);
            // 
            // cxvaltozas
            // 
            this.cxvaltozas.AutoSize = true;
            this.cxvaltozas.Location = new System.Drawing.Point(373, 23);
            this.cxvaltozas.Name = "cxvaltozas";
            this.cxvaltozas.Size = new System.Drawing.Size(152, 17);
            this.cxvaltozas.TabIndex = 1;
            this.cxvaltozas.Text = "Igazolvány száma változik!";
            this.cxvaltozas.UseVisualStyleBackColor = true;
            this.cxvaltozas.CheckedChanged += new System.EventHandler(this.cxvaltozas_CheckedChanged);
            // 
            // txigszam
            // 
            this.txigszam.Enabled = false;
            this.txigszam.Location = new System.Drawing.Point(464, 74);
            this.txigszam.Name = "txigszam";
            this.txigszam.Size = new System.Drawing.Size(100, 20);
            this.txigszam.TabIndex = 2;
            // 
            // txosztaly
            // 
            this.txosztaly.Location = new System.Drawing.Point(636, 74);
            this.txosztaly.Name = "txosztaly";
            this.txosztaly.Size = new System.Drawing.Size(45, 20);
            this.txosztaly.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Igazolvány szám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Osztály:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Név:";
            // 
            // txnev
            // 
            this.txnev.Location = new System.Drawing.Point(464, 115);
            this.txnev.Name = "txnev";
            this.txnev.Size = new System.Drawing.Size(217, 20);
            this.txnev.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Született:";
            // 
            // dtszuldatum
            // 
            this.dtszuldatum.CustomFormat = "yyyy. MMMM dd.";
            this.dtszuldatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtszuldatum.Location = new System.Drawing.Point(464, 155);
            this.dtszuldatum.Name = "dtszuldatum";
            this.dtszuldatum.Size = new System.Drawing.Size(217, 20);
            this.dtszuldatum.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lakcím:";
            // 
            // txirszam
            // 
            this.txirszam.Location = new System.Drawing.Point(464, 195);
            this.txirszam.Name = "txirszam";
            this.txirszam.Size = new System.Drawing.Size(52, 20);
            this.txirszam.TabIndex = 11;
            // 
            // txvaros
            // 
            this.txvaros.Location = new System.Drawing.Point(464, 221);
            this.txvaros.Name = "txvaros";
            this.txvaros.Size = new System.Drawing.Size(217, 20);
            this.txvaros.TabIndex = 12;
            // 
            // txutca
            // 
            this.txutca.Location = new System.Drawing.Point(464, 247);
            this.txutca.Name = "txutca";
            this.txutca.Size = new System.Drawing.Size(217, 20);
            this.txutca.TabIndex = 13;
            // 
            // btmod
            // 
            this.btmod.Location = new System.Drawing.Point(380, 281);
            this.btmod.Name = "btmod";
            this.btmod.Size = new System.Drawing.Size(301, 45);
            this.btmod.TabIndex = 14;
            this.btmod.Text = "Adatok módosítása";
            this.btmod.UseVisualStyleBackColor = true;
            this.btmod.Click += new System.EventHandler(this.btmod_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txuzenet);
            this.panel1.Location = new System.Drawing.Point(380, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 47);
            this.panel1.TabIndex = 15;
            // 
            // txuzenet
            // 
            this.txuzenet.AutoSize = true;
            this.txuzenet.Location = new System.Drawing.Point(143, 18);
            this.txuzenet.Name = "txuzenet";
            this.txuzenet.Size = new System.Drawing.Size(41, 13);
            this.txuzenet.TabIndex = 0;
            this.txuzenet.Text = "Üzenet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btmod);
            this.Controls.Add(this.txutca);
            this.Controls.Add(this.txvaros);
            this.Controls.Add(this.txirszam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtszuldatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txnev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txosztaly);
            this.Controls.Add(this.txigszam);
            this.Controls.Add(this.cxvaltozas);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tanulók adatai";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgadatok;
        private System.Windows.Forms.ComboBox cbvaros;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn igszam;
        private System.Windows.Forms.CheckBox cxvaltozas;
        private System.Windows.Forms.TextBox txigszam;
        private System.Windows.Forms.TextBox txosztaly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txnev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtszuldatum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txirszam;
        private System.Windows.Forms.TextBox txvaros;
        private System.Windows.Forms.TextBox txutca;
        private System.Windows.Forms.Button btmod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txuzenet;
    }
}

