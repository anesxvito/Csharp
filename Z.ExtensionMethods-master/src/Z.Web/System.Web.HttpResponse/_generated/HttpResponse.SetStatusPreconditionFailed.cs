| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():



using System.Web;
#endif

public static partial class Extensions
{

    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 412 (Precondition failed.).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusPreconditionFailed(this HttpResponse @this)
    {
        @this.StatusCode = 412;
        @this.StatusDescription = "Precondition failed.";
    }
#endif
}