using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DelPin___Eksamensprojekt.DBSQL;
using DelPin___Eksamensprojekt.ForretningsLogik;

namespace DelPin___Eksamensprojekt.GUI
{
    public partial class AdminLogin : Form
    {
        LoginDB DB;
        public AdminLogin()
        {
            DB = new LoginDB();
            InitializeComponent();
        }

        private void LoginBt_Click(object sender, EventArgs e)
        {
            this.Hide();

            string navn = NavnTxtB.Text;
            int pinkode = Convert.ToInt32(PinkodeTxtB.Text);

            if (DB.Adminlogin(navn, pinkode))
            {
                MainMenu m = new MainMenu();
                m.ShowDialog();
            }
            else
            {
                MessageBox.Show("           Admin eksisterer ikke                 ");
                AdminLogin al = new AdminLogin();
                al.ShowDialog();
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

        private void ShowBT_Click_1(object sender, EventArgs e)
        {
            if(PinkodeTxtB.PasswordChar == '*')
            {
                HideBT.BringToFront();
                PinkodeTxtB.PasswordChar = '\0';
            }

        }

        private void HideBT_Click_1(object sender, EventArgs e)
        {
            if (PinkodeTxtB.PasswordChar == '\0')
            {
                ShowBT.BringToFront();
                PinkodeTxtB.PasswordChar = '*';
            }

        }

        
    }
}
