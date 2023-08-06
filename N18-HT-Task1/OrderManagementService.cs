using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N18_HT_Task1
{
    public class OrderManagementService
    {
        List<int> Orders = new List<int>();
        OrderCacheService Cache = OrderCacheService.GetInstance();
        //private OrderManagementService() { }

        public int Max()
        {
            var key = CacheKeyConstants.Max(Orders);
            var max =  Cache.Get(key);
            if(max != default)
            {
                return max;
            }
            else
            {
                var maxx = 0;
                foreach(var x in Orders)
                {
                    if(maxx <  x)
                    {
                        maxx = x;
                    }
                }
                    Cache.Set(key, maxx);
                    return maxx;
            }
        }

        public int Min()
        {
            var key = CacheKeyConstants.Min(Orders);
            var min = Cache.Get(key);
            if(min != default)
            {
                return min;
            }
            else
            {
                var minn = Orders[0];
                foreach(var x in Orders)
                {
                    if(minn > x)
                    {
                        minn = x;
                    }
                }
                    Cache.Set(key, minn);
                    return minn;
            }
        }

        public int Sum()
        {
            var key = CacheKeyConstants.Sum(Orders);
            var sum = Cache.Get(key);
            if(sum != default)
            {
                return sum;
            }
            else
            {
                foreach(var x in Orders)
                {
                    sum += x;
                }
                return sum;
            }
        }

        public void Add(int amount)
        {
            Orders.Add(amount);
        }
    }
}
