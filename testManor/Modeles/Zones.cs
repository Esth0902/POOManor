namespace testManor.Pages;

public class Zone
{
    public int StartRow { get; } //1ere ligne de la zone
    public int EndRow { get; } //dernière ligne de la zone
    public int StartColumn { get;} //1ere colonne de la zone
    public int EndColumn { get;} //dernière colonne de la zone

    public Zone(int startRow, int endRow, int startColumn, int endColumn)
    {
        StartRow = startRow;
        EndRow = endRow;
        StartColumn = startColumn;
        EndColumn = endColumn;
    }

    public bool IsInside(int row, int column) //la position actuelle est-elle dans la zone ?
    {
        return row >= StartRow && row <= EndRow && column >= StartColumn && column <= EndColumn; //
    }
}

public class Door
{
    public (int Row, int Column) Position1 { get; } // Position dans la première zone
    public (int Row, int Column) Position2 { get; } // Position dans la deuxième zone

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


public class Exit : Stair
{
    public new string Image = "images/porte.png";

    public Exit(int positionX, int positionY) : base(positionX, positionY)
    {
        PositionX = positionX; 
        PositionY = positionY;
    }
    
}

public class etang : Stair
{
    public new string Image =  "images/etang.png";
    public etang(int positionX, int positionY) : base(positionX, positionY)
    {
        PositionX = positionX;
        PositionY = positionY;
    }
}

public class caisse
{
    public new string Image =  "images/caisse.png";
    public int PositionX { get; }
    public int PositionY { get; }
    public Item Item { get; }
    public caisse(int positionX, int positionY, Item item)
    {
        PositionX = positionX;
        PositionY = positionY;
        Item = item;

    }
}