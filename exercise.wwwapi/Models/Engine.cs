namespace exercise.wwwapi.Models
{
    public class Engine
    {
        public string id { get; }
        public Player player1 { get; }
        public Player player2 {get;}
        public Player current { get; set; }

        public Engine(string firstPlayerName, string secondPlayerName, int mapSize)
        {
            id = Guid.NewGuid().ToString();
            player1 = new Player(firstPlayerName, mapSize);
            player2 = new Player(secondPlayerName, mapSize);
            current = player1;
        }
         
        public bool ShootTurn(Player player, int x, int y)
        {
            var enemy = player == player1 ? player2 : player1;

            if(!enemy.selfMap.ValidCoordinate(x, y))
            {
                throw new Exception("ERROR! Invalid coordinates!");
            }
            if (!enemy.selfMap.tiles[x, y].hit)
            {
                enemy.selfMap.tiles[x, y].hit = true;
                player.targetMap.tiles[x, y].hit = true;

                if(enemy.selfMap.tiles[x, y].ship)
                {
                    foreach(var ship in enemy.ships)
                    {
                        if (ship.coordinates.Any(coord => coord.x == x && coord.y == y))
                        {
                            ship.coordinates.RemoveAll(coord => coord.x == x && coord.y == y);
                            if(ship.coordinates.Count == 0)
                            {
                                ship.dead = true;
                            }
                            break;
                        }

                    }
                }
            }
            else
            {
                throw new Exception("ERROR! Tile has already been shot!");
            }

            current = enemy;
            return enemy.ships.All(s => s.dead);
        }
    }
}
