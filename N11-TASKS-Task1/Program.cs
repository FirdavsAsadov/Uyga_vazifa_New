using System.Numerics;
using System.Threading.Tasks.Sources;

var userinput = Console.ReadLine();
    List<string> standard_savollar = new List<string>()
        {
        "What is the capital city of Australia? - Canberra",
        "Which river is the longest in South America?",
        "Which continent is known as the Land Down Under",
        "In which continent is the Sahara Desert located?" ,
        "What is the highest mountain in the European Alps?" ,
        };
    List<string> standar_javoblar = new List<string>()
        {
         "Canberra",
         "Amazon",
         "Australia",
         "Africa",
         "Mont Blanc"
        };
         List<string> Oson_savollar = new List<string>()
         {
         "Name the largest island in the world",
         "What is the largest lake by surface area in Africa?",
         "Name the smallest country in the world by land area."
         };
         List<string> oson_javoblar = new List<string>()
         {
         "Greenland",
         "Victoria",
         "Vatican"
         };
         List<string> Qiyin_savollar = new List<string>()
         {
         "Which country is home to the world's largest coral reef system?",
         "What is the deepest oceanic trench in the world?",
         "Name the active volcano in Italy that famously erupted in AD 79, burying the city of Pompeii."
          };
         List<string> qiyin_javoblar = new List<string>()
         {
         "Australia",
         "Mariana",
         "Mount Vesuvius"
         };
var standard = 0;
var correct = 0;
var incorrect = 0;
while (true)
{
 
    try
    {
        
        Console.WriteLine(standard_savollar[standard]);
        if (Console.ReadLine() == standar_javoblar[standard])
        {
            correct++;
            Console.WriteLine("cORRECT!!");
        }
        else
        {
            incorrect++;
            Console.WriteLine("iNCORRECT");
        }
        if (correct == 2)
        {
            correct = 0;
            standard_savollar.Insert(standard + 1, Qiyin_savollar[standard]);
            standar_javoblar.Insert(standard + 1, qiyin_javoblar[standard]);
        }
        else if (incorrect == 2)
        {
            incorrect = 0;
            standar_javoblar.Insert(standard + 1, oson_javoblar[standard]);
            standard_savollar.Insert(standard + 1, Oson_savollar[standard]);
        }
        standard++;
    }
    catch
    {
        Console.WriteLine("Savollar tugadi");
        break;
    }


}



///1-Agara standard savollarni i teng bolmay qolsa standar javoblarga incorrect ++
/// 2-Aks holda teng bo'ladigan bolsa correct ++
/// 3-
///

