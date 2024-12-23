public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that query if '@this' is valid uint.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if valid uint, false if not.</returns>
    public static bool IsValidUInt32(this object @this)
    {
        if (@this == null)
        {
            return true;
        }

        uint result;
        return uint.TryParse(@this.ToString(), out result);
    }
}
