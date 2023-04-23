using DelPin___Eksamensprojekt.ForretningsLogik;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelPin___Eksamensprojekt.DBSQL
{
    public class KundeDB
    {
        public List<Kunde> HentKunde()
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();


            List<Kunde> Kundeliste = new List<Kunde>(); //Liste med alle Kunder.

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT * FROM Kunde", conn);
            SqlDataReader dataReader = SELECTCOMMAND.ExecuteReader();

            while (dataReader.Read())
            {
                if (dataReader.HasRows)
                {
                    int kundeNr = dataReader.GetInt32(0);
                    string kundeNavn = dataReader.GetString(1);
                    int pinKode = dataReader.GetInt32(2);
                    int afdelingsNr = dataReader.GetInt32(3);

                    Kunde kunde = new Kunde(kundeNr, kundeNavn, pinKode, afdelingsNr);

                    Kundeliste.Add(kunde);
                }
            }
            conn.Close();
            return Kundeliste;
        }

      

        public void SetKundetype(int kundeNr)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand InsertP = new SqlCommand
                    ($"INSERT INTO PrivatKunde(KundeNr) VALUES ({kundeNr})", conn);
            InsertP.ExecuteNonQuery();


            /*
            if (kundeNavn is PrivatKunde)
            {
                SqlCommand InsertP = new SqlCommand
                    ($"INSERT INTO PrivatKunde(KundeNr) VALUES ({kundeNavn})", conn);
                InsertP.ExecuteNonQuery();
            }
            else if (kundeNavn is ErhvervsKunde)
            {
                SqlCommand InsertE = new SqlCommand
                    ($"INSERT INTO ErhvervsKunde(KundeNr) VALUES ({kundeNavn})", conn);
                InsertE.ExecuteNonQuery();
            }
            */
            conn.Close();
        }



        public void OpretKunde(Kunde kunde)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand INSERTCOMMAND = new SqlCommand
                ($"INSERT INTO Kunde (KundeNavn, PinKode, AfdelingsNr) VALUES ('{kunde.kundeNavn}', {kunde.pinKode}, {kunde.afdelingsNr})", conn);
           INSERTCOMMAND.ExecuteNonQuery();
           
            conn.Close();
        }


        public void SletKunde(string Kundenavn)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand Delete = new SqlCommand($"delete from Kunde where KundeNavn = ('{Kundenavn}')", conn);

            Delete.ExecuteNonQuery();

            conn.Close();

        }
        


        public List<Afdeling> HentAfdelinger()
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            List<Afdeling> afdelingsliste = new List<Afdeling>(); //Liste med alle afdelinger oprettes.

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT * FROM Afdeling", conn);
            SqlDataReader dataReader = SELECTCOMMAND.ExecuteReader();

            while (dataReader.Read())
            {
                if (dataReader.HasRows)
                {
                    string afdelingsNavn = dataReader.GetString(1);
                    int postNr = dataReader.GetInt32(2);
                    Afdeling afdeling = new Afdeling(afdelingsNavn, postNr);
                    afdeling.afdelingsNr = dataReader.GetInt32(0);
                    afdelingsliste.Add(afdeling);
                    //Afdeling afdeling = new Afdeling(dataReader.GetString(1), dataReader.GetInt32(2));
                }
            }
            conn.Close();
            return afdelingsliste;
        }

        public void OpdaterKunde(string kundeNavn, int pinKode, int afdelingsNr, int kundeNr)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand UPDATECOMMAND = new SqlCommand
                ($"UPDATE kunde SET KundeNavn = ('{kundeNavn}'), Pinkode = ({pinKode}), AfdelingsNr = ({afdelingsNr}) WHERE KundeNr = ('{kundeNr}') ", conn);
            UPDATECOMMAND.ExecuteNonQuery();
            conn.Close();
        }

        public bool IsKundeAlleredeOprettet(string kNavn, int pKode)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT * FROM Kunde WHERE KundeNavn = ('{kNavn}') AND Pinkode = ({pKode})", conn);
            SqlDataReader dataReader = SELECTCOMMAND.ExecuteReader();

            bool resultat = false;

            while (dataReader.Read())
            {
                if (dataReader.HasRows)
                {
                    resultat = true;
                }
                else
                {
                    resultat = false;
                }
            }
            conn.Close();
            return resultat;
        }
    }
}
