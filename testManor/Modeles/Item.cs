﻿namespace testManor.Pages;

public class Item
{
    public string Nom { get; }
    public string Image { get; }   
    
    public Item(string nom, string image) //Constructeur
    {
        Nom = nom;
        Image = image;
    }
    
    public static List<Item> ListDiversItems()
    {
        return new List<Item>
        {
            new Item("des planches", "images/planche.png"),
            new Item("des vis", "images/vis.png"),
            new Item("une visseuse", "images/visseuse.png"),
            new Item("la clef de la cuisine", "images/clefgrenier.png")
        };
    }
}

