using CyberEnergy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data.SqlClient;

namespace CyberEnergy.Repository
{
    public class RepositoryKorisnika
    {
        public static Korisnik GetKorisnik(string Username)
        {
            string sql = $"SELECT * FROM Korisnik WHERE Username = '{Username}'";
            return FetchKorisnik(sql);
        }
        public static Korisnik GetKorisnik(int id)
        {
            string sql = $"SELECT * FROM Korisnik WHERE Id_Korisnika = '{id}'";
            return FetchKorisnik(sql);
        }
        private static Korisnik FetchKorisnik(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Korisnik korisnik = null;

            if (reader.HasRows)
            {
                reader.Read();
                korisnik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return korisnik;
        }
       
        private static Korisnik CreateObject(SqlDataReader reader)
        {
            int Id_Korisnika = int.Parse(reader["Id_Korisnika"].ToString());
            string Ime = reader["Ime"].ToString();
            string Prezime = reader["Prezime"].ToString();
            string Username = reader["Username"].ToString();
            string Password = reader["Password"].ToString();

            var korisnik = new Korisnik
            {
                Id_Korisnika = Id_Korisnika,
                Ime = Ime,
                Prezime = Prezime,
                Username = Username,
                Password = Password

            };
            return korisnik;
        }
      
    }
}
