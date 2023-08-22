namespace N29_HT_Task2;

public class ClonableList<T> : List<T>, ICloneable where T : ICloneable
{
    public object Clone()
    {
        var clone = new ClonableList<T>();
        foreach(T item in this)
        {
            clone.Add((T)item.Clone());
        }

        return clone;
    }
}