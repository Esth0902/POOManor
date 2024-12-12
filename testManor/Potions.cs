namespace testManor.Pages;

public class Potions
{
    
    public string Nom { get; set; }
    public string Image { get; set; }   
    public int Pointdevie { get; set; }

    public Potions(string nom, string image, int pointdevie)
    {
        Nom = nom;
        Image = image;
        Pointdevie = pointdevie;
    }
    
    public static List<Potions> ListPotions()
    {
        return new List<Potions>
        {
            new Potions("un snickers", "images/snickers.png", 5),
            new Potions("une boisson energisante", "images/boisson.jpg", 10),
            new Potions("une trousse à pharmacie", "images/trousse.jpg", 20),
        };
    }
}