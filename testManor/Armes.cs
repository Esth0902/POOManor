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
    
    List<Armes> armes = new List<Armes>
    {
        new Armes("Marteau", "marteau.png", 3),
        new Armes("Couteau", "epee.png", 2),
        new Armes("Baton", "arc.png", 1),
        new Armes("Poele", "poele.png", 2),
        new Armes("Os","bone.png",1),
    };
}