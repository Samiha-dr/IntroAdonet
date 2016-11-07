using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicoWeb1.Models
{
    public class Patients
    {
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

        private DateTime datenaissance;

        public DateTime Datenaissance
        {
            get { return datenaissance; }
            set { datenaissance = value; }
        }

        [Required]
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
        [DataType(DataType.Password)]
        [MaxLength(15,ErrorMessage="Maximum 15 caractéres")]
        [MinLength(3, ErrorMessage="Minimum 3 caractéres")]
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
        [Display(Name ="Adresse-Email")]
        [DataType(DataType.EmailAddress)]
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


    }
}