/*int a = 5,b = 6, P, S;
GetArea(a, b, out P, out S);
Console.WriteLine("Perimetr" + P);
Console.WriteLine("Yuza" + S);
static void GetArea(int a, int b, out int P, out int S)
{
     P = 2 * (a + b);
     S = a * b;
}*/

/*public class Program
{
    static void Main(string[] args)
    {
        int Min,  Max;
        Console.WriteLine("Son kiriting: ");
        string[]? nums = Console.ReadLine().Split();
        int[] numss = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            numss[i] = int.Parse(nums[i]);
        }
        FindMinMax(out Max, out Min, numss);
        Console.WriteLine($"minimum: {Min}");
        Console.WriteLine($"maximum: {Max}");
        
    
    }
    static void FindMinMax(out int min, out int max, params int[] nums)
    {
      
      min = int.MinValue; max = int.MaxValue;
      foreach (int i in nums)
      {
          if (i > min)
          {
              min = i;
          }
          if (i < max)
          {
              max = i;
          }
        }
    }
}*/

public class Program
{
    static void Main()
    {

    }


   
}

public class Perso
{
    public string Name { get; set; }
    public byte Age { get; set; }
    public bool IsMarried { get; set; }

    public Perso(string name, byte age, bool ismarried)
    {
        Name = name;
        Age = age;
        IsMarried = ismarried;
    }

    public void DisplayInfo()
    {





    }
}


