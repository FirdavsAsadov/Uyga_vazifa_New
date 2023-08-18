namespace N28_CT_task1;

public abstract class IStudent
{
    public abstract string Name { get; set; }
    public Dictionary<string, double> Grades;

    public void AddGrade(string assignment, double grade)
    {
        
    }
}