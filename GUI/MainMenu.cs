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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void LoginBT_Click(object sender, EventArgs e)
        {
            this.Close();
            KundeLogin KL = new KundeLogin();
            KL.Show();
        }

        private void AdmKunderBT_Click(object sender, EventArgs e)
        {
            this.Close();
            AdministrerKunde AK = new AdministrerKunde();
            AK.Show();
        }

        private void AdmAfdelingBT_Click(object sender, EventArgs e)
        {
            this.Close();
            AdministrerAfdeling AA = new AdministrerAfdeling();
            AA.Show();
        }

        private void AdmProduktBT_Click(object sender, EventArgs e)
        {
            this.Close();
            AdministrerMaskine AM = new AdministrerMaskine();
            AM.Show();
        }

        private void BookingBT_Click(object sender, EventArgs e)
        {
            this.Close();
            BookingMenu B = new BookingMenu(0);
            B.Show();
        }

        private void LogUdBT_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminLogin AL = new AdminLogin();
            AL.Show();



        }
    }
}
