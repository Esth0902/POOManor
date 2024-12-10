namespace testManor.Pages;

public class Armes
{
    public string Nom { get; set; }
    public string Image { get; set; }   
    public int Pointdegats { get; set; }

    public Armes(string nom, string image, int pointdegats)
    {
        Nom = nom;
        Image = image;
        Pointdegats = pointdegats;
    }
    
    public static List<Armes> ListArme()
    {
        return new List<Armes>
        {
            new Armes("Marteau", "images/hammer.png", 3),
            new Armes("Couteau", "images/couteau.png", 2),
            new Armes("Baton", "images/baton.png", 1),
            new Armes("Poele", "images/poele.png", 2),
            new Armes("Os", "images/bone.png", 1),
        };
    }
}