| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;

public static partial class Extensions
{
    /// <summary>
    ///     Indicates whether the character at the specified position in a specified string is categorized as a separator
    ///     character.
    /// </summary>
    /// <param name="s">A string.</param>
    /// <param name="index">The position of the character to evaluate in .</param>
    /// <returns>true if the character at position  in  is a separator character; otherwise, false.</returns>
    public static Boolean IsSeparator(this String s, Int32 index)
    {
        return Char.IsSeparator(s, index);
    }
}