using System;
using System.Diagnostics.CodeAnalysis;

namespace GoldRush_Core.Types
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position() : this(0,0) { }
        public Position(int x, int y) { X = x; Y = y; }

        public override string ToString() => $"[{X};{Y}]";
        public override bool Equals([DisallowNull] object obj) => obj is Position other ? this == other : false;

        public static bool operator !=([DisallowNull] Position first, [DisallowNull] Position second) => !(first == second);
        public static bool operator ==([DisallowNull] Position first, [DisallowNull] Position second) => first.X == second.X && first.Y == second.Y;

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(X);
            hash.Add(Y);
            return hash.ToHashCode();
        }
    }
}