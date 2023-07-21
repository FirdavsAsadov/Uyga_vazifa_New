using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main()
    {
        
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        var prices = new List<int> 
        { 250, 200, 100, 150, 200, 200, 200, 140}; 
        var res = prices.Distinct();                                       
        var count = res.Count();                                                      
        int summa = 0;                                                                   
                                                                                         
        foreach (var item in res)                                                     
        {                                                                                
            int frequency = prices.Count(p => p == item);
            summa += frequency / 3 * item * 2;
            summa += frequency % 3 * item;
        }
        Console.WriteLine(summa);
        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        Console.WriteLine(ts);
    }
}