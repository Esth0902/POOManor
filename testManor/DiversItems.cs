namespace testManor.Pages;

public class DiversItems
{
    public string Nom { get; set; }
    public string Image { get; set; }   

    public DiversItems(string nom, string image )
    {
        Nom = nom;
        Image = image;
    }
    
    public static List<DiversItems> ListDiversItems()
    {
        return new List<DiversItems>
        {
            new DiversItems("des planches", "images/planches.png"),
            new DiversItems("des vis", "images/vis.png"),
            new DiversItems("une visseuse", "images/visseuse.png"),
        };
    }
}