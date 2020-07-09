using System;

class Voiture
{
    private string marque;
    private int consoCarburant;
    private int plein;
    private int compteurkm;
    private int capaciteReservoir;

    public Voiture(string marque, int consoCarburant, int plein, int compteurkm, int capaciteReservoir){
        this.marque = marque;
        this.consoCarburant = consoCarburant;
        this.plein = plein;
        this.compteurkm = compteurkm;
        this.capaciteReservoir = capaciteReservoir;

    }

    public string Marque { get => marque ; set => marque = value ;}

    public int ConsoCarburant { get => consoCarburant ; set => consoCarburant = value ;}

    public int Plein { get => plein ; set => plein = value ;}

    public int Compteurkm { get => compteurkm ; set => compteurkm = value ;}

    public int CapaciteReservoir { get => capaciteReservoir ; set => capaciteReservoir = value ;}

    public int Roule(int distance){
        //calcul du besoin d'essence pour le trajet
        int essenceAConsomme = (this.consoCarburant*distance)/100;
        //On parcourt le plus de km possibles, perte de l'essence
        this.plein = this.plein - essenceAConsomme;
        int restekm = 0;
        //On regarde ce qui reste dans le reservoir
        if(this.plein<=0){
            //Il n'y avait pas assez d'essence pour le trajet.
            restekm = (- (this.plein) * 100)/this.consoCarburant;
            this.plein = 0;
            Console.WriteLine("La voiture n'a plus d'essence.");
        }
        //ajout de kilometre au compteur
        this.compteurkm += (distance - restekm);
        return restekm;
    }

    public void MettreEssence(int volume){
        int reservoir = volume + this.plein;
        if(reservoir >= this.capaciteReservoir ){
            this.plein = this.capaciteReservoir;
        }else{
            this.plein = this.plein + volume;
        }
        Console.WriteLine("La voiture a " + this.plein  + "L d'essence.");
    }

    public void MettreLePlein(){
        Console.WriteLine("La voiture a " + this.plein  + "L d'essence.");
        this.plein = this.capaciteReservoir;
    }

}