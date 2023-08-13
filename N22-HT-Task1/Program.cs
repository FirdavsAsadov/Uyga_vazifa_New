

using N22_HT_Task1;

var Mylist = new CustomList<int>();

Mylist.Add(1);
Mylist.Add(2);
Mylist.Add(3);
Mylist.Add(4);
Mylist.AddRange(10, 20, 30, 40);
/*foreach (var item in Mylist.items)
{
    Console.WriteLine(item);
}
Console.WriteLine(Mylist.Contains(10));
var lists = new int[10];
Mylist.CopyTo(lists);
foreach (var item in lists)
{
    Console.WriteLine(item);
}*/
/*Console.WriteLine(Mylist.IndexOf(4));*/
/*Mylist.InsertRange(0, 10, 2,5,6);*/
/*Mylist.Remove(2);*/
Mylist.ToArray();
foreach (var item in Mylist.items)
{
    Console.WriteLine(item);
}










