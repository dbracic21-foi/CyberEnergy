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
    public class repositoryAdministrator
    {
        public static Administrator GetAdministrator(string UserName)
        {
            string sql = $"SELECT * FROM Administrator WHERE UserName ='{UserName}'";
            return FetchAdministrator(sql);

        }
        public static Administrator GetAdministrator(int id)
        {
          
            string sql = $"SELECT * FROM Administrator WHERE Id_Administratora ={id}";
            return FetchAdministrator(sql);

        }
        public static Administrator FetchAdministrator(string sql) 
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Administrator administrator = null;
            if(reader.HasRows == true)
            {
                reader.Read();
                administrator = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return administrator;
            

        }
        private static Administrator CreateObject(SqlDataReader reader)
        {
            int id= int.Parse(reader["Id_Administratora"].ToString());
            string UserName = reader["UserName"].ToString();
            string Password = reader["Password"].ToString() ;

            var Administrator = new Administrator
            {
                Id_Administratora = id,
                UserName = UserName,
                Password = Password

            };
            return Administrator;
        }
    }
}
