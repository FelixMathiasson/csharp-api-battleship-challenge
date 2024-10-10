namespace exercise.wwwapi.Models
{
    public class Ship
    {
        public string shipType { get; set; }
        public int size { get; set; }
        public bool dead { get; set; }
        public List<(int x, int y)> coordinates {  get; set; }

        public Ship(int size, string shipType)
        {
            this.size = size;
            this.shipType = shipType;
            this.dead = false;
            coordinates = new List<(int x, int y)>();
        }
    }
}
