using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberEnergy.Models;
using DBLayer;
namespace CyberEnergy.Repository
{ 
    //Repozitorij za dohvačanje različitih vrsta energija iz baze podataka
    //Rzličite vrste energije dohvačamo po njegovom Id-u
    public class RepositoryKolicine
    {
        public static Kolicina GetKolicina(int id)
        {
            Kolicina kolicina = null;
            string sql = $"SELECT * FROM Kolicina WHERE Id_Kolicine ={id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                kolicina = CreateObject(reader);
                reader.Close();

            }
            DB.CloseConnection();
            return kolicina;

        }

        public static List<Kolicina> GetKolicina()
        {
            List<Kolicina> kolicina = new List<Kolicina>();
            string sql = $"SELECT * FROM [dbo].[Kolicina]";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Kolicina kolicina1 = CreateObject(reader);
                kolicina.Add(kolicina1);

            }
            reader.Close();
            DB.CloseConnection();

            return kolicina;

        }


        private static Kolicina CreateObject(SqlDataReader reader)
        {
            int Id_Kolicine = int.Parse(reader["Id_Kolicine"].ToString());
            string UkupnaKolicina = reader["UkupnaKolicina"].ToString();


            var Kolicina = new Kolicina
            {
                Id_Kolicine = Id_Kolicine,
                UkupnaKolicina = UkupnaKolicina,


            };
            return Kolicina;
        }
    }
}
