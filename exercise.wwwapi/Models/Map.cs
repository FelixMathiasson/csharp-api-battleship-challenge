using System.Drawing;

namespace exercise.wwwapi.Models
{
    public class Map
    {
        public int size = 10;
        public Tile[,] tiles {  get; set; }

        public Map(int size)
        {
            this.size = size;
            tiles = new Tile[size, size];
        }

        public bool ValidCoordinate(int x, int y)
        {
            return x >= 0 && x < size && y >= 0 && y < size;
        }

        public void PutShip(Tile startTile, Tile endTile, Ship ship)
        {
            //start out by finding the direction
            int verticalAdder = 0;
            int horizontalAdder = 0;
            int horizontalDifference =  Math.Abs(startTile.coord.x - endTile.coord.x);
            int verticalDifference = Math.Abs(startTile.coord.y - endTile.coord.y);



            if (verticalDifference == 0)
            {
                if (startTile.coord.x > endTile.coord.x)
                {
                    horizontalAdder = -1;
                }
                else
                {
                    horizontalAdder = 1;
                }
                for(int x = 0; x < horizontalDifference; x++) 
                {
                    int xCoord = startTile.coord.x + horizontalAdder * x;
                    int yCoord = startTile.coord.y;
                    if (ValidCoordinate(xCoord, yCoord))
                    {
                        tiles[xCoord, yCoord].ship = true;
                        ship.coordinates.Add((xCoord, yCoord));
                    }
                    else
                    {
                        throw new Exception("ERROR! That coordinate is not legal for ship placement!");
                    }
                }
            } 
            else
            {
                if (startTile.coord.y > endTile.coord.y)
                {
                    verticalAdder = -1;
                }
                else
                {
                    verticalAdder = 1;
                }
                for (int y = 0; y < verticalDifference; y++)
                {
                    int xCoord = startTile.coord.x;
                    int yCoord = startTile.coord.y + verticalDifference * y;
                    if (ValidCoordinate(xCoord, yCoord))
                    {
                        tiles[xCoord, yCoord].ship = true;
                        ship.coordinates.Add((xCoord, yCoord));
                    }
                    else
                    {
                        throw new Exception("ERROR! That coordinate is not legal for ship placement!");
                    }
                }
            }


        }
    }
}
