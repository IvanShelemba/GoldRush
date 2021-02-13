using System;
using System.Diagnostics.CodeAnalysis;

namespace GoldRush_Core.Entities
{
    public class Owner
    {
        private static int _id = 0;

        public int ID { get; private set; }
        public String Name { get; private set; }

        public Owner([DisallowNull] string name)
        { 
            ID = _id++;
            Name = name;
        }
    }
}