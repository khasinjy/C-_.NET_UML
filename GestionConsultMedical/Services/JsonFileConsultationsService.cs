using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using myWebAppHTTPS.Models;
using Microsoft.AspNetCore.Hosting;

namespace myWebAppHTTPS.Services
{
    public class JsonFileConsultationsService
    {
        // Constructeur du service : permet de récupérer les informations concernant l'hote web 
        public JsonFileConsultationsService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        // Nom du fichier json à lire 
        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "consultations.json"); }
        }

        public IEnumerable<Consultations> GetConsultations()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Consultations[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }


        public void addConsultations(Consultations consultation){

            List<Consultations> consultations = GetConsultations().ToList();
            consultations.Add(consultation);

            using(var outputStream = File.OpenWrite(JsonFileName))
            {
                JsonSerializer.Serialize<IEnumerable<Consultations>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }), 
                    consultations
                );
            }



        }
    }

}