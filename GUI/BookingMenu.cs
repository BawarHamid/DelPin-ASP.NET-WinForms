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
    public partial class BookingMenu : Form
    {
        OrdreDB ordreDB;
        MaskineDB maskineDB;
        BookingDB bookingDB;
        int kundeNr = 0;

        public BookingMenu(int kundeNr)
        {
            this.kundeNr = kundeNr;

            ordreDB = new OrdreDB();
            maskineDB = new MaskineDB();
            bookingDB = new BookingDB();

            InitializeComponent();

            if (this.kundeNr > 0)
            {
                KundeNrTxtB.Text = this.kundeNr.ToString();
                KundeNrTxtB.Enabled = false;
            }
            else
            {
                KundeNrTxtB.Enabled = true;
            }
        }

        private void BookingMenu_Load(object sender, EventArgs e)
        {
            AfdelingCmB.DataSource = maskineDB.HentAfdelinger();
            dataGridView1.DataSource = ordreDB.HentOrdre(kundeNr);
            dataGridView2.DataSource = bookingDB.HentBookinger();
        }

        private void AfdelingCmB_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaskineCmB.DataSource = maskineDB.HentMaskinerUdFraAfdeling(((Afdeling)AfdelingCmB.SelectedItem).afdelingsNr);
        }

        private void MenuBT_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu m = new MainMenu();
            m.Show();
        }

        public void OpdaterListe()
        {
            dataGridView1.DataSource = ordreDB.HentOrdre(kundeNr);
            dataGridView2.DataSource = bookingDB.HentBookinger();
            if (this.kundeNr <= 0)
                KundeNrTxtB.Clear();
        }

        private void OpretOrdreBT_Click(object sender, EventArgs e)
        {
            string strkundeNr = KundeNrTxtB.Text;

            if (strkundeNr.Equals(""))
            {
                MessageBox.Show("ET FELT ER TOMT! UDFYLD ALLE FELTER OG PRØV IGEN!", "SYSTEMFEJL!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (OpretOrdreBT.Enabled)
                {
                    int kundeNr = Convert.ToInt32(strkundeNr);
                    ordreDB.OpretOrdre(new Ordre(kundeNr));
                    MessageBox.Show("Din Ordre er nu oprettet!", "Oprettelse  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpdaterListe();

                }
                else
                {
                    MessageBox.Show("ERROR!", "Fejl  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void OpdaterOrdreBT_Click(object sender, EventArgs e)
        {
            string strKundeNr = KundeNrTxtB.Text;

            if (strKundeNr.Equals(""))
            {
                MessageBox.Show("ET FELT ER TOMT! UDFYLD ALLE FELTER OG PRØV IGEN!", "SYSTEMFEJL!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int ordreNr = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                int kundeNr = Convert.ToInt32(strKundeNr);
                ordreDB.OpdaterOrdre(ordreNr, kundeNr);
                MessageBox.Show("Ordren er nu opdateret", "Opdatering  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpdaterListe();
            }
        }

        private void SletOrdreBT_Click(object sender, EventArgs e)
        {
            int ordreNr = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ordreDB.SletOrdre(ordreNr);
            MessageBox.Show("Den valgte Ordre er nu slettet!", "Ordre Slettet  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpdaterListe();
        }

        private void RydFelterOrdreBT_Click(object sender, EventArgs e)
        {
            if (this.kundeNr <= 0)
                KundeNrTxtB.Clear();
        }

        private void OpretBookingBT_Click(object sender, EventArgs e)
        {
            string strOrdreNr = OrdreNrTxtB.Text;
            string strStartsDato = dateTimePicker1.Text;
            string strSlutDato = dateTimePicker2.Text;
            string strRessourceNr = MaskineCmB.Text;

            if (strOrdreNr.Equals("") || strStartsDato.Equals("") || strSlutDato.Equals("") || strRessourceNr.Equals(""))
            {
                MessageBox.Show("ET FELT ER TOMT! UDFYLD ALLE FELTER OG PRØV IGEN!", "SYSTEMFEJL!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (OpretBookingBT.Enabled)
                {
                    int ordreNr = Convert.ToInt32(strOrdreNr);
                    DateTime startsDato = dateTimePicker1.Value.Date;
                    DateTime slutDato = dateTimePicker2.Value.Date;
                    int ressourceNr = ((Maskine)MaskineCmB.SelectedItem).ressourceNr;
                    DateTime dagensDato = DateTime.Now.Date;

                    if (startsDato < dagensDato)
                    {
                        MessageBox.Show("Den valgte periode er i fortiden!", "DatoFejl!  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (startsDato > slutDato)
                        {
                            MessageBox.Show("StartsDatoen må ikke være efter SlutDatoen!", "DatoFejl!  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (bookingDB.IsMaskineOptagetDato(startsDato, slutDato, ressourceNr) == false)
                            {
                                bookingDB.OpretBooking(new Booking(startsDato, slutDato, ressourceNr, ordreNr));
                                MessageBox.Show("Bookingen er nu oprettet i databasen!", "Oprettelse  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                OpdaterListe();
                            }
                            else
                            {
                                MessageBox.Show("Maskinen er optaget i valgte periode!", "BookingFejl!  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ERROR!", "Fejl  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void OpdaterBookingBT_Click(object sender, EventArgs e)
        {
            string strStartsDato = dateTimePicker1.Text;
            string strSlutDato = dateTimePicker2.Text;
            string strRessourceNr = MaskineCmB.Text;
            string strOrdreNr = OrdreNrTxtB.Text;

            if (strOrdreNr.Equals("") || strStartsDato.Equals("") || strSlutDato.Equals("") || strRessourceNr.Equals(""))
            {
                MessageBox.Show("ET FELT ER TOMT! UDFYLD ALLE FELTER OG PRØV IGEN!", "SYSTEMFEJL!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int bookingNr = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                DateTime startsDato = Convert.ToDateTime(strStartsDato);
                DateTime slutDato = Convert.ToDateTime(strSlutDato);
                int ressourceNr = ((Maskine)MaskineCmB.SelectedItem).ressourceNr;
                int ordreNr = Convert.ToInt32(strOrdreNr);
                bookingDB.OpdaterBooking(bookingNr, startsDato, slutDato, ressourceNr, ordreNr);
                MessageBox.Show("Bookingen er nu opdateret", "Opdateret...:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpdaterListe();
            }
        }

        private void SletBookingBT_Click(object sender, EventArgs e)
        {
            int bookingNr = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            bookingDB.SletBooking(bookingNr);
            MessageBox.Show("Den valgte Booking er nu slettet!", "Ordre Slettet  :", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpdaterListe();
        }

        private void RydFelterBookingBT_Click(object sender, EventArgs e)
        {
            OrdreNrTxtB.Clear();
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker1.Value = ((DateTime)dataGridView2.CurrentRow.Cells[1].Value);
            dateTimePicker2.Value = ((DateTime)dataGridView2.CurrentRow.Cells[2].Value);

            Afdeling afdeling = maskineDB.HentAfdelingsNrForRessourseNr(Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value.ToString()));

            foreach (Afdeling afdeling2 in AfdelingCmB.Items)
            {
                if (afdeling.afdelingsNr == afdeling2.afdelingsNr)
                {
                    if (AfdelingCmB.SelectedItem == afdeling2)
                    {
                        List<Maskine> maskinerForAfdeling = maskineDB.HentMaskinerUdFraAfdeling(((Afdeling)AfdelingCmB.SelectedItem).afdelingsNr);

                        MaskineCmB.DataSource = maskinerForAfdeling;
                        int valgtRessourceNr = Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value.ToString());

                        foreach (Maskine maskine in maskinerForAfdeling)
                        {
                            if (maskine.ressourceNr == valgtRessourceNr)
                            {
                                MaskineCmB.SelectedItem = maskine;
                            }
                        }
                    }
                    else
                    {
                        AfdelingCmB.SelectedItem = afdeling2;
                    }
                }
            }
            OrdreNrTxtB.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.kundeNr <= 0)
                KundeNrTxtB.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }
    }
}
