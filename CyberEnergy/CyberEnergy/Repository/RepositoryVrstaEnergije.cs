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
    //Repozitorij za dohvačanje Vrste energije iz baze podataka
    //Vrste energije  dohvačamo po njegovom Id-u
    public class RepositoryVrstaEnergije
    {
        public static VrstaEnergije GetEnergija(int id)
        {
            VrstaEnergije vrstaenergije = null;
            string sql = $"SELECT * FROM NazivPotrosnje WHERE Id_VrstePotrosnje ={id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                vrstaenergije = CreateObject(reader);
                reader.Close();

            }
            DB.CloseConnection();
            return vrstaenergije;

        }

        public static List<VrstaEnergije> GetEnergija()
        {
            List<VrstaEnergije> vrstaenergije = new List<VrstaEnergije>();
            string sql = $"SELECT * FROM [dbo].[NazivPotrosnje]";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                VrstaEnergije vrstaEnergije = CreateObject(reader);
                vrstaenergije.Add(vrstaEnergije);

            }
            reader.Close();
            DB.CloseConnection();

            return vrstaenergije;

        }


        private static VrstaEnergije CreateObject(SqlDataReader reader)
        {
            int Id_VrstePotrosnje = int.Parse(reader["Id_VrstePotrosnje"].ToString());
            string Naziv = reader["Vrsta_Potrosnje"].ToString();


            var VrstaEnergije = new VrstaEnergije
            {
                Id_VrstePotrosnje = Id_VrstePotrosnje,
                Naziv_Vrste_Potrosnje = Naziv,


            };
            return VrstaEnergije;
        }
    }
}
