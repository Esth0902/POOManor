namespace testManor.Pages;

public class Coffre
{
    private List<Item> coffrealeatoires;

    public Coffre()
    {
        coffrealeatoires = new List<Item>();
        coffrealeatoires.AddRange(Armure.ListArmures());
        coffrealeatoires.AddRange(Arme.ListArme());
        coffrealeatoires.AddRange(Potion.ListPotions());
        coffrealeatoires.AddRange(Item.ListDiversItems());

    }

    public object ChoisirObjet()
    {
        Random aleatoire = new Random();
        int index = aleatoire.Next(coffrealeatoires.Count);
        return coffrealeatoires[index];
    }
}


