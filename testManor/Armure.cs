namespace testManor.Pages;

public class Armure : Item
{ public int PointDefense { get; set; }

    public Armure(string nom, string image, int pointDefense) : base(nom, image)
    {
        PointDefense = pointDefense;
    }

    public static List<Armure> ListArmures()
    {
        return new List<Armure>

        {
            new Armure("un parapluie", "images/parapluie.png", 2),
            new Armure("un casque", "images/velo.png", 3),
            new Armure("des billes", "images/billes.png", 1),
            new Armure("des patins", "images/patin.png", 2),
            new Armure("de la glue", "images/glue.png", 1),
        };
    }
}