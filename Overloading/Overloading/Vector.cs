using System.Numerics;

namespace Overloading
{
    public class Vector
    {
        private double X { get; set; }
        private double Y { get; set; }
        private double Z { get; set; }

        public Vector(double x, double y, double z)
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
            return new Vector(-v.X, v.Y, -v.Z);
        }

        // Multiply a vector by a number (scaler)
        public static Vector operator *(Vector v, double scaler)
        {
            return new Vector(v.X * scaler, v.Y * scaler, v.Z * scaler);
        }

        // Divide a vector by a number (scaler)
        public static Vector operator /(Vector v, double scaler)
        {
            return new Vector(v.X / scaler, v.Y / scaler, v.Z / scaler);
        }

        public override string ToString() => $"X: {X} Y: {Y} Z: {Z}";
    }
}