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
    public class repositoryZgrade
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
            string sql = $"SELECT * FROM Zgrade";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Zgrade zgrade = CreateObject(reader);
              //  zgrade.Add();

            }
            reader.Close();
            DB.CloseConnection();

            return Zgrade;

        }
        private static Zgrade CreateObject(SqlDataReader reader)
        {
            int Id_Zgrade = int.Parse(reader["Id_Zgrade"].ToString());
            string Naziv = reader["Naziv"].ToString();


            var Zgrade = new Zgrade
            {
                Id_Zgrade = Id_Zgrade,
                Naziv = Naziv,


            };
            return Zgrade;
        }
    }
}
