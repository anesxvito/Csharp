| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that extracts the Double from the string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted Double.</returns>
    public static double ExtractDouble(this string @this)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < @this.Length; i++)
        {
            if (Char.IsDigit(@this[i]) || @this[i] == '.')
            {
                if (sb.Length == 0 && i > 0 && @this[i - 1] == '-')
                {
                    sb.Append('-');
                }
                sb.Append(@this[i]);
            }
        }

        return Convert.ToDouble(sb.ToString());
    }
}