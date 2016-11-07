using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicoWeb1.Models
{
    public class Medecins
    {
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        private string spécialité;

        public string Spécialité
        {
            get { return spécialité; }
            set { spécialité = value; }
        }
        private bool? disponibilité;

        public bool? Disponibilité
        {
            get { return disponibilité; }
            set { disponibilité = value; }
        }
    }
}