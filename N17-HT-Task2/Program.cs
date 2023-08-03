using System.Collections.Immutable;


public class Program
{
    static void Main()
    {
        ChatService obj = new ChatService();
        obj.Add("Hi everybody");
        obj.Add("Let's get started");
        var ch1 = obj.Add("We'll start the meeting in 10 minutes");
    
        obj.Update(ch1,"Sorry guys, we are having technical issues, let's wait for another 10 minutes");
        obj.Update(ch1,"I'm really sorry meeting is cancelled");
        obj.Display();

    }
}

public class ChatMessage
{
    public Guid Id;

    public DateTime SenTime;

    public DateTime EditTime;

    public string Content;

    public ChatMessage(string content)
    {
        Id = Guid.NewGuid();
        SenTime = DateTime.Now;
        Content = content;
    }
    public ChatMessage(ChatMessage chatMessage)
    {
        this.Id = chatMessage.Id;
        this.SenTime = chatMessage.SenTime;
        this.EditTime = DateTime.Now;
        
    }
}


public class ChatService
{
    List<ChatMessage> Messages = new List<ChatMessage>();
    public Guid Add(string content)
    {
        if (!string.IsNullOrWhiteSpace(content))
        {
            var messages = new ChatMessage(content);
            Messages.Add(messages);
            return messages.Id;
      
        }
        else
            throw new ArgumentException("Qo'shib bo'lmaydi: ");
    }

    public void Update(Guid id, string content)
    {

        foreach (ChatMessage message in Messages)
        {
            if (message.Id == id && !string.IsNullOrWhiteSpace(content))
            {
                var obj = new ChatMessage(message);
                Messages.Remove(message);
                obj.EditTime = DateTime.Now;
                obj.Content = content;
                Messages.Add(obj);
                return;
            }
        }

        throw new ArgumentException("Xatooo!!");
           
    }

    public void Display()
    {
        foreach(ChatMessage message in Messages)
        {
            Console.WriteLine($"{message.Content} - {message.SenTime}");
        }
    }
}


public class MessageValidator
{
    public void IsValidMessage(string content)
    {
        if(string.IsNullOrWhiteSpace(content))
        {
            Console.WriteLine(content);
        }
        else
            Console.WriteLine("errroooor!!!");
    }
}