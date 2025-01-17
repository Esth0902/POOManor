using System.Collections.Immutable;

namespace testManor.Pages.Services;

public class HeroService   
{
   public MonHero MonHero { get; set; }

   public bool StopMoving { get; set; } = true; //arrêt des déplacements des monstres initialisé à true, passe à false quand on clique sur "jouons"
   public List<string> ListInventaire { get; } = [];
   public event Action? OnChange;  // Événement déclenché lorsqu'il y a un changement dans l'inventaire

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
 

        