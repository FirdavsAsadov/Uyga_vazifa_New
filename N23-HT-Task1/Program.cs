/*var sonlar = new List<int>()
{
    1,
    2, 3, 4, 5, 6, 7, 8, 9, 10
};
var list = new List<int>();*/

public class Program
{
    static void Main(string[] args)
    {
        var list = new List<int>();
        var sonlar = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
        };

        var tub_sonlar = sonlar.Where(num => IsPrime(num)).OrderDescending();
        foreach (int num in tub_sonlar)
        {
            Console.WriteLine(num);
        }
        
        static bool IsPrime(int n)
        {
            for(var i = 2; i < n; i++)
            {
                if(n % i == 0)
                    return false;
            }
            return true;
        }
    }
}