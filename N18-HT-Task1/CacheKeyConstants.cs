using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N18_HT_Task1
{
    public static class CacheKeyConstants
    {
        public static string Sum(List<int> hashcode)
        {
            int sum = 0;
            foreach (int i in hashcode)
            {
                sum += i.GetHashCode();
            }
            return $"{sum} - sum";
        }

        public static string Max(List<int> hashcode)
        {
            int max = 0;
            foreach(int i in hashcode)
            {
                max += i.GetHashCode();
            }
            return $"{max} - max";
        }

        public static string Min(List<int> hashcode)
        {
            int min = 0;
            foreach( int i in hashcode)
            {
                min += i.GetHashCode();
            }
            return $"{min} - min";
        }
    }
}
