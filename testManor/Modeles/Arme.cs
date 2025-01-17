namespace testManor.Pages;

public class Arme : Item //Herite de la classe Item
{
    public int Pointdegats { get; }

    public Arme(string nom, string image, int pointdegats) : base(nom, image)
    {
        Pointdegats = pointdegats;
    }
    
    public static List<Arme> ListArme()
    {
        return new List<Arme>
        {
            new Arme("un marteau", "images/hammer.png", 3),
            new Arme("un couteau", "images/couteau.png", 2),
            new Arme("un baton", "images/baton.png", 1),
            new Arme("une poele", "images/poele.png", 2),
            new Arme("un os", "images/os.png", 1),
        };
    }
}