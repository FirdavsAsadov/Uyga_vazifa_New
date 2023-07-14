


Console.WriteLine("ism familya sharif kiriting: ");
var input = Console.ReadLine();
var words = input.Split();

for(var index = 0; index<= words.Length; index++)
{
    words[index] = words[index].Substring(0, 1).ToUpper() + words[index].Substring(1).ToLower();
}
Console.WriteLine();



//foreach (var item in words)
//{
//   var change = Convert.ToString(item[0]);
//    for (int i = 1; i < item.Length; i++)
//    {
//        if (item[i] >= 'A' && item[i] <= 'Z')
//        {
//            change += Convert.ToChar(Convert.ToInt32(item[i] + 32));   
//        }
//        else
//        {
//            change += item[i];
//        }
//    }
//    Console.WriteLine(change + "");
//}
//Console.WriteLine();