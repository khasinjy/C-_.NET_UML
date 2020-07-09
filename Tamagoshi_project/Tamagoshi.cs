using System;

namespace Tamagoshi_project
{
    
    class Tamagoshi
    {
        private int nbePointsDeVie;
        private int nbePointsDeRessource;
        private ILifeStrategy lifeStrategy;

        public void setLifeStrategy(ILifeStrategy lifeStrategy) {
            this.lifeStrategy = lifeStrategy;
        }

        public Tamagoshi(int nbePointsDeVie, int nbePointsDeRessource){
            this.nbePointsDeVie = nbePointsDeVie;
            this.nbePointsDeRessource = nbePointsDeRessource;
        }

        public void play(){
            nbePointsDeVie = nbePointsDeVie+ lifeStrategy.pointsLostWhenPlaying();
        }

        public void eat(){
            nbePointsDeRessource = nbePointsDeRessource + lifeStrategy.pointsLostWhenEating();
        }

    }
}