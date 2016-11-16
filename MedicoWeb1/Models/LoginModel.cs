using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MedicoWeb1.Models
{
    public class LoginModel
    {
        private string _login;

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }
        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public bool Verif()
        {
            bool Isverif = false;
            //connexion

            SqlConnection Oconn = new SqlConnection();
            //2- connexion au serveur
            Oconn.ConnectionString = @"Data Source=MIKEW8\TFTIC2012;Initial Catalog=MedicoDb;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

            try 
                {
                    Oconn.Open();
                    SqlCommand Ocm = new SqlCommand(@"SELECT * FROM Patient WHERE [Login]=@login AND [Password]=@password",Oconn);
            }


            return Isverif;
        }
         
            
        }
    }
