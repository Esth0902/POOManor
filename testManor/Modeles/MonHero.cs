public class MonHero
{
    public string Nom { get; }
    public string Image { get; }
    public int Damage { get; set; }
    public int Life { get; set; }
    public int Armor { get; set; }

    public MonHero(string nom, string image, int damage, int life, int armor) //Constructeur
    {
        Nom = nom;
        Image = image;
        Damage = damage;
        Life = life;
        Armor = armor;
    }
    
}