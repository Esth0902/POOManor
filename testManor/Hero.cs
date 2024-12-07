// namespace testManor.Pages;

// public class Heros {
//     public string Name { get; set; }
//     public int PositionX { get; set; } // Colonne
//     public int PositionY { get; set; } // Ligne
//     public virtual string Image { get; }

//     protected int Life { get; set; }
//     protected int Damage { get; set; }

//     public Heros(string name, int positionX, int positionY)
//     {
//         Name = name;
//         PositionX = positionX;
//         PositionY = positionY;
//     }

//     public void Attacked(int damage)
//     {
//         Life -= damage;
//     }

//     public bool Alive()
//     {
//         return Life > 0;
//     }
    
// }

// public class HeroM : Heros
// {
//     public override string Image => "images/HeroM.png";
    
//     public HeroM(string name, int positionX, int positionY) : base(name, positionX, positionY)
//     {
//         Life = 5;
//         Damage = 1;
//     }
// }

// public class HeroF : Heros
// {
//     public override string Image => "images/HeroF.png";
    
//     public HeroF(string name, int positionX, int positionY) : base(name, positionX, positionY)
//     {
//         Life = 5;
//         Damage = 1;
//     }
// }