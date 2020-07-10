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
    public class MedecinsModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public JsonFileMedecinsService MedecinsServive { get; }

        [BindProperty]

        public Medecins Medecin { get; set; }

        public IEnumerable<Medecins> Medecins { get; private set; }

        public MedecinsModel(ILogger<IndexModel> logger, JsonFileMedecinsService medecinsServive)
        {
            _logger = logger;
            MedecinsServive = medecinsServive;
        }

        public void OnGet()
        {
            Medecins = MedecinsServive.GetMedecins();
        }

        public IActionResult OnPost()
        {
            MedecinsServive.addMedecins(Medecin);
            return RedirectToPage("./Medecins");
        }


    }
}
