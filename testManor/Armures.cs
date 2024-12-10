namespace testManor.Pages;

public class Armures
{
    public string Nom { get; set; }
    public string Image { get; set; }   
    public int PointDefense { get; set; }

    public Armures(string nom, string image, int pointDefense)
    {
        Nom = nom;
        Image = image;
        PointDefense = pointDefense;
    }

    public static List<Armures> ListArmures()
    {
        return new List<Armures>

        {
            new Armures("Parapluie", "images/parapluie.png", 2),
            new Armures("Casque", "images/velo.jpg", 3),
            new Armures("Billes", "images/billes.png", 1),
            new Armures("Patin", "images/patin.jpg", 2),
            new Armures("Glue", "images/glue.jpg", 1),
        };
    }
}