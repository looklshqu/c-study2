using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer2
{
    class MyCache
    {
        // 필드
        private Dictionary<string, string> cache;

        // 생성자
        public MyCache()
        {
            cache = new Dictionary<string, string>();
            // default값
            cache.Add("Debug", "false");
            cache.Add("Logging", "true");
        }

        // 메서드
        public void Add(string key, string value)
        {
            if (!cache.ContainsKey(key))
            {
                cache[key] = value;
            }
            else
            {
                throw new ApplicationException("key already exists");
            }
        }

        private DateTime cacheExpires;

        // 속성은 파라미터가 없음
        public DateTime CacheExpires
        {
            get { return cacheExpires; }
            set { cacheExpires = value; }
        }

        public string this[string key]
        {
            get
            {
                if (cache.ContainsKey(key))
                {
                    return cache[key];
                }
                return null;
            }
            set
            {
                if (cache.ContainsKey(key))
                {
                    cache[key] = value;
                }
                else
                {
                    throw new ApplicationException("key not found");
                }
            }
        }

        public string Get(string key)
        {
            if (cache.ContainsKey(key))
            {
                return cache[key];
            }
            return null;
        }

        public void Set(string key, string value)
        {
            if (cache.ContainsKey(key))
            {
                cache[key] = value;
            }
            else
            {
                throw new ApplicationException("key not found");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyCache myCache = new MyCache();
            myCache.Add("ItemId", "1100");
            string dbg = myCache.Get("Debug");
            myCache.Set("Debug", "false");

            string db = myCache["Debug"];
            myCache["Debug"] = "false";
        }
    }
}
