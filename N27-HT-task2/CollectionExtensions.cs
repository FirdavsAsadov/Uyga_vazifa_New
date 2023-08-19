namespace N27_HT_task2;

public static class CollectionExtensions
{
    public static ICollection<Skill> Update(this ICollection<Skill> first, ICollection<Skill> second)
    {
        var list = first.ToList();
        var addeedItem = second.ExceptBy(first.Select(firstitem => firstitem.Id), ite => ite.Id);
        var removedItem = first.ExceptBy(second.Select(firstitem => firstitem.Id), ite => ite.Id);
        var intersectedItem = first.Select(firstitem => firstitem.Id).Intersect(second.Select(item => item.Id));
        foreach (var item in addeedItem)
        {
            list.Add(item);
        }
        foreach (var item in removedItem)
        {
            list.Remove(item);
        }

        foreach (var keys in intersectedItem)
        {
            var firstItem = list.First(x => x.Id == keys);
            var secondItem = second.First(x => x.Id == keys);
            firstItem.Name =    secondItem.Name;
            firstItem.Level =   secondItem.Level;
        }

        return list;
    }
}