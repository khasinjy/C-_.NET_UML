using System;

class CompteCourant : Compte
{
    private string date_echeance;

	public string getDate_echeance() {
		return this.date_echeance;
	}

	public void setDate_echeance(string date_echeance) {
		this.date_echeance = date_echeance;
	}


    public CompteCourant(string num_compte,Client titulaire,Banque banque,double solde,string date_souscription,string nom_carteBleu,string date_echeance)
    : base(num_compte,titulaire,banque,solde,date_souscription,nom_carteBleu)
    {
        this.date_echeance = date_echeance;
    }

    public void Retrait(double montant){
        this.solde = this.solde - montant;
        Console.WriteLine(montant +"€ a été prélevé du compte n° "+ this.num_compte +". Il reste "+ this.solde +"€ sur ce compte.");
    }

}