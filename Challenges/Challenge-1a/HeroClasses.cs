using System;

public class Program
{
    public Hero HeroOne;
    public Hero HeroTwo;
    public Hero HeroThree; // added new hero

    public void Main()
    {
        HeroOne = new Hero();
        HeroTwo = new Hero();
        HeroThree = new Hero();

        HeroOne.health = 2;  //rebalanced hero 1, slow heavy hitter
        HeroOne.powerlevel = 3;
        HeroOne.speed = 1;

        HeroTwo.health = 3; //hero 2 can take a hit, but cant dish it out
        HeroTwo.powerlevel = 1;
        HeroTwo.speed = 2;

        HeroThree.health = 1; //hero 3 is fast and deadly, but can easily be hurt
        HeroThree.powerlevel = 2;
        HeroThree.speed = 3;
    }
}

public class Hero
{
    public int health;
    public int powerlevel;
    public int speed; //added movement speed value
}