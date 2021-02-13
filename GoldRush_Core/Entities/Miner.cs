using GoldRush_Core.Types;
using System.Diagnostics.CodeAnalysis;

namespace GoldRush_Core.Entities
{
    public class Miner : IMapElement
    {
        private static int _id = 0;

        public int ID { get; private set; }
        public Owner CurrentOwner { get; set; }
        public Position CurrentPosition { get; set; }

        public int CurrentGold { get; set; }
        public int CurrentStamina { get; set; }

        public Miner([DisallowNull] Owner owner) : this(owner, new Position()) { }
        public Miner([DisallowNull] Owner owner, [DisallowNull] Position position)
        {
            ID = _id++;
            CurrentOwner = owner;
            CurrentPosition = position;

            CurrentGold = 0;
            CurrentStamina = 100;
        }
    }
}