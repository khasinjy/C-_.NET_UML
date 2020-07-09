using System;

namespace Tamagoshi_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagoshi Popi = new Tamagoshi(50, 50);
            Popi.setLifeStrategy(new HappyLifeStrategy());
            Popi.play();
        }
    }
}
