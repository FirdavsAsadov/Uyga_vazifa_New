//Console.WriteLine("ismingizni kiriting: ");
//var ism = Console.ReadLine();
//Console.WriteLine("sharifingizni kiriting: ");
//var sharif = Console.ReadLine();
//var formmattingname = string.Format(ism + sharif).ToLower();
//Console.WriteLine(formmattingname);
//var names = "qurbonaliholmuratov firdavsasadov abduraahmonsadriddinov firdavstolibov fazliddinomonov".Split();
//var simbols = "& ! @ # $ % ^ & * () _ - + = ".Split();
//Random random = new Random();
//var randomsymbol = random.Next(simbols.Length);
//if (names.Contains(formmattingname))
//{
//    formmattingname += simbols[randomsymbol];
//    Console.WriteLine(formmattingname);
//}
//else
//{
//    Console.WriteLine("siz umumman hato username kiritdingiz");
//}
public class Program
{
    static void Main()
    {
        var essaybals = 500;

        var essay = "Lorem ipsum dolor sit amet consectetur adipisicing elit. quaerat est " +
                    "quas commodi quibusdam labore, nihil doloribus quam temporibus " +
                    "inventore optio expedita consectetur voluptatem QUIDEM nulla soluta earum." +
                    " Numquam rem alias minima culpa iste distinctio. Eum similique est consequuntur minus, odio " +
                    "nisi recusandae iure asperiores facere, reiciendis voluptate maiores! Repellat, dolorum!".Split();

        int sozlarSoni = SozlarSoni(essay);
        if (sozlarSoni < 500)
        {
            essaybals -= 5;
        }

        else
        {
            essaybals += 5;
        }

        static int SozlarSoni(string essay)
        {
            string[] sozlar = essay.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }
    }
}