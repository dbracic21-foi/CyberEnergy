using CyberEnergy.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberEnergy.Repository
{
    public class RepositoryUloge
    {
        public static Uloga GetUloge(int id)
        {
            Uloga uloge = null;
            string sql = $"SELECT * FROM Korisnici WHERE Id_oznaka ={id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                uloge = CreateObject(reader);
                reader.Close();

            }
            DB.CloseConnection();
            return uloge;

        }

        public static List<Uloga> GetUloge()
        {
            List<Uloga> uloge = new List<Uloga>();
            string sql = $"SELECT * FROM [dbo].[Korisnici]";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Uloga Uloge = CreateObject(reader);
                uloge.Add(Uloge);

            }
            reader.Close();
            DB.CloseConnection();

            return uloge;

        }


        private static Uloga CreateObject(SqlDataReader reader)
        {
            int Id_Oznake = int.Parse(reader["Id_Oznaka"].ToString());
            string Naziv_uloge = reader["Naziv_Uloge"].ToString();


            var uloga = new Uloga
            {
                Id_Oznaka = Id_Oznake,
                Naziv_Uloge = Naziv_uloge

            };
            return uloga;
        }
    }
}
