using System;

class StateBloque : State
{   
    public void Pousser(Tourniquet tourniquet){
        Console.WriteLine("Veuillez insérer un ticket.");
    }
    
    public void InsererTicketValide(Tourniquet tourniquet){
        Console.WriteLine("Veuillez pousser le tourniquet.");
        tourniquet.setState(new StateDebloque());
    }
    
    public void InsererTicketNonValide(Tourniquet tourniquet){
        Console.WriteLine("Ticket invalide.");
    }

}