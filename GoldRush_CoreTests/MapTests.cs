using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoldRush_Core.Entities;
using System;
using System.Collections.Generic;

namespace Robots_CoreTests
{
    [TestClass]
    public class MapTests
    {
        [TestMethod]
        public void MapInit()
        {
            try
            {
                IGameMap map = new GameMap();
            }
            catch (Exception exc)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void FillMap()
        {
            try 
            {
                IGameMap map = new GameMap();

                var owner = new Owner("Ivan");

                var miner1 = new Miner(owner);
                var miner2 = new Miner(owner);

                map.AddElement(miner1);
                map.AddElement(miner2);

                Assert.AreEqual(2, map.GetElementsByType(typeof(Miner)).Count);

                map.AddElements(new List<IMapElement>() { new Miner(owner), new Miner(owner), new Miner(owner) });

                Assert.AreEqual(5, map.GetElementsByType(typeof(Miner)).Count);

                map.AddElement(new Swamp());
                map.AddElement(new Swamp());

                Assert.AreEqual(5, map.GetElementsByType(typeof(Miner)).Count);
                Assert.AreEqual(2, map.GetElementsByType(typeof(Swamp)).Count);

                Assert.ThrowsException<ArgumentException>(() => map.AddElements(new List<IMapElement>()));
                Assert.ThrowsException<KeyNotFoundException>(() => map.GetElementsByType(typeof(GoldMine)));                
            }
            catch (Exception exc)
            {
                Assert.Fail();
            }
        }
    }
}