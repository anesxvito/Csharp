| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():



using System.Web;
#endif

public static partial class Extensions
{

    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 206 (Partial content.).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusPartialContent(this HttpResponse @this)
    {
        @this.StatusCode = 206;
        @this.StatusDescription = "Partial content.";
    }
#endif
}