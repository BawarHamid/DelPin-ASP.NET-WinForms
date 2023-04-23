using DelPin___Eksamensprojekt.ForretningsLogik;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelPin___Eksamensprojekt.DBSQL
{
    public class AfdelingDB
    {
        public List<Afdeling> HentAfdeling()
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();


            List<Afdeling> Afdelingliste = new List<Afdeling>(); //Liste med alle Kunder.

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT * FROM Afdeling", conn);
            SqlDataReader dataReader = SELECTCOMMAND.ExecuteReader();

            while (dataReader.Read())
            {
                if (dataReader.HasRows)
                {
                    int afdelingsNr = dataReader.GetInt32(0);
                    string afdelingsNavn = dataReader.GetString(1);
                    int postNr = dataReader.GetInt32(2);

                    Afdeling afdeling = new Afdeling(afdelingsNr, afdelingsNavn, postNr);

                    Afdelingliste.Add(afdeling);
                }
            }
            conn.Close();
            return Afdelingliste;
        }

       



        public void OpretAfdeling(Afdeling afdeling)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand INSERTCOMMAND = new SqlCommand
                ($"INSERT INTO Afdeling (AfdelingsNavn, PostNr) VALUES ('{afdeling.afdelingsNavn}', {afdeling.postNr})", conn);
            INSERTCOMMAND.ExecuteNonQuery();

            conn.Close();
        }


        public void SletAfdeling(string AfdelingNavn)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand Delete = new SqlCommand($"delete from Afdeling where AfdelingsNavn = ('{AfdelingNavn}')", conn);

            Delete.ExecuteNonQuery();

            conn.Close();

        }

        public void OpdaterAfdeling(int afdelingsNr, string afdelingsNavn, int postNr)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand UPDATECOMMAND = new SqlCommand
                ($"UPDATE Afdeling SET  AfdelingsNavn = ('{afdelingsNavn}'), PostNr = ({postNr})  Where AfdelingsNr = ({afdelingsNr})", conn);
            UPDATECOMMAND.ExecuteNonQuery();
            conn.Close();
        }

        public bool IsAfdelingAlleredeOprettet(string aNavn, int postNr)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT * FROM Afdeling WHERE AfdelingsNavn = ('{aNavn}') AND PostNr = ({postNr})", conn);
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
