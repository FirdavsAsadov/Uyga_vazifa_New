using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N18_HT_Task1
{
    internal class OrderCacheService
    {
        Dictionary<string, int> Caches = new Dictionary<string, int>();
        private static OrderCacheService _instanec;
        public static OrderCacheService GetInstance()
        {
            if( _instanec == null)
            {
                _instanec = new OrderCacheService();
            }
            return _instanec;
        }
        private OrderCacheService() { }
        public int Get(string key)
        {
            if (Caches.ContainsKey(key))
            {
                return Caches[key];
            }
            return default;
        }

        public void Set(string key, int value)
        {
            if(!Caches.ContainsKey(key))
            {
                Caches.Add(key, value);
            }
            else
            {
                throw new Exception("Invalid!!");
            }
        }
    }
}
