using System.Net;
using System.Threading.Channels;
using N29_HT_Task1;

try
{
    var obj = new EventStack<Event>();

    obj.Push(new Event("Adashni Tug'ulgan kuni", new DateTime(2023, 8, 21)));
    obj.Push(new Event("Qodiralining Bayramin", new DateTime(2023, 8, 31)));
    obj.Push(new Event("Mustaqillik", new DateTime(2023, 9, 1)));
    

/*
obj.Add(new Event("Qodiralining Bayramin", new DateTime(2023,8,11)));
*/
    obj.Push(new Event("Qodiralining Bayramin", new DateTime(2024, 10, 13)));
    Console.WriteLine(obj.Peek().Name);
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
public class EventStack<T> : List<T> where T : IEvent
{
    public void Push(T eventt)
    {
        if (Count!=0&&!TrueForAll(x => x.Date < eventt.Date))
        {
            throw new ArgumentException("Xato!!");
        }
        Add(eventt);
    }
    public void Pop()
    {
        if (Count > 0)
        {
            RemoveAt(Count - 1);
        }   
    }
        
    public T Peek()
    {
        if (Count > 0)
        {
            return base[Count - 1];
        }
        return default(T);
    }
}