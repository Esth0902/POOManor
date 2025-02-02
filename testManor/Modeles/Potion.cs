﻿namespace testManor.Pages;

public class Potion : Item //Herite de Item
{ public int Pointdevie { get; }

    public Potion(string nom, string image, int pointdevie) : base(nom, image)
    {
        Pointdevie = pointdevie;
    }
    
    public static List<Potion> ListPotions()
    {
        return new List<Potion>
        {
            new Potion("un snickers", "images/snickers.png", 5),
            new Potion("une boisson energisante", "images/boisson.png", 10),
            new Potion("une trousse à pharmacie", "images/trousse.png", 20),
        };
    }
}