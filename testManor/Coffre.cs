namespace testManor.Pages;

public class Coffre
{
    private List<object> coffrealeatoires;

    public Coffre()
    {
        coffrealeatoires = new List<object>();
        coffrealeatoires.AddRange(Armures.ListArmures());
        coffrealeatoires.AddRange(Armes.ListArme());

    }

    public object ChoisirObjet()
    {
        Random aleatoire = new Random();
        int index = aleatoire.Next(coffrealeatoires.Count);
        return coffrealeatoires[index];
    }
}


