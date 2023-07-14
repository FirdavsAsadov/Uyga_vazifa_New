//Console.WriteLine("ismingizni kiriting: ");
//string ism = Console.ReadLine();
//Console.WriteLine("sharifingizni kiriting: ");
//string sharif = Console.ReadLine();
//Console.WriteLine(ism);
//Console.WriteLine(sharif);

//Console.WriteLine("I\nLove\nC#");
//string file = "D:\\Games\\Sifu by Igruha";
//Console.WriteLine($"Sifu by Igruha fayl joylangan {file}");
//Console.WriteLine("text kiriting: ");
//string soz = Console.ReadLine();
//Console.WriteLine($"{soz.Length} sozning uzunligi {soz[0]}");
//Console.WriteLine("text indexni kiriting: ");
//int index1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("text uzunligini kiriting: ");
//int uzun =  Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"{soz.Substring(index1, uzun)}");
//using System;
//namespace passwordgenerator
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Harflar qatnashsinmi: (yes/no)");
//            string soz = Console.ReadLine();
//            Console.WriteLine("sonlar qatnashsinmi: (yes/no)");
//            string son = Console.ReadLine();
//            Console.WriteLine("simvollar qatnashsinmi: (yes/no)");
//            string simvol = Console.ReadLine();
//            Console.WriteLine("Password uzunligini kiriting: ");
//            int uzunlik = Convert.ToInt32(Console.ReadLine());
//            string password = GeneratePassword(uzunlik, soz, simvol, son);
//            Console.WriteLine("Generatsiyalangan parol: " + password);
//        }
//        static string GeneratePassword(int uzunlik, string soz, string son, string simvol)
//        {
//            const string harflar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
//            const string simvollar = "!@#$%^&*()_+";
//            const string numbers = "0123456789";
//            string belgilar = "";
//            if (soz.ToLower() == "yes") 
//                belgilar += soz;
//            if (simvollar.ToLower() == "yes")
//                belgilar += simvollar;
//            if (numbers.ToLower() == "yes")
//                belgilar += numbers;
//            Random random = new Random();
//            string password = "";
//            while(password.Length < uzunlik)
//            {
//                password += belgilar[random.Next(belgilar.Length)];
//            }
//            return password;

//        }
//    }
//}
Console.WriteLine("emailingizni kiriting: ");
var gmail = Console.ReadLine();
var change = string.Empty;
var count = (int)default;
var count1 = (int)default;
foreach (var i in gmail)
{
    var ite = Convert.ToInt32(i);
    if ((ite >= 97 && ite <= 122)||(ite >= 65 && ite <= 90)||(ite >= 48 && ite <= 57)||  ite == 46 || ite == 64)
    {
        count++;
    }
    else
    {
        Console.WriteLine($"kodingizni shu yerida hato bor {i}");
    }
    if (ite >= 65 && ite <= 90)
    {
        change += Convert.ToChar(ite + 32);
        count1++;
        
    }
    else
    {
        change += item;
    }
    if (count == gmail.Length && count1 != 0) ;
    Console.WriteLine($"manabu yaxshi variant{change}");
}
