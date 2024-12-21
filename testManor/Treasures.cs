namespace testManor.Pages;

public class Weapon {
public string Name { get; set; }
public int PositionX { get; set; } // Colonne
public int PositionY { get; set; } // Ligne
public virtual string Image { get; }
protected int DamagePoints { get; set; }
protected int DefensePoints { get; set; }

public Weapon(string name, int positionX, int positionY)
    {
    Name = name;
    PositionX = positionX;
    PositionY = positionY;
    }
}

public class Knife : Weapon
{
    public override string Image => "images/couteau.png";
    
    public Knife(string name, int positionX, int positionY) : base(name, positionX, positionY)
    {
        DamagePoints = 2;
    }
}

public class Umbrella : Weapon
{
    public override string Image => "images/parapluie.png";
    
    public Umbrella(string name, int positionX, int positionY) : base(name, positionX, positionY)
    {
        DefensePoints = 2;
    }
}

public class Hammer : Weapon
{
    public override string Image => "images/hammer.png";
    
    public Hammer(string name, int positionX, int positionY) : base(name, positionX, positionY)
    {
        DamagePoints = 2;
    }
}

