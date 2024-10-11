namespace exercise.wwwapi.Models
{
    public class Player
    {
        public string name {  get; }
        public List<Ship> ships { get; set; }
        public Map selfMap { get; }
        public Map targetMap { get;}
        string id { get; }

        public Player(string name, int mapSize)
        {
            id = Guid.NewGuid().ToString();
            this.name = name;
            selfMap = new Map(mapSize);
            targetMap = new Map(mapSize);
            ships = new List<Ship>();
        }
    }
}
