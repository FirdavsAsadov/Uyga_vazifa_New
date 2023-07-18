
//using System;

//class Program
//{
//    static void Main()
//    {
//        string[] students = new string[10];
//        students[0] = "G'ayrat";
//        students[1] = "Baxodir";
//        students[2] = "Odil";
//        students[3] = "Davron";
//        students[4] = "Sarvinoz";
//        students[5] = "Jonibek";
//        students[6] = "Davron";
//        students[7] = "Qodirali";
//        students[8] = "Muxlisa";
//        students[9] = "Go'zal";

//        int[] balss = new int[10];
//        balss[0] = 70;
//        balss[1] = 90;
//        balss[2] = 50;
//        balss[3] = 80;
//        balss[4] = 20;
//        balss[5] = 90;
//        balss[6] = 99;
//        balss[7] = 67;
//        balss[8] = 50;
//        balss[9] = 86;

//        int maxScore = balss[0];
//        int minScore = balss[0];
//        int totalScore = 0;
//        int above80Count = 0;
//        int above90Count = 0;

//        for (int i = 0; i < 10; i++)
//        {
//            totalScore += balss[i];

//            if (balss[i] > maxScore)
//                maxScore = balss[i];

//            if (balss[i] < minScore)
//                minScore = balss[i];

//            if (balss[i] >= 80)
//                above80Count++;

//            if (balss[i] >= 90)
//                above90Count++;
//        }
//        Console.WriteLine("Eng baland ball: " + maxScore);
//        Console.WriteLine("O'rtacha ball: " + (totalScore / 10));
//        Console.WriteLine("Eng past ball: " + minScore);
//        Console.WriteLine("80 dan yuqori ball olgan talabalar soni: " + above80Count);
//        Console.WriteLine("90 dan yuqori ball olgan talabalar soni: " + above90Count);
//        Console.WriteLine("Talabalar ro'yxati:");
//        for (int i = 0; i < 10; i++)
//        {
//            if (balss[i] >= 90)
//                Console.WriteLine(students[i] + "  - Top");
//            else if (balss[i] >= 80)
//                Console.WriteLine(students[i] + " - Good");
//            else
//                Console.WriteLine(students[i] + " - Fail");
//        }
//    }
//}







    string[] events = new string[10]
    {
        "Algoritmlash Musobaqasi",
        "Navruz",
        "Yangi yil",
        "14-yanvar",
        "8-mart",
        "Frontend musobaqasi",
        "Backend Musobaqasi",
        "NT Ochilish marosomi",
        "Dizayn Musobaqasi",
        "Najot Quiz"
    };

    DateTime[] dates = new DateTime[10]
    {
        new DateTime(2023, 5, 6),
        new DateTime(2022, 5, 5),
        new DateTime(2010, 4, 6),
        new DateTime(2011, 2, 2),
        new DateTime(2009, 1, 2),
        new DateTime(2013, 12, 3),
        new DateTime(2012, 11, 6),
        new DateTime(2019, 8, 5),
        new DateTime(2018, 3, 1),
        new DateTime(2000, 6, 8)
    };
