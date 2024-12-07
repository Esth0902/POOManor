namespace testManor.Pages;

public class Monsters
{
    public string Name { get; set; }
    public int PositionX { get; set; } // Colonne
    public int PositionY { get; set; } // Ligne
    public virtual string Image { get; }

    protected int Life { get; set; }
    protected int Damage { get; set; }

    public Monsters(string name, int positionX, int positionY)
    {
        Name = name;
        PositionX = positionX;
        PositionY = positionY;
    }

    public void Attacked(int damage)
    {
        Life -= damage;
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
        Life = 2;
        Damage = 1;
    }
}

public class Ghost : Monsters
{
    public override string Image => "images/ghost.png";
    
    public Ghost(string name, int positionX, int positionY) : base(name, positionX, positionY)
    {
        Life = 3;
        Damage = 2;
    }
}

public class Werewolf : Monsters
{
    public override string Image => "images/werewolf.png";
    
    public Werewolf(string name, int positionX, int positionY) : base(name, positionX, positionY)
    {
        Life = 10;
        Damage = 5;
    }
}


