using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egyszeru_tanulok
{
    public partial class Form1 : Form
    {
        List<Tanulo> lista=new List<Tanulo>();
        string elsosor;
        string igazolvanyszam;
        void betoltes()
        {
            FileStream fs = new FileStream("tanulo.csv",FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            elsosor=sr.ReadLine();
            while(!sr.EndOfStream)
            {
                Tanulo t = new Tanulo(sr.ReadLine());
                lista.Add(t);
                dgadatok.Rows.Add(t.Nev,t.Igszam);
            }
            sr.Close();
            fs.Close();

            for(int i = 0; i < lista.Count; i++)
            {
                if (!cbvaros.Items.Contains(lista[i].Varos))
                {
                    cbvaros.Items.Add(lista[i].Varos);
                }
            }
            cbvaros.SelectedIndex = 1;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            betoltes();
        }

        private void cxvaltozas_CheckedChanged(object sender, EventArgs e)
        {
            if (cxvaltozas.Checked)
            {
                txigszam.Enabled = true;
            }
            else
            {
                txigszam.Enabled = false;
            }
        }

        private void dgadatok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow sor = dgadatok.Rows[e.RowIndex];
            //igazolvanyszam = sor.Cells["igszam"].Value.ToString();
            //txigszam.Text = igazolvanyszam;
        }

        private void cbvaros_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgadatok.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Varos == cbvaros.Text)
                {
                    dgadatok.Rows.Add(lista[i].Nev, lista[i].Igszam);
                }
            }
        }

        private void dgadatok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow sor = dgadatok.Rows[e.RowIndex];
            igazolvanyszam = sor.Cells["igszam"].Value.ToString();
            txigszam.Text = igazolvanyszam;

            int i = 0;
            while (lista[i].Igszam != igazolvanyszam)
            {
                i++;
            }
            txnev.Text = lista[i].Nev;
            txosztaly.Text = lista[i].Osztaly;
            txirszam.Text = lista[i].Irszam;
            txvaros.Text = lista[i].Varos;
            txutca.Text = lista[i].Utca;
            dtszuldatum.Value = lista[i].Szulido;
        }

        private void btmod_Click(object sender, EventArgs e)
        {
            if (txigszam.TextLength == 0)
            {
                MessageBox.Show("Adja meg az igazolászámot!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txigszam.Focus();
                txigszam.Clear();
            }
            else if (txnev.TextLength == 0)
            {
                MessageBox.Show("Adja meg az igazolászámot!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txnev.Focus();
                txnev.Clear();
            }
            else if (txosztaly.TextLength == 0)
            {
                MessageBox.Show("Adja meg az igazolászámot!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txosztaly.Focus();
                txosztaly.Clear();
            }
            else if (txirszam.TextLength == 0)
            {
                MessageBox.Show("Adja meg az igazolászámot!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txirszam.Focus();
                txirszam.Clear();
            }
            else if (txvaros.TextLength == 0)
            {
                MessageBox.Show("Adja meg az igazolászámot!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txvaros.Focus();
                txvaros.Clear();
            }
            else if (txutca.TextLength == 0)
            {
                MessageBox.Show("Adja meg az igazolászámot!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txutca.Focus();
                txutca.Clear();
            }
            else if (txnev.TextLength == 0)
            {
                MessageBox.Show("Adja meg az igazolászámot!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txnev.Focus();
                txnev.Clear();
            }
            else
            {

            }
        }
    }
}
