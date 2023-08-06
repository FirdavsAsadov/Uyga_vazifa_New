using N18_HT_Task1;
using System;
var management = new OrderManagementService();
management.Add(55);
management.Add(170);
management.Add(250);
management.Add(700);

Console.WriteLine($"Sum{management.Sum()}");
Console.WriteLine($"Sum{management.Sum()}");
Console.WriteLine($"Min{management.Min()}");
Console.WriteLine($"Min{management.Min()}");
Console.WriteLine($"Max{management.Max()}");
Console.WriteLine($"Max{management.Max()}");

management.Add(550);
management.Add(22);
management.Add(95);
management.Add(430);

Console.WriteLine($"Sum{management.Sum()}");
Console.WriteLine($"Sum{management.Sum()}");
Console.WriteLine($"Min{management.Min()}");
Console.WriteLine($"Min{management.Min()}");
Console.WriteLine($"Max{management.Max()}");
Console.WriteLine($"Max{management.Max()}");