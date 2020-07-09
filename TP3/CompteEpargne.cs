using System;

class CompteEpargne : Compte
{
    private string type;
    private float plafond;

	public string getType() {
		return this.type;
	}

	public void setType(string type) {
		this.type = type;
	}

	public float getPlafond() {
		return this.plafond;
	}

	public void setPlafond(float plafond) {
		this.plafond = plafond;
	}


 // Utilisant :base() pour appeler le Constructeur de la classe mère.
    public CompteEpargne(string num_compte,Client titulaire,Banque banque,double solde,string date_souscription,string nom_carteBleu,string type,float plafond)
    : base(num_compte,titulaire,banque,solde,date_souscription,nom_carteBleu)
    {
        this.type = type;
        this.plafond = plafond;
    }

}