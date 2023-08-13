var numbers = new List<int>()
{
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10,  11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32,-43 
};
var allMusbat = numbers.All(x => x < 0);
Console.WriteLine($"Hammasi musbatmi {allMusbat}");
var isHaveOdd = numbers.Any(x => x != 0);
Console.WriteLine($"Toq son bormi {isHaveOdd}");
var havethreandnine = numbers.Contains(3) && numbers.Contains(9);
Console.WriteLine($"Uch va to'qqiz bormi {havethreandnine}");