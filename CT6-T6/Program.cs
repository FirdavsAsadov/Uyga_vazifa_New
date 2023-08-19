//using CT6_T6;
public class Program
{
    public static void Main(string[] args)
    {

//List<Student> students = new List<Student>()
//{
//    new Student(){ Id = 1, FullName = "Abdulxayev Jasurbek Anvar O'g'li",  Age = 18,  EduType = "DotNET", Payment = 2400000, IsPayable = true },
//    new Student(){ Id = 2, FullName = "Abdumannonov Botirjon Davlat O'g'li",  Age = 20,  EduType = "Python", Payment = 2400000, IsPayable = false

//    },
//    new Student(){ Id = 3, FullName = "Abdurahmonov Azizbek Alisher O'g'li",  Age = 21,  EduType = "DotNET", Payment = 2400000 },
//    new Student(){ Id = 4, FullName = "Anvarjonov Ozodbek Avazxon O'g'li",  Age = 16,  EduType = "SMM", Payment = 2400000 },
//    new Student(){ Id = 5, FullName = "Asadov Firdavs Asqarbek O'g'li",  Age = 17,  EduType = "Dizayn", Payment = 2400000 },
//    new Student(){ Id = 6, FullName = "Eshmurodov Umarali Abduhalim O'g'li",  Age = 23,  EduType = "SMM", Payment = 2400000 },
//    new Student(){ Id = 7, FullName = "Jo'raboyev Boburjon Murodjon O'g'li",  Age = 22,  EduType = "Dizayn", Payment = 2400000 },
//    new Student(){ Id = 8, FullName = "Karimjonov Ilhom Ramzjon O'g'li",  Age = 21,  EduType = "DotNET", Payment = 2400000 },
//    new Student(){ Id = 9, FullName = "Komiljonov Muhammadaziz Abduraximovich",  Age = 19,  EduType = "Python", Payment = 2400000 },
//    new Student(){ Id = 10, FullName = "Rashidov Asadbek",  Age = 20,  EduType = "Dizayn", Payment = 2400000 },
//    new Student(){ Id = 11, FullName = "Sadriddinov Abdurahmon Jurabek O'g'li",  Age = 19,  EduType = "Python", Payment = 2400000 },
//    new Student(){ Id = 12, FullName = "Sattorova Habiba Shuxrat Qizi",  Age = 16,  EduType = "DotNET", Payment = 2400000 },
//    new Student(){ Id = 14, FullName = "Tolibov Firdavs Odil O'g'li",  Age = 24,  EduType = "DotNET", Payment = 2400000 },
//    new Student(){ Id = 15, FullName = "To'rayev Dinur Alisher O'g'li",  Age = 21,  EduType = "Python", Payment = 2400000 },
//    new Student(){ Id = 16, FullName = "Vositov Muhammadrizo Muhammadtolib O'g'li",  Age = 25,  EduType = "SMM", Payment = 2400000 },
//    new Student(){ Id = 17, FullName = "Xaybullayev Mexroj Mansurjonovich",  Age = 16,  EduType = "Dizayn", Payment = 2400000 },
//    new Student(){ Id = 18, FullName = "Xolmuratov Qurbonali Suxrob O'g'li",  Age = 23,  EduType = "DotNET", Payment = 2400000 },
//};
//while (true)
//{
//    Console.WriteLine("Talabalar ro'yhati");
//    var choses = Console.ReadKey().KeyChar;
//    switch (choses)
//    {
//        case '1':
//            Console.WriteLine("\nDotNET \nPython \nDizayn \nSMM");
//            while (true)
//            {
//                var jobs = Console.ReadKey().KeyChar;

//                switch (jobs)
//                {
//                    case '1':
//                        foreach(Student student in students)
//                        {
//                            if(student.EduType == "DotNET")
//                            {
//                                Console.WriteLine($" DotNET Talabalasi \n{student.Id} - {student.FullName} - {student.Age}");
//                            }
//                        }
//                        break;
//                    case '2':
//                        foreach(Student student in students)
//                        {
//                            if(student.EduType.ToLower() == "smm" )
//                            {
//                                Console.WriteLine($" SMM Talabasi \n{student.Id} - {student.FullName} - {student.Age}");
//                            }
//                        }
//                        break;
//                    case '3':
//                        foreach (Student student in students)
//                        {
//                            if (student.EduType == "Python")
//                            {
//                                Console.WriteLine($"Python Talabasi \n{student.Id} - {student.FullName} - {student.Age}");
//                            }
//                        }
//                        break;
//                    case '4':
//                        foreach(Student student in students)
//                        {
//                            if( student.EduType == "Dizayn")
//                            {
//                                Console.WriteLine($"Dizayn Talabasi \n{student.Id} - {student.FullName} - {student.Age}");

//                            }
//                        }
//                        break; 
//            }
//            }
//            break;
//    }
//}

        string[] names = new string[5];
        names[0] = "firdavs";
        names[1] = "Abdurahmon";
        names[2] = "Azizbek";
        names[3] = "Qurbonali";
        names[4] = "ravshan";
        DateTime[] birthday = new DateTime[5];
        birthday[0] = new DateTime(2006, 11, 13);
        birthday[1] = new DateTime(2003, 12, 25);
        birthday[2] = new DateTime(2008, 1, 7);
        birthday[3] = new DateTime(2002, 6, 1);
        birthday[4] = new DateTime(2000, 2, 4);

        Array.Sort(birthday, names);


        var temp = birthday[0];
        for (int indexA = 0; indexA < names.Length - 1; indexA++)
        {
            for (int indexB = indexA + 1; indexB < names.Length; indexB++)
            {
                if (birthday[indexB].DayOfYear > birthday[indexA].DayOfYear)
                {
                    temp = birthday[indexB];
                    birthday[indexA] = birthday[indexB];
                    birthday[indexB] = birthday[indexA];
                    var temp2 = names[indexA];
                    names[indexA] = names[indexB];
                    names[indexB] = temp2;
                }

                for (var i = 0; i < birthday.Length; i++)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}