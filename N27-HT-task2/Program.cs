using N27_HT_task2;
using System.Text.Json;
var skillsA = new List<Skill>()
{
   new Skill("Vue",3),
   new("Angular", 7),
   new("React", 2),
   new(".NET", 6),
   new("Python", 3)
   
};
Console.WriteLine(skillsA);

var updatedItemA = skillsA[2];
updatedItemA.Name = "CSS";
var updatedItemB = skillsA[3];
updatedItemB.Level = 10;
var skillB = new List<Skill>
{
    new("Ruby", 3),
    new("Swift", 5),
    updatedItemA,
    updatedItemB,
    skillsA[0],
    skillsA[3],
};
Console.WriteLine(JsonSerializer.Serialize(skillB));
Console.WriteLine();

var result = skillsA.Update(skillB);
Console.WriteLine(JsonSerializer.Serialize(result));
/*var skillsA = new List<Skill>
{
    new("Vue", 3),
    new("Angular", 7),
    new("React", 2),
    new(".NET", 6),
    new("Python", 3),
};
Console.WriteLine(skillsA);

var updatedItemA = skillsA[2];
updatedItemA.Name = "CSS";
var updatedItemB = skillsA[3];
updatedItemB.Level = 10;


var skillB = new List<Skill>
{
    new("Ruby", 3),
    new("Swift", 5),
    updatedItemA,
    updatedItemB,
    skillsA[0],
    skillsA[3],
};#2#
#1#

Console.WriteLine(JsonSerializer.Serialize(skillB));
Console.WriteLine();

var result = skillsA.Update(skillB);
Console.WriteLine(JsonSerializer.Serialize(result))*/