using System.Collections;

namespace N27_CT_TAsk2;

public class PriorityQueue<TEvent> : IEnumerable<TEvent>, IPriorityQueue<TEvent> where TEvent : ITaskEvent
{
    private readonly List<TEvent> _events = new();

    public void Enqueue(TEvent eventItem)
    {
        _events.Add(eventItem);
    }

    public TEvent Dequeue()
    {
        
        var a = _events[0];
        var index = 0;
        for (var itemA = 0;itemA < _events.Count; itemA ++)
        {
            if (_events[itemA] <= a)
            {
                a = _events[itemA];
                index = itemA;
            }
        }
        _events.RemoveAt(index);
        return a;
    }

    public TEvent Peek()
    {
        var a = _events[0];
        for (var itemA = 0; itemA < _events.Count; itemA++)
        {
            if (_events[itemA].Priority > a.Priority)
            {
                a = _events[itemA];
            }
        }
        return a;
    }

    public IEnumerator<TEvent> GetEnumerator()
    {
        return _events.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _events.GetEnumerator();
    }
}