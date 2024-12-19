namespace testManor.Pages;

public class Heros(string name, int positionX, int positionY)
{
    
    public string? Name { get; set; } = name;
    public int? PositionX { get; set; } = positionX;
    public int? PositionY { get; set; } = positionY;
    public virtual string? Image { get; }

    protected int? Life { get; set; }
    protected int? Damage { get; set; }
        
    protected int? Armor { get; set; }


    public void Attacked(int damage)
    {
        Life -= damage;
    }

    public bool Alive()
    {
        return Life > 0;
    }
    
}

public class Hero : Heros
{
    public override string Image => "images/HeroF.png";
    
    public Hero(string name, int positionX, int positionY) : base(name, positionX, positionY)
    {
        Life = 5;
        Armor = 0;
        Damage = 2;
    }
}