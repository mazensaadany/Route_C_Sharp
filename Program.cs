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

        string resultInterpolated = $"Book: {title}, Pages: {pages}";
        Console.WriteLine(resultInterpolated);

        #endregion

        Console.WriteLine("--------------------------------------------------");

        #region [7th Answer]

        string resultFormat = string.Format("Book: {0}, Pages: {1}", title, pages);
        Console.WriteLine(resultFormat);

        #endregion

    }
}

