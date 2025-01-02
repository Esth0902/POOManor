﻿using System.Collections.Immutable;
using Microsoft.AspNetCore.Components;

namespace testManor.Pages.Services;

public class HeroService   
{
   public MonHero MonHero { get; set; }
   
   public List<string> ListInventaire { get; set; } = [];
   public event Action? OnChange;
   
   private readonly NavigationManager nav;

   public HeroService(NavigationManager nav)
   {
      this.nav = nav;
   }

   public void AddNotif(string item)
   {
      ListInventaire.Add(item);
      OnChange?.Invoke();
   }
   
   public void CheckGameOver()
   {
      if (MonHero.Life <= 0)
      {
         // Déclencher le Game Over
         nav.NavigateTo("MapGameOver");
      }
   }
}
 

        