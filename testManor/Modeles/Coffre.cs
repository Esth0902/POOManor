namespace testManor.Pages;

public class Coffre
{
    private List<Item> coffrealeatoires;
    public int PositionX { get;}
    public int PositionY { get;}
    public bool Ouvert { get; set; }
    
    public string Image  = "images/coffre.png";
    
    public string ImageOuvert = "images/coffreouvert.png";
    
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


