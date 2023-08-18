namespace N27_CT_TAsk2;

public interface IPriorityQueue<TEvent> where TEvent : ITaskEvent
{
    void Enqueue(TEvent eventItem);

    TEvent Dequeue();

    TEvent Peek();
}