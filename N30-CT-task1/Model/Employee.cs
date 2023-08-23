namespace N30_CT_task1;

public class Employee
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
    public string DepartmentName { get; set; }
    static int _count = 1000;
    private string No;

    public Employee(string name, string fullName, string surname, string position, decimal salary, string departmentName)
    {
        Id = Guid.NewGuid();
        No = _count++.ToString();
        FullName = fullName;
        Surname = surname;
        Position = position;
        Salary = salary;
        DepartmentName = departmentName;
        Name = name;
        FullName = fullName;
        Surname = surname;
        Position = position;
        Salary = salary;
        DepartmentName = departmentName;
    }
}