using System;

class StateDebloque : State
{   
    public void Pousser(Tourniquet tourniquet){
        Console.WriteLine("Passez.");
        tourniquet.setState(new StateBloque());
    }

    public void InsererTicketValide(Tourniquet tourniquet){
        Console.WriteLine("Le tourniquet est déjà debloqué.");
    }

    public void InsererTicketNonValide(Tourniquet tourniquet){
        Console.WriteLine("Ticket non valide.Le tourniquet est déjà debloqué.");
    }

}