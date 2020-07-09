using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using myWebAppHTTPS.Models;
using Microsoft.AspNetCore.Hosting;

namespace myWebAppHTTPS.Services
{
    public class JsonFileMedecinsService
    {
        // Constructeur du service : permet de récupérer les informations concernant l'hote web 
        public JsonFileMedecinsService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        // Nom du fichier json à lire 
        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "medecins.json"); }
        }

        public IEnumerable<Medecins> GetMedecins()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Medecins[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }


        public void addMedecins(Medecins medecin){

            List<Medecins> medecins = GetMedecins().ToList();
            medecins.Add(medecin);

            using(var outputStream = File.OpenWrite(JsonFileName))
            {
                JsonSerializer.Serialize<IEnumerable<Medecins>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }), 
                    medecins
                );
            }



        }
    }

}