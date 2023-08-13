using System.Collections;

namespace N22_T1.Models;

// Generic interfeys - qachonki klass ham generic bo'lsa

// Agar interfeysga generic parameter berilsa - generic methodlarni implement qilishi kerak bo'ladi
// Agar interfeysga aniq tip parameter berilsa - o'sha tipdagi methodlarni implement qilishi kerak bo'ladi

public class PriorityQueue<TEvent> : IEnumerable<TEvent>, IPriorityQueue<TEvent> where TEvent : ITaskEvent
{
    private readonly List<TEvent> _events = new();

    public void Enqueue(TEvent eventItem)
    {
        _events.Add(eventItem);
    }

    public TEvent Dequeue()
    {
        var deq = _events[0];
        var idx = 0;
        for(var i  = 0; i < _events.Count; i++)
        {
            if (_events[i].Priority > deq.Priority)
            {
                deq = _events[i];
                idx = i; 
            }
        }
        _events.RemoveAt(idx);
        return deq;
    }

    public TEvent Peek()
    {
        var deq = _events[0];
        var idx = 0;
        for (var i = 0; i < _events.Count; i++)
        {
            if (_events[i].Priority > deq.Priority)
            {
                deq = _events[i];
                idx = i;
            }
        }
        return deq;
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