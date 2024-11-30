@page "/Map"

    <h3>Map</h3>
    <div class="map">
    @for (int row = 0; row < 15; row++)
{
    <div class="row">
        @for (int col = 0; col < 20; col++)
    {
        @if (row == 7 && col == 10)
        {
            <div class="cell cell1"></div> <!-- Cellule spéciale -->
        }
        else
        {
            <div class="cell"></div> <!-- Cellule normale -->
        }
    }
    </div>
}
</div>