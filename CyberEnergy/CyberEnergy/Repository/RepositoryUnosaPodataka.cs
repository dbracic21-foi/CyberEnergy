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
        public static UnosPodataka GetUnosPodataka(Zgrade zgrade )
        {
            UnosPodataka unospodataka = null;
            string sql = $"SELECT * FROM UnosPodataka WHERE NazivZgrade ='{zgrade.Naziv_Zgrade}'";
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
            string NazivZgrade = reader["NazivZgrade"].ToString();
            var nazivzgrade = RepositoryZgrade.GetZgrade(nazivzgrade);


            int Id_Korisnika = int.Parse(reader["Id_Korisnika"].ToString());
            var korisnik = RepositoryKorisnika.GetKorisnik(Id_Korisnika);

            int  Naziv_Mjerne_Jedinice = int.Parse(reader["Id_MjerneJedinice"].ToString());
            var mjernajedinica = RepositoryMjerneJedinice.GetMjernaJedinica(Naziv_Mjerne_Jedinice);

            int Id_VrstePotrosnje = int.Parse(reader["Id_VrstePotrosnje"].ToString());
            var NazivPotrosnje = RepositoryVrstaEnergije.GetEnergija(Id_VrstePotrosnje);

            int UkupnaKolicina = int.Parse(reader["UkupnaKolicina"].ToString());
            var ukupnakolicina = RepositoryKolicine.GetKolicina(UkupnaKolicina);

            var unospodataka = new UnosPodataka { 
            Zgrade = nazivzgrade,
            Korisnik = korisnik,
            MjernaJedinica = mjernajedinica,
            VrstaEnergije = NazivPotrosnje,
            Kolicina = ukupnakolicina
            
            
            };
            return unospodataka;


        }
        public static void InsertUnosa(Korisnik korisnik, Zgrade zgrade,MjernaJedinica mjernajedinica, VrstaEnergije vrstaenergije)
        {
            string sql = $"INSERT INTO UnosPodataka (NazivZgrade,Naziv_Mjerne_Jedinice,Vrsta_Potrosnje) VALUES ('{zgrade.Naziv_Zgrade}','{mjernajedinica.Naziv_Mjerne_Jedinice}','{vrstaenergije.Naziv_Vrste_Potrosnje}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void UpdateUnosaPodataka(UnosPodataka unospodataka, Zgrade zgrade, VrstaEnergije vrstaenergije,MjernaJedinica mjernajedinice)
        {
            string sql = $"UPDATE UnosPodataka SET NazivZgrade = '{zgrade.Naziv_Zgrade}', Naziv_Mjerne_Jedinice = '{mjernajedinica.Naziv_Mjerne_Jedinice}', Vrsta_Potrosnje = '{vrstaenergije.Naziv_Vrste_Potrosnje}' WHERE Id = {unosPodataka.Id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
