namespace N30_CT_task1;

public class HumanResourceManager : IHumanResourceManager
{
    public List<Employee> Employees { get; set; }
    public List<Department> Departments { get; set; }

    public void AddDepartment(Department department)
    {
        Departments.Where(department => department.Name == department.Name).ToList().ForEach(department =>
            Console.WriteLine("This department has been added to the list of departments"));
        Departments.Add(department);
    }

    public List<Department> GetDepartments()
    {
        return Departments.ToList();
    }

    public void EditDepartments(Department department)
    {
        Departments.Where(department => department.Name == department.Name).ToList().ForEach(department =>
            Console.WriteLine("This department has been edited in the list of departments"));
        Departments.Remove(department);
        Departments.Add(department);
    }

    public void AddEmployee(Employee employee)
    {
        Employees.Where(x => x.Name != employee.Name).ToList().Add(employee);
        Console.WriteLine("This employee has been added to the list of employees");
    }



    public void RemoveEmployee(Employee employee)
    {
        Employees.RemoveAll(x => x.Id == employee.Id);
        Console.WriteLine("This employee has been removed from the list of employees");
    }

    public void EditEmployee(Employee employee)
    {
        var EditedEmployes = Employees.FirstOrDefault(x => x.Id == employee.Id);
        if (EditedEmployes != null)
        {
            EditedEmployes.Name = employee.Name;
            EditedEmployes.Salary = employee.Salary;
            EditedEmployes.Id = employee.Id;
            EditedEmployes.Position = employee.Position;
            EditedEmployes.DepartmentName = employee.DepartmentName;
            EditedEmployes.Surname = employee.Surname;
            EditedEmployes.FullName = employee.FullName;
            Console.WriteLine("This employee sucessfully edited");
        }

        Console.WriteLine("This employee has been not edited");
    }
    public Department findDepartment(string name)
    {
        return Departments.FirstOrDefault(x => x.Name == name);
    }
}