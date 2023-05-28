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
    public class RepositoryZgrade
    {
        public static Zgrade GetZgrade(int id)
        {
            Zgrade zgrade = null;
            string sql = $"SELECT * FROM Zgrade WHERE Id_Zgrade ={id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                zgrade = CreateObject(reader);
                reader.Close();

            }
            DB.CloseConnection();
            return zgrade;

        }

        public static List<Zgrade> GetZgrade()
        {
            List<Zgrade> Zgrade = new List<Zgrade>();
            string sql = $"SELECT * FROM [dbo].[Zgrade]";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Zgrade zgrade = CreateObject(reader);
                Zgrade.Add(zgrade);

            }
            reader.Close();
            DB.CloseConnection();

            return Zgrade;

        }


        private static Zgrade CreateObject(SqlDataReader reader)
        {
            int Id_Zgrade = int.Parse(reader["Id_Zgrade"].ToString());
            string Naziv = reader["Naziv_Zgrade"].ToString();


            var Zgrade = new Zgrade
            {
                Id_Zgrade = Id_Zgrade,
                Naziv_Zgrade = Naziv,


            };
            return Zgrade;
        }
        public static List<Zgrade> GetZgradeSearch(string NazivZgrade)
        {
            var zgrade = new List<Zgrade>(); //stvara listu zahtjeva

            string sql = $"SELECT * FROM dbo.Zgrade WHERE Naziv_Zgrade='{NazivZgrade}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Zgrade zgrade1  = CreateObject(reader);
                zgrade.Add(zgrade1);
            }
            reader.Close();
            DB.CloseConnection();
            return zgrade;
        }
    }
}
