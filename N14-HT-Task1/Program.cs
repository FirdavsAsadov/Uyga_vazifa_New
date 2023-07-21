public class Program
{
    static void Main()
    {
        NotificationMessages obj = new NotificationMessages();
        var nmadur2 = obj.SearchMessages("Mchs");
        Console.WriteLine(nmadur2);
         var nimadur = obj.SearchMessages("Blocked");
        Console.WriteLine(nimadur);
    }
}





public class NotificationMessages
{
    private Dictionary<string, string> messages = new Dictionary<string, string>();


		public NotificationMessages()
	{
		messages.Add("SuccRegistration" , "You successfully registered");
        messages.Add("AskPassword" , "Enter your password");
        messages.Add("Blocked" , "Your account has been blocked");
    }

    protected KeyValuePair<string,string>? FindMessage(string name)
    {
        foreach(var message in messages)
        {
            if (message.Key.Contains(name))
            {
                return message;
            }
        }
        return null;
    }

    public string SearchMessages(string name)
    {
        var find = FindMessage(name);
        return find == null ? "Hech narsa yuq" : find.Value.Value;
    }
    
}
