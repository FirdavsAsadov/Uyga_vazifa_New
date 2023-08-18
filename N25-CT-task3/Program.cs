using N25_CT_task3;

var Employes = new List<Emplyee>()
{
    new Emplyee("Jasur", "Jack", 5000, 5),
    new ("Jahon", "Bob", 9000, 7),
    new Emplyee("Jasur", "Jack", 5000, 6),
    new ("Jahon", "Bob", 6700, 8),
    new Emplyee("Jasur", "Jack", 3400, 3),
    new ("Jahon", "Bob", 8700, 4),
    new Emplyee("Jasur", "Jack", 9200, 1),
    new ("Jahon", "Bob", 10000, 9),
};

var emplyess = new EmplayeService(Employes);
int pageSize = 2;
int pageToken = 2;
var pgination = emplyess.GetBySalary(pageSize, pageToken);
Console.WriteLine("Paginated Employes: ");
foreach(var emplyee in pgination)
{
    Console.WriteLine($"{emplyee.FirstName} - {emplyee.LastName} - {emplyee.Salary} - KPI {emplyee.KPI}");
}