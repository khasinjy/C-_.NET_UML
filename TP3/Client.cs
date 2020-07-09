using System;

class Client
{
    private string numero_client;
    private string nom;
    private string prenom;
    private string numero_telephone;

	public string getNumero_client() {
		return this.numero_client;
	}

	public void setNumero_client(string numero_client) {
		this.numero_client = numero_client;
	}

	public string getNom() {
		return this.nom;
	}

	public void setNom(string nom) {
		this.nom = nom;
	}

	public string getPrenom() {
		return this.prenom;
	}

	public void setPrenom(string prenom) {
		this.prenom = prenom;
	}

	public string getNumero_telephone() {
		return this.numero_telephone;
	}

	public void setNumero_telephone(string numero_telephone) {
		this.numero_telephone = numero_telephone;
	}


    public Client(string nom, string prenom,string numero_telephone){
        this.nom = nom;
        this.prenom = prenom;
        this.numero_telephone = numero_telephone;
    }

}