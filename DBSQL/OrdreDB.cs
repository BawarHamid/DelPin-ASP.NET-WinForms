using DelPin___Eksamensprojekt.ForretningsLogik;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelPin___Eksamensprojekt.DBSQL
{
    public class OrdreDB
    {
        public void OpretOrdre(Ordre ordre)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand INSERTCOMMAND = new SqlCommand
                ($"INSERT INTO Ordre (KundeNr) VALUES ({ordre.kundeNr})", conn);
            INSERTCOMMAND.ExecuteNonQuery();
            conn.Close();
        }

        public List<Ordre> HentOrdre()
        {
            return HentOrdre(0);
        }

        public List<Ordre> HentOrdre(int kNr)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            List<Ordre> ordreList = new List<Ordre>(); //Liste med alle Ordre oprettes.

            SqlCommand SELECTCOMMAND;
            if (kNr == 0)
            {
                SELECTCOMMAND = new SqlCommand($"SELECT * FROM Ordre", conn);
            }
            else
            {
                SELECTCOMMAND = new SqlCommand($"SELECT * FROM Ordre WHERE KundeNr=({kNr})", conn);
            }

            SqlDataReader dataReader = SELECTCOMMAND.ExecuteReader();

            while (dataReader.Read())
            {
                if (dataReader.HasRows)
                {
                    int ordreNr = dataReader.GetInt32(0);
                    int kundeNr = dataReader.GetInt32(1);

                    Ordre ordre = new Ordre(ordreNr, kundeNr);
                    ordreList.Add(ordre);
                }
            }
            conn.Close();
            return ordreList;
        }

        public void SletOrdre(int ordreNr)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand DELETECOMMAND = new SqlCommand
                ($"DELETE FROM Ordre WHERE OrdreNr = ({ordreNr})", conn);
            DELETECOMMAND.ExecuteNonQuery();
            conn.Close();
        }

        public void OpdaterOrdre(int ordreNr, int kundeNr)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand UPDATECOMMAND = new SqlCommand
                ($"UPDATE Ordre SET KundeNr = ({kundeNr}) WHERE OrdreNr = ({ordreNr}) ", conn);
            UPDATECOMMAND.ExecuteNonQuery();
            conn.Close();
        }
    }
}
