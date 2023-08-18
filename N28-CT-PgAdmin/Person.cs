using System.ComponentModel.DataAnnotations.Schema;

namespace N28_CT_PgAdmin;
[Table("person")]
public class Person
{
    public Person(string login, string email, int age)
    {
        Login = login;
        Email = email;
        Age = age;
    }

    [Column("id")]
    public int Id { get; set;}
    [Column("login")]
    public string Login { get; set;}
    [Column("email")]   
    public string Email { get; set;}
    [Column("age")]
    public int Age { get; set;}
    
}