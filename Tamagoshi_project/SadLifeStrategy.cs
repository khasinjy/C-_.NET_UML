using System;

class SadLifeStrategy : ILifeStrategy
{
    //-10 ress en mangeant
    //1 pdv en jouant
    public int pointsLostWhenEating(){
        return -10;
    }

    public int pointsLostWhenPlaying(){
        return 1;
    }

}