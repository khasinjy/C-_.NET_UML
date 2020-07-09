using System;

interface State {
    void Pousser(Tourniquet tourniquet);
    void InsererTicketValide(Tourniquet tourniquet);
    void InsererTicketNonValide(Tourniquet tourniquet);
}