﻿namespace exercise.wwwapi.Models
{
    public class Coordinate
    {
        public int x { get; set; }
        public int y { get; set; }
        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
