using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DelPin___Eksamensprojekt.DBSQL;
using DelPin___Eksamensprojekt.ForretningsLogik;

namespace DelPin___Eksamensprojekt.GUI
{
    public partial class KundeLogin : Form
    {
        LoginDB DB;

        public KundeLogin()
        {
            DB = new LoginDB();
            InitializeComponent();
        }

        private void LoginBT_Click(object sender, EventArgs e)
        {
            string Navn = NavnTxtB.Text;
            int Pinkode = Convert.ToInt32(PinkodeTxtB.Text);
            int kundeNr = DB.Kundelogin(Navn, Pinkode);
            if (kundeNr > 0)
            {
                this.Close();
                BookingMenu BM = new BookingMenu(kundeNr);
                BM.ShowDialog();
            }
            else
            {
                MessageBox.Show("           Kunden eksisterer ikke                ");
                KundeLogin kl = new KundeLogin();
                kl.ShowDialog();
            }
        }

        private void ShowBT_Click(object sender, EventArgs e)
        {
            if(PinkodeTxtB.PasswordChar == '*')
            {
                HideBT.BringToFront();
                PinkodeTxtB.PasswordChar = '\0';
            }
        }

        private void HideBT_Click(object sender, EventArgs e)
        {
            if (PinkodeTxtB.PasswordChar == '\0')
            {
                ShowBT.BringToFront();
                PinkodeTxtB.PasswordChar = '*';
            }
        }
    }
}
