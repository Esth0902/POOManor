namespace testManor.Pages;

public class Coffre
{
    private List<Item> coffrealeatoires;
    public int PositionX { get; set; }
    public int PositionY { get; set; }
    public bool Ouvert { get; set; } = false;
    public string Image { get; set; } = "images/coffre.png";
    public string ImageOuvert { get; set; } = "images/coffreouvert.png";
    

    public Coffre(int positionX, int positionY)
    {
        PositionX = positionX;
        PositionY = positionY;
        
        coffrealeatoires = new List<Item>();
        coffrealeatoires.AddRange(Armure.ListArmures());
        coffrealeatoires.AddRange(Arme.ListArme());
        coffrealeatoires.AddRange(Potion.ListPotions());

    }

    public object ChoisirObjet()
    {
        Random aleatoire = new Random();
        int index = aleatoire.Next(coffrealeatoires.Count);
        return coffrealeatoires[index];
    }
}


