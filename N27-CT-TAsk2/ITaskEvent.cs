namespace N27_CT_TAsk2;

public interface ITaskEvent
{
    Guid Id { get; }
    string Name { get; }
    byte Priority { get; }

    static bool operator <=(ITaskEvent left, ITaskEvent right)
    {
        return left.Priority <= right.Priority;
    }
    static bool operator>=(ITaskEvent left, ITaskEvent right)
    {
        return left.Priority >= right.Priority;
    }
}