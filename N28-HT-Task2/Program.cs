using System.Threading.Channels;
using System.Text.Json;
using N28_HT_Task2;

var post = new List<VideoPost>()
{
    new VideoPost("httpjakuy","veidio1",45,14,Topics.Business),
    new VideoPost("httpjakuy","veidio2",65,124,Topics.Fun),
    new VideoPost("httpjakuy","veidio3",45,94,Topics.Gaming),
    new VideoPost("httpjakuy","veidio4",43,84,Topics.IT),
    new VideoPost("httpjakuy","veidio5",15,44,Topics.Fun),
    new VideoPost("httpjakuy","veidio6",66,34,Topics.IT),
    new VideoPost("httpjakuy","veidio7",47,14,Topics.Gaming),
    new VideoPost("httpjakuy","veidio8",411,24,Topics.Business),
    new VideoPost("httpjakuy","veidio9",49,54,Topics.Fun),
};
Console.WriteLine("Most LIkes");
Console.WriteLine(post.Max(x => x.Likes));
Console.WriteLine($"Most Dislikes");
Console.WriteLine(post.Min(x => x.Dislikes));
Console.WriteLine("Average likes");
Console.WriteLine(post.Average(x => x.Likes));
Console.WriteLine("All vedios Dislike");
Console.WriteLine(post.Sum(x => x.Dislikes));
var VediosOnlyTitleandDescription = post.Select(x => new { x.Title, x.Description}).ToList();
VediosOnlyTitleandDescription.ForEach(x => Console.WriteLine($"Title - {x.Title} || Descirption - {x.Description}"));
Console.WriteLine("Vediolarni Topic bo'yicha Unique qilib: ");
Console.WriteLine("videolardan topic bo'yicha unique qilib");
var topics = post.DistinctBy(x => x.Topic).ToList();
topics.ForEach(Console.WriteLine);
Console.WriteLine();

var grouped = post.GroupBy(
    video => video.Topic,
    (topic, videos) => new
    {
        Topic = topic,
        Videos = videos.ToList()
    }
);

Console.WriteLine(JsonSerializer.Serialize(grouped));