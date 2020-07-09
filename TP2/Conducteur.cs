using System;

class Conducteur
{
    private string pseudo;
    private Voiture voiture;

    public Conducteur(string pseudo){
        this.pseudo = pseudo;
    }

    public string Pseudo { get => pseudo ; set => pseudo = value ;}

    public Voiture Voiture { get => voiture ; set => voiture = value ;}

    public void Achete(Voiture voiture){
        this.Voiture = voiture;
        Console.WriteLine("Le conducteur " + this.pseudo + " a acheté une nouvelle voiture : une "+ this.Voiture.Marque +".");
    }

    public void Conduit(int distance){
        int distanceRestante = this.voiture.Roule(distance);
        if(distanceRestante <= 0){
            Console.WriteLine("Le conducteur a pu faire son trajet de " + distance + " km.");
        }else{
            Console.WriteLine("Le conducteur n'a pu faire son trajet de " + distance + " km.Il reste " + distanceRestante +" km à parcourir.");
        }
    }

    public void FaireLePlein(){
        this.voiture.MettreLePlein();
        Console.WriteLine("Le conducteur a fait le plein d'essence (" + this.voiture.Plein +"L).");
    }

    public void MettreEssence(int volume){
        Console.WriteLine("La voiture a " + this.voiture.Plein  + "L d'essence.");
        Console.WriteLine("Le conducteur veut mettre " + volume  + "L d'essence à sa voiture.");
        this.Voiture.MettreEssence(volume);
    }

}