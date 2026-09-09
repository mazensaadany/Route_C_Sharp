using System.Text;

namespace RouteAss_2;

    internal class Program
    {
        static void Main(string[] args)
        {
        #region [1st Answer]

        string title = "clean code";


        string upperTitle = title.ToUpper();

        Console.WriteLine(title);
        Console.WriteLine(upperTitle);

        #endregion

        Console.WriteLine("--------------------------------------------------");
        
        #region [2nd Answer]

        string v1 = "clean code";
        string v2 = "clean code";

        Console.WriteLine(ReferenceEquals(v1, v2));

        #endregion

        Console.WriteLine("--------------------------------------------------");

        #region [3rd Answer]

        StringBuilder sb = new StringBuilder();
        sb.Append("Book List");
        sb.Append(" - Updated");

        Console.WriteLine(sb);

        #endregion

        Console.WriteLine("--------------------------------------------------");

        #region [4th Answer]

        sb.Replace("Book List", "Library");

        Console.WriteLine(sb);

        #endregion

        Console.WriteLine("--------------------------------------------------");

        #region [5th Answer]

        string Title = "Clean Code";
        int pages = 464;

        string result = "Book: " + Title + ", Pages: " + pages;
        Console.WriteLine(result);

        #endregion

        Console.WriteLine("--------------------------------------------------");

        #region [6th Answer]

        string resultInterpolated = $"Book: {Title}, Pages: {pages}";
        Console.WriteLine(resultInterpolated);

        #endregion

        Console.WriteLine("--------------------------------------------------");

        #region [7th Answer]

        string resultFormat = string.Format("Book: {0}, Pages: {1}", Title, pages);
        Console.WriteLine(resultFormat);

        #endregion

        Console.WriteLine("--------------------------------------------------");

        #region [8th Answer]

        int Pages = 464;

        if (Pages > 300)
        {
            Console.WriteLine("Long Book");
        }
        else
        {
            Console.WriteLine("Short Book");
        }

        #endregion

        Console.WriteLine("--------------------------------------------------");

        #region [9th Answer]

        bool isAvailable = true;

        if (Pages > 300 && isAvailable)
        {
            Console.WriteLine("You can borrow this book");
        }

        #endregion

        Console.WriteLine("--------------------------------------------------");

        #region [10th Answer]

        string title1 = "Refactoring";
        switch(title1)
        {
            case "Clean Code":
                Console.WriteLine("great choice");
                break;
            case "Refactoring":
                Console.WriteLine("nice pick");
                break;
            default:
                Console.WriteLine("Never heard of it");
                break;
        }

        #endregion

        Console.WriteLine("--------------------------------------------------");

        #region [11th Answer]

        string sizeLabel = pages > 300 ? "long book" : "short book";
        Console.WriteLine(sizeLabel);

        #endregion

        Console.WriteLine("--------------------------------------------------");

        #region [12th Answer]

        string[] books = { "Clean Code", "Refactoring", "The Pragmatic Programmer" };

        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"{i+1}.{books[i]}");
        }

        #endregion
    }
}

