namespace N27_CT_Task1;

public class TaskService
{
    private readonly List<Tasks> _tasks = new List<Tasks>();

    public List<Tasks> Add(Tasks task)
    {
        _tasks.Add(task);
        return _tasks;
    }

    public void CompleteTask(int taskId)
    {
        var iscomplet = _tasks.FirstOrDefault(x => x.Id == taskId);
        if (iscomplet != null)
        {
            iscomplet.IsComplete = true;
        }

        throw new InvalidOperationException("this is Argument is not found in the tasks list");
    }

    public List<Tasks> GetTasks(Priority priority)
    {
        return _tasks.Where(t => t.Priority == priority).OrderBy(task => task.Deadline).ToList();
    }
}