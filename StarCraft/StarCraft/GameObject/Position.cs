namespace StarCraft.GameObject
{
    public struct Position
    {
        public readonly int X;

        public readonly int Y;

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //Constructor parsing input strings coordinates to int value.
        public Position(string xStr, string yStr)
        {
            this.X = int.Parse(xStr);
            this.Y = int.Parse(yStr);
        }

        public override int GetHashCode()
        {
            return this.X * 7 + this.Y;
        }
        //Equality between two points.
        public static bool operator ==(Position a, Position b)
        {
            return a.X == b.X && a.Y == b.Y;
        }
        //Inequality between two points.
        public static bool operator !=(Position a, Position b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", this.X, this.Y);
        }

        public static Position Parse(string pointString)
        {
            string coordinatesPairString = pointString.Substring(1, pointString.Length - 2);
            string[] coordinates = coordinatesPairString.Split(',');
            return new Position(coordinates[0], coordinates[1]);
        }
    }
}
