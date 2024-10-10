namespace exercise.wwwapi.Models
{
    public class Tile
    {
        public Coordinate coord {  get; set; }
        public bool hit { get; set; }
        public bool ship {  get; set; }

        public Tile(int x, int y)
        {
            coord = new Coordinate(x, y);
            hit = false;
            ship = false;
        }
    }
}
