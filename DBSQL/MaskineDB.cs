using DelPin___Eksamensprojekt.ForretningsLogik;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelPin___Eksamensprojekt.DBSQL
{
    public class MaskineDB
    {
        public void OpretMaskine(Maskine maskine)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand INSERTCOMMAND = new SqlCommand
                ($"INSERT INTO Maskine (MaskineNavn, Pris, AfdelingsNr) VALUES ('{maskine.maskineNavn}', {maskine.pris}, {maskine.afdelingsNr})", conn);
            INSERTCOMMAND.ExecuteNonQuery();
            conn.Close();
        }

        public List<Maskine> HentMaskiner()
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            List<Maskine> maskineList = new List<Maskine>(); //Liste med alle Maskiner oprettes.

            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT * FROM Maskine", conn);
            SqlDataReader dataReader = SELECTCOMMAND.ExecuteReader();

            while (dataReader.Read())
            {
                if (dataReader.HasRows)
                {
                    int ressourceNr = dataReader.GetInt32(0);
                    string maskineNavn = dataReader.GetString(1);
                    double pris = dataReader.GetDouble(2);
                    int afdelingsNr = dataReader.GetInt32(3);

                    Maskine maskine = new Maskine(ressourceNr, maskineNavn, pris, afdelingsNr);
                    maskineList.Add(maskine);
                }
            }
            conn.Close();
            return maskineList;
        }

        public List<Maskine> HentMaskinerUdFraAfdeling(int afdelingsNr)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            List<Maskine> maskineList = new List<Maskine>(); //Liste med alle Maskiner oprettes.

            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT * FROM Maskine WHERE AfdelingsNr = {afdelingsNr}", conn);
            SqlDataReader dataReader = SELECTCOMMAND.ExecuteReader();

            while (dataReader.Read())
            {
                if (dataReader.HasRows)
                {
                    int ressourceNr = dataReader.GetInt32(0);
                    string maskineNavn = dataReader.GetString(1);
                    double pris = dataReader.GetDouble(2);
                    int afdelingsnr = dataReader.GetInt32(3);
                    Maskine maskine = new Maskine(ressourceNr, maskineNavn, pris, afdelingsnr);
                    maskineList.Add(maskine);
                }
            }
            conn.Close();
            return maskineList;
        }

   

      


        public List<Afdeling> HentAfdelinger()
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            List<Afdeling> afdelingsliste = new List<Afdeling>(); //Liste med alle afdelinger oprettes.

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

        public void SletMaskine(int ressourceNr)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand DELETECOMMAND = new SqlCommand
                ($"DELETE FROM Maskine WHERE ressourceNr = ({ressourceNr})", conn);
            DELETECOMMAND.ExecuteNonQuery();
            conn.Close();
        }

        public void OpdaterMaskiner(string maskineNavn, double pris, int afdelingsNr, int ressourceNr)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand UPDATECOMMAND = new SqlCommand
                ($"UPDATE Maskine SET MaskineNavn = ('{maskineNavn}'), Pris = ({pris}), AfdelingsNr = ({afdelingsNr}) WHERE RessourceNr = ({ressourceNr})", conn);
            UPDATECOMMAND.ExecuteNonQuery();
            conn.Close();
        }

        public Afdeling HentAfdelingsNrForRessourseNr(int ressourceNr)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT * FROM Afdeling WHERE AfdelingsNr IN (SELECT AfdelingsNr FROM Maskine WHERE RessourceNr = ({ressourceNr}))", conn);
            SqlDataReader dataReader = SELECTCOMMAND.ExecuteReader();

            Afdeling afdeling = null;

            while (dataReader.Read())
            {
                if (dataReader.HasRows)
                {
                    int afdelingsNr = dataReader.GetInt32(0);
                    string afdelingsNavn = dataReader.GetString(1);
                    int postNr = dataReader.GetInt32(2);
                    afdeling = new Afdeling(afdelingsNr, afdelingsNavn, postNr);
                }
            }
            conn.Close();
            return afdeling;
        }

        public bool IsMaskineAlleredeOprettet(string mNavn, double mPris, int aNr)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT * FROM Maskine WHERE MaskineNavn = ('{mNavn}') AND Pris = ({mPris}) AND AfdelingsNr = ({aNr})", conn);
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
