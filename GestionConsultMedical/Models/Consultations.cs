using System;
using System.ComponentModel.DataAnnotations;

namespace myWebAppHTTPS.Models
{
    public class Consultations
    {

        public int id { get; set; }

        public string horaire { get; set; }

        public int Medecins_id { get; set; }  

        public int Patients_id { get; set; }  

        public string raison { get; set; }  


    }
}
