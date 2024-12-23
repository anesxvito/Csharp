using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that checks if the DateTime is a weekend day (Saturday or Sunday).
    /// </summary>
    /// <param name="this">The DateTime to act on.</param>
    /// <returns>true if the DateTime is a weekend day; otherwise, false.</returns>
    public static bool IsWeekendDay(this DateTime @this)
    {
        return @this.DayOfWeek == DayOfWeek.Saturday || @this.DayOfWeek == DayOfWeek.Sunday;
    }
}
