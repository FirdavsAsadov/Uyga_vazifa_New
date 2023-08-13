using task2;

var books = new List<Book>()
{
    new Book(name: "Ishq Ertagi", 6, "John Bob"),
    new Book(name: "Yulduzlar Mangu Yonadi", 9, "Hakim ziyech"),
    new Book(name: "Sariq Devni minib", 7, "Xudoyberdi To'xtaboyev"),
    new Book(name: "Otamdan Qolgan dalalar", 10, "Tog'ay Murod"),
    new Book(name: "Ot kishnagan oqshom", 8, "Tog'ay Murod"),
    new Book(name: "Oydinda Odamlar", 5, "Tog'ay Murod")


};
Book sortedBooks =  books.OrderByDescending(book => book.Rating).First(book => book.Author == "Tog'ay Murod");
var sortedBookss = books.OrderByDescending(book => book.Rating).Last(book => book.Author == "Tog'ay Murod");
Console.WriteLine($"First book {sortedBooks.Name} - {sortedBooks.Rating} - {sortedBooks.Author}");
Console.WriteLine($"Last book {sortedBookss.Name} - {sortedBookss.Rating} - {sortedBookss.Author}");
/*var authors = sortedBooks.Select(book => book.Author).Distinct();
foreach (var author in authors)
{
    var authorBooks = sortedBooks.Where(book => book.Author == author);
    var bestRatedbook = authorBooks.First();
    var worstRatedbook = authorBooks.Last();
    Console.WriteLine($"Best Rated book: {bestRatedbook} - Rating - {bestRatedbook.Rating}");
    Console.WriteLine($"Worst Rated book: {worstRatedbook} - Rating - {worstRatedbook.Rating}");
}*/