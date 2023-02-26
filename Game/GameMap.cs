public class GameMap
{
    // Define the size of the game map
    private const int MapWidth = 28;
    private const int MapHeight = 31;

    // Define the types of objects that can appear in the game map
    public enum MapObject
    {
        Empty,
        Wall,
        Pellet,
        PowerPellet
    }

    // Define the 2D array that represents the game map
    private MapObject[,] map = new MapObject[MapWidth, MapHeight];

    public GameMap()
    {
        // Set up the initial state of the game map
        for (int x = 0; x < MapWidth; x++)
        {
            for (int y = 0; y < MapHeight; y++)
            {
                // Set the edges of the map to be walls
                if (x == 0 || x == MapWidth - 1 || y == 0 || y == MapHeight - 1)
                {
                    map[x, y] = MapObject.Wall;
                }
                // Set up the rest of the map with pellets and walls
                else
                {
                    // Add walls to the map where needed
                    if ((y == 7 || y == 23) && (x > 3 && x < 24))
                    {
                        map[x, y] = MapObject.Wall;
                    }
                    else if ((x == 3 || x == 24) && (y > 7 && y < 23))
                    {
                        map[x, y] = MapObject.Wall;
                    }
                    else if (y == 15 && x > 7 && x < 20)
                    {
                        map[x, y] = MapObject.Wall;
                    }
                    // Add pellets to the map where there are empty spaces
                    else
                    {
                        map[x, y] = MapObject.Pellet;
                    }
                }
            }
        }

        // Add power pellets to the map in specific locations
        map[1, 1] = MapObject.PowerPellet;
        map[1, MapHeight - 2] = MapObject.PowerPellet;
        map[MapWidth - 2, 1] = MapObject.PowerPellet;
        map[MapWidth - 2, MapHeight - 2] = MapObject.PowerPellet;
    }

    // Get the type of object in a specific cell of the game map
    public MapObject GetMapObject(int x, int y)
    {
        return map[x, y];
    }
}