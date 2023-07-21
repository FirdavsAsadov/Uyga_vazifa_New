/*using System.Collections.Generic;

foydalanuvchi uchun User modelidan foydalaning 
( ismi, familyasi, yoshi ) 
-ularni listda saqlang va keyin queue ga qo'shing
- queue qoshilgan odamlar shu qo'shilgan 
tartibda chiqishini 
list bilan solishtiring*/

using System.Globalization;

public class Program
{
    static void Main()
    {
        var lists = new List<string>();
        var quee = new Queue<string>();

        lists.Add(new User("Jasur", "Qodirov", 20));
    }
}



public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Age { get; set; }

    public User(string name, string surname, string age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }
}


