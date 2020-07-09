using System;

namespace Tourniquet_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Tourniquet roue1 = new Tourniquet();
            roue1.Pousser();
            roue1.InsererTicketNonValide();
            roue1.Pousser();
            roue1.InsererTicketValide();
            roue1.Pousser();
        }
    }
}
