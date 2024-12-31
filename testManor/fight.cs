using testManor.Pages;

public class fight
{
    public MonHero Hero { get; private set; }
    public Monsters Monster { get; private set; }
    public bool IsFightOver { get; private set; } = false;

    public fight(MonHero hero, Monsters monster)
    {
        Hero = hero;  // Correction : assignation correcte des paramètres
        Monster = monster;
    }

    public async void Start()
    {
        while (!IsFightOver)
        {
            StopMoving = true;
            HeroTurn();
            await Task.Delay(2000);
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
        }
    }

    private void MonsterTurn()
    {
        if (IsFightOver) return;

        Hero.Life -= Monster.Damage;

        if (Hero.Life <= 0)
        {
            IsFightOver = true;
        }
    }
}