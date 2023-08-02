﻿using N6_Task1;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

List<Student> student = new List<Student>()
{
    new Student(){ Id = 1, FullName = "Abdulxayev Jasurbek Anvar O'g'li",  BirthDay = new DateTime(2005, 12, 12),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2000000 },
    new Student(){ Id = 2, FullName = "Abdumannonov Botirjon Davlat O'g'li",  BirthDay = new DateTime(2004, 1, 17),  EduType = "Python", Payment = 1600000, PaymentAmount = 500000 },
    new Student(){ Id = 3, FullName = "Abdurahmonov Azizbek Alisher O'g'li",  BirthDay = new DateTime(2003, 12, 12),  EduType = "DotNET", Payment = 22400000, PaymentAmount = 3000000 },
    new Student(){ Id = 4, FullName = "Anvarjonov Ozodbek Avazxon O'g'li",  BirthDay = new DateTime(2003, 11, 1),  EduType = "SMM", Payment = 1450000, PaymentAmount = 2500000 },
    new Student(){ Id = 5, FullName = "Asadov Firdavs Asqarbek O'g'li",  BirthDay = new DateTime(2006, 7, 18),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 0 },
    new Student(){ Id = 6, FullName = "Eshmurodov Umarali Abduhalim O'g'li",  BirthDay = new DateTime(2005, 12, 12),  EduType = "SMM", Payment = 1450000, PaymentAmount = 900000 },
    new Student(){ Id = 7, FullName = "Jo'raboyev Boburjon Murodjon O'g'li",  BirthDay = new DateTime(2007, 4, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 2000000 },
    new Student(){ Id = 8, FullName = "Karimjonov Ilhom Ramzjon O'g'li",  BirthDay = new DateTime(2005, 8, 1),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2500000 },
    new Student(){ Id = 9, FullName = "Komiljonov Muhammadaziz Abduraximovich",  BirthDay = new DateTime(2002, 1, 12),  EduType = "Python", Payment = 1600000, PaymentAmount = 1500000 },
    new Student(){ Id = 10, FullName = "Rashidov Asadbek",  BirthDay = new DateTime(2001, 3, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 1900000 },
    new Student(){ Id = 11, FullName = "Sadriddinov Abdurahmon Jurabek O'g'li",  BirthDay = new DateTime(2003, 5, 12),  EduType = "Python", Payment = 1600000, PaymentAmount = 1700000 },
    new Student(){ Id = 12, FullName = "Sattorova Habiba Shuxrat Qizi",  BirthDay = new DateTime(2006, 2, 7),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2000000 },
    new Student(){ Id = 14, FullName = "Tolibov Firdavs Odil O'g'li",  BirthDay = new DateTime(2003, 5, 6),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2700000 },
    new Student(){ Id = 15, FullName = "To'rayev Dinur Alisher O'g'li",  BirthDay = new DateTime(2002, 8, 22),  EduType = "Python", Payment = 1600000, PaymentAmount = 2000000 },
    new Student(){ Id = 16, FullName = "Vositov Muhammadrizo Muhammadtolib O'g'li",  BirthDay = new DateTime(2000, 11, 20),  EduType = "SMM", Payment = 1450000, PaymentAmount = 1400000 },
    new Student(){ Id = 17, FullName = "Xaybullayev Mexroj Mansurjonovich",  BirthDay = new DateTime(2005, 2, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 2000000 },
    new Student(){ Id = 18, FullName = "Xolmuratov Qurbonali Suxrob O'g'li",  BirthDay = new DateTime(2006, 5, 9),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2400000 },
};

int[,] balls = new int[,]
{
    { 90, 100, 75, 60 },
    { 100, 100, 70, 0 },
    { 90, 50, 60, 100 },
    { 60, 50, 100, 90 },
    { 100, 10, 75, 45 },
    { 55, 85, 70, 60 },
    { 95, 90, 40, 100 },
    { 80, 100, 100, 40 },
    { 65, 80, 100, 50 },
    { 80, 90, 100, 60 },
    { 90, 85, 65, 55 },
    { 100, 55, 90, 100 },
    { 80, 75, 90, 60 },
    { 90, 90, 100, 55 },
    { 100, 60, 90, 75 },
    { 90, 80, 50, 100 },
    { 100, 100, 60, 60 },
    { 90, 50, 80, 90 },
};

menu:
while (true)
{
    Console.WriteLine("1 - talabalar ro'yhati\n2 - to'lovlar\n3 - Baholar\n4-Talaba Qo'shish");
    var chose = Console.ReadKey().KeyChar;
    switch (chose)
    {
        case '1':
            Console.Clear();
            var tanlov = "1 - DotNET\n2 - SMM\n3 - Python\n4 - Dizayn\n5-Talaba Qo'shish\n6-Talaba Qo'shish";
            Console.WriteLine(tanlov);
            while (true)
            {
                var choose = Console.ReadKey().KeyChar;



                switch (choose)
                {
                    case '1':
                        Console.Clear();
                        foreach (var item in student)
                        {
                            if (item.EduType.ToLower() == "dotnet")
                                Console.WriteLine($"{item.Id} - {item.FullName} - {item.GetAge()} - {item.EduType}");
                        }
                        Console.WriteLine("\n0 - ortga");
                        break;
                    case '2':
                        Console.Clear();
                        foreach (var item in student)
                            if (item.EduType.ToLower() == "smm")
                                Console.WriteLine($"{item.Id}-{item.FullName} - {item.GetAge()} - {item.EduType}");
                        Console.WriteLine("\n0 - ortga");

                        break;
                    case '3':
                        Console.Clear();
                        foreach (var item in student)
                            if (item.EduType.ToLower() == "python")
                                Console.WriteLine($"{item.Id} - {item.FullName} - {item.GetAge()} - {item.EduType}");
                        Console.WriteLine("\n0 - ortga");

                        break;
                    case '4':
                        Console.Clear();
                        foreach (var item in student)
                            if (item.EduType.ToLower() == "dizayn")
                                Console.WriteLine($"{item.Id} - {item.FullName} - {item.GetAge()} - {item.EduType}");
                        Console.WriteLine("\n0 - ortga");
                        break;
                        
                    case '5':
                        Console.Clear();
                        foreach (var item in student)
                        {
                            Console.WriteLine(value: $"{item.Id} {item.FullName.PadRight(45, ' ')}");
                        }
                        Console.WriteLine("FIO: ");
                        string Fio = Console.ReadLine();

                        Console.WriteLine("Yo'nalish: ");
                        string yonalish = Console.ReadLine();
                        student.Add(new Student
                        {
                            Id = student.Last().Id + 1,
                            FullName = Fio,
                            BirthDay = DateTime.Now,
                            EduType = yonalish
                        });
                        foreach (var item in student)
                        {
                            Console.WriteLine($"{item.Id} {item.FullName}");
                        }
                        break;
                    case '6':
                                    Console.Clear();
                                    foreach (var item in student)
                                    {
                                        Console.WriteLine(value: $"{item.Id} {item.FullName.PadRight(45, ' ')}");
                                    }
                                    Console.WriteLine("O'chirmoqchi Bo'lgan Talabaning Id sini kiriting: ");
                                    int id =  int.Parse(Console.ReadLine());
                                    student.RemoveAt(id);
                                    Console.WriteLine("O'chirildi");
                                    break;
                    case '0':
                        Console.Clear();
                        goto menu;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Xato amal kiritildi!");
                        break;

                }
            }
        case '3':
            Console.Clear();
            Console.WriteLine("Sana                                         11  \t12 \t13 \t14");
            var idx = 0;
            foreach (var item in student)
            {
                var row = string.Empty;
                var name = item.FullName;

                while (true)
                {
                    if (name.Length != 45)
                    {
                        name += " ";
                    }
                    else
                    {
                        break;
                    }
                }
                row += name;
                for (int i = 0; i < 4; i++)
                {
                    var bal = Convert.ToString(balls[idx, i]);
                    while (true)
                    {
                        if (bal.Length != 4)
                        {
                            bal += " ";
                        }
                        else
                        {
                            break;
                        }
                    }
                    row += bal + "\t";
                }
                idx++;

                Console.WriteLine(row + " ");
            }
            break;
        case '2':
            {
                Console.Clear();
                Console.WriteLine("1 - DotNET\n2 - SMM\n3 - Python\n4 - Dizayn");
                while (true)
                {
                    var coce = Console.ReadKey().KeyChar;
                    switch(coce)
                    {
                        case '1':
                            Console.Clear();
                            foreach(var item in student)
                            {
                                if(item.EduType == "DotNET")
                                {
                                    
                                    Console.WriteLine($"{item.Id} - {item.FullName.PadRight(45)} - {item.Payment} - {item.PaymentAmount} to'lagan {item.GetAmount()} ");
                                }
                            }
                            break;
                        case '2':
                            Console.Clear();
                            foreach(var item in student)
                            {
                                if(item.EduType == "SMM")
                                {
                                    Console.WriteLine($"{item.Id} - {item.FullName.PadRight(45)} - {item.Payment} - {item.PaymentAmount} to'lagan {item.GetAmount()} ");
                                }
                            }
                            break;
                        case '3':
                            Console.Clear();
                            foreach (var item in student)
                            {
                                if (item.EduType == "Python")
                                {
                                    Console.WriteLine($"{item.Id} - {item.FullName.PadRight(45)} - {item.Payment} - {item.PaymentAmount} to'lagan {item.GetAmount()} ");
                                }
                            }
                            break;
                        case '4':
                            Console.Clear();
                            foreach (var item in student)
                            {
                                if (item.EduType == "Dizayn")
                                {
                                    Console.WriteLine($"{item.Id} - {item.FullName.PadRight(45)} - {item.Payment} - {item.PaymentAmount} to'lagan {item.GetAmount()} ");
                                }
                            }
                            break;
                    }
                }
            }


            break;
        case 'q':
            goto x;
            break;
        default: Console.Clear(); Console.WriteLine("Noto'g'ri amal!"); break;
    }

x:
    break;
}



