using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace GoldRush_Core.Entities
{
    public interface IGameMap
    {
        public void AddElement([DisallowNull] IMapElement el);
        public void AddElements([DisallowNull] List<IMapElement> elements);
        public List<IMapElement> GetElementsByType([DisallowNull] Type elType);
    }
}
