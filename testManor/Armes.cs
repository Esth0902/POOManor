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
            new Armes("un marteau", "images/hammer.png", 3),
            new Armes("un couteau", "images/couteau.png", 2),
            new Armes("un baton", "images/baton.png", 1),
            new Armes("une poele", "images/poele.png", 2),
            new Armes("un os", "images/bone.png", 1),
        };
    }
}