using DelPin___Eksamensprojekt.DBSQL;
using DelPin___Eksamensprojekt.ForretningsLogik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelPin___Eksamensprojekt.GUI
{
    public partial class AdministrerMaskine : Form
    {
        MaskineDB db;
        public AdministrerMaskine()
        {
            db = new MaskineDB();
            InitializeComponent();
        }

        public void OpdaterListe()
        {
            dataGridView1.DataSource = db.HentMaskiner();
            MNavntxtB.Clear();
            PrisTxtB.Clear();
        }


        private void OpretBT_Click(object sender, EventArgs e)
        {
            string mNavn = MNavntxtB.Text;
            string strpris = PrisTxtB.Text;
            string strANr = AfdelingCmB.Text;

            if (mNavn.Equals("") || strpris.Equals("") || strANr.Equals(""))
            {
                MessageBox.Show("ET FELT ER TOMT! UDFYLD ALLE FELTER OG PRØV IGEN!", "SYSTEMFEJL!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (OpretBT.Enabled)
                {
                    double pris = Convert.ToDouble(strpris);
                    int aNr = ((Afdeling)AfdelingCmB.SelectedItem).afdelingsNr;

                    if (db.IsMaskineAlleredeOprettet(mNavn, pris, aNr) == false)
                    {
                        db.OpretMaskine(new Maskine(mNavn, pris, aNr));
                        MessageBox.Show("Maskinen er nu oprettet i databasen!", "Oprettelse  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OpdaterListe();
                    }
                    else
                    {
                        MessageBox.Show("Maskinen er allerede oprettet i databasen!", "OprettelsesFejl  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("ERROR!", "Fejl  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SletBT_Click(object sender, EventArgs e)
        {
            int ressourceNr = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            db.SletMaskine(ressourceNr);
            MessageBox.Show("Den valgte Maskine er nu slettet!", "Ordre Slettet  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpdaterListe();
        }

        private void RydBT_Click(object sender, EventArgs e)
        {
            MNavntxtB.Clear();
            PrisTxtB.Clear();        
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MNavntxtB.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            PrisTxtB.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            foreach (Afdeling afdelinger in AfdelingCmB.Items)
            {
                if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value) == afdelinger.afdelingsNr)
                {
                    AfdelingCmB.SelectedItem = afdelinger;
                }
            }
        }

        private void AdministrerMaskine_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.HentMaskiner();
            AfdelingCmB.DataSource = db.HentAfdelinger();
        }

        private void OpdaterBT_Click(object sender, EventArgs e)
        {
            string maskineNavn = MNavntxtB.Text;
            string strPris = PrisTxtB.Text;
            string strAfdelingsNr = AfdelingCmB.Text;

            if (maskineNavn.Equals("") || strPris.Equals("") || strAfdelingsNr.Equals(""))
            {
                MessageBox.Show("ET FELT ER TOMT! UDFYLD ALLE FELTER OG PRØV IGEN!", "SYSTEMFEJL!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int ressoruceNr = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                double pris = Convert.ToDouble(strPris);
                int afdelingsNr = ((Afdeling)AfdelingCmB.SelectedItem).afdelingsNr;
                db.OpdaterMaskiner(maskineNavn, pris, afdelingsNr, ressoruceNr);
                MessageBox.Show("Maskinen er nu opdateret", "Opdatering  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpdaterListe();
            }
        }

        private void MenuBT_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu m = new MainMenu();
            m.Show();
        }

       
    }
}
