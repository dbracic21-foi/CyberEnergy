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
            string sql = $"SELECT * FROM UnosPodataka WHERE Id_Korisnika ={korisnik.Id_Korisnika}  AND NazivZgrade ={zgrade.Naziv_Zgrade}";
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
            int  NazivZgrade = int.Parse(reader["NazivZgrade"].ToString());
            var nazivzgrade = RepositoryZgrade.GetZgrade(NazivZgrade);

            int Id_Korisnika = int.Parse(reader["Id_Korisnika"].ToString());
            var korisnik = RepositoryKorisnika.GetKorisnik(Id_Korisnika);

            int  Naziv_Mjerne_Jedinice = int.Parse(reader["Naziv_Mjerne_Jedinice"].ToString());
            var mjernajedinica = RepositoryMjerneJedinice.GetMjernaJedinica(Naziv_Mjerne_Jedinice);

            int Id_VrstePotrosnje = int.Parse(reader["Id_VrstePotrosnje"].ToString());
            var NazivPotrosnje = RepositoryVrstaEnergije.GetEnergija(Id_VrstePotrosnje);

            var unospodataka = new UnosPodataka { 
            Zgrade = nazivzgrade,
            Korisnik = korisnik,
            MjernaJedinica = mjernajedinica,
            VrstaEnergije = NazivPotrosnje,
            
            
            };
            return unospodataka;


        }
        public static void InsertUnosa(Korisnik korisnik, Zgrade zgrade,MjernaJedinica mjernajedinica, VrstaEnergije vrstaenergije)
        {
            string sql = $"INSERT INTO UnosPodataka (NazivZgrade,Naziv_Mjerne_Jedinice,Id_VrstePotrosnje) VALUES ('{zgrade.Naziv_Zgrade}','{mjernajedinica.Naziv_Mjerne_Jedinice}',{vrstaenergije.Id_VrstePotrosnje})";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
