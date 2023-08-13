List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
/*var querySyntax = from obj in list
                  where obj < 2
                  select obj;
foreach (var item in querySyntax)
{
    Console.WriteLine(item);*/
/*}
*/

var methodSyntax = list.Where(obj => obj > 2);
foreach(var item in methodSyntax)
{
    Console.WriteLine(item);
}
var mixedSyntax = (from obj in list
                   select obj).Max();
Console.WriteLine(mixedSyntax);