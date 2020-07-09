using System;

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Banque banque_populaire = new Banque("banque populaire");
            Banque CIC = new Banque("CIC");
            Client Paul = new Client("Smith", "Paul","0676839471");
            CompteCourant compte1 = new CompteCourant("0494672633",Paul,banque_populaire,300.60,"01/03/2020","visa","01/03/2022");
            CompteEpargne epargne = new CompteEpargne("0950495402",Paul,CIC,10,"01/06/2019","mastercard","epargne_logement",500000);
            compte1.Virement(20,epargne);
            compte1.Retrait(10);
        }
    }
}
