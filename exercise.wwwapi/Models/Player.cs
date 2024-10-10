namespace exercise.wwwapi.Models
{
    public class Player
    {
        public string name {  get; set; }
        public List<Ship> ships { get; set; }
        public Map selfMap { get; set; }
        public Map targetMap { get; set; }
    }
}
