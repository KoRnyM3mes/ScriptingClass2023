using System;

public class Program
{
    public Weapon Sword; // created weapons for a medieval setting
    public Weapon Halberd;
    public Weapon BrassKnuckle;
    public Weapon Quarterstaff;

    public void Main()
    {
        Sword = new Weapon();
        Halberd = new Weapon();
        BrassKnuckle = new Weapon();
        Quarterstaff = new Weapon();

        Sword.damage = 4; //The Sword is a fast and deadly close range option that cant stun
        Sword.speed = 3;
        Sword.stun = 0;
        Sword.range = 2;

        Halberd.damage = 5; //The Halberd is a very deadly but slow weapon that slightly stuns. Has good range
        Halberd.speed = 1;
        Halberd.stun = 1;
        Halberd.range = 4;

        BrassKnuckle.damage = 2; //The Brass Knuckle is not as deadly, but is very quick and stuns a ton. Very close range
        BrassKnuckle.speed = 4;
        BrassKnuckle.stun = 5;
        BrassKnuckle.range = 1;

        Quarterstaff.damage = 2; //The Quarterstaff is not deadly, but it has ok speed, a lot of stun and range
        Quarterstaff.speed = 2;
        Quarterstaff.stun = 4;
        Quarterstaff.range = 4;

    }
}

public class Weapon
{
    public int damage; // how much health the weapon decreases each attack
    public int speed; // how fast a weapong can perform an attack
    public int stun; // how much an attack affects hero movement and sway effect
    public int range; //how far away a weapon can perform an attack against target
}