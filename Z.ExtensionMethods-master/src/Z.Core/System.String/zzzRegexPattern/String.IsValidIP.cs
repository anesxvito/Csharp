| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Text.RegularExpressions;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that query if 'obj' is valid IP.
    /// </summary>
    /// <param name="obj">The obj to act on.</param>
    /// <returns>true if valid ip, false if not.</returns>
    public static bool IsValidIP(this string obj)
    {
        return Regex.IsMatch(obj, @"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$");
    }
}