namespace testManor.Pages;

public class Item
{
    public string Nom { get; set; }
    public string Image { get; set; }   
    
    public Item(string nom, string image)
    {
        Nom = nom;
        Image = image;
    }
    
    public static List<Item> ListDiversItems()
    {
        return new List<Item>
        {
            new Item("des planches", "images/planches.png"),
            new Item("des vis", "images/vis.png"),
            new Item("une visseuse", "images/visseuse.png"),
        };
    }
}

