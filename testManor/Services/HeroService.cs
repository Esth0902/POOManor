using System.Collections.Immutable;

namespace testManor.Pages.Services;

public class HeroService 
{
   public MonHero MonHero { get; set; }
   
   public List<string> ListInventaire { get; set; } = ["images/hammer.png"];
   public event Action? OnChange;

   public void AddNotif(string item)
   {
      ListInventaire.Add(item);
      OnChange?.Invoke();
   }
}
 

        