namespace Overloading
{
    public class Vector
    {
        private int X { get; set; }
        private int Y { get; set; }
        private int Z { get; set; }

        public Vector(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Add two 3D vectors together
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        // Subtract one 3D vector from another
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        // Negate a 3D vector
        public static Vector operator -(Vector v)
        {
            return new Vector(-v.X, -v.Y, -v.Z);
        }

        // Multiply a vector by a number (scaler)
        public static Vector operator *(Vector v, int scaler)
        {
            return new Vector(v.X * scaler, v.Y * scaler, v.Z * scaler);
        }

        // Divide a vector by a number (scaler)
        public static Vector operator /(Vector v, int scaler)
        {
            return new Vector(v.X / scaler, v.Y / scaler, v.Z / scaler);
        }

        public override string ToString()
        {
            return $"X: {X} Y: {Y} Z: {Z}";
        }

    }
}