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
    public partial class AdministrerKunde : Form
    {
        KundeDB kundeDB;

        public AdministrerKunde()
        {
            kundeDB = new KundeDB();
            InitializeComponent();
        }

        public void OpdaterListe()
        {
            dataGridView1.DataSource = kundeDB.HentKunde();
            NavnTxtB.Clear();
            PinkodeTxtB.Clear();
        }


        private void SletBT_Click(object sender, EventArgs e)
        {
            string Kundenavn = ((string)dataGridView1.CurrentRow.Cells[1].Value);
            kundeDB.SletKunde(Kundenavn);
            OpdaterListe();

        }

       

        private void RydFelterBT_Click(object sender, EventArgs e)
        {
            NavnTxtB.Clear();
            PinkodeTxtB.Clear();
        }

        private void OpretBT_Click(object sender, EventArgs e)
        {
            string kundeNavn = NavnTxtB.Text;
            int pinKode = Convert.ToInt32(PinkodeTxtB.Text);
            string aafdelingsNr = Convert.ToString(AfdelingComB.Text);

            if (kundeNavn.Equals("") || pinKode.Equals("") || aafdelingsNr.Equals(""))
            {
                MessageBox.Show("ET FELT ER TOMT! UDFYLD ALLE FELTER OG PRØV IGEN!", "SYSTEMFEJL!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (OpretBT.Enabled)
                {
                    int afdelingsNr = ((Afdeling)AfdelingComB.SelectedItem).afdelingsNr;

                    if (kundeDB.IsKundeAlleredeOprettet(kundeNavn, pinKode) == false)
                    {
                        kundeDB.OpretKunde(new Kunde(kundeNavn, pinKode, afdelingsNr));

                        MessageBox.Show("Kunden er nu oprettet i databasen!", "Oprettelse  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OpdaterListe();
                    }
                    else
                    {
                        MessageBox.Show("Kunden findes allerede i databasen med samme navn og kode!", "OprettelsesFejl!  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    

                }
                else
                {
                    MessageBox.Show("ERROR!", "Fejl  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void RedigereBT_Click(object sender, EventArgs e)
        {
            string Navn = NavnTxtB.Text;
            string Pinkode = PinkodeTxtB.Text;
            string strAfdelingsNr = AfdelingComB.Text;
            string KundeNR = KundeNrTxtB.Text;

            
            if (Navn.Equals("") || Pinkode.Equals("") || strAfdelingsNr.Equals(""))
            {
                MessageBox.Show("ET FELT ER TOMT! UDFYLD ALLE FELTER OG PRØV IGEN!", "SYSTEMFEJL!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string kundeNavn = Convert.ToString(Navn);
                int pinKode = Convert.ToInt32(Pinkode);
                int afdelingsNr = ((Afdeling)AfdelingComB.SelectedItem).afdelingsNr;
                int kundeNr = Convert.ToInt32(KundeNR);

                kundeDB.OpdaterKunde(kundeNavn, pinKode, afdelingsNr, kundeNr);
                
                MessageBox.Show("Kunden er nu opdateret", "Opdatering  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpdaterListe();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KundeNrTxtB.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            NavnTxtB.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            PinkodeTxtB.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            foreach (Afdeling afdelinger in AfdelingComB.Items)
            {
                if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value) == afdelinger.afdelingsNr)
                {
                    AfdelingComB.SelectedItem = afdelinger;
                }
            }
        }

        private void AdministrerKunde_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kundeDB.HentKunde();
            AfdelingComB.DataSource = kundeDB.HentAfdelinger();
        }

        private void MenuBT_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu m = new MainMenu();
            m.Show();
        }

        private void KundeTypeBT_Click(object sender, EventArgs e)
        {
            string Navn = NavnTxtB.Text;
            string Pinkode = PinkodeTxtB.Text;
            string strAfdelingsNr = AfdelingComB.Text;
            int kundeNr = Convert.ToInt32(KundeNrTxtB.Text);


            if (Navn.Equals("") || Pinkode.Equals("") || strAfdelingsNr.Equals("") || kundeNr.Equals(""))
            {
                MessageBox.Show("ET FELT ER TOMT! UDFYLD ALLE FELTER OG PRØV IGEN!", "SYSTEMFEJL!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                //int kundeNr = Convert.ToInt32(kundeNr);
                //int kundeNr = ((int)dataGridView1.CurrentRow.Cells[0].Value);


                kundeDB.SetKundetype(kundeNr);

                MessageBox.Show("Kunden er nu opdateret", "Opdatering  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpdaterListe();
            }
            
        }

       
    }
}
