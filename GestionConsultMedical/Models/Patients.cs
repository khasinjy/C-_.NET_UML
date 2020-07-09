using System;
using System.ComponentModel.DataAnnotations;

namespace myWebAppHTTPS.Models
{
    public class Patients
    {

        public int id { get; set; }

        public string nom { get; set; }

        public string prenom { get; set; }  

        public string numero_secu { get; set; }

        public string ville { get; set; }

        public string adresse { get; set; }  

        public string numero { get; set; } 

        public int medecin_traitant { get; set; } 

    }
}
