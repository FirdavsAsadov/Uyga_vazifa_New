using System;
using System.Collections.Generic;

namespace VocationPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assalomu Alaykum bizning <Vocation Planerga> hush kelibsiz");
            List<string> userList = new List<string>
            {
                "Jasur",
                "Donyor",
                "G'ayrat",
                "Qodirali"
            };

            var empty = new Dictionary<DateTime, int>();
            empty.Add(new DateTime(2023, 12, 4, 17, 30, 2), 7);
            empty.Add(new DateTime(2024, 1, 4, 7, 40, 2), 3);
            empty.Add(new DateTime(2021, 3, 5, 21, 23, 5), 4);

            const string Companyname = "The Travel Guru";
            const string NameToken = "{{NameToken}}";
            const string CompanyNameToken = "{{CompanyName}}";
            const string TicketDateToken = "{{TicketDate}}";
            Dictionary<string, string> message = new Dictionary<string, string>()
            {
                {"UnderAge","Uzr Hurmatli {{Name}} siz loyhadan foydalanish uchun kichkinasiz" },
                {"GoldenAger", "Uzr Hurmatli {{Name}} Loyha yoshlar uchun mo'ljallangan"}
            };
            LinkedList<string> emails = new LinkedList<string>();
            emails.AddFirst("Hello {{NameToken}}. Welcome to onboard. ");
            emails.AddLast("Your Data is being processed and we will inform updates for you as soon as possible.{{CompanyName}} Team");
            emails.AddLast("Congratulations! Your flight ticket is booked for {{TicketDate}}.{{CompanyName}} Team");
            var name = string.Empty;
            while (true)
            {
                Console.Write($"Foydalanuvchi ismini kiriting: ");
                name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Noto'g'ri ism kiritildi!!!!   Ismni qaytadan Kiriting: ");
                }
                else
                {
                    var count = 0;
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (name[i] >= '0' && name[i] <= '9')
                        {
                            Console.WriteLine("Xato!!!!");
                            break;
                        }
                        else
                        {
                            count++;
                        }
                    }
                    if (count == name.Length)
                    {
                        break;
                    }
                }
            }
            string age;
            while (true)
            {
                Console.Write($"Foydalanuvchi Yoshini kiriting: ");
                age = Console.ReadLine();
                if (string.IsNullOrEmpty(age))
                {
                    Console.WriteLine("Siz hato kiritdingiz qaytadan urining!!");
                }
                else
                {
                    var count = 0;
                    for (var i = 0; i < age.Length; i++)
                    {
                        if (((age[i] >= 'a' && age[i] <= 'z') || (age[i] >= 'A' && age[i] <= 'Z')))
                        {
                            Console.WriteLine("Sonlardan Foydalaning");
                            break;
                        }
                        else
                        {
                            count++;
                        }
                    }
                    if (count == age.Length)
                    {
                        break;
                    }
                }
            }

            var yosh = Convert.ToInt32(age);
            var uchishvaqti = default(DateTime);
            
            
                if (yosh < 18)
                {
                    Console.WriteLine(message["UnderAge"].Replace(NameToken, name));
                    return;
                }
                else if (yosh >= 18 && yosh <= 90)
                {
                    userList.Add(name);
                    foreach (var item in empty.Keys)
                    {
                        if (empty[item] >= userList.Count)
                        {
                            uchishvaqti = item;
                            break;
                        }
                    }
                    var i = 0;
                    foreach (var item in userList)
                    {
                        foreach (var item2 in emails)
                        {
                        //Console.WriteLine(item2
                        //    .Replace(CompanyNameToken, Companyname)
                        //    .Replace(NameToken, userList[i])
                        //    .Replace(TicketDateToken, uchishvaqti.ToString("yyyy/MM/dd HH:mm:ss")));
                        Console.WriteLine(item2
                            .Replace(CompanyNameToken, Companyname)
                            .Replace(NameToken, userList[i])
                            .Replace(TicketDateToken, uchishvaqti.ToString("yyyy/MM/dd HH:mm:ss tt")));
                    }
                        Console.WriteLine();
                        i++;
                    }
                }
            else if (yosh > 90)
            {
                Console.WriteLine(message["GoldenAger"].Replace(NameToken, name));
                return;
            }
            


        }
    }
}





