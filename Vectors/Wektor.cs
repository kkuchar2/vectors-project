using System;

namespace Vectors
{
    public class Wektor : IComparable<Wektor>
    {
        public Wektor(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
            Dlugosc = Math.Sqrt(X * X + Y * Y + Z * Z);
        }
        
        public double X { get; }

        public double Y { get; }

        public double Z { get; }
        
        public double Dlugosc { get; }
        
        public static Wektor operator +(Wektor w1, Wektor w2)
        {
            return new Wektor(w1.X + w2.X, w1.Y + w2.Y, w1.Z + w2.Z);
        }
        
        public static Wektor operator -(Wektor w1, Wektor w2)
        {
            return new Wektor(w1.X - w2.X, w1.Y - w2.Y, w1.Z - w2.Z);
        }

        public static bool operator ==(Wektor w1, Wektor w2)
        {
            return w1.Equals(w2);
        }
        
        public static bool operator !=(Wektor w1, Wektor w2)
        {
            return !w1.Equals(w2);
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != GetType())
                return false;
            Wektor w = (Wektor) obj;
            return X == w.X && Y == w.Y && Z == w.Z;
        }
        
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }
        
        public static double Dot(Wektor w1, Wektor w2)
        {
            return w1.X * w2.X + w1.Y * w2.Y + w1.Z * w2.Z;
        }
        
        public static Wektor Cross(Wektor w1, Wektor w2)
        {
            return new Wektor(w1.Y * w2.Z - w1.Z * w2.Y,
                w1.Z * w2.X - w1.X * w2.Z,
                w1.X * w2.Y - w1.Y * w2.X);
        }
        
        public static Wektor operator *(Wektor w, double d)
        {
            return new Wektor(w.X * d, w.Y * d, w.Z * d);
        }
        
        public static bool IsOrthogonal(Wektor w1, Wektor w2)
        {
            return Dot(w1, w2) == 0;
        }
        
        public int CompareTo(Wektor other)
        {
            if (Dlugosc < other.Dlugosc)
                return -1;
            
            return Dlugosc > other.Dlugosc ? 1 : 0;
        }
    }
}