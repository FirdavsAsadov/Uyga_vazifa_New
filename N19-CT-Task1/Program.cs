public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }

    readonly string nationality;

    private Person()
    {
        
    }
    public Person(string name, int age, string city)
    {
        Name = name;
        Age = age;
        City = city;
    }

    public Person(Person person)
    {
        this.Name = person.Name;
        this.Age = person.Age;
        this.City = person.City;
    }
    static Person()
    {
        Console.WriteLine("ishga tushdi: ");

    }
}