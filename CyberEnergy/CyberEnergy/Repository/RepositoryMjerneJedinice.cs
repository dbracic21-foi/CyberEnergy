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
    //Repozitorij za dohvačanje Mjernih jedinica iz baze podataka
    //MjerneJedinice dohvačamo po njegovom Id-u
    public class RepositoryMjerneJedinice
    {
        public static MjernaJedinica GetMjernaJedinica(int id)
        {
            MjernaJedinica mjernajedinica =  null;
            string sql = $"SELECT * FROM MjernaJedinica WHERE Id_MjerneJedinice ={id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
               mjernajedinica = CreateObject(reader);
                reader.Close();

            }
            DB.CloseConnection();
            return mjernajedinica;

        }

        public static List<MjernaJedinica> GetMjernaJedinica()
        {
            List<MjernaJedinica> mjernajedinica = new List<MjernaJedinica>();
            string sql = $"SELECT * FROM [dbo].[MjernaJedinica]";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                MjernaJedinica mjernajedinica1 = CreateObject(reader);
                mjernajedinica.Add(mjernajedinica1);

            }
            reader.Close();
            DB.CloseConnection();

            return mjernajedinica;

        }


        private static MjernaJedinica CreateObject(SqlDataReader reader)
        {
            int Id_MjerneJedinice = int.Parse(reader["Id_MjerneJedinice"].ToString());
            string Naziv = reader["Naziv_Mjerne_Jedinice"].ToString();


            var MjernaJedinica = new MjernaJedinica
            {
                Id_MjerneJedinice = Id_MjerneJedinice,
                Naziv_Mjerne_Jedinice = Naziv,


            };
            return MjernaJedinica;
        }
    }
}
