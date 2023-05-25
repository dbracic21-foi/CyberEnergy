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
    public class repositoryUpraviteljZgrade
    {
        public static Upravitelj_Zgrade GetUpraviteljZgrade(string UserName)
        {
            string sql = $"SELECT * FROM UpraviteljZgrade WHERE UserName ='{UserName}'";
            return FetchUpravitelj_Zgrade(sql);

        }
        public static Upravitelj_Zgrade GetUpraviteljZgrade(int id)
        {

            string sql = $"SELECT * FROM UpraviteljZgrade WHERE Id_Upravitelja ={id}";
            return FetchUpravitelj_Zgrade(sql);

        }
        public static Upravitelj_Zgrade FetchUpravitelj_Zgrade(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Upravitelj_Zgrade upravitelj_zgrade = null;
            if (reader.HasRows == true)
            {
                reader.Read();
                upravitelj_zgrade = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return upravitelj_zgrade;


        }
        private static Upravitelj_Zgrade CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id_Upravitelja"].ToString());
            string UserName = reader["UserName"].ToString();
            string Password = reader["Password"].ToString();

            var Upravitelj_Zgrade = new Upravitelj_Zgrade
            {
                Id_Upravitelja = id,
                UserName = UserName,
                Password = Password

            };
            return Upravitelj_Zgrade;
        }
    }
}
