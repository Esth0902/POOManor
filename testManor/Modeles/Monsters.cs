namespace testManor.Pages;

public class Monsters
{
    public string Name { get; set; }
    public int PositionX { get; set; } // Colonne
    public int PositionY { get; set; } // Ligne
    public virtual string Image { get; }

    protected internal int Life { get; set; }
    protected internal int Damage { get; set; }
    

    public Monsters(string name, int positionX, int positionY)
    {
        Name = name;
        PositionX = positionX;
        PositionY = positionY;
    }

    public bool Alive()
    {
        return Life > 0;
    }
    
}

public class Zombie : Monsters
{
    public override string Image => "images/zombie.png";
    
    public Zombie(string name, int positionX, int positionY) : base(name, positionX, positionY)
    {
        Life = 20;
        Damage = 2;
    }
}

public class Ghost : Monsters
{
    public override string Image => "images/ghost.png";
    
    public Ghost(string name, int positionX, int positionY) : base(name, positionX, positionY)
    {
        Life = 40;
        Damage = 5;
    }
}

public class Werewolf : Monsters
{
    public override string Image => "images/werewolf.png";
    
    public Werewolf(string name, int positionX, int positionY) : base(name, positionX, positionY)
    {
        Life = 70;
        Damage = 20;
    }
}

