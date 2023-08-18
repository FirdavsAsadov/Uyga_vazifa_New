namespace N27_CT_Task3;

public class Meeting
{
    public string Name { get; set; }
    public TimeSpan Duration { get; set; }

    public Meeting(string name, TimeSpan duration)
    {
        Name = name;
        Duration = duration;
    }
    public static TimeSpan operator +(TimeSpan t1, Meeting t2)
    {
        return t1 + t2.Duration;
    }
}