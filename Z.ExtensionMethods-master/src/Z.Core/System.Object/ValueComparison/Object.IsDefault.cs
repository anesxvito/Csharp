| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


public static partial class Extensions
{
    /// <summary>
    ///     A T extension method that query if 'source' is the default value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="source">The source to act on.</param>
    /// <returns>true if default, false if not.</returns>
    public static bool IsDefault<T>(this T source)
    {
        return source.Equals(default(T));
    }
}