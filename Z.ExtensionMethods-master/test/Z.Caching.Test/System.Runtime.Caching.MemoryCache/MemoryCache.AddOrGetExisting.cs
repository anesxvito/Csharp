﻿| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Runtime.Caching;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Caching.Test
{
    [TestClass]
    public class MemoryCache
    {
        [TestMethod]
        public void AddOrGetExisting()
        {
            var cache2 = new CacheTest();
            var cache3 = new CacheTest();
            var cache4 = new CacheTest();

            System.Runtime.Caching.MemoryCache cache = System.Runtime.Caching.MemoryCache.Default;

            int cache1_1 = cache.AddOrGetExisting("cache1", 1);
            int cache1_2 = cache.AddOrGetExisting("cache1", 2);

            int cache2_1 = cache.AddOrGetExisting("cache2", i => cache2.Increment());
            int cache2_2 = cache.AddOrGetExisting("cache2", i => cache2.Increment());

            int cache3_1 = cache.AddOrGetExisting("cache3", i => cache3.Increment(), new CacheItemPolicy());
            int cache3_2 = cache.AddOrGetExisting("cache3", i => cache3.Increment(), new CacheItemPolicy());

            int cache4_1 = cache.AddOrGetExisting("cache4", i => cache4.Increment(), new DateTimeOffset(new DateTime(2100, 01, 01)));
            int cache4_2 = cache.AddOrGetExisting("cache4", i => cache4.Increment(), new DateTimeOffset(new DateTime(2100, 01, 01)));

            Assert.AreEqual(1, cache1_1);
            Assert.AreEqual(1, cache1_2);

            Assert.AreEqual(1, cache2_1);
            Assert.AreEqual(1, cache2_2);

            Assert.AreEqual(1, cache3_1);
            Assert.AreEqual(1, cache3_2);

            Assert.AreEqual(1, cache4_1);
            Assert.AreEqual(1, cache4_2);
        }

        public class CacheTest
        {
            public int Cache = 0;

            public int Increment()
            {
                Cache++;
                return Cache;
            }
        }
    }
}