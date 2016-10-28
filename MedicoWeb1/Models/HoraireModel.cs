using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MedicoWeb1.Models
{
    public class HoraireModel
    {
        private int _idHoraire;

        public int IdHoraire
        {
            get { return _idHoraire; }
            set { _idHoraire = value; }
        }
        private string _jour;

        public string Jour
        {
            get { return _jour; }
            set { _jour = value; }
        }
        private TimeSpan _debMat;

        public TimeSpan DebMat
        {
            get { return _debMat; }
            set { _debMat = value; }
        }
        private TimeSpan _finMat;

        public TimeSpan FinMat
        {
            get { return _finMat; }
            set { _finMat = value; }
        }
        private TimeSpan _debAprem;

        public TimeSpan DebAprem
        {
            get { return _debAprem; }
            set { _debAprem = value; }
        }
        private TimeSpan _finAprem;

        public TimeSpan FinAprem
        {
            get { return _finAprem; }
            set { _finAprem = value; }
        }
        private DateTime _debDate;

        public DateTime DebDate
        {
            get { return _debDate; }
            set { _debDate = value; }
        }
        private DateTime _finDate;

        public DateTime FinDate
        {
            get { return _finDate; }
            set { _finDate = value; }
        }

        public List<HoraireModel> GetAll()
        {
            List<HoraireModel> Laliste = new List<HoraireModel>();
            //1- Connexion
            SqlConnection oConn = new SqlConnection();

            //1.1- Chemin vers le serveur ==>ConnectionString
            oConn.ConnectionString = @"Data Source=26R2-07\WADSQL;Initial Catalog=MedicoDb;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            // 1.2- Ouvrir la connexion 
            try
            {
                oConn.Open();

                //2-Commande

                SqlCommand oCmd = new SqlCommand(@"SELECT * FROM Horaire 
                    where DebDate<=getdate() and FinDate>=GETDATE()",oConn);
                //Forme longue
                //Sql Command oCmd = new SqlCommand();
                //oCmd.Connection = oConn;
                //oCmd.CommandText="SElect"


                //3- Execute

                SqlDataReader oDr = oCmd.ExecuteReader();
                //3.1 - Lire toutes les données
                while (oDr.Read())
                {
                    HoraireModel HM = new HoraireModel();
                    HM.IdHoraire = (int)oDr["IdHoraire"];
                    HM.Jour = oDr["Jour"].ToString();
                    HM.DebMat = (TimeSpan)oDr["DebMat"];
                    HM.FinMat = (TimeSpan)oDr["FinMat"];
                    HM.DebAprem = (TimeSpan)oDr["DebAprem"];
                    HM.FinAprem = (TimeSpan)oDr["FinAprem"];
                    HM.DebDate = (DateTime)oDr["DebDate"];
                    HM.FinDate = (DateTime)oDr["FinDate"];
                    Laliste.Add(HM);
                }

                //3.2- Fermer le reader
                oDr.Close();

                //4- Fermer la connexion 
                oConn.Close();

            }
            catch (Exception)
            {
                
                throw;
            }

            return Laliste;
        }
    }
}