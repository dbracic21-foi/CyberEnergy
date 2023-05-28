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
        public static UnosPodataka GetUnosPodataka(int Id )
        {
            UnosPodataka unospodataka = null;
            
            string sql = $"SELECT * FROM UnosPodataka WHERE Id_UnosaPodataka = {Id}";
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
        public static List<UnosPodataka>GetUnosPodataka()
        {
            List<UnosPodataka> unospodataka = new List<UnosPodataka>();
            string sql = $"SELECT * FROM UnosPodataka";
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

            int id = int.Parse(reader["Id_UnosaPodataka"].ToString());

            int  NazivZgrade = int.Parse(reader["Id_UnosaPodataka"].ToString());
            var nazivzgrade = RepositoryZgrade.GetZgrade(NazivZgrade);
            int  Naziv_Mjerne_Jedinice = int.Parse(reader["Id_UnosaPodataka"].ToString());
            var mjernajedinica = RepositoryMjerneJedinice.GetMjernaJedinica(Naziv_Mjerne_Jedinice);
            int Id_VrstePotrosnje = int.Parse(reader["Id_UnosaPodataka"].ToString());
            var NazivPotrosnje = RepositoryVrstaEnergije.GetEnergija(Id_VrstePotrosnje);
            int UkupnaKolicina = int.Parse(reader["Id_UnosaPodataka"].ToString());
            var ukupnakolicina = RepositoryKolicine.GetKolicina(UkupnaKolicina);

            var unospodataka = new UnosPodataka { 
            Id_UnosaPodataka = id,
            Zgrade = nazivzgrade,
            MjernaJedinica = mjernajedinica,
            VrstaEnergije = NazivPotrosnje,
            Kolicina = ukupnakolicina
            };
            return unospodataka;


        }
        public static void InsertUnosa(Zgrade zgrade,MjernaJedinica mjernajedinica, VrstaEnergije vrstaenergije, Kolicina kolicina)
        {
            string sql = $"INSERT INTO UnosPodataka (NazivZgrade,Naziv_Mjerne_Jedinice,Vrsta_Potrosnje,Kolicina) VALUES ('{zgrade.Naziv_Zgrade}','{mjernajedinica.Naziv_Mjerne_Jedinice}','{vrstaenergije.Naziv_Vrste_Potrosnje}','{kolicina.UkupnaKolicina})";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        
        public static void UpdateUnosaPodataka(Zgrade zgrade, VrstaEnergije vrstaenergije,MjernaJedinica mjernajedinice, int id)
        {
         
            string sql = $"UPDATE UnosPodataka SET NazivZgrade = '{zgrade.Naziv_Zgrade}', Naziv_Mjerne_Jedinice = '{mjernajedinice.Naziv_Mjerne_Jedinice}', Vrsta_Potrosnje = '{vrstaenergije.Naziv_Vrste_Potrosnje}' WHERE Id_UnosaPodataka = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void DeleteUnosaPodataka(int id)
        {
            string sql = $"DELETE FROM UnosaPodataka WHERE Id_UnosaPodataka = {id} ";
        }
        
    }
}
