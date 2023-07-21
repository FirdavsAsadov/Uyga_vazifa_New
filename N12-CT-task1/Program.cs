/*using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

var Cars = new List<Car>
{
    new Car()
    {
        Name = "Accord",
        Brand = "Honda",
    },
    new Car()
    {
        Name = "Camry",
        Brand = "Toyota",
    },
    new Car()
    {
        Name = "Civic",
        Brand = "Honda",

    },
    new Car()
    {
        Name = "Elantra",
        Brand = "Hyundai",

    },
    new Car()
    {
        Name = "Accord",
        Brand = "Honda",
    },
    new Car()
    {
        Name = "Sonata",
        Brand = "Hyundai",
    },
    new Car()
    {
        Name = "Elantra",
        Brand = "Hyundai",
    },
    new Car()
    {
        Name = "Fusion",
        Brand = "Ford",

    },
    new Car()
    {
        Name = "Malibu",
        Brand = "Chevrolet",

    },
    new Car
    {
        Name = "Accord",
        Brand = "Honda",
    }
};



var duplicatecars = new Dictionary<Car, int>();
foreach (var car in Cars)
{
    if (!duplicatecars.ContainsKey(car))
        duplicatecars.Add(car, 1);
    else duplicatecars[car]++;
}
foreach (var car in duplicatecars)
{
    if (car.Value > 1)
    {
        Console.WriteLine($"{car.Key.Name} - {car.Key.Brand} {car}");
    }
}


public class Car
{
    public string Name { get; set; }
    public string Brand { get; set; }

    public override bool Equals(object? obj)
    {
        return this.GetHashCode() == obj.GetHashCode();
    }
    public override int GetHashCode()
    {
        return Name.GetHashCode()
            + Brand.GetHashCode();
    }



}*/

/*var movies = new List<string>()
{
     "Inception",
    "Dark Knight",
    "Top Gun 2",
    "Don't Look Up",
    "Top Gun"
};
for(var indexA = 0;indexA < movies.Count; indexA++)
{
    for(var indexB = indexA; indexB < movies.Count; indexB++)
    {
        if (movies[indexA].CompareTo(movies[indexB])>0)
        {
            var temp = movies[indexA];
            movies[indexA] = movies[indexB];
            movies[indexB] = temp;
        }
    }
}
foreach(var move in movies)
{
    Console.WriteLine(move);
}
Console.WriteLine();
Console.WriteLine("Kamayish");
Console.WriteLine();
for (var indexA = 0; indexA < movies.Count; indexA++)
{
    for (var indexB = indexA; indexB < movies.Count; indexB++)
    {
        if (movies[indexA].CompareTo(movies[indexB]) < 0)
        {
            var temp = movies[indexA];
            movies[indexA] = movies[indexB];
            movies[indexB] = temp;
        }
    }
}
foreach (var move in movies)
{
    Console.WriteLine(move);
}
*/
/*var count = 0;
var ages = new List<int>();
var age = new List<int>()
{
    12,
    15,
    25,
    12,
    56,
    13,
    81,
    55,
    25,
    12
};
Dictionary<int, int> yoshlar_soni = new Dictionary<int, int>();
foreach(int yosh in ages)
{
    if (yoshlar_soni.ContainsKey(yosh))
    {
        yoshlar_soni[yosh]++;
    }
    else
    {
        yoshlar_soni[yosh] = 1;
    }
    foreach(var pair in yoshlar_soni)
    {
        if(pair.Value > 1)
        {
            Console.WriteLine($"{pair.Key} - {pair.Value}");
        }
    }
}*/
/*using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Foydalanuvchi yoshlarini o'zgartirib yozing
        List<int> yoshlar = new List<int> { 12, 15, 25, 12, 56, 13, 81, 55, 25, 12 };

        // Yoshlarni sanash uchun Dictionary obyekti yaratamiz
        Dictionary<int, int> yoshlar_soni = new Dictionary<int, int>();

        // Yoshlarni sanash
        foreach (int yosh in yoshlar)
        {
            if (yoshlar_soni.ContainsKey(yosh))
                yoshlar_soni[yosh]++;
            else
                yoshlar_soni[yosh] = 1;
        }

        // Natijalarni chiqaramiz
        foreach (var pair in yoshlar_soni)
        {
            if (pair.Value > 1)
                Console.WriteLine($"{pair.Key} - {pair.Value}");
        }
    }
}
*/
/*List<string> names = new List<string>()
{
    "John David Smith",
    "Peter Michael Brown",
    "John Johns Jones",
    "G`ishtmat G`ishtmatov G`ishtmatovich"
};
Dictionary<string, string> search_names = new Dictionary<string, string>();
foreach(var name in names)
{
    var izlanyotgan_ism = Console.ReadLine();
    if (search_names.ContainsKey(name))
    {
        Console.WriteLine(izlanyotgan_ism);
    }
}*/


//////

/*Dictionary<string, string> keyValuePairs = new Dictionary<string, string>()
{
    { "peter", "Peter Michael Brown" },
    { "john", "John David Smith" },
    { "johns", "John Johns Jones" },
    { "g`ishtmat", "G`ishtmat G`ishtmatov G`ishtmatovich" }
};
Console.Write("Keywordni kiriting: ");
var izlanyotgan_soz = Console.ReadLine();
foreach(var item in keyValuePairs)
{
    if (item.Value.ToLower().Contains(izlanyotgan_soz.ToLower()))
    {
        Console.WriteLine(item.Value);
    }
}*/
using System.Dynamic;
///1-Lis
/// 
using System;

/*class Program
{
    static void Main()
    {
        string[] names = new string[] { "john", "Tom", "Tim" };
        string[] names2 = new string[] { "john", "Tim", "Tom" };

        SelectionSort(names);
        SelectionSort(names2);

        Console.WriteLine("names massivi:");
        foreach (var name in names)
            Console.WriteLine(name);

        Console.WriteLine();
        Console.WriteLine("names2 massivi:");
        foreach (var name22 in names2)
        {
            Console.WriteLine(name22);
        }
    }

    static void SelectionSort(string[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (string.Compare(arr[j], arr[minIndex], StringComparison.Ordinal) < 0)
                    minIndex = j;
            }

            string temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }
}
*/



