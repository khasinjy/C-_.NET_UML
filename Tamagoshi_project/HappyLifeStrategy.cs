using System;

class HappyLifeStrategy : ILifeStrategy
{   
    //-5 ress en mangeant
    //+10 pdv en jouant
    public int pointsLostWhenEating(){
        return -5;
    }

    public int pointsLostWhenPlaying(){
        return 10;
    }

}