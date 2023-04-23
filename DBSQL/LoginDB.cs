using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelPin___Eksamensprojekt.DBSQL
{
    public class  LoginDB
    {
        public Boolean Adminlogin(string navn, int pinkode)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();


            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT * FROM Medarbejder WHERE Navn = ('{navn}') and Pinkode = ({pinkode})", conn);


            //SELECTCOMMAND.ExecuteNonQuery();
            SqlDataReader admin = SELECTCOMMAND.ExecuteReader();

            Boolean Admin = admin.HasRows;


            //sql.Close();
            conn.Close();

            return Admin;
        }


        public int Kundelogin(string Navn, int Pinkode)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();


            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT KundeNr FROM Kunde WHERE KundeNavn = ('{Navn}') and PinKode = ({Pinkode})", conn);


            //SELECTCOMMAND.ExecuteNonQuery();
            SqlDataReader kunde = SELECTCOMMAND.ExecuteReader();

            int kundeNr = 0;
            while (kunde.Read())
            {
                if (kunde.HasRows)
                {
                    kundeNr = kunde.GetInt32(0);
                    //Afdeling afdeling = new Afdeling(dataReader.GetString(1), dataReader.GetInt32(2));
                }
            }


            //sql.Close();
            conn.Close();

            return kundeNr;
        }
    }
}
