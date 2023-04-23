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
    public partial class AdministrerAfdeling : Form
    {
        AfdelingDB afdelingDB;

        public AdministrerAfdeling()
        {
            afdelingDB = new AfdelingDB();
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu m = new MainMenu();
            m.Show();
        }

        public void OpdaterListe()
        {
            dataGridView1.DataSource = afdelingDB.HentAfdeling();
            NavnTxtB.Clear();
            PostNrTxtB.Clear();
        }

        private void OpretBT_Click(object sender, EventArgs e)
        {
            string AfdelingsNavn = NavnTxtB.Text;
            int PostNr = Convert.ToInt32(PostNrTxtB.Text);

            if (AfdelingsNavn.Equals("") || PostNr.Equals(""))
            {
                MessageBox.Show("ET FELT ER TOMT! UDFYLD ALLE FELTER OG PRØV IGEN!", "SYSTEMFEJL!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (OpretBT.Enabled)
                {
                    if (afdelingDB.IsAfdelingAlleredeOprettet(AfdelingsNavn, PostNr) == false)
                    {
                        afdelingDB.OpretAfdeling(new Afdeling(AfdelingsNavn, PostNr));

                        MessageBox.Show("Afdeling er nu oprettet i databasen!", "Oprettelse  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OpdaterListe();
                    }
                    else
                    {
                        MessageBox.Show("Afdelingen findes allerede i databasen!", "OprettelsesFejl!  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string AfdelingNavn = ((string)dataGridView1.CurrentRow.Cells[1].Value);
            afdelingDB.SletAfdeling(AfdelingNavn);
            OpdaterListe();
        }

        private void RydFelterBT_Click(object sender, EventArgs e)
        {
            NavnTxtB.Clear();
            PostNrTxtB.Clear();
            AfdelingNrTxtB.Clear();
        }

        private void OpdaterBT_Click(object sender, EventArgs e)
        {
            string afdelingsNavn = NavnTxtB.Text;
            int postNr = Convert.ToInt32(PostNrTxtB.Text);
            int afdelingsNr = Convert.ToInt32(AfdelingNrTxtB.Text);


            if (afdelingsNavn.Equals("") || postNr.Equals("") || afdelingsNr.Equals(""))
            {
                MessageBox.Show("ET FELT ER TOMT! UDFYLD ALLE FELTER OG PRØV IGEN!", "SYSTEMFEJL!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string AfdelingsNavn = Convert.ToString(afdelingsNavn);
                int PostNR = Convert.ToInt32(postNr);
                int AfdelingsNr = Convert.ToInt32(afdelingsNr);

                afdelingDB.OpdaterAfdeling(AfdelingsNr, AfdelingsNavn, PostNR);

                MessageBox.Show("Afdeling er nu opdateret", "Opdatering  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpdaterListe();
            }
        }

   

        private void AdministrerAfdeling_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = afdelingDB.HentAfdeling();
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            AfdelingNrTxtB.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            NavnTxtB.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            PostNrTxtB.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