Console.WriteLine("Choose: ");
char symboll = Console.ReadKey().KeyChar;
Console.Clear();
if(symboll == '1')
{
    Console.WriteLine("1 - Eventlarni Saralash \n 2 - Eventni nomi Bo'yicha topish \n 3 - " +
        "eventni vaqti bo'yicha topish \n 4 - " +
        "kelayotgan eventlarni ko'rsatish \n 5 - o'tib ketgan eventlarni ko'rsatish \n 6 - " +
        "kelayotgan eventlarni ko'rsatish ( yaqinligi bo'yicha ) \n 7 - o'tib ketgan eventlarni ko'rsatish " +
        "( yaqinligi bo'yicha ) \n 8 - dasturni yopish  ");
    char symboll2 = Console.ReadKey().KeyChar;
    Console.Clear();
    if(symboll2 == '1')
    {
        Array.Sort(events);
        Console.WriteLine("Saralangan nomlar");
        foreach(var name in events)
        {
            Console.WriteLine(name);
        }

    }
    else if (symboll2 == '2')
    {
        Console.Clear();
        Console.WriteLine("Event NOmini kiriting: ");
         var search = Console.ReadLine();
        if (string.IsNullOrEmpty(search))
        {
            Console.WriteLine("Hech Narsa kiritmadingiz!");
        }
        Console.Clear();
        var count = 0;
        for(var i = 0; i < events.Length; i++)
        {
            if (events[i].ToLower().Contains(search.ToLower()))
            {
                Console.WriteLine($"{events[i]} - {dates[i]}");
                count++;
            }
        }
        if(count == 0)
        {
            Console.WriteLine("Event Mavjud emas!");

        }
        Console.WriteLine();

    }
    else if(symboll2 == '3')
    {
        Console.WriteLine("Events Vaqtini kiriting: ");
        var searchtime = Convert.ToInt32(Console.ReadLine());
        for(var searchevent = 0; searchevent < dates.Length; searchevent++)
        {
            if (Convert.ToString(dates[searchevent]).Contains(Convert.ToString(searchtime)))
            {
                Console.WriteLine($"{events[searchevent]} - {dates[searchtime]} da ");
            }
        }
        Thread.Sleep(4000);
    }
    else if(symboll2 == '4')
    {
        var count = 0;
        for(var i = 0; i < dates.Length; i++)
        {
            if (dates[i].DayOfYear > DateTime.Now.DayOfYear)
            {
                Console.WriteLine($"{events[i]} - {dates[i]}");
                count++;
            }
            else{ 
                Console.WriteLine("Bunday Event yo'q");
            }
        }
    }
    else if(symboll2 == '5')
    {
        var count = 0;
        for(var i =0; i < dates.Length; i++)
        {
            if (dates[i].DayOfYear < DateTime.Now.DayOfYear)
            {
                Console.WriteLine($"{events[i]} - {dates[i]}");
                count++;
            }
        }
    }
    else if(symboll2 == '6')
    {
        Console.Clear();
        var nearName = new string[1];
        var nearDate = new DateTime[1];
        var count = 0;
        for(int i = 0 ; i < events.Length; i++)
        {
            if (dates[i].DayOfYear > DateTime.Now.DayOfYear)
            {
                nearDate[count] = dates[i];
                nearName[count] = events[i];
                count++;
                Array.Resize(ref nearDate,nearDate.Length + 1);
                Array.Resize(ref nearName, nearName.Length + 1);
            }
        }
        Array.Resize(ref nearDate, nearDate.Length - 1);
        Array.Resize(ref nearName, nearName.Length - 1);
        for(var i = 0; i < nearName.Length; i++)
        {
            for(var j = i + 1; j < nearName.Length; j++)
            {
                if (nearDate[i].DayOfYear > nearDate[j].DayOfYear)
                {
                    var temp = nearDate[i];
                    nearDate[i] = nearDate[j];
                    nearDate[j] = temp;

                    var temp2 = nearName[i];
                    nearName[i] = nearName[j];
                    nearName[j] = temp2;
                }
            }
        }
        for(int i =  0; i < nearDate.Length; i++)
        {
            Console.WriteLine($"{nearName[i]} - {nearDate[i]}");
        }
        
    }
    else if(symboll2 == '7')
    {
        Console.Clear();
        var nearName = new string[1];
        var nearDate = new DateTime[1];
        var count = 0;
        for (int i = 0; i < events.Length; i++)
        {
            if (dates[i].DayOfYear < DateTime.Now.DayOfYear)
            {
                nearDate[count] = dates[i];
                nearName[count] = events[i];
                count++;
                Array.Resize(ref nearDate, nearDate.Length + 1);
                Array.Resize(ref nearName, nearName.Length + 1);
            }
        }
        Array.Resize(ref nearDate, nearDate.Length - 1);
        Array.Resize(ref nearName, nearName.Length - 1);
        for (var i = 0; i < nearName.Length; i++)
        {
            for (var j = i + 1; j < nearName.Length; j++)
            {
                if (nearDate[i].DayOfYear < nearDate[j].DayOfYear)
                {
                    var temp = nearDate[i];
                    nearDate[i] = nearDate[j];
                    nearDate[j] = temp;

                    var temp2 = nearName[i];
                    nearName[i] = nearName[j];
                    nearName[j] = temp2;
                }
            }
        }
        for (int i = 0; i < nearDate.Length; i++)
        {
            Console.WriteLine($"{nearName[i]} - {nearDate[i]}");
        }

    }
    else if(symboll2 == '8')
    {
        return;
    }
}
    





