using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using myWebAppHTTPS.Models;
using Microsoft.AspNetCore.Hosting;

namespace myWebAppHTTPS.Services
{
    public class JsonFilePatientsService
    {
        // Constructeur du service : permet de récupérer les informations concernant l'hote web 
        public JsonFilePatientsService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        // Nom du fichier json à lire 
        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "patients.json"); }
        }

        public IEnumerable<Patients> GetPatients()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Patients[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }


        public void addPatients(Patients patient){

            List<Patients> patients = GetPatients().ToList();
            patients.Add(patient);

            using(var outputStream = File.OpenWrite(JsonFileName))
            {
                JsonSerializer.Serialize<IEnumerable<Patients>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }), 
                    patients
                );
            }



        }
    }

}