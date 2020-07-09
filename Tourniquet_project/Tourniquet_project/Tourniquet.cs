using System;

class Tourniquet {

	private State state;

	public void setState(State state){
		this.state = state;
	}

    public Tourniquet(){
        this.state = new StateBloque() ;
    }

    public void Pousser(){
        state.Pousser(this);
    }
    
    public void InsererTicketValide(){
        state.InsererTicketValide(this);
    }
    
    public void InsererTicketNonValide(){
        state.InsererTicketNonValide(this);
    }

}