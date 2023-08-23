namespace N30_CT_task1;

public interface IHumanResourceManager
{
    List<Department> Departments { get; set; }
    void AddDepartment(Department department);
    List<Department> GetDepartments();
    void EditDepartments(Department department);
    void AddEmployee(Employee employee);
    void RemoveEmployee(Employee employee);
    void EditEmployee(Employee employee);
    Department findDepartment(string name);
}