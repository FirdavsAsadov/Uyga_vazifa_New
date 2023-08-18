using N25_CT_Task2;
using System;
using Newtonsoft.Json;
class Program
{
    static void Main(string[] args)
    {
        string json = File.ReadAllText(@"D:\person\jerson.txt"); // JSON fayl nomini o'zgartiring
        Root root = JsonConvert.DeserializeObject<Root>(json);

        // JSON ma'lumotlari deserializatsiya qilindi, root obyekti orqali ularga murojat qilishingiz mumkin
        Console.WriteLine("Country Name: " + root.name.common);
        Console.WriteLine("Capital: " + root.capital[0]);
        // Boshqa ma'lumotlarga ham murojat qilishingiz mumkin

        // Qo'shimcha amallar
        // Misol uchun, latlng koordinatalarini chiqarish
     /*   Console.WriteLine("Latitude: " + root.latlng[0]);
        Console.WriteLine("Longitude: " + root.latlng[1]);*/
    }
}
