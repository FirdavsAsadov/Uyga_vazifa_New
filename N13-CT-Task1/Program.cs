


/*GameEngine? obj = new GameEngine();
*/
/*obj.Display();*/
var obj2 = new OptimazedGameEngine();
obj2.Display();



public class Hero
{
    public  Guid Id;
    public string Name;

    public override string ToString()
    {
        return $"The Hero ==>  {Id} ==> {Name}";
    }
}

public class GameEngine
{
    public List<Hero> heroList = new List<Hero>();

    public GameEngine()
    { 

        heroList.Add(new Hero() { Id =Guid.NewGuid(), Name = "Yurnero" });
        heroList.Add(new Hero() { Id = Guid.NewGuid(), Name = "Sven" });
        heroList.Add(new Hero() { Id = Guid.NewGuid(), Name = "Tiny" });
    }

    public void Display()
    {
        foreach(var hero in heroList)
        {
            Console.WriteLine(hero.ToString());
        }
    }
}
public class OptimazedGameEngine : GameEngine
{
    public OptimazedGameEngine()
    {
        heroList.Add(new Hero() { Id = Guid.NewGuid(), Name = "Invoker" });
        heroList.Add(new Hero() { Id = Guid.NewGuid(), Name = "Lina" });
        heroList.Add(new Hero() { Id = Guid.NewGuid (), Name = "Medusa" });
    }
}
