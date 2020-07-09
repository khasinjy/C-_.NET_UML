using System;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Conducteur conducteur1 = new Conducteur("Brad");
            Voiture mazda2016 = new Voiture("Mazda",2,20,100000,50);
            conducteur1.Achete(mazda2016);
            conducteur1.Conduit(250);
            //conducteur1.FaireLePlein();
            conducteur1.MettreEssence(12);
            //Console.WriteLine(conducteur1.Voiture.Plein); //Afficher le plein d'essence de la voiture du conducteur
        }
    }
}
