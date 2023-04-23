using DelPin___Eksamensprojekt.ForretningsLogik;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelPin___Eksamensprojekt.DBSQL
{
    public class BookingDB
    {
   

        public void OpretBooking(Booking booking)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand INSERTCOMMAND = new SqlCommand
                ($"INSERT INTO Booking (StartsDato, SlutDato, RessourceNr, OrdreNr) VALUES ('{booking.startsDato.ToString("yyyy-MM-dd")}', '{booking.slutDato.ToString("yyyy-MM-dd")}', {booking.ressourceNr}, {booking.ordreNr})", conn);
            INSERTCOMMAND.ExecuteNonQuery();
            conn.Close();
        }


        public List<Booking> HentBookinger()
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            List<Booking> bookingListe = new List<Booking>(); //Liste med alle bookinger oprettes.

            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT * FROM Booking JOIN Ordre ON Ordre.OrdreNr = Booking.OrdreNr", conn);
            SqlDataReader dataReader = SELECTCOMMAND.ExecuteReader();

            while (dataReader.Read())
            {
                if (dataReader.HasRows)
                {
                    int bookingNr = dataReader.GetInt32(0);
                    DateTime startsDato = dataReader.GetDateTime(1);
                    DateTime slutDato = dataReader.GetDateTime(2);
                    int ressourceNr = dataReader.GetInt32(3);
                    int ordreNr = dataReader.GetInt32(4);
                    Booking booking = new Booking(bookingNr, startsDato, slutDato, ressourceNr, ordreNr);
                    bookingListe.Add(booking);
                }
            }
            conn.Close();
            return bookingListe;
        }

        public void SletBooking(int bookingNr)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand DELETECOMMAND = new SqlCommand
                ($"DELETE FROM Booking WHERE BookingNr = ({bookingNr})", conn);
            DELETECOMMAND.ExecuteNonQuery();
            conn.Close();
        }

        public void OpdaterBooking(int bookingNr, DateTime startsDato, DateTime slutDato, int ressourceNr, int ordreNr)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand UPDATECOMMAND = new SqlCommand
                ($"UPDATE Booking SET StartsDato = ('{startsDato.ToString("yyyy-MM-dd")}'), SlutDato = ('{slutDato.ToString("yyyy-MM-dd")}'), RessourceNr = ({ressourceNr}), OrdreNr = ({ordreNr})  WHERE BookingNr = ({bookingNr}) ", conn);
            UPDATECOMMAND.ExecuteNonQuery();
            conn.Close();
        }

        public bool IsMaskineOptagetDato(DateTime startsDato, DateTime slutDato, int ressourceNr)
        {
            DatabaseDB db = new DatabaseDB();
            db.GetConnection();

            SqlConnection conn = new SqlConnection(db.GetConnection());
            conn.Open();

            SqlCommand SELECTCOMMAND = new SqlCommand
                ($"SELECT * FROM Booking WHERE StartsDato >= ('{startsDato.ToString("yyyy-MM-dd")}') AND SlutDato <= ('{slutDato.ToString("yyyy-MM-dd")}') AND RessourceNr = ({ressourceNr})", conn);
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
