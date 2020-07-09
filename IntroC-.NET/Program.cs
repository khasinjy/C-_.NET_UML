using System;
 
namespace VSC
{
    class Program
    {
        static void Main(string[] args)
        {
            int partie = 1;
            int _scoreTotalPlayer1 = 0;
            int _scoreTotalPlayer2 = 0;
 
            while(partie <= 3){
                //Nouvelle partie : les scores à 0, nombres à deviner à générer
                int _compteurDeTourPlayer1 = 0;
                int _compteurDeTourPlayer2 = 0;
                Random nbrealeatoire = new Random();
                int x = nbrealeatoire.Next(0,100);
                int y = nbrealeatoire.Next(0,100);

                Console.WriteLine("Nouvelle partie! Le joueur 1 commence.");
                
                //Deroulement de la partie
                _compteurDeTourPlayer1 = Score(x);
                Console.WriteLine("Au joueur suivant!");
                _compteurDeTourPlayer2 = Score(y);

                //Déclaration du gagnant de la partie (si egalite, 1 partout)
                if(_compteurDeTourPlayer1<_compteurDeTourPlayer2){
                    Console.WriteLine($"Le joueur 1 a gagné cette partie en {_compteurDeTourPlayer1} tour(s) contre {_compteurDeTourPlayer2} tour(s).");
                    _scoreTotalPlayer1 ++;
                }
                else if(_compteurDeTourPlayer1>_compteurDeTourPlayer2){
                    Console.WriteLine($"Le joueur 2 a gagné cette partie en {_compteurDeTourPlayer2} tour(s) contre {_compteurDeTourPlayer1} tour(s).");
                    _scoreTotalPlayer2 ++;
                }
                else{
                    _scoreTotalPlayer1 ++; 
                    _scoreTotalPlayer2 ++; 
                }

                int Score(int _nombreAdeviner){
                    string _stringEntree = null;
                    int _nombreEntree = 0;
                    int _compteurDeTour = 0;
                    do
                    {
                        _compteurDeTour++;
                        Console.WriteLine("Entrez votre nombre :");
                        _stringEntree = Console.ReadLine();
                        _nombreEntree =int.Parse(_stringEntree);
        
                        if (_nombreEntree == _nombreAdeviner)
                            Console.WriteLine($"Vous avez gagné en {_compteurDeTour} tour(s)");
                        else if (_nombreEntree < _nombreAdeviner)
                            Console.WriteLine("C'est plus");
                        else
                            Console.WriteLine("C'est moins");
        
                    }while (_nombreEntree != _nombreAdeviner);
                    return _compteurDeTour;
                }
                
                //Partie suivante
                partie ++;
            }

            //Déclaration du gagnant de la game après les 3 parties
            if(_scoreTotalPlayer1>_scoreTotalPlayer2){
                Console.WriteLine($"Le joueur 1 est le meilleur joueur avec un score de {_scoreTotalPlayer1} - {_scoreTotalPlayer2}.");
            }
            else if(_scoreTotalPlayer1<_scoreTotalPlayer2){
                Console.WriteLine($"Le joueur 2 est le meilleur joueur avec un score de {_scoreTotalPlayer1} - {_scoreTotalPlayer2}.");
            }
            else{
                Console.WriteLine($"Il y a égalité entre les deux joueurs avec un score de {_scoreTotalPlayer1} partout.");
            }

        }
    }
}