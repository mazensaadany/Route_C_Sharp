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

    }
}

