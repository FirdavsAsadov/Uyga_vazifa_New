namespace N27_HT_task2;

public class Skill
{
    public Guid Id {get; set; }
    public string Name { get; set; }
    public int Level { get; set; }

    public Skill(string name, int level)
    {
        Id = Guid.NewGuid();
        Name = name;
        Level = level;
    }
}