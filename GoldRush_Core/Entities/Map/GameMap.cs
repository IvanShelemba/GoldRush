using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace GoldRush_Core.Entities
{
    public class GameMap : IGameMap
    {
        private Dictionary<Type, List<IMapElement>> EntitiesOnMap;
        public GameMap() => EntitiesOnMap = new Dictionary<Type, List<IMapElement>>();

        public void AddElement([DisallowNull] IMapElement el)
        {
            Type ElType = el.GetType();
            GroupOf(ElType).Add(el);
        }

        public void AddElements([DisallowNull] List<IMapElement> elements)
        {
            if (elements.Count < 1) throw new ArgumentException();

            Type ElType = elements[0].GetType();
            GroupOf(ElType).AddRange(elements);
        }

        private List<IMapElement> GroupOf(Type elType)
        {
            InitializeGroupIfNotExist(elType);
            
            return EntitiesOnMap[elType];
        }

        private void InitializeGroupIfNotExist(Type elType)
        {
            if (!EntitiesOnMap.ContainsKey(elType)) 
                EntitiesOnMap.Add(elType, new List<IMapElement>());
        }

        public List<IMapElement> GetElementsByType([DisallowNull] Type elType)
        {
            if (EntitiesOnMap.ContainsKey(elType))
                return EntitiesOnMap[elType];
            else 
                throw new KeyNotFoundException();
        }
    }
}