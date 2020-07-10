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
    public class ConsultationsModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public JsonFileConsultationsService ConsultationsServive { get; }

        public JsonFileMedecinsService MedecinsServive { get; }

        public JsonFilePatientsService PatientsServive { get; }

        [BindProperty]
        public Consultations Consultation { get; set; }

        public Medecins Medecin { get; set; }

        public Patients Patient { get; set; }

        public IEnumerable<Consultations> Consultations { get; private set; }

        public IEnumerable<Medecins> Medecins { get; private set; }

        public IEnumerable<Patients> Patients { get; private set; }

        public ConsultationsModel(ILogger<IndexModel> logger, JsonFileConsultationsService consultationsServive, JsonFileMedecinsService medecinsServive, JsonFilePatientsService patientsServive)
        {
            _logger = logger;
            ConsultationsServive = consultationsServive;
            MedecinsServive = medecinsServive;
            PatientsServive = patientsServive;
        }

        public void OnGet()
        {

            Consultations = ConsultationsServive.GetConsultations();
            Medecins = MedecinsServive.GetMedecins();
            Patients = PatientsServive.GetPatients();

        }

        public IActionResult OnPost()
        {
            ConsultationsServive.addConsultations(Consultation);
            return RedirectToPage("./Consultations");
        }
    }
}
