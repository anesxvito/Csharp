| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;

public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that converts this object to an int 32 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to an int.</returns>
    public static int ToInt32OrDefault(this object @this)
    {
        try
        {
            return Convert.ToInt32(@this);
        }
        catch (Exception)
        {
            return default(int);
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to an int 32 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to an int.</returns>
    public static int ToInt32OrDefault(this object @this, int defaultValue)
    {
        try
        {
            return Convert.ToInt32(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    /// An object extension method that converts this object to an int 32 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <param name="useDefaultIfNull">true to use default if null.</param>
    /// <returns>The given data converted to an int.</returns>
    public static int ToInt32OrDefault(this object @this, int defaultValue, bool useDefaultIfNull)
    {
        if (useDefaultIfNull && @this == null)
        {
            return defaultValue;
        }

        try
        {
            return Convert.ToInt32(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to an int 32 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to an int.</returns>
    public static int ToInt32OrDefault(this object @this, Func<int> defaultValueFactory)
    {
        try
        {
            return Convert.ToInt32(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }

    /// <summary>
    /// An object extension method that converts this object to an int 32 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <param name="useDefaultIfNull">true to use default if null.</param>
    /// <returns>The given data converted to an int.</returns>
    public static int ToInt32OrDefault(this object @this, Func<int> defaultValueFactory, bool useDefaultIfNull)
    {
        if (useDefaultIfNull && @this == null)
        {
            return defaultValueFactory();
        }

        try
        {
            return Convert.ToInt32(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }
}