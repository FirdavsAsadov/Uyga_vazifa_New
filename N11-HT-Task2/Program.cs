MusicPlayer musicOlayer = new MusicPlayer();
musicOlayer.Add("busenes", "jakuy");
musicOlayer.Add("Qodirali", "Chingiz");
musicOlayer.Add("OLam", "Dunyo");



while (true)
{
    Console.WriteLine("Choose a command\nnext - n\nprevious - p\npause - pause\nplay - play");
    var choose = Console.ReadLine().ToLower();
    switch (choose)
    {
        case "n" or "N":
            musicOlayer.Next();
            break;
        case "p":
            musicOlayer.Previous();
            break;
        case "pause":
            musicOlayer.Pause();
            break;
        case "play":
            musicOlayer.Play();
            break;
    }

}
public class Track
{
    public string name;
    public string author;
}
public class MusicPlayer
{
    private List<Track> tracks;
    private int hozirgimusiqa;


    public MusicPlayer()
    {
        tracks = new List<Track>();
        hozirgimusiqa = 0;
    }
    public void Add(string name1, string author1)
    {
        tracks.Add(new Track { name = name1, author = author1});
    }


    public void Next()
    {
        if (hozirgimusiqa == tracks.Count-1)
        {
            hozirgimusiqa = 0;
            hozirgimusiqa1();
        }
        else
        {
            hozirgimusiqa += 1;
            hozirgimusiqa1();
        }
    }

    public void Previous()
    {
        if (hozirgimusiqa == 0)
        {
            hozirgimusiqa = tracks.Count - 1;
            hozirgimusiqa1();
        }
        else
        {
            hozirgimusiqa -= 1;
            hozirgimusiqa1();
        }
    }

    public void Pause()
    {
        Console.WriteLine($"{tracks[hozirgimusiqa].name} Paused");
    }

    public void Play()
    {
        hozirgimusiqa1();
    }

    private void hozirgimusiqa1()
    {
        Console.WriteLine($"Playing - {tracks[hozirgimusiqa].name} - Author: {tracks[hozirgimusiqa].author}");
    }
}
///1-Next method ochish
///2-Previous method yaratish
///3-Pause method yaratish
///4-Play method yaratish
///
/// 
///
