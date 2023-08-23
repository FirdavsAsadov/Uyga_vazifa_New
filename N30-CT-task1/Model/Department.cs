namespace N30_CT_task1;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int WorkLimit { get; set; }
    public decimal SalaryLimit { get; set; }
    /*public List<Employee> Employees { get; set; }*/

    public Department(int id,string name, int workLimit, decimal salaryLimit)
    {
        Id = id;
        Name = name;
        WorkLimit = workLimit;
        SalaryLimit = salaryLimit;
        /*
        Employees = new List<Employee>();
    */
    }

    public void CalcSalary()
    {
        
    }
}