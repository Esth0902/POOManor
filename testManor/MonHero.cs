﻿public class MonHero
{
    public string Nom { get; set; }
    public string Image { get; set; }
    public int Damage { get; set; }
    public int Life { get; set; }
    public int Armor { get; set; }

    public MonHero(string nom, string image, int damage, int life, int armor)
    {
        Nom = nom;
        Image = image;
        Damage = damage;
        Life = life;
        Armor = armor;
    }
    
}