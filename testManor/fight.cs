using testManor.Pages;

public class fight
{
    public MonHero Hero { get; private set; }
    public Monsters Monster { get; private set; }
    public bool IsFightOver { get; private set; } = false;
    public string text { get; set; }

    public fight(MonHero hero, Monsters monster)
    {
        Hero = hero;
        Monster = monster;
    }
    public async void Start()
    {
        while (!IsFightOver)
        {
            
            HeroTurn();
            if (IsFightOver) break;
            MonsterTurn();
        }
    }

    private void HeroTurn()
    {
        if (IsFightOver) return;

        Monster.Life -= Hero.Damage;
        if (Monster.Life <= 0)
        {
            IsFightOver = true;
            text = "Vous avez vaincu le monstre !";
        }
    }

    private void MonsterTurn()
    {
        if (IsFightOver) return;
        if (Hero.Armor - Monster.Damage > 0)
        {
            Hero.Armor -= Monster.Damage;
        }
        else
        {
            Hero.Armor-=Math.Min(Hero.Armor, Monster.Damage);
            Hero.Life -= Monster.Damage - Hero.Armor;
        }

        if (Hero.Life <= 0)
        {
            IsFightOver = true;
            text = "le monstre vous a eu !";
        }
    }
}