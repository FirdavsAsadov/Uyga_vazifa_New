using N25_CT_Task4;

var movies = new MoveService();
movies.Add("Jodu", "Margarita", 6);
movies.Add("Eternal Echoes", "Samantha Carter", 8);
movies.Add("Whispers in the Wind", "Benjamin Turner", 7);
movies.Add("Midnight Serenade", "Emily Mitchell", 9);
movies.Add("Forgotten Realms", "Alexander Roberts", 5);
movies.Add("Starlit Secrets", "Olivia Parker", 8);
movies.Add("Shadows of Yesterday", "Michael Hughes", 7);
movies.Add("Chingakkok katta ilon", "G'Ishmat", 10);
var GetRatingMovie = movies.GetByRating();
foreach (var movie in GetRatingMovie)
{
    Console.WriteLine($"{movie.Name} - {movie.Author} - {movie.Rating}");
}
/*var SearchMovie = movies.Search("Jodu");
foreach (var movie in SearchMovie)
{
    Console.WriteLine($"{movie.Name} - {movie.Author}");
}*/