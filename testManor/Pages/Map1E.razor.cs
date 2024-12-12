using Microsoft.AspNetCore.Components;

namespace testManor.Pages;

public partial class Map1E : ComponentBase
{
    private List<Zone> Zones { get; set; } // initialisation de la liste des zones
    private List<Door> Doors { get; set; } // initialisation de la liste des portes

    protected override void OnInitialized()
    {
        Zones = new List<Zone>
        {
            new Zone(0, 4, 0, 9),  // Zone 1 garage
            new Zone(0, 4, 10, 19), // Zone 2 salon
            new Zone(5, 9, 0, 9),  // Zone 3 entrée
            new Zone(5, 9, 10, 19), // Zone 4 cuisine
        };

        Doors = new List<Door>
        {
            new Door((4, 3), (5, 3)), // Porte entre Zone 1 et Zone 3
            new Door((4, 11), (5, 11)), // Porte entre Zone 2 et Zone 4
            new Door((2, 9), (2, 10 )), //porte entre zone 1 garage et zone 2 salon
            new Door((7, 9), (7, 10)) //porte entre zone 3 entrée et zone 4 cuisine
        };
        
        MonstersList = new List<Monsters> // créer la liste des monstres présents sur la carte
        {
            //new Zombie("Zombie1_1", 4, 2),
            new Ghost("ghost1_2", 3, 3),
            new Ghost("ghost2_1", 14, 2),
            new Ghost("ghost2_2", 14, 2),
            //new Zombie("Zombie3_1", 4, 7),
            //new Zombie("Zombie3_2", 4, 7),
            new Ghost("ghost4_1", 19, 7),
            new Ghost("ghost4_2", 19, 7),
        };
    }
    private bool CanMoveTo(int currentRow, int currentCol, int targetRow, int targetCol)
    {
        // Vérifier si le déplacement reste dans la même zone
        var currentZone = Zones.FirstOrDefault(z => z.IsInside(currentRow, currentCol)); 
        //recherche dans la liste des zones le premier élément qui répond à la condition, sinon renvoie null
        var targetZone = Zones.FirstOrDefault(z => z.IsInside(targetRow, targetCol));

        if (currentZone == targetZone)
            return true;

        // Vérifier si le déplacement passe par une porte
        return Doors.Any(d =>
            (d.Position1 == (currentRow, currentCol) && d.Position2 == (targetRow, targetCol)) ||
            (d.Position2 == (currentRow, currentCol) && d.Position1 == (targetRow, targetCol)));
    }
}