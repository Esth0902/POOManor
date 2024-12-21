namespace testManor.Pages;

public class Zone
{
    public int StartRow { get; set; } //1ere ligne de la zone
    public int EndRow { get; set; } //dernière ligne de la zone
    public int StartColumn { get; set; } //1ere colonne de la zone
    public int EndColumn { get; set; } //dernière colonne de la zone

    public Zone(int startRow, int endRow, int startColumn, int endColumn)
    {
        StartRow = startRow;
        EndRow = endRow;
        StartColumn = startColumn;
        EndColumn = endColumn;
    }

    public bool IsInside(int row, int column)
    {
        return row >= StartRow && row <= EndRow && column >= StartColumn && column <= EndColumn; //
    }
}

public class Door
{
    public (int Row, int Column) Position1 { get; set; } // Position dans la première zone
    public (int Row, int Column) Position2 { get; set; } // Position dans la deuxième zone

    public Door((int Row, int Column) position1, (int Row, int Column) position2)
    {
        Position1 = position1;
        Position2 = position2;
    }
}

public class Stair
{
    public int PositionX { get; set; } // Colonne
    public int PositionY { get; set; } // Ligne
    public virtual string Image { get; }

    public Stair(int positionX, int positionY)
    {
        PositionX = positionX;
        PositionY = positionY;
    }
}