
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

var essay = new Document
{
    Content = "sLorem ipsum dolor sit amet consectetur " +
        "adipisicing elit. quaerat " +
        "est quas quas commodi est est est est est est est est est est  est quibusdam labore, nihil doloribus " +
        "quam temporibus " +
        "inventore optio expedita consectetur voluptatem " +
        "QUIDEM nulla soluta earum." +
        "Numquam rem alias minima culpa iste distinctio. Eum similique est " +
        "consequuntur minus, odio " +
        "nisi recusandae iure asperiores facere, reiciendis " +
        "voluptate maiores! Repellat, dolorum!"
};

/*Console.WriteLine(essay.Content.Split('.', ',', ' ',).Length);
*/var analyzer = new DocumentAnalyzer();
var score = analyzer.Analyessay(essay);
Console.WriteLine(score);


public class Document
{
    public string Content;
    public int Score = 100;

}

public class DocumentAnalyzer
{
    public int Analyessay(Document document)
    {
        document.Score = kattaharfbilanyozilganlar(document);
        document.Score = firstdigitcapital(document);
        document.Score = Analyzeessaytakror(document);
        document.Score = Analyze500(document);
        return document.Score;


    }

    public int Analyze500(Document document)
    {
        if (document.Content.Length < 500)
        {
            return document.Score -= 5;
        }

        return document.Score;
    }
    public int Analyzeessaytakror(Document document)
    {
        var words = document.Content.Split(' ');
        var distnictwords = words.Distinct().ToList();
        var count = 0;
        foreach (var distinctWord in distnictwords)
        {
            count = 0;
            foreach (var word in words)
                if (distinctWord == word)
                    count++;

            if (words.Length / 5 < count)
            {
                document.Score -= 5;
            }

        }

        return document.Score;
    }
    public int firstdigitcapital(Document document)
    {
       string firstWord = document.Content.Trim().Split('.',' ','!','?')[0];
        if(!string.IsNullOrEmpty(firstWord) && !char.IsUpper(firstWord[0]))
        {
            document.Score -= 5;
        }
        return document.Score;
    }
    public int kattaharfbilanyozilganlar(Document document)
    {
        
    }

}


/// 1- Document modulini yaratish
/// 2- Document Classida essay Bo'lsin
/// 3- Document Analyz Servis class ochilsin
/// 4- unda Analyz methodi ochish
/// 
/// 
/// 
/// 
/// 
/// 
/// ///
/// ///
/// ///
///
/// 
/// ///
/// ///
/// ///
///















