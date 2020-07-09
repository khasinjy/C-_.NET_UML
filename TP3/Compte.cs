using System;

class Compte
{
    protected string num_compte;
    protected Client titulaire;
    protected Banque banque;
    protected double solde;
    protected string date_souscription; 
    protected CarteBleu carte_bleu;

	public string getNum_compte() {
		return this.num_compte;
	}

	public void setNum_compte(string num_compte) {
		this.num_compte = num_compte;
	}

	public Client getTitulaire() {
		return this.titulaire;
	}

	public void setTitulaire(Client titulaire) {
		this.titulaire = titulaire;
	}

	public Banque getBanque() {
		return this.banque;
	}

	public void setBanque(Banque banque) {
		this.banque = banque;
	}

	public double getSolde() {
		return this.solde;
	}

	public void setSolde(double solde) {
		this.solde = solde;
	}

	public string getDate_souscription() {
		return this.date_souscription;
	}

	public void setDate_souscription(string date_souscription) {
		this.date_souscription = date_souscription;
	}

	public CarteBleu getCarte_bleu() {
		return this.carte_bleu;
	}

	public void setCarte_bleu(CarteBleu carte_bleu) {
		this.carte_bleu = carte_bleu;
	}



    public Compte(string num_compte,Client titulaire,Banque banque,double solde,string date_souscription,string nom_carteBleu){
        this.num_compte = num_compte;
        this.titulaire = titulaire;
        this.banque = banque;
        this.solde = solde;
        this.date_souscription = date_souscription;
        this.carte_bleu = new CarteBleu(nom_carteBleu);
    }

    public void Virement(double montant,Compte compte){
        this.solde = this.solde - montant;
		Console.WriteLine("Le compte n°" + this.num_compte +" a été crédité de "+ montant +" euros. Il reste "+ this.solde +"euros sur ce compte.");
        double nouveauSoldeCompte2 = compte.getSolde() + montant;
        compte.setSolde(nouveauSoldeCompte2);
        Console.WriteLine("Le compte n°" + compte.getNum_compte() +" a été débité de "+ montant +" euros. Il reste "+ compte.getSolde() +" euros sur ce compte.");
    }

}