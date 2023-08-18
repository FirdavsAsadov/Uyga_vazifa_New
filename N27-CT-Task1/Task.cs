namespace N27_CT_Task1;

public class Tasks
{
    public Tasks(int id, string description, Priority priority,bool isComplete, DateTime deadline)
    {
        Id = id;
        Description = description;
        Priority = priority;
        IsComplete = isComplete;
        Deadline = deadline;
        CreatedDate = DateTime.Now;
    }
    public int Id { get; set; }
    public string Description { get; set; }
    public Priority Priority { get; set;}
    public DateTime Deadline { get; set; }
    public bool IsComplete { get; set; }
    public DateTime CreatedDate { get; set; }
}
public enum Priority
{
    Low,
    Medium,
    High,
}

