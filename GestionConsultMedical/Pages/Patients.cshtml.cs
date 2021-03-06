using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using myWebAppHTTPS.Services;
using myWebAppHTTPS.Models;

namespace myWebAppHTTPS.Pages
{
    public class PatientsModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public JsonFileMedecinsService MedecinsServive { get; }

        public JsonFilePatientsService PatientsServive { get; }

        [BindProperty]

        public Medecins Medecin { get; set; }

        [BindProperty]
        
        public Patients Patient { get; set; }

        public IEnumerable<Consultations> Consultations { get; private set; }

        public IEnumerable<Medecins> Medecins { get; private set; }

        public IEnumerable<Patients> Patients { get; private set; }

        public PatientsModel(ILogger<IndexModel> logger, JsonFileMedecinsService medecinsServive, JsonFilePatientsService patientsServive)
        {
            _logger = logger;
            MedecinsServive = medecinsServive;
            PatientsServive = patientsServive;
        }

        public void OnGet()
        {
            Medecins = MedecinsServive.GetMedecins();
            Patients = PatientsServive.GetPatients();

        }

        public IActionResult OnPost()
        {
            PatientsServive.addPatients(Patient);
            return RedirectToPage("./Patients");
        }


    }
}
