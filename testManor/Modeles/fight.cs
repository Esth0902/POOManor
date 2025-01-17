using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using testManor.Pages;
using testManor.Pages.Services;

public class fight
{
    public MonHero Hero { get;  }
    public Monsters Monster { get;  }
    public bool IsFightOver { get; private set; } = false;
    public bool GameOver { get; private set; } = false;
    public string? Text { get; set; }

    public fight(MonHero hero, Monsters monster)
    {
        Hero = hero;
        Monster = monster;
    }

    public void HeroTurn()
    {
        if (IsFightOver) return;
        Monster.Life -= Hero.Damage;
        if (Monster.Life <= 0)
        {
            IsFightOver = true;
            Text = "Vous avez vaincu le monstre !";
        }
        else
        {
            Text = $"Vous avez infligé {Hero.Damage} dégâts au monstre.";
        }
    }

    public void MonsterTurn()
    {
        if (IsFightOver) return;
        if (Hero.Armor - Monster.Damage > 0)
        {
            Hero.Armor -= Monster.Damage;
        }
        else
        {
            Hero.Armor -= Math.Min(Hero.Armor, Monster.Damage);
            Hero.Life -= Monster.Damage - Hero.Armor;
        }

        if (Hero.Life <= 0)
        {
            IsFightOver = true;
            GameOver = true;
            Text = "Vous avez été vaincu par le monstre.";
        }
        else
        {
            Text = $"Le monstre vous a infligé {Monster.Damage} dégâts.";
        }
    }
}