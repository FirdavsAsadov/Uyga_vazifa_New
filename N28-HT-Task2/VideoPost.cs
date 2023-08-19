namespace N28_HT_Task2;

public class VideoPost
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Likes { get; set;}
    public int Dislikes { get; set; }
    public Topics Topic { get; set; }

    public VideoPost()
    {
        
    }

    public VideoPost(string title, string description,int likes,int dislikes,Topics topic)
    {
        Id = Guid.NewGuid();
        Title = title;
        Description = description;
        Likes = likes;
        Dislikes = dislikes;
        Topic = topic;
        
    }
}