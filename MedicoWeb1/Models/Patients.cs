using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MedicoWeb1.Models
{
    public class Patients
    {
        [KeyAttribute]//primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// generer automatiquement ID
        private int IdClient;

        public int IdClient1
        {
            get { return IdClient; }
            set { IdClient = value; }
        }
        [Required]
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        [Required]
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name="Date De Naissance")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        private DateTime dateNaissance;

        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }

        
        private bool? sex;

        public bool? Sex
        {
            get { return sex; }
            set { sex = value; }
        }


        [Required]
        private string adresse;

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        [Required]
        [Display(Name="Password")]
        [DataType(DataType.Password)]
        [MaxLength(15, ErrorMessage = "Maximum 15 caractéres")]
        [MinLength(3, ErrorMessage = "Minimum 3 caractéres")]
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        [Required]

        private string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public bool Save()
        {
           


                //1-connexion

                SqlConnection Oconn= new SqlConnection();

                    //1.1 - Chemin vers le serveur ==> ConnectionString (DB =>propreties =>data source)

                Oconn.ConnectionString = @"Data Source=26R2-07\WADSQL;Initial Catalog=MedicoDb;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

                    //1.2 - Ouvrir la connexion
                try 
                {
                    Oconn.Open();

                //2-creer la commande
                    SqlCommand oCmd =
               new SqlCommand(@"INSERT INTO dbo.Patient
           ([Nom]
           ,[Prenom]
           ,[DateNaissance]
           ,[Sex]
           ,[Adresse]
           ,[Password]
           ,[Email]
           ,[Login]
           
     VALUES
           (@Nom
           ,@Prenom
           ,@DateNaissance
           ,@Sex
           ,@Adresse
           ,@Password
           ,@Email
           ,@Login
           )"
                              , Oconn);
                
            
                //3 - Ajout des paramètres

               SqlParameter pNom= new SqlParameter();
               pNom.ParameterName = "@Nom";
               pNom.Value = this.Nom;

               SqlParameter pPrenom = new SqlParameter();
               pPrenom.ParameterName = "@Prenom";
               pPrenom.Value = this.Prenom;

               SqlParameter pDateNaissance = new SqlParameter();
               pDateNaissance.ParameterName = "@DateNaissance";
               pDateNaissance.Value = this.DateNaissance;

               
               SqlParameter pEmail = new SqlParameter();
               pEmail.ParameterName = "@Email";
               pEmail.Value = this.Email;
               
               
              
               SqlParameter pLogin = new SqlParameter();
               pLogin.ParameterName = "@Login";
               pLogin.Value = this.Login;

               SqlParameter pPassword = new SqlParameter();
               pPassword.ParameterName = "@Password";
               pPassword.Value = this.Password;

               SqlParameter pSex = new SqlParameter();
               pSex.ParameterName = "@Sex";
               pSex.Value = this.Sex;


               oCmd.Parameters.Add(pNom);
               oCmd.Parameters.Add(pPrenom);
               oCmd.Parameters.Add(pDateNaissance);
               
               oCmd.Parameters.Add(pEmail);
               
              
               
               oCmd.Parameters.Add(pLogin);
               oCmd.Parameters.Add(pPassword);
               oCmd.Parameters.Add(pSex);

               oCmd.ExecuteNonQuery();
                
                //4 - Fermer la connexion
                Oconn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}