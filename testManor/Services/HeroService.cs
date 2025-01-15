using System.Collections.Immutable;

namespace testManor.Pages.Services;

public class HeroService   
{
   public MonHero MonHero { get; set; }

   public bool StopMoving { get; set; } = true; //arrêt des déplacements des monstres initialisé à true, passe à false quand on clique sur "jouons"
   public List<string> ListInventaire { get; set; } = [];
   public event Action? OnChange;

   public void AddNotif(string item)
   {
      ListInventaire.Add(item);
      OnChange?.Invoke();
   }
   
   public void ViderInventaire()
   {
      ListInventaire.Clear();
      OnChange?.Invoke();
   }
   
}
 

        