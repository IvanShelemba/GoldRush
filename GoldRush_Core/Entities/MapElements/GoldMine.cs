using GoldRush_Core.Types;

namespace GoldRush_Core.Entities
{
    public class GoldMine : IMapElement
    {
        public int CurrentCapacity { get; set; }
        public Position CurrentPosition { get; private set; }
    }
}