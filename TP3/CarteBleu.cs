using System;

class CarteBleu
{
    private string nom;
    private bool active;

	public string getNom() {
		return this.nom;
	}

	public void setNom(string nom) {
		this.nom = nom;
	}

	public bool isActive() {
		return this.active;
	}

	public void setActive(bool active) {
		this.active = active;
	}


    public CarteBleu(string nom){
        this.nom = nom;
        this.active = true; //par defaut, la carte est activée
    }

}