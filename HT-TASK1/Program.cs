//string[] savol = new string[5];
//Random rd = new Random();   
//savol[0] = "olma qanday rangda bo'ladi";
//savol[1] = "gilosning og'irligi tahminan qancha";
//savol[2] = "Qodirali kim";
//savol[3] = "5 soni qaysi sondan oldin keladi";
//savol[4] = "men kimman";
//string[] togrijavob = new string[5];
//togrijavob[0] = "qizil";
//togrijavob[1] = "100gr";
//togrijavob[2] = "Ajayib inson";
//togrijavob[3] = "4";
//togrijavob[4] = "Firdavs Asadov";
//string[] xatajavob = new string[5];
//xatajavob[0] = "qora";
//xatajavob[1] = "1kg";
//xatajavob[2] = "aktyor";
//xatajavob[3] = "6";
//xatajavob[4] = "mark tvin";
//string[] usersanswer = new string[5];
//var togrijavoblarsoni = 5;
//var ball = 0;
//for (int i = 0; i < savol.Length; i++)
//{
//    var check = rd.Next(0, 2);
//    switch (check)
//    {
//        case 0:
//            Console.WriteLine(savol[i]);
//            Console.WriteLine($"A {togrijavob[i]}");
//            Console.WriteLine($"b {xatajavob[i]}");
//            break;

//        case 1:
//            Console.WriteLine(savol[i]);
//            Console.WriteLine($"A {xatajavob[i]}");
//            Console.WriteLine($"b {togrijavob[i]}");
//            break;
//    }

//    string javob = Console.ReadLine();
//    if (check == 0 && javob == "A")  
//    {
//        Console.WriteLine("Togri: ");
//        ball++;
//    }
//    else if (check == 1 && javob == "B")
//    {
//        Console.WriteLine("Tog'ri javob!");
//        ball++;
//    }
//    else if(check == 0 && javob == "B")
//    {
//        Console.WriteLine("Xato!");
//        togrijavoblarsoni--;

//    }
//    else if(check == 1 && javob == "A")
//    {
//        Console.WriteLine("Xato!");
//        togrijavoblarsoni--;
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("To'plangan ballar: " + ball);
//Console.WriteLine("Tog'ri javoblar soni: " + togrijavoblarsoni);
//Console.WriteLine("\n  test javoblari: ");
//for (int i = 0; i < savol.Length; i++)
//{
//    Console.WriteLine(savol[i] + ": " + usersanswer[i] + "\n" + togrijavob[i]);
//};



//////    2-MASALA    ///////
using System.Data;
DataTable bt = new DataTable();

while (true)
{
    Console.WriteLine("Bitta son kiriting: ");
    var son1 = Console.ReadLine();
    Console.WriteLine("Bitta comanda kiriting *-> multiply | /-> divide | + -> add | - -> subtract | e -> exit: ");
    var comand = Console.ReadLine();
    Console.WriteLine("Ikkinchi sonni kiriitng: ");
    var son2 = Console.ReadLine();
    string ifoda = $"{son1}{comand}{son2}";



    object result = bt.Compute(ifoda, "");
    Console.WriteLine($"Javob: {result}");
    Console.Write("Kalkulyator comand kiriting: ");
    if (comand == "e")
    {
        Console.WriteLine("Exit\nThanks ");
        break;
    }
    else
        continue;
};


