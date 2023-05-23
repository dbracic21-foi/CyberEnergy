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
        public static Administrator GetAdministrator(int id)
        {
            Administrator administrator = null;
            string sql = $"SELECT * FROM Administrator WHERE Id ={id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if(reader.HasRows ) { 
            reader.Read();
            administrator = CreateObject(reader);
            reader.Close();
                    
            }
            DB.CloseConnection();
            return administrator;

        }
        public static List<Administrator> GetAdministrators()
        {
            List<Administrator> administrators = new List<Administrator>();
            string sql = "SELECT * FROM Students";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while(reader.Read( )) { 
            Administrator administrator = CreateObject(reader);
            administrators.Add(administrator);

            }
            reader.Close();
            DB.CloseConnection( );

            return administrators;

        }
        private static Administrator CreateObject(SqlDataReader reader)
        {
           
            string Ime = reader["Ime"].ToString(); int id = int.Parse(reader["Id_Administratora"].ToString());
            string Prezime = reader["Prezime"].ToString() ;

            var Administrator = new Administrator
            {
                Id_Administratora = id,
                Ime = Ime,
                Prezime = Prezime

            };
            return Administrator;
        }
    }
}
