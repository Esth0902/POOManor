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
    //Initialisation de la liste des objets     
        coffrealeatoires = new List<Item>();
    //Ajout des armures, armes et potions à la liste d'objets    
        coffrealeatoires.AddRange(Armure.ListArmures());
        coffrealeatoires.AddRange(Arme.ListArme());
        coffrealeatoires.AddRange(Potion.ListPotions());

    }

    public object ChoisirObjet() 
    //Methode pour choisir un objet aléatoire dans le coffre
    {
        Random aleatoire = new Random(); // Génère un nombre aléatoire
        int index = aleatoire.Next(coffrealeatoires.Count); 
        // Next va générer entre 0 et X (nombre d'éléments dans le coffre avec le count)
        return coffrealeatoires[index]; //Retourne un element aléatoire dans le coffre 
    }
}


