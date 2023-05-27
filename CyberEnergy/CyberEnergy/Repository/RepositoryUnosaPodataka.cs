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
    public class RepositoryUnosaPodataka
    {
        public static UnosPodataka GetUnosPodataka(Korisnik korisnik, Zgrade zgrade )
        {
            UnosPodataka unospodataka = null;
            string sql = $"SELECT * FROM UnosPodataka WHERE Id_Korisnika ={korisnik.Id_Korisnika}  AND Id_Zgrade ={zgrade.Id_Zgrade}";
            DB.OpenConnection();
            var reader = DB.GetDataReader( sql );
            if(reader.HasRows)
            {
                reader.Read();
                unospodataka = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return unospodataka;


        }
        public static List<UnosPodataka>GetUnosPodataka(Korisnik korisnik)
        {
            List<UnosPodataka> unospodataka = new List<UnosPodataka>();
            string sql = $"SELECT * FROM UnosPodataka WHERE Id_Korisnika = {korisnik.Id_Korisnika}";
            DB.OpenConnection();
            var reader = DB.GetDataReader( sql );
           while(reader.Read()) {
                UnosPodataka unospodataka1 = CreateObject(reader);
                unospodataka.Add(unospodataka1);
            }
           reader.Close();
            DB.CloseConnection();
            return unospodataka;
        }
        private static UnosPodataka CreateObject(SqlDataReader reader)
        {
            int Id_Zgrada = int.Parse(reader["Id_Zgrade"].ToString());
            var zgrade = RepositoryZgrade.GetZgrade(Id_Zgrada);

            int Id_Korisnika = int.Parse(reader["Id_Korisnika"].ToString());
            var korisnik = RepositoryKorisnika.GetKorisnik(Id_Korisnika);

            int  Id_MjerneJedinice = int.Parse(reader["Id_MjerneJedinice"].ToString());
            var mjernajedinica = RepositoryMjerneJedinice.GetMjernaJedinica(Id_MjerneJedinice);

            int Id_VrstePotrosnje = int.Parse(reader["Id_VrstePotrosnje"].ToString());
            var NazivPotrosnje = RepositoryVrstaEnergije.GetEnergija(Id_VrstePotrosnje);

            var unospodataka = new UnosPodataka { 
            Zgrade = zgrade,
            Korisnik = korisnik,
            MjernaJedinica = mjernajedinica,
            VrstaEnergije = NazivPotrosnje,
            
            
            };
            return unospodataka;


        }
        public static void InsertUnosa(Korisnik korisnik, Zgrade zgrade,MjernaJedinica mjernajedinica, VrstaEnergije vrstaenergije)
        {
            string sql = $"INSERT INTO UnosPodataka (Id_Zgrade,Id_MjerneJedinice,Id_VrstePotrosnje) VALUES ({zgrade.Id_Zgrade},{mjernajedinica.Id_MjerneJedinice},{vrstaenergije.Id_VrstePotrosnje})";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
