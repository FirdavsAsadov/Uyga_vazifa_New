
Console.WriteLine("");






public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }


    public Person()
    {
        //Console.WriteLine("Isworked");
    }
    public Person(string name, int age, string city)
    {
        Name = name;
        Age = age;
        City = city;
    }

    public Person(Person person)
    {
        Name = person.Name;
        Age = person.Age;
        City = person.City;
    }
    /*private Person()
    {
        Console.WriteLine("ishga tushdi: ");

    }*/
}